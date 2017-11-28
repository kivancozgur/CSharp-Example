namespace companentler
{
    partial class datetimepicker
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ilktarih = new System.Windows.Forms.TextBox();
            this.dogtartext = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(134, 26);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // ilktarih
            // 
            this.ilktarih.Location = new System.Drawing.Point(234, 52);
            this.ilktarih.Name = "ilktarih";
            this.ilktarih.Size = new System.Drawing.Size(100, 20);
            this.ilktarih.TabIndex = 1;
            // 
            // dogtartext
            // 
            this.dogtartext.Location = new System.Drawing.Point(234, 89);
            this.dogtartext.Name = "dogtartext";
            this.dogtartext.Size = new System.Drawing.Size(100, 20);
            this.dogtartext.TabIndex = 2;
            // 
            // datetimepicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 310);
            this.Controls.Add(this.dogtartext);
            this.Controls.Add(this.ilktarih);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "datetimepicker";
            this.Text = "datetimepicker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox ilktarih;
        private System.Windows.Forms.TextBox dogtartext;
    }
}