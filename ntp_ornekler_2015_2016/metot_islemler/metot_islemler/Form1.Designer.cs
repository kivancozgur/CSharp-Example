namespace metot_islemler
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
            this.radio4islem = new System.Windows.Forms.RadioButton();
            this.radioalan = new System.Windows.Forms.RadioButton();
            this.panel4islem = new System.Windows.Forms.Panel();
            this.toplacheck = new System.Windows.Forms.CheckBox();
            this.cikarcheck = new System.Windows.Forms.CheckBox();
            this.panelsayilar = new System.Windows.Forms.Panel();
            this.sayi1text = new System.Windows.Forms.TextBox();
            this.sayi2text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hesapbuton = new System.Windows.Forms.Button();
            this.panelalan = new System.Windows.Forms.Panel();
            this.Ucgencheck = new System.Windows.Forms.CheckBox();
            this.karecek = new System.Windows.Forms.CheckBox();
            this.panelucgen = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabantext = new System.Windows.Forms.TextBox();
            this.yuksektext = new System.Windows.Forms.TextBox();
            this.panelkare = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.kenartext = new System.Windows.Forms.TextBox();
            this.panel4islem.SuspendLayout();
            this.panelsayilar.SuspendLayout();
            this.panelalan.SuspendLayout();
            this.panelucgen.SuspendLayout();
            this.panelkare.SuspendLayout();
            this.SuspendLayout();
            // 
            // radio4islem
            // 
            this.radio4islem.AutoSize = true;
            this.radio4islem.Location = new System.Drawing.Point(113, 12);
            this.radio4islem.Name = "radio4islem";
            this.radio4islem.Size = new System.Drawing.Size(57, 17);
            this.radio4islem.TabIndex = 0;
            this.radio4islem.Text = "4 işlem";
            this.radio4islem.UseVisualStyleBackColor = false;
            this.radio4islem.CheckedChanged += new System.EventHandler(this.radio4islem_CheckedChanged);
            // 
            // radioalan
            // 
            this.radioalan.AutoSize = true;
            this.radioalan.Location = new System.Drawing.Point(401, 12);
            this.radioalan.Name = "radioalan";
            this.radioalan.Size = new System.Drawing.Size(99, 17);
            this.radioalan.TabIndex = 1;
            this.radioalan.Text = "alan hesaplama";
            this.radioalan.UseVisualStyleBackColor = false;
            this.radioalan.CheckedChanged += new System.EventHandler(this.radioalan_CheckedChanged);
            // 
            // panel4islem
            // 
            this.panel4islem.Controls.Add(this.cikarcheck);
            this.panel4islem.Controls.Add(this.toplacheck);
            this.panel4islem.Location = new System.Drawing.Point(83, 44);
            this.panel4islem.Name = "panel4islem";
            this.panel4islem.Size = new System.Drawing.Size(160, 96);
            this.panel4islem.TabIndex = 2;
            this.panel4islem.Visible = false;
            // 
            // toplacheck
            // 
            this.toplacheck.AutoSize = true;
            this.toplacheck.Location = new System.Drawing.Point(17, 11);
            this.toplacheck.Name = "toplacheck";
            this.toplacheck.Size = new System.Drawing.Size(67, 17);
            this.toplacheck.TabIndex = 0;
            this.toplacheck.Text = "Toplama";
            this.toplacheck.UseVisualStyleBackColor = true;
            this.toplacheck.CheckedChanged += new System.EventHandler(this.toplacheck_CheckedChanged);
            // 
            // cikarcheck
            // 
            this.cikarcheck.AutoSize = true;
            this.cikarcheck.Location = new System.Drawing.Point(17, 34);
            this.cikarcheck.Name = "cikarcheck";
            this.cikarcheck.Size = new System.Drawing.Size(64, 17);
            this.cikarcheck.TabIndex = 1;
            this.cikarcheck.Text = "Çıkarma";
            this.cikarcheck.UseVisualStyleBackColor = true;
            this.cikarcheck.CheckedChanged += new System.EventHandler(this.cikarcheck_CheckedChanged);
            // 
            // panelsayilar
            // 
            this.panelsayilar.Controls.Add(this.label2);
            this.panelsayilar.Controls.Add(this.label1);
            this.panelsayilar.Controls.Add(this.sayi2text);
            this.panelsayilar.Controls.Add(this.sayi1text);
            this.panelsayilar.Location = new System.Drawing.Point(56, 146);
            this.panelsayilar.Name = "panelsayilar";
            this.panelsayilar.Size = new System.Drawing.Size(242, 111);
            this.panelsayilar.TabIndex = 2;
            this.panelsayilar.Visible = false;
            // 
            // sayi1text
            // 
            this.sayi1text.Location = new System.Drawing.Point(95, 21);
            this.sayi1text.Name = "sayi1text";
            this.sayi1text.Size = new System.Drawing.Size(100, 20);
            this.sayi1text.TabIndex = 0;
            // 
            // sayi2text
            // 
            this.sayi2text.Location = new System.Drawing.Point(95, 59);
            this.sayi2text.Name = "sayi2text";
            this.sayi2text.Size = new System.Drawing.Size(100, 20);
            this.sayi2text.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sayı1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "sayı2";
            // 
            // hesapbuton
            // 
            this.hesapbuton.Location = new System.Drawing.Point(303, 282);
            this.hesapbuton.Name = "hesapbuton";
            this.hesapbuton.Size = new System.Drawing.Size(75, 23);
            this.hesapbuton.TabIndex = 4;
            this.hesapbuton.Text = "HESAPLA";
            this.hesapbuton.UseVisualStyleBackColor = true;
            this.hesapbuton.Click += new System.EventHandler(this.hesapbuton_Click);
            // 
            // panelalan
            // 
            this.panelalan.Controls.Add(this.karecek);
            this.panelalan.Controls.Add(this.Ucgencheck);
            this.panelalan.Location = new System.Drawing.Point(367, 44);
            this.panelalan.Name = "panelalan";
            this.panelalan.Size = new System.Drawing.Size(200, 77);
            this.panelalan.TabIndex = 5;
            this.panelalan.Visible = false;
            // 
            // Ucgencheck
            // 
            this.Ucgencheck.AutoSize = true;
            this.Ucgencheck.Location = new System.Drawing.Point(21, 11);
            this.Ucgencheck.Name = "Ucgencheck";
            this.Ucgencheck.Size = new System.Drawing.Size(58, 17);
            this.Ucgencheck.TabIndex = 0;
            this.Ucgencheck.Text = "Üçgen";
            this.Ucgencheck.UseVisualStyleBackColor = true;
            // 
            // karecek
            // 
            this.karecek.AutoSize = true;
            this.karecek.Location = new System.Drawing.Point(21, 34);
            this.karecek.Name = "karecek";
            this.karecek.Size = new System.Drawing.Size(47, 17);
            this.karecek.TabIndex = 1;
            this.karecek.Text = "kare";
            this.karecek.UseVisualStyleBackColor = true;
            // 
            // panelucgen
            // 
            this.panelucgen.Controls.Add(this.yuksektext);
            this.panelucgen.Controls.Add(this.tabantext);
            this.panelucgen.Controls.Add(this.label4);
            this.panelucgen.Controls.Add(this.label3);
            this.panelucgen.Location = new System.Drawing.Point(367, 127);
            this.panelucgen.Name = "panelucgen";
            this.panelucgen.Size = new System.Drawing.Size(200, 100);
            this.panelucgen.TabIndex = 2;
            this.panelucgen.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Taban";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "yukseklik";
            // 
            // tabantext
            // 
            this.tabantext.Location = new System.Drawing.Point(75, 19);
            this.tabantext.Name = "tabantext";
            this.tabantext.Size = new System.Drawing.Size(100, 20);
            this.tabantext.TabIndex = 2;
            // 
            // yuksektext
            // 
            this.yuksektext.Location = new System.Drawing.Point(75, 55);
            this.yuksektext.Name = "yuksektext";
            this.yuksektext.Size = new System.Drawing.Size(100, 20);
            this.yuksektext.TabIndex = 3;
            // 
            // panelkare
            // 
            this.panelkare.Controls.Add(this.kenartext);
            this.panelkare.Controls.Add(this.label5);
            this.panelkare.Location = new System.Drawing.Point(364, 127);
            this.panelkare.Name = "panelkare";
            this.panelkare.Size = new System.Drawing.Size(200, 100);
            this.panelkare.TabIndex = 6;
            this.panelkare.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "kenar";
            // 
            // kenartext
            // 
            this.kenartext.Location = new System.Drawing.Point(61, 19);
            this.kenartext.Name = "kenartext";
            this.kenartext.Size = new System.Drawing.Size(100, 20);
            this.kenartext.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 345);
            this.Controls.Add(this.panelkare);
            this.Controls.Add(this.panelucgen);
            this.Controls.Add(this.panelalan);
            this.Controls.Add(this.hesapbuton);
            this.Controls.Add(this.panelsayilar);
            this.Controls.Add(this.panel4islem);
            this.Controls.Add(this.radioalan);
            this.Controls.Add(this.radio4islem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel4islem.ResumeLayout(false);
            this.panel4islem.PerformLayout();
            this.panelsayilar.ResumeLayout(false);
            this.panelsayilar.PerformLayout();
            this.panelalan.ResumeLayout(false);
            this.panelalan.PerformLayout();
            this.panelucgen.ResumeLayout(false);
            this.panelucgen.PerformLayout();
            this.panelkare.ResumeLayout(false);
            this.panelkare.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radio4islem;
        private System.Windows.Forms.RadioButton radioalan;
        private System.Windows.Forms.Panel panel4islem;
        private System.Windows.Forms.CheckBox cikarcheck;
        private System.Windows.Forms.CheckBox toplacheck;
        private System.Windows.Forms.Panel panelsayilar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sayi2text;
        private System.Windows.Forms.TextBox sayi1text;
        private System.Windows.Forms.Button hesapbuton;
        private System.Windows.Forms.Panel panelalan;
        private System.Windows.Forms.CheckBox karecek;
        private System.Windows.Forms.CheckBox Ucgencheck;
        private System.Windows.Forms.Panel panelucgen;
        private System.Windows.Forms.Panel panelkare;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox yuksektext;
        private System.Windows.Forms.TextBox tabantext;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox kenartext;
    }
}

