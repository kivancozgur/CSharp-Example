namespace companentler
{
    partial class chekboxform
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
            this.koscek = new System.Windows.Forms.CheckBox();
            this.uycek = new System.Windows.Forms.CheckBox();
            this.kitapcek = new System.Windows.Forms.CheckBox();
            this.yuzcek = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // koscek
            // 
            this.koscek.AutoSize = true;
            this.koscek.Location = new System.Drawing.Point(55, 73);
            this.koscek.Name = "koscek";
            this.koscek.Size = new System.Drawing.Size(57, 17);
            this.koscek.TabIndex = 0;
            this.koscek.Text = "koşma";
            this.koscek.UseVisualStyleBackColor = true;
            // 
            // uycek
            // 
            this.uycek.AutoSize = true;
            this.uycek.Location = new System.Drawing.Point(55, 96);
            this.uycek.Name = "uycek";
            this.uycek.Size = new System.Drawing.Size(49, 17);
            this.uycek.TabIndex = 1;
            this.uycek.Text = "uyku";
            this.uycek.UseVisualStyleBackColor = true;
            // 
            // kitapcek
            // 
            this.kitapcek.AutoSize = true;
            this.kitapcek.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.kitapcek.Location = new System.Drawing.Point(55, 12);
            this.kitapcek.Name = "kitapcek";
            this.kitapcek.Size = new System.Drawing.Size(90, 17);
            this.kitapcek.TabIndex = 2;
            this.kitapcek.Text = "kitap okumak";
            this.kitapcek.UseVisualStyleBackColor = true;
            // 
            // yuzcek
            // 
            this.yuzcek.AutoSize = true;
            this.yuzcek.Location = new System.Drawing.Point(55, 38);
            this.yuzcek.Name = "yuzcek";
            this.yuzcek.Size = new System.Drawing.Size(62, 17);
            this.yuzcek.TabIndex = 3;
            this.yuzcek.Text = "yüzmek";
            this.yuzcek.UseVisualStyleBackColor = true;
            this.yuzcek.CheckedChanged += new System.EventHandler(this.yuzcek_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(149, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 90);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "cinsiyet ";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(52, 50);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(54, 17);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "bayan";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.ForeColor = System.Drawing.Color.Black;
            this.radioButton1.Location = new System.Drawing.Point(52, 24);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(42, 17);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "bay";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Location = new System.Drawing.Point(329, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(183, 90);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "uyruk";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(67, 50);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(48, 17);
            this.radioButton4.TabIndex = 10;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "diğer";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(67, 24);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(34, 17);
            this.radioButton3.TabIndex = 9;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "tc";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // chekboxform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 401);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.yuzcek);
            this.Controls.Add(this.kitapcek);
            this.Controls.Add(this.uycek);
            this.Controls.Add(this.koscek);
            this.Name = "chekboxform";
            this.Text = "chekboxform";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox koscek;
        private System.Windows.Forms.CheckBox uycek;
        private System.Windows.Forms.CheckBox kitapcek;
        private System.Windows.Forms.CheckBox yuzcek;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}