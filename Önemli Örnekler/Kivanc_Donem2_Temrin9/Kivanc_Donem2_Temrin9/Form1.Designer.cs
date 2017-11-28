namespace Kivanc_Donem2_Temrin9
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tarihbut = new System.Windows.Forms.Button();
            this.ilktarbut = new System.Windows.Forms.Button();
            this.ikincitarbut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.Chartreuse;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.SystemColors.Highlight;
            this.dateTimePicker1.Location = new System.Drawing.Point(40, 14);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(322, 29);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Desktop;
            this.listBox1.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(40, 161);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(991, 446);
            this.listBox1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "",
            "Fizik",
            "Kimya",
            "Beden",
            "Ingilizce",
            "Fransızca",
            "Din Kültürü"});
            this.comboBox1.Location = new System.Drawing.Point(492, 16);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 30);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Brown;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.Color.NavajoWhite;
            this.textBox1.Location = new System.Drawing.Point(817, 18);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 29);
            this.textBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Wheat;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.button1.Location = new System.Drawing.Point(817, 62);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 51);
            this.button1.TabIndex = 4;
            this.button1.Text = "No Bul";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(419, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ders";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.label2.Location = new System.Drawing.Point(768, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "No";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Plum;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.Indigo;
            this.button2.Location = new System.Drawing.Point(512, 62);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 51);
            this.button2.TabIndex = 7;
            this.button2.Text = "Ders Seç";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tarihbut
            // 
            this.tarihbut.BackColor = System.Drawing.Color.LightGreen;
            this.tarihbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tarihbut.ForeColor = System.Drawing.Color.DarkGreen;
            this.tarihbut.Location = new System.Drawing.Point(129, 97);
            this.tarihbut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tarihbut.Name = "tarihbut";
            this.tarihbut.Size = new System.Drawing.Size(146, 54);
            this.tarihbut.TabIndex = 8;
            this.tarihbut.Text = "Tarihler Arası Ara";
            this.tarihbut.UseVisualStyleBackColor = false;
            this.tarihbut.Click += new System.EventHandler(this.tarihbut_Click);
            // 
            // ilktarbut
            // 
            this.ilktarbut.BackColor = System.Drawing.Color.SkyBlue;
            this.ilktarbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ilktarbut.Location = new System.Drawing.Point(40, 53);
            this.ilktarbut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ilktarbut.Name = "ilktarbut";
            this.ilktarbut.Size = new System.Drawing.Size(146, 34);
            this.ilktarbut.TabIndex = 9;
            this.ilktarbut.Text = "İlk Tarih Seç";
            this.ilktarbut.UseVisualStyleBackColor = false;
            this.ilktarbut.Click += new System.EventHandler(this.ilktarbut_Click);
            // 
            // ikincitarbut
            // 
            this.ikincitarbut.BackColor = System.Drawing.Color.LightCoral;
            this.ikincitarbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ikincitarbut.ForeColor = System.Drawing.Color.Maroon;
            this.ikincitarbut.Location = new System.Drawing.Point(210, 53);
            this.ikincitarbut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ikincitarbut.Name = "ikincitarbut";
            this.ikincitarbut.Size = new System.Drawing.Size(152, 34);
            this.ikincitarbut.TabIndex = 10;
            this.ikincitarbut.Text = "İkinci Tarih Seç";
            this.ikincitarbut.UseVisualStyleBackColor = false;
            this.ikincitarbut.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1042, 614);
            this.Controls.Add(this.ikincitarbut);
            this.Controls.Add(this.ilktarbut);
            this.Controls.Add(this.tarihbut);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.MediumBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Temrin9";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button tarihbut;
        private System.Windows.Forms.Button ilktarbut;
        private System.Windows.Forms.Button ikincitarbut;
    }
}

