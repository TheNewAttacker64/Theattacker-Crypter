using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace attackercrypter
{
    public partial class NotifySettings : Form
    {
        public NotifySettings()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            File.WriteAllText("ServerCred.txt", ip.Text + "|" + port.Text + "|" + password.Text);
            MessageBox.Show("Done");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.WriteAllText("tgbot.txt", token.Text + "|" + chatid.Text);
            MessageBox.Show("Done");

        }

        private void NotifySettings_Load(object sender, EventArgs e)
        {

        }
    }
}
