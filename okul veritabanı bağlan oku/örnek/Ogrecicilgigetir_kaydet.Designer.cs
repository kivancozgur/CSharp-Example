namespace örnek
{
    partial class Ogrecicilgigetir_kaydet
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
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ognotext = new System.Windows.Forms.TextBox();
            this.adsoyadtext = new System.Windows.Forms.TextBox();
            this.tckimliktext = new System.Windows.Forms.TextBox();
            this.dogtar = new System.Windows.Forms.DateTimePicker();
            this.adrestext = new System.Windows.Forms.TextBox();
            this.Kaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(38, 84);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(227, 173);
            this.listBox1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(273, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ognotext
            // 
            this.ognotext.Location = new System.Drawing.Point(499, 8);
            this.ognotext.Name = "ognotext";
            this.ognotext.Size = new System.Drawing.Size(76, 20);
            this.ognotext.TabIndex = 3;
            // 
            // adsoyadtext
            // 
            this.adsoyadtext.Location = new System.Drawing.Point(499, 34);
            this.adsoyadtext.Name = "adsoyadtext";
            this.adsoyadtext.Size = new System.Drawing.Size(100, 20);
            this.adsoyadtext.TabIndex = 4;
            // 
            // tckimliktext
            // 
            this.tckimliktext.Location = new System.Drawing.Point(499, 58);
            this.tckimliktext.Name = "tckimliktext";
            this.tckimliktext.Size = new System.Drawing.Size(130, 20);
            this.tckimliktext.TabIndex = 5;
            // 
            // dogtar
            // 
            this.dogtar.Location = new System.Drawing.Point(499, 84);
            this.dogtar.Name = "dogtar";
            this.dogtar.Size = new System.Drawing.Size(200, 20);
            this.dogtar.TabIndex = 6;
            // 
            // adrestext
            // 
            this.adrestext.Location = new System.Drawing.Point(499, 123);
            this.adrestext.Multiline = true;
            this.adrestext.Name = "adrestext";
            this.adrestext.Size = new System.Drawing.Size(211, 93);
            this.adrestext.TabIndex = 7;
            // 
            // Kaydet
            // 
            this.Kaydet.Location = new System.Drawing.Point(524, 234);
            this.Kaydet.Name = "Kaydet";
            this.Kaydet.Size = new System.Drawing.Size(75, 23);
            this.Kaydet.TabIndex = 8;
            this.Kaydet.Text = "kaydet";
            this.Kaydet.UseVisualStyleBackColor = true;
            this.Kaydet.Click += new System.EventHandler(this.Kaydet_Click);
            // 
            // Ogrecicilgigetir_kaydet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 294);
            this.Controls.Add(this.Kaydet);
            this.Controls.Add(this.adrestext);
            this.Controls.Add(this.dogtar);
            this.Controls.Add(this.tckimliktext);
            this.Controls.Add(this.adsoyadtext);
            this.Controls.Add(this.ognotext);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Name = "Ogrecicilgigetir_kaydet";
            this.Text = "Ogrecicilgigetir_kaydet";
            this.Load += new System.EventHandler(this.Ogrecicilgigetir_kaydet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox ognotext;
        private System.Windows.Forms.TextBox adsoyadtext;
        private System.Windows.Forms.TextBox tckimliktext;
        private System.Windows.Forms.DateTimePicker dogtar;
        private System.Windows.Forms.TextBox adrestext;
        private System.Windows.Forms.Button Kaydet;
    }
}