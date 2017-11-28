namespace Okul_Zili
{
    partial class Form2
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
            this.eklebut = new System.Windows.Forms.Button();
            this.kaydetbut = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // eklebut
            // 
            this.eklebut.Location = new System.Drawing.Point(163, 76);
            this.eklebut.Name = "eklebut";
            this.eklebut.Size = new System.Drawing.Size(75, 23);
            this.eklebut.TabIndex = 0;
            this.eklebut.Text = "Ekle";
            this.eklebut.UseVisualStyleBackColor = true;
            this.eklebut.Click += new System.EventHandler(this.eklebut_Click);
            // 
            // kaydetbut
            // 
            this.kaydetbut.Location = new System.Drawing.Point(163, 176);
            this.kaydetbut.Name = "kaydetbut";
            this.kaydetbut.Size = new System.Drawing.Size(75, 23);
            this.kaydetbut.TabIndex = 1;
            this.kaydetbut.Text = "Kaydet";
            this.kaydetbut.UseVisualStyleBackColor = true;
            this.kaydetbut.Click += new System.EventHandler(this.kaydetbut_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 43);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 2;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(12, 144);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 95);
            this.listBox2.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 256);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.kaydetbut);
            this.Controls.Add(this.eklebut);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button eklebut;
        private System.Windows.Forms.Button kaydetbut;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
    }
}