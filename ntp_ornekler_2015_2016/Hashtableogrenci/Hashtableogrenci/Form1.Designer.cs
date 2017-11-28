namespace Hashtableogrenci
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
            this.adtext = new System.Windows.Forms.TextBox();
            this.ognotext = new System.Windows.Forms.TextBox();
            this.adrestext = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adtext
            // 
            this.adtext.Location = new System.Drawing.Point(109, 45);
            this.adtext.Name = "adtext";
            this.adtext.Size = new System.Drawing.Size(100, 20);
            this.adtext.TabIndex = 0;
            // 
            // ognotext
            // 
            this.ognotext.Location = new System.Drawing.Point(109, 10);
            this.ognotext.Name = "ognotext";
            this.ognotext.Size = new System.Drawing.Size(100, 20);
            this.ognotext.TabIndex = 1;
            // 
            // adrestext
            // 
            this.adrestext.Location = new System.Drawing.Point(109, 80);
            this.adrestext.Name = "adrestext";
            this.adrestext.Size = new System.Drawing.Size(100, 20);
            this.adrestext.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(109, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(209, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "ara";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 242);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.adrestext);
            this.Controls.Add(this.ognotext);
            this.Controls.Add(this.adtext);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox adtext;
        private System.Windows.Forms.TextBox ognotext;
        private System.Windows.Forms.TextBox adrestext;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

