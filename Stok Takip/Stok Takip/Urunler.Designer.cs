namespace Stok_Takip
{
    partial class Urunler
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.modelnotext = new System.Windows.Forms.TextBox();
            this.parcasec = new System.Windows.Forms.ListBox();
            this.secilenparca = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.kaydetbut = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.fiyatlist = new System.Windows.Forms.ListBox();
            this.secbut = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.secbut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ana Kategori";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Model Kodu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 138);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Parça Seç";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trajan Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(308, 182);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Adet*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(403, 138);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Seçilen Parçalar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(438, 486);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Toplam Fiyat;";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(552, 486);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "0 TL";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.LightGray;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Trajan Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(212, 25);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 27);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // modelnotext
            // 
            this.modelnotext.BackColor = System.Drawing.Color.LightGray;
            this.modelnotext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modelnotext.ForeColor = System.Drawing.Color.Black;
            this.modelnotext.Location = new System.Drawing.Point(212, 65);
            this.modelnotext.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.modelnotext.Name = "modelnotext";
            this.modelnotext.Size = new System.Drawing.Size(180, 23);
            this.modelnotext.TabIndex = 10;
            // 
            // parcasec
            // 
            this.parcasec.BackColor = System.Drawing.Color.LightGray;
            this.parcasec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.parcasec.Font = new System.Drawing.Font("Trajan Pro", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parcasec.ForeColor = System.Drawing.Color.Black;
            this.parcasec.FormattingEnabled = true;
            this.parcasec.ItemHeight = 15;
            this.parcasec.Location = new System.Drawing.Point(42, 163);
            this.parcasec.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.parcasec.Name = "parcasec";
            this.parcasec.Size = new System.Drawing.Size(209, 302);
            this.parcasec.TabIndex = 11;
            // 
            // secilenparca
            // 
            this.secilenparca.BackColor = System.Drawing.Color.LightGray;
            this.secilenparca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.secilenparca.Font = new System.Drawing.Font("Trajan Pro", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secilenparca.ForeColor = System.Drawing.Color.Black;
            this.secilenparca.FormattingEnabled = true;
            this.secilenparca.ItemHeight = 15;
            this.secilenparca.Location = new System.Drawing.Point(406, 163);
            this.secilenparca.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.secilenparca.Name = "secilenparca";
            this.secilenparca.Size = new System.Drawing.Size(229, 302);
            this.secilenparca.TabIndex = 12;
            this.secilenparca.SelectedIndexChanged += new System.EventHandler(this.secilenparca_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.LightGray;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(311, 201);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(44, 26);
            this.textBox2.TabIndex = 13;
            // 
            // kaydetbut
            // 
            this.kaydetbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kaydetbut.Location = new System.Drawing.Point(267, 515);
            this.kaydetbut.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.kaydetbut.Name = "kaydetbut";
            this.kaydetbut.Size = new System.Drawing.Size(112, 29);
            this.kaydetbut.TabIndex = 16;
            this.kaydetbut.Text = "Kaydet";
            this.kaydetbut.UseVisualStyleBackColor = true;
            this.kaydetbut.Click += new System.EventHandler(this.kaydetbut_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 560);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(574, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "*Ürünü seçilen parçalar listesine attıktan sonra adet girmeyi unutmayınız!";
            // 
            // fiyatlist
            // 
            this.fiyatlist.BackColor = System.Drawing.Color.LightGray;
            this.fiyatlist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fiyatlist.Font = new System.Drawing.Font("Trajan Pro", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fiyatlist.ForeColor = System.Drawing.Color.Black;
            this.fiyatlist.FormattingEnabled = true;
            this.fiyatlist.ItemHeight = 15;
            this.fiyatlist.Location = new System.Drawing.Point(658, 163);
            this.fiyatlist.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.fiyatlist.Name = "fiyatlist";
            this.fiyatlist.Size = new System.Drawing.Size(126, 302);
            this.fiyatlist.TabIndex = 19;
            this.fiyatlist.Visible = false;
            // 
            // secbut
            // 
            this.secbut.Image = global::Stok_Takip.Properties.Resources._1465222345_Arrow_Direction_Move_Next_Forward_Right;
            this.secbut.Location = new System.Drawing.Point(285, 240);
            this.secbut.Name = "secbut";
            this.secbut.Size = new System.Drawing.Size(94, 79);
            this.secbut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.secbut.TabIndex = 20;
            this.secbut.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Stok_Takip.Properties.Resources._1465222425_Arrow_Direction_Move_Back_Left_Previous;
            this.pictureBox1.Location = new System.Drawing.Point(285, 334);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // Urunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(820, 601);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.secbut);
            this.Controls.Add(this.fiyatlist);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.kaydetbut);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.secilenparca);
            this.Controls.Add(this.parcasec);
            this.Controls.Add(this.modelnotext);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Trajan Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Urunler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Urunler";
            this.Load += new System.EventHandler(this.Urunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.secbut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox modelnotext;
        private System.Windows.Forms.ListBox parcasec;
        private System.Windows.Forms.ListBox secilenparca;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button kaydetbut;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox fiyatlist;
        private System.Windows.Forms.PictureBox secbut;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}