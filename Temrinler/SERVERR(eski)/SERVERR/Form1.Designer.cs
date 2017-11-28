namespace SERVERR
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
            this.RtxtBox_Sohbet = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.RtxtBox_Ileti = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtBox_Dinleme_port = new System.Windows.Forms.TextBox();
            this.TxtBox_Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_Baslat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SOHBET";
            // 
            // RtxtBox_Sohbet
            // 
            this.RtxtBox_Sohbet.Location = new System.Drawing.Point(29, 25);
            this.RtxtBox_Sohbet.Name = "RtxtBox_Sohbet";
            this.RtxtBox_Sohbet.Size = new System.Drawing.Size(314, 156);
            this.RtxtBox_Sohbet.TabIndex = 1;
            this.RtxtBox_Sohbet.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(314, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "İletiniz";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // RtxtBox_Ileti
            // 
            this.RtxtBox_Ileti.Location = new System.Drawing.Point(29, 216);
            this.RtxtBox_Ileti.Name = "RtxtBox_Ileti";
            this.RtxtBox_Ileti.Size = new System.Drawing.Size(314, 96);
            this.RtxtBox_Ileti.TabIndex = 3;
            this.RtxtBox_Ileti.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "AYARLAR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dinleme Portu";
            // 
            // TxtBox_Dinleme_port
            // 
            this.TxtBox_Dinleme_port.Location = new System.Drawing.Point(370, 86);
            this.TxtBox_Dinleme_port.Name = "TxtBox_Dinleme_port";
            this.TxtBox_Dinleme_port.Size = new System.Drawing.Size(100, 20);
            this.TxtBox_Dinleme_port.TabIndex = 6;
            // 
            // TxtBox_Name
            // 
            this.TxtBox_Name.Location = new System.Drawing.Point(375, 163);
            this.TxtBox_Name.Name = "TxtBox_Name";
            this.TxtBox_Name.Size = new System.Drawing.Size(100, 20);
            this.TxtBox_Name.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(372, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nick Name";
            // 
            // Btn_Baslat
            // 
            this.Btn_Baslat.Location = new System.Drawing.Point(375, 214);
            this.Btn_Baslat.Name = "Btn_Baslat";
            this.Btn_Baslat.Size = new System.Drawing.Size(75, 23);
            this.Btn_Baslat.TabIndex = 9;
            this.Btn_Baslat.Text = "BAŞLAT";
            this.Btn_Baslat.UseVisualStyleBackColor = true;
            this.Btn_Baslat.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 335);
            this.Controls.Add(this.Btn_Baslat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtBox_Name);
            this.Controls.Add(this.TxtBox_Dinleme_port);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RtxtBox_Ileti);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RtxtBox_Sohbet);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox RtxtBox_Sohbet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox RtxtBox_Ileti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtBox_Dinleme_port;
        private System.Windows.Forms.TextBox TxtBox_Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_Baslat;
    }
}

