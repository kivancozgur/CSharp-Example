namespace Stok_Takip
{
    partial class Parcalar
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.parcaadtxt = new System.Windows.Forms.TextBox();
            this.birimfiyattxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.parcanotxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parça Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Birim Fiyatı";
            // 
            // parcaadtxt
            // 
            this.parcaadtxt.BackColor = System.Drawing.Color.LightGray;
            this.parcaadtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.parcaadtxt.Font = new System.Drawing.Font("Trajan Pro", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parcaadtxt.ForeColor = System.Drawing.Color.Black;
            this.parcaadtxt.Location = new System.Drawing.Point(215, 85);
            this.parcaadtxt.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.parcaadtxt.Name = "parcaadtxt";
            this.parcaadtxt.Size = new System.Drawing.Size(180, 25);
            this.parcaadtxt.TabIndex = 4;
            // 
            // birimfiyattxt
            // 
            this.birimfiyattxt.BackColor = System.Drawing.Color.LightGray;
            this.birimfiyattxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.birimfiyattxt.Font = new System.Drawing.Font("Trajan Pro", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birimfiyattxt.ForeColor = System.Drawing.Color.Black;
            this.birimfiyattxt.Location = new System.Drawing.Point(215, 129);
            this.birimfiyattxt.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.birimfiyattxt.Name = "birimfiyattxt";
            this.birimfiyattxt.Size = new System.Drawing.Size(180, 25);
            this.birimfiyattxt.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(215, 194);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Parça No:";
            // 
            // parcanotxt
            // 
            this.parcanotxt.BackColor = System.Drawing.Color.LightGray;
            this.parcanotxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.parcanotxt.Font = new System.Drawing.Font("Trajan Pro", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parcanotxt.ForeColor = System.Drawing.Color.Black;
            this.parcanotxt.Location = new System.Drawing.Point(215, 47);
            this.parcanotxt.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.parcanotxt.Name = "parcanotxt";
            this.parcanotxt.Size = new System.Drawing.Size(180, 25);
            this.parcanotxt.TabIndex = 8;
            // 
            // Parcalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(523, 264);
            this.Controls.Add(this.parcanotxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.birimfiyattxt);
            this.Controls.Add(this.parcaadtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Trajan Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "Parcalar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parcalar";
            this.Load += new System.EventHandler(this.Parcalar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox parcaadtxt;
        private System.Windows.Forms.TextBox birimfiyattxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox parcanotxt;
    }
}