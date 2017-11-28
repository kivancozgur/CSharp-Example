namespace örnek
{
    partial class Kayitgezintisi_sil_degistir
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
            this.adrestext = new System.Windows.Forms.TextBox();
            this.dogtar = new System.Windows.Forms.DateTimePicker();
            this.tckimliktext = new System.Windows.Forms.TextBox();
            this.adsoyadtext = new System.Windows.Forms.TextBox();
            this.ognotext = new System.Windows.Forms.TextBox();
            this.buttonileri = new System.Windows.Forms.Button();
            this.butongeri = new System.Windows.Forms.Button();
            this.buttonsil = new System.Windows.Forms.Button();
            this.buttondegistir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adrestext
            // 
            this.adrestext.Location = new System.Drawing.Point(144, 141);
            this.adrestext.Multiline = true;
            this.adrestext.Name = "adrestext";
            this.adrestext.Size = new System.Drawing.Size(211, 93);
            this.adrestext.TabIndex = 12;
            // 
            // dogtar
            // 
            this.dogtar.Location = new System.Drawing.Point(144, 102);
            this.dogtar.Name = "dogtar";
            this.dogtar.Size = new System.Drawing.Size(200, 20);
            this.dogtar.TabIndex = 11;
            // 
            // tckimliktext
            // 
            this.tckimliktext.Location = new System.Drawing.Point(144, 76);
            this.tckimliktext.Name = "tckimliktext";
            this.tckimliktext.Size = new System.Drawing.Size(130, 20);
            this.tckimliktext.TabIndex = 10;
            // 
            // adsoyadtext
            // 
            this.adsoyadtext.Location = new System.Drawing.Point(144, 52);
            this.adsoyadtext.Name = "adsoyadtext";
            this.adsoyadtext.Size = new System.Drawing.Size(100, 20);
            this.adsoyadtext.TabIndex = 9;
            // 
            // ognotext
            // 
            this.ognotext.Location = new System.Drawing.Point(144, 26);
            this.ognotext.Name = "ognotext";
            this.ognotext.ReadOnly = true;
            this.ognotext.Size = new System.Drawing.Size(76, 20);
            this.ognotext.TabIndex = 8;
            // 
            // buttonileri
            // 
            this.buttonileri.Location = new System.Drawing.Point(269, 258);
            this.buttonileri.Name = "buttonileri";
            this.buttonileri.Size = new System.Drawing.Size(75, 23);
            this.buttonileri.TabIndex = 13;
            this.buttonileri.Text = "İleri-->";
            this.buttonileri.UseVisualStyleBackColor = true;
            this.buttonileri.Click += new System.EventHandler(this.buttonileri_Click);
            // 
            // butongeri
            // 
            this.butongeri.Location = new System.Drawing.Point(133, 258);
            this.butongeri.Name = "butongeri";
            this.butongeri.Size = new System.Drawing.Size(75, 23);
            this.butongeri.TabIndex = 14;
            this.butongeri.Text = "<__geri";
            this.butongeri.UseVisualStyleBackColor = true;
            this.butongeri.Click += new System.EventHandler(this.butongeri_Click);
            // 
            // buttonsil
            // 
            this.buttonsil.Location = new System.Drawing.Point(269, 300);
            this.buttonsil.Name = "buttonsil";
            this.buttonsil.Size = new System.Drawing.Size(75, 23);
            this.buttonsil.TabIndex = 15;
            this.buttonsil.Text = "sil";
            this.buttonsil.UseVisualStyleBackColor = true;
            this.buttonsil.Click += new System.EventHandler(this.buttonsil_Click);
            // 
            // buttondegistir
            // 
            this.buttondegistir.Location = new System.Drawing.Point(133, 300);
            this.buttondegistir.Name = "buttondegistir";
            this.buttondegistir.Size = new System.Drawing.Size(75, 23);
            this.buttondegistir.TabIndex = 16;
            this.buttondegistir.Text = "Değiştir";
            this.buttondegistir.UseVisualStyleBackColor = true;
            this.buttondegistir.Click += new System.EventHandler(this.buttondegistir_Click);
            // 
            // Kayitgezintisi_sil_degistir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 357);
            this.Controls.Add(this.buttondegistir);
            this.Controls.Add(this.buttonsil);
            this.Controls.Add(this.butongeri);
            this.Controls.Add(this.buttonileri);
            this.Controls.Add(this.adrestext);
            this.Controls.Add(this.dogtar);
            this.Controls.Add(this.tckimliktext);
            this.Controls.Add(this.adsoyadtext);
            this.Controls.Add(this.ognotext);
            this.Name = "Kayitgezintisi_sil_degistir";
            this.Text = "Kayitgezintisi_sil_degistir";
            this.Load += new System.EventHandler(this.Kayitgezintisi_sil_degistir_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox adrestext;
        private System.Windows.Forms.DateTimePicker dogtar;
        private System.Windows.Forms.TextBox tckimliktext;
        private System.Windows.Forms.TextBox adsoyadtext;
        private System.Windows.Forms.TextBox ognotext;
        private System.Windows.Forms.Button buttonileri;
        private System.Windows.Forms.Button butongeri;
        private System.Windows.Forms.Button buttonsil;
        private System.Windows.Forms.Button buttondegistir;
    }
}