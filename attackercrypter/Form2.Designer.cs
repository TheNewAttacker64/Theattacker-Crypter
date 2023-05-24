namespace attackercrypter
{
    partial class pumpform
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.pumpReal = new System.Windows.Forms.RadioButton();
            this.pumpFake = new System.Windows.Forms.RadioButton();
            this.pump = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(347, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 24);
            this.button1.TabIndex = 4;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(309, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Select File";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(51, 81);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 98;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(177, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 16);
            this.label4.TabIndex = 99;
            this.label4.Text = "MB";
            // 
            // pumpReal
            // 
            this.pumpReal.AutoSize = true;
            this.pumpReal.BackColor = System.Drawing.Color.Transparent;
            this.pumpReal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pumpReal.ForeColor = System.Drawing.Color.White;
            this.pumpReal.Location = new System.Drawing.Point(217, 133);
            this.pumpReal.Name = "pumpReal";
            this.pumpReal.Size = new System.Drawing.Size(120, 28);
            this.pumpReal.TabIndex = 101;
            this.pumpReal.TabStop = true;
            this.pumpReal.Text = "RealBytes";
            this.pumpReal.UseVisualStyleBackColor = false;
            // 
            // pumpFake
            // 
            this.pumpFake.AutoSize = true;
            this.pumpFake.BackColor = System.Drawing.Color.Transparent;
            this.pumpFake.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pumpFake.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pumpFake.Location = new System.Drawing.Point(51, 133);
            this.pumpFake.Name = "pumpFake";
            this.pumpFake.Size = new System.Drawing.Size(129, 28);
            this.pumpFake.TabIndex = 100;
            this.pumpFake.TabStop = true;
            this.pumpFake.Text = "Fake bytes";
            this.pumpFake.UseVisualStyleBackColor = false;
            // 
            // pump
            // 
            this.pump.BackColor = System.Drawing.Color.Red;
            this.pump.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pump.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pump.FlatAppearance.BorderSize = 0;
            this.pump.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pump.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pump.ForeColor = System.Drawing.Color.White;
            this.pump.Location = new System.Drawing.Point(180, 166);
            this.pump.Name = "pump";
            this.pump.Size = new System.Drawing.Size(121, 37);
            this.pump.TabIndex = 102;
            this.pump.Text = "Pump it :)";
            this.pump.UseCompatibleTextRendering = true;
            this.pump.UseVisualStyleBackColor = false;
            this.pump.Click += new System.EventHandler(this.pump_Click);
            // 
            // pumpform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::attackercrypter.Properties.Resources.kali_linux_3;
            this.ClientSize = new System.Drawing.Size(509, 235);
            this.Controls.Add(this.pump);
            this.Controls.Add(this.pumpReal);
            this.Controls.Add(this.pumpFake);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "pumpform";
            this.Text = "pumper";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton pumpReal;
        private System.Windows.Forms.RadioButton pumpFake;
        private System.Windows.Forms.Button pump;
    }
}