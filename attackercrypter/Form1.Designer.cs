
namespace attackercrypter
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.exdf = new System.Windows.Forms.CheckBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Injection = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.numericUpDownSc = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.servicename = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.foldername = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Filename = new System.Windows.Forms.TextBox();
            this.numericUpDownSleep = new System.Windows.Forms.NumericUpDown();
            this.Sleeptime = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtIcon = new System.Windows.Forms.TextBox();
            this.pictureIcon = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.author = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSleep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(309, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Select File";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(351, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(36, 106);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(309, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Encryption Key";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(351, 120);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 43);
            this.button3.TabIndex = 6;
            this.button3.Text = "Generate";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // exdf
            // 
            this.exdf.AutoSize = true;
            this.exdf.BackColor = System.Drawing.Color.Transparent;
            this.exdf.Cursor = System.Windows.Forms.Cursors.Cross;
            this.exdf.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic);
            this.exdf.ForeColor = System.Drawing.Color.Transparent;
            this.exdf.Location = new System.Drawing.Point(36, 313);
            this.exdf.Name = "exdf";
            this.exdf.Size = new System.Drawing.Size(143, 20);
            this.exdf.TabIndex = 7;
            this.exdf.Text = "Exclude Deffender";
            this.exdf.UseVisualStyleBackColor = false;
            this.exdf.CheckedChanged += new System.EventHandler(this.exdf_CheckedChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(36, 132);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(309, 20);
            this.textBox3.TabIndex = 9;
            this.textBox3.Text = "IV";
            // 
            // Injection
            // 
            this.Injection.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Injection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Injection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Injection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Injection.ForeColor = System.Drawing.Color.Black;
            this.Injection.FormattingEnabled = true;
            this.Injection.Items.AddRange(new object[] {
            "AssemblyLoad(.Net)"});
            this.Injection.Location = new System.Drawing.Point(36, 228);
            this.Injection.Name = "Injection";
            this.Injection.Size = new System.Drawing.Size(381, 24);
            this.Injection.TabIndex = 22;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Italic);
            this.radioButton1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButton1.Location = new System.Drawing.Point(510, 57);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(107, 32);
            this.radioButton1.TabIndex = 24;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Startup";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Italic);
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(510, 95);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(102, 32);
            this.radioButton2.TabIndex = 26;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Sctask";
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 28);
            this.label5.TabIndex = 27;
            this.label5.Text = "Encryption Settings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(31, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 28);
            this.label1.TabIndex = 28;
            this.label1.Text = "Injection Settings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(31, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 28);
            this.label2.TabIndex = 29;
            this.label2.Text = "Post exploitation Modules";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.Color.Transparent;
            this.checkBox2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Italic);
            this.checkBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBox2.Location = new System.Drawing.Point(453, 19);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(250, 32);
            this.checkBox2.TabIndex = 30;
            this.checkBox2.Text = "Persistence Settings";
            this.checkBox2.UseVisualStyleBackColor = false;
            // 
            // numericUpDownSc
            // 
            this.numericUpDownSc.Location = new System.Drawing.Point(559, 181);
            this.numericUpDownSc.Name = "numericUpDownSc";
            this.numericUpDownSc.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownSc.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic);
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(429, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "ScTask Run Every";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic);
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(695, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "Minutes";
            // 
            // servicename
            // 
            this.servicename.Location = new System.Drawing.Point(573, 143);
            this.servicename.Name = "servicename";
            this.servicename.Size = new System.Drawing.Size(149, 20);
            this.servicename.TabIndex = 34;
            this.servicename.Text = "Windows Updater";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic);
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(456, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 19);
            this.label6.TabIndex = 35;
            this.label6.Text = "Service Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic);
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(437, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 19);
            this.label7.TabIndex = 37;
            this.label7.Text = "Folder Name";
            // 
            // foldername
            // 
            this.foldername.Location = new System.Drawing.Point(554, 219);
            this.foldername.Name = "foldername";
            this.foldername.Size = new System.Drawing.Size(149, 20);
            this.foldername.TabIndex = 36;
            this.foldername.Text = "Windows";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic);
            this.label8.ForeColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(437, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 19);
            this.label8.TabIndex = 39;
            this.label8.Text = "Filename";
            // 
            // Filename
            // 
            this.Filename.Location = new System.Drawing.Point(554, 245);
            this.Filename.Name = "Filename";
            this.Filename.Size = new System.Drawing.Size(149, 20);
            this.Filename.TabIndex = 38;
            this.Filename.Text = "Windows-Updater";
            // 
            // numericUpDownSleep
            // 
            this.numericUpDownSleep.Location = new System.Drawing.Point(225, 339);
            this.numericUpDownSleep.Name = "numericUpDownSleep";
            this.numericUpDownSleep.Size = new System.Drawing.Size(92, 20);
            this.numericUpDownSleep.TabIndex = 40;
            // 
            // Sleeptime
            // 
            this.Sleeptime.AutoSize = true;
            this.Sleeptime.BackColor = System.Drawing.Color.Transparent;
            this.Sleeptime.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Sleeptime.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic);
            this.Sleeptime.ForeColor = System.Drawing.Color.Transparent;
            this.Sleeptime.Location = new System.Drawing.Point(225, 313);
            this.Sleeptime.Name = "Sleeptime";
            this.Sleeptime.Size = new System.Drawing.Size(63, 20);
            this.Sleeptime.TabIndex = 41;
            this.Sleeptime.Text = "Sleep";
            this.Sleeptime.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic);
            this.label9.ForeColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(323, 339);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 16);
            this.label9.TabIndex = 42;
            this.label9.Text = "Seconds";
            // 
            // TxtIcon
            // 
            this.TxtIcon.AccessibleDescription = "Your ETC Wallet Adress";
            this.TxtIcon.AccessibleName = "";
            this.TxtIcon.BackColor = System.Drawing.Color.White;
            this.TxtIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtIcon.ForeColor = System.Drawing.Color.Black;
            this.TxtIcon.Location = new System.Drawing.Point(856, 96);
            this.TxtIcon.Multiline = true;
            this.TxtIcon.Name = "TxtIcon";
            this.TxtIcon.Size = new System.Drawing.Size(132, 24);
            this.TxtIcon.TabIndex = 45;
            this.TxtIcon.Tag = "";
            // 
            // pictureIcon
            // 
            this.pictureIcon.BackColor = System.Drawing.Color.Transparent;
            this.pictureIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureIcon.Location = new System.Drawing.Point(854, 54);
            this.pictureIcon.Margin = new System.Windows.Forms.Padding(2);
            this.pictureIcon.Name = "pictureIcon";
            this.pictureIcon.Size = new System.Drawing.Size(40, 37);
            this.pictureIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureIcon.TabIndex = 44;
            this.pictureIcon.TabStop = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.ForeColor = System.Drawing.Color.DimGray;
            this.button4.Location = new System.Drawing.Point(854, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 30);
            this.button4.TabIndex = 43;
            this.button4.Text = "Icon";
            this.button4.UseCompatibleTextRendering = true;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.ForeColor = System.Drawing.Color.DimGray;
            this.button2.Location = new System.Drawing.Point(554, 344);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(413, 33);
            this.button2.TabIndex = 46;
            this.button2.Text = "Build";
            this.button2.UseCompatibleTextRendering = true;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(763, 267);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 28);
            this.label10.TabIndex = 47;
            this.label10.Text = "Builder";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(658, 318);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(309, 20);
            this.textBox4.TabIndex = 48;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(599, 313);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 28);
            this.label11.TabIndex = 49;
            this.label11.Text = "Url";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.ForeColor = System.Drawing.Color.DimGray;
            this.button5.Location = new System.Drawing.Point(36, 164);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(93, 30);
            this.button5.TabIndex = 50;
            this.button5.Text = "Encrypt";
            this.button5.UseCompatibleTextRendering = true;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // author
            // 
            this.author.AutoSize = true;
            this.author.BackColor = System.Drawing.Color.Transparent;
            this.author.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Italic);
            this.author.Location = new System.Drawing.Point(893, 143);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(54, 28);
            this.author.TabIndex = 51;
            this.author.TabStop = true;
            this.author.Text = "Dev";
            this.author.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.author_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::attackercrypter.Properties.Resources.kali_linux_3;
            this.ClientSize = new System.Drawing.Size(1001, 389);
            this.Controls.Add(this.author);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TxtIcon);
            this.Controls.Add(this.pictureIcon);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Sleeptime);
            this.Controls.Add(this.numericUpDownSleep);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Filename);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.foldername);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.servicename);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownSc);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.Injection);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.exdf);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "AttackerCrypter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSleep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox exdf;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox Injection;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.NumericUpDown numericUpDownSc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox servicename;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox foldername;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Filename;
        private System.Windows.Forms.NumericUpDown numericUpDownSleep;
        private System.Windows.Forms.CheckBox Sleeptime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtIcon;
        private System.Windows.Forms.PictureBox pictureIcon;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.LinkLabel author;
    }
}

