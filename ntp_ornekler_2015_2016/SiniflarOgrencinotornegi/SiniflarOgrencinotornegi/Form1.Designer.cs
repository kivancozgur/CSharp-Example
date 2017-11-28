namespace SiniflarOgrencinotornegi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.adsoyadtext = new System.Windows.Forms.TextBox();
            this.yastext = new System.Windows.Forms.TextBox();
            this.adrestext = new System.Windows.Forms.TextBox();
            this.derscombo = new System.Windows.Forms.ComboBox();
            this.y1text = new System.Windows.Forms.TextBox();
            this.y2text = new System.Windows.Forms.TextBox();
            this.soztext = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yaş:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adres:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "DErs Seçin:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(241, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Yaz1:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(241, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "yaz2:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(239, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Sozlu 1:";
            // 
            // adsoyadtext
            // 
            this.adsoyadtext.Location = new System.Drawing.Point(301, 6);
            this.adsoyadtext.Name = "adsoyadtext";
            this.adsoyadtext.Size = new System.Drawing.Size(137, 20);
            this.adsoyadtext.TabIndex = 7;
            // 
            // yastext
            // 
            this.yastext.Location = new System.Drawing.Point(301, 43);
            this.yastext.Name = "yastext";
            this.yastext.Size = new System.Drawing.Size(100, 20);
            this.yastext.TabIndex = 8;
            // 
            // adrestext
            // 
            this.adrestext.Location = new System.Drawing.Point(301, 80);
            this.adrestext.Name = "adrestext";
            this.adrestext.Size = new System.Drawing.Size(158, 20);
            this.adrestext.TabIndex = 9;
            // 
            // derscombo
            // 
            this.derscombo.FormattingEnabled = true;
            this.derscombo.Items.AddRange(new object[] {
            "Kimya",
            "ingilizce",
            "fizik"});
            this.derscombo.Location = new System.Drawing.Point(310, 115);
            this.derscombo.Name = "derscombo";
            this.derscombo.Size = new System.Drawing.Size(121, 21);
            this.derscombo.TabIndex = 10;
            // 
            // y1text
            // 
            this.y1text.Location = new System.Drawing.Point(290, 136);
            this.y1text.Name = "y1text";
            this.y1text.Size = new System.Drawing.Size(42, 20);
            this.y1text.TabIndex = 11;
            // 
            // y2text
            // 
            this.y2text.Location = new System.Drawing.Point(290, 162);
            this.y2text.Name = "y2text";
            this.y2text.Size = new System.Drawing.Size(42, 20);
            this.y2text.TabIndex = 12;
            // 
            // soztext
            // 
            this.soztext.Location = new System.Drawing.Point(290, 195);
            this.soztext.Name = "soztext";
            this.soztext.Size = new System.Drawing.Size(42, 20);
            this.soztext.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(266, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 355);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.soztext);
            this.Controls.Add(this.y2text);
            this.Controls.Add(this.y1text);
            this.Controls.Add(this.derscombo);
            this.Controls.Add(this.adrestext);
            this.Controls.Add(this.yastext);
            this.Controls.Add(this.adsoyadtext);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox adsoyadtext;
        private System.Windows.Forms.TextBox yastext;
        private System.Windows.Forms.TextBox adrestext;
        private System.Windows.Forms.ComboBox derscombo;
        private System.Windows.Forms.TextBox y1text;
        private System.Windows.Forms.TextBox y2text;
        private System.Windows.Forms.TextBox soztext;
        private System.Windows.Forms.Button button1;
    }
}

