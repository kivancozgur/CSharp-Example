namespace veritabani_mvc
{
    partial class Formilerigeri
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
            this.geribut = new System.Windows.Forms.Button();
            this.ileribut = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.adtxt = new System.Windows.Forms.TextBox();
            this.notxt = new System.Windows.Forms.TextBox();
            this.dogtarpicker = new System.Windows.Forms.DateTimePicker();
            this.adrestxt = new System.Windows.Forms.TextBox();
            this.Silbtn = new System.Windows.Forms.Button();
            this.tckimliktxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // geribut
            // 
            this.geribut.Location = new System.Drawing.Point(68, 400);
            this.geribut.Name = "geribut";
            this.geribut.Size = new System.Drawing.Size(81, 39);
            this.geribut.TabIndex = 0;
            this.geribut.Text = "<---   Geri ";
            this.geribut.UseVisualStyleBackColor = true;
            this.geribut.Click += new System.EventHandler(this.geribut_Click);
            // 
            // ileribut
            // 
            this.ileribut.Location = new System.Drawing.Point(176, 400);
            this.ileribut.Name = "ileribut";
            this.ileribut.Size = new System.Drawing.Size(83, 39);
            this.ileribut.TabIndex = 1;
            this.ileribut.Text = "İleri --->";
            this.ileribut.UseVisualStyleBackColor = true;
            this.ileribut.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(56, 229);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(314, 160);
            this.listBox1.TabIndex = 2;
            // 
            // adtxt
            // 
            this.adtxt.Location = new System.Drawing.Point(84, 12);
            this.adtxt.Name = "adtxt";
            this.adtxt.Size = new System.Drawing.Size(100, 20);
            this.adtxt.TabIndex = 3;
            // 
            // notxt
            // 
            this.notxt.Location = new System.Drawing.Point(84, 38);
            this.notxt.Name = "notxt";
            this.notxt.Size = new System.Drawing.Size(100, 20);
            this.notxt.TabIndex = 4;
            // 
            // dogtarpicker
            // 
            this.dogtarpicker.Location = new System.Drawing.Point(84, 91);
            this.dogtarpicker.Name = "dogtarpicker";
            this.dogtarpicker.Size = new System.Drawing.Size(200, 20);
            this.dogtarpicker.TabIndex = 5;
            // 
            // adrestxt
            // 
            this.adrestxt.Location = new System.Drawing.Point(84, 117);
            this.adrestxt.Multiline = true;
            this.adrestxt.Name = "adrestxt";
            this.adrestxt.Size = new System.Drawing.Size(200, 106);
            this.adrestxt.TabIndex = 6;
            // 
            // Silbtn
            // 
            this.Silbtn.Location = new System.Drawing.Point(285, 400);
            this.Silbtn.Name = "Silbtn";
            this.Silbtn.Size = new System.Drawing.Size(76, 39);
            this.Silbtn.TabIndex = 7;
            this.Silbtn.Text = "Sil";
            this.Silbtn.UseVisualStyleBackColor = true;
            this.Silbtn.Click += new System.EventHandler(this.Silbtn_Click);
            // 
            // tckimliktxt
            // 
            this.tckimliktxt.Location = new System.Drawing.Point(84, 65);
            this.tckimliktxt.Name = "tckimliktxt";
            this.tckimliktxt.Size = new System.Drawing.Size(100, 20);
            this.tckimliktxt.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ad Soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Numara";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tckimlik";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Doğum Tarihi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Adres";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(317, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 39);
            this.button1.TabIndex = 14;
            this.button1.Text = "Değiştir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Formilerigeri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 469);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tckimliktxt);
            this.Controls.Add(this.Silbtn);
            this.Controls.Add(this.adrestxt);
            this.Controls.Add(this.dogtarpicker);
            this.Controls.Add(this.notxt);
            this.Controls.Add(this.adtxt);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ileribut);
            this.Controls.Add(this.geribut);
            this.Name = "Formilerigeri";
            this.Text = "5";
            this.Load += new System.EventHandler(this.Formilerigeri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button geribut;
        private System.Windows.Forms.Button ileribut;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox adtxt;
        private System.Windows.Forms.TextBox notxt;
        private System.Windows.Forms.DateTimePicker dogtarpicker;
        private System.Windows.Forms.TextBox adrestxt;
        private System.Windows.Forms.Button Silbtn;
        private System.Windows.Forms.TextBox tckimliktxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}