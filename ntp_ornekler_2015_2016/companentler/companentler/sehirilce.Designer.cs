namespace companentler
{
    partial class sehirilce
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
            this.ilcombo = new System.Windows.Forms.ComboBox();
            this.ilcelist = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ilcombo
            // 
            this.ilcombo.FormattingEnabled = true;
            this.ilcombo.Items.AddRange(new object[] {
            "ankara",
            "bursa",
            "izmir"});
            this.ilcombo.Location = new System.Drawing.Point(12, 32);
            this.ilcombo.Name = "ilcombo";
            this.ilcombo.Size = new System.Drawing.Size(121, 21);
            this.ilcombo.TabIndex = 0;
            this.ilcombo.Text = "Seçiniz";
            this.ilcombo.SelectedIndexChanged += new System.EventHandler(this.ilcombo_SelectedIndexChanged);
            // 
            // ilcelist
            // 
            this.ilcelist.FormattingEnabled = true;
            this.ilcelist.Location = new System.Drawing.Point(322, 16);
            this.ilcelist.Name = "ilcelist";
            this.ilcelist.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.ilcelist.Size = new System.Drawing.Size(119, 238);
            this.ilcelist.TabIndex = 1;
            this.ilcelist.SelectedIndexChanged += new System.EventHandler(this.ilcelist_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "İl Seçiniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ilçe seçiniz:";
            // 
            // sehirilce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 349);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ilcelist);
            this.Controls.Add(this.ilcombo);
            this.Name = "sehirilce";
            this.Text = "sehirilce";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ilcombo;
        private System.Windows.Forms.ListBox ilcelist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}