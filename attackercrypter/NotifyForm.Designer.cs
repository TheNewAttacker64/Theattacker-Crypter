
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
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(36, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 28);
            this.label5.TabIndex = 28;
            this.label5.Text = "Telegram Settings";
            // 
            // token
            // 
            this.token.Location = new System.Drawing.Point(61, 59);
            this.token.Name = "token";
            this.token.Size = new System.Drawing.Size(158, 20);
            this.token.TabIndex = 29;
            this.token.Text = "Bot token";
            // 
            // chatid
            // 
            this.chatid.Location = new System.Drawing.Point(61, 85);
            this.chatid.Name = "chatid";
            this.chatid.Size = new System.Drawing.Size(158, 20);
            this.chatid.TabIndex = 30;
            this.chatid.Text = "chatid";
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(296, 85);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(158, 20);
            this.port.TabIndex = 56;
            this.port.Text = "port";
            // 
            // ip
            // 
            this.ip.Location = new System.Drawing.Point(296, 59);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(158, 20);
            this.ip.TabIndex = 55;
            this.ip.Text = "ip addr";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(260, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 28);
            this.label1.TabIndex = 54;
            this.label1.Text = "Socket Server Settings";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(296, 111);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(158, 20);
            this.password.TabIndex = 58;
            this.password.Text = "password";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.ForeColor = System.Drawing.Color.DimGray;
            this.button6.Location = new System.Drawing.Point(296, 137);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(158, 36);
            this.button6.TabIndex = 59;
            this.button6.Text = "Save Server Creds";
            this.button6.UseCompatibleTextRendering = true;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ForeColor = System.Drawing.Color.DimGray;
            this.button1.Location = new System.Drawing.Point(61, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 36);
            this.button1.TabIndex = 60;
            this.button1.Text = "Save Tg bot Creds";
            this.button1.UseCompatibleTextRendering = true;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NotifySettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::attackercrypter.Properties.Resources.kali_linux_3;
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
            this.Text = "NotifyForm";
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