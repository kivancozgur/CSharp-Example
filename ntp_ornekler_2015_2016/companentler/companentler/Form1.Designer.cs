namespace companentler
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
            this.button1 = new System.Windows.Forms.Button();
            this.sayi1text = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sayi2text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.butontopla = new System.Windows.Forms.Button();
            this.butoncarp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(177, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Tıkla";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sayi1text
            // 
            this.sayi1text.Location = new System.Drawing.Point(95, 101);
            this.sayi1text.Name = "sayi1text";
            this.sayi1text.Size = new System.Drawing.Size(121, 20);
            this.sayi1text.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(336, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "sayı1";
            // 
            // sayi2text
            // 
            this.sayi2text.Location = new System.Drawing.Point(95, 127);
            this.sayi2text.Name = "sayi2text";
            this.sayi2text.Size = new System.Drawing.Size(121, 20);
            this.sayi2text.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "sayi2";
            // 
            // butontopla
            // 
            this.butontopla.Location = new System.Drawing.Point(253, 96);
            this.butontopla.Name = "butontopla";
            this.butontopla.Size = new System.Drawing.Size(75, 23);
            this.butontopla.TabIndex = 6;
            this.butontopla.Text = "toplama";
            this.butontopla.UseVisualStyleBackColor = true;
            this.butontopla.Click += new System.EventHandler(this.butontopla_Click);
            // 
            // butoncarp
            // 
            this.butoncarp.Location = new System.Drawing.Point(253, 128);
            this.butoncarp.Name = "butoncarp";
            this.butoncarp.Size = new System.Drawing.Size(72, 25);
            this.butoncarp.TabIndex = 7;
            this.butoncarp.Text = "Çarp";
            this.butoncarp.UseVisualStyleBackColor = true;
            this.butoncarp.Click += new System.EventHandler(this.butoncarp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 452);
            this.Controls.Add(this.butoncarp);
            this.Controls.Add(this.butontopla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sayi2text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.sayi1text);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "companantler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox sayi1text;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sayi2text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butontopla;
        private System.Windows.Forms.Button butoncarp;
    }
}

