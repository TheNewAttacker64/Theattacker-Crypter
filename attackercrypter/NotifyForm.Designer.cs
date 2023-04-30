
namespace attackercrypter
{
    partial class NotifySettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotifySettings));
            this.label5 = new System.Windows.Forms.Label();
            this.token = new System.Windows.Forms.TextBox();
            this.chatid = new System.Windows.Forms.TextBox();
            this.port = new System.Windows.Forms.TextBox();
            this.ip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(7, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 28);
            this.label5.TabIndex = 28;
            this.label5.Text = "Telegram Settings";
            // 
            // token
            // 
            this.token.BackColor = System.Drawing.Color.White;
            this.token.ForeColor = System.Drawing.Color.Red;
            this.token.Location = new System.Drawing.Point(12, 101);
            this.token.Name = "token";
            this.token.Size = new System.Drawing.Size(158, 20);
            this.token.TabIndex = 29;
            this.token.Text = "Bot token";
            // 
            // chatid
            // 
            this.chatid.BackColor = System.Drawing.Color.White;
            this.chatid.ForeColor = System.Drawing.Color.Red;
            this.chatid.Location = new System.Drawing.Point(12, 136);
            this.chatid.Name = "chatid";
            this.chatid.Size = new System.Drawing.Size(158, 20);
            this.chatid.TabIndex = 30;
            this.chatid.Text = "chatid";
            // 
            // port
            // 
            this.port.ForeColor = System.Drawing.Color.Red;
            this.port.Location = new System.Drawing.Point(353, 110);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(158, 20);
            this.port.TabIndex = 56;
            this.port.Text = "port";
            // 
            // ip
            // 
            this.ip.ForeColor = System.Drawing.Color.Red;
            this.ip.Location = new System.Drawing.Point(353, 85);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(158, 20);
            this.ip.TabIndex = 55;
            this.ip.Text = "ip addr";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(262, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 28);
            this.label1.TabIndex = 54;
            this.label1.Text = "Socket Server Settings";
            // 
            // password
            // 
            this.password.ForeColor = System.Drawing.Color.Red;
            this.password.Location = new System.Drawing.Point(353, 137);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(158, 20);
            this.password.TabIndex = 58;
            this.password.Text = "password";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Green;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(353, 168);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(158, 36);
            this.button6.TabIndex = 59;
            this.button6.Text = "Save";
            this.button6.UseCompatibleTextRendering = true;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 36);
            this.button1.TabIndex = 60;
            this.button1.Text = "Save";
            this.button1.UseCompatibleTextRendering = true;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NotifySettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(523, 234);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.password);
            this.Controls.Add(this.port);
            this.Controls.Add(this.ip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chatid);
            this.Controls.Add(this.token);
            this.Controls.Add(this.label5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NotifySettings";
            this.Text = "Notification Settings";
            this.Load += new System.EventHandler(this.NotifySettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox token;
        private System.Windows.Forms.TextBox chatid;
        private System.Windows.Forms.TextBox port;
        private System.Windows.Forms.TextBox ip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
    }
}