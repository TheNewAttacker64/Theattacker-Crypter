using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace attackercrypter
{
    public partial class pumpform : Form
    {
        public pumpform()
        {
            InitializeComponent();
        }
        public static void IncreaseFileSizeFakebyte(string filePath, int targetSizeMB)
        {
            long targetSizeBytes = targetSizeMB * 1024 * 1024;

            FileInfo fileInfo = new FileInfo(filePath);
            long currentSize = fileInfo.Length;
            long bytesToAdd = targetSizeBytes - currentSize;

            if (bytesToAdd <= 0)
            {
                MessageBox.Show("Target size is smaller or equal to the current size");
                return;
            }

            using (FileStream fileStream = new FileStream(filePath, FileMode.Append, FileAccess.Write))
            {
                byte[] nullBytes = new byte[bytesToAdd];
                fileStream.Write(nullBytes, 0, (int)bytesToAdd);
            }

            MessageBox.Show($"File size increased to {targetSizeMB} MB");
        }
        public static void IncreaseFileSize(string filePath, int targetSizeMB)
        {
            long targetSizeBytes = targetSizeMB * 1024L * 1024L; 

            FileInfo fileInfo = new FileInfo(filePath);
            long currentSize = fileInfo.Length;
            long bytesToAdd = targetSizeBytes - currentSize;

            if (bytesToAdd <= 0)
            {
                MessageBox.Show("Target size is smaller or equal to the current size");
                return;
            }

            using (FileStream fileStream = new FileStream(filePath, FileMode.Append, FileAccess.Write))
            {
                byte[] buffer = new byte[8192]; 
                long remainingBytesToAdd = bytesToAdd;

                using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
                {
                    while (remainingBytesToAdd > 0)
                    {
                        int bytesToWrite = (int)Math.Min(remainingBytesToAdd, buffer.Length);

                        rng.GetBytes(buffer, 0, bytesToWrite);
                        fileStream.Write(buffer, 0, bytesToWrite);
                        remainingBytesToAdd -= bytesToWrite;
                    }
                }
            }

            MessageBox.Show($"File size increased to {targetSizeMB} MB");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Executable Files|*.exe";
            openFileDialog.Title = "Select an Executable File To pump";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFile = openFileDialog.FileName;
                textBox1.Text = selectedFile;
                
            }
            else
            {
                MessageBox.Show("File selection canceled.");
            }
        }

        private void pumpfake_Click(object sender, EventArgs e)
        {
          
        }

        private void pump_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text) || !File.Exists(textBox1.Text))
            {
                MessageBox.Show("Choose Valid Path");
                return;
            }
            if (pumpFake.Checked)
            {
                IncreaseFileSizeFakebyte(textBox1.Text, ((int)numericUpDown1.Value));
            }
            else if (pumpReal.Checked)
            {
                IncreaseFileSize(textBox1.Text,((int)numericUpDown1.Value));
            }
            {
                
            }
        }
    }
}
