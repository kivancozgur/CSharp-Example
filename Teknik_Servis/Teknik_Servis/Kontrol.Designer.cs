namespace Teknik_Servis
{
    partial class Kontrol
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
            this.btncikis = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.musterilergroup = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.araText = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnTamirEdildi = new System.Windows.Forms.Button();
            this.btnFatura = new System.Windows.Forms.Button();
            this.btnParcaBekleniyor = new System.Windows.Forms.Button();
            this.btniade = new System.Windows.Forms.Button();
            this.musterilergroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btncikis
            // 
            this.btncikis.Font = new System.Drawing.Font("HK Grotesk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncikis.Image = global::Teknik_Servis.Properties.Resources.cikis;
            this.btncikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncikis.Location = new System.Drawing.Point(1262, 660);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(88, 46);
            this.btncikis.TabIndex = 5;
            this.btncikis.Text = "ÇIKIŞ";
            this.btncikis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncikis.UseVisualStyleBackColor = true;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("HK Grotesk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(632, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 56);
            this.button1.TabIndex = 1;
            this.button1.Text = "Müşteri Tamir İstemedi İade";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // musterilergroup
            // 
            this.musterilergroup.Controls.Add(this.dataGridView1);
            this.musterilergroup.Controls.Add(this.btniade);
            this.musterilergroup.Controls.Add(this.btnParcaBekleniyor);
            this.musterilergroup.Controls.Add(this.btnFatura);
            this.musterilergroup.Controls.Add(this.btnTamirEdildi);
            this.musterilergroup.Controls.Add(this.btnAra);
            this.musterilergroup.Controls.Add(this.araText);
            this.musterilergroup.Controls.Add(this.label1);
            this.musterilergroup.Location = new System.Drawing.Point(23, 295);
            this.musterilergroup.Name = "musterilergroup";
            this.musterilergroup.Size = new System.Drawing.Size(805, 399);
            this.musterilergroup.TabIndex = 12;
            this.musterilergroup.TabStop = false;
            this.musterilergroup.Text = "groupBox1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(46, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(566, 248);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("HK Grotesk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(632, 172);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(196, 39);
            this.button2.TabIndex = 2;
            this.button2.Text = "Parça Bekleniyor";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("HK Grotesk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(632, 293);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(196, 33);
            this.button3.TabIndex = 10;
            this.button3.Text = "Faturalandır";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("HK Grotesk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(632, 239);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(196, 33);
            this.button4.TabIndex = 3;
            this.button4.Text = "Tamir Edildi (OK)";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("HK Grotesk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(449, 41);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(97, 31);
            this.button5.TabIndex = 9;
            this.button5.Text = "Ara";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("HK Grotesk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(267, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 27);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Ad";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("HK Grotesk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(164, 45);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 19);
            this.label13.TabIndex = 8;
            this.label13.Text = "Müşteri Ara :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HK Grotesk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Müşteri Ara :";
            // 
            // araText
            // 
            this.araText.Font = new System.Drawing.Font("HK Grotesk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.araText.Location = new System.Drawing.Point(267, 42);
            this.araText.Name = "araText";
            this.araText.Size = new System.Drawing.Size(176, 27);
            this.araText.TabIndex = 7;
            this.araText.Text = "Ad";
            // 
            // btnAra
            // 
            this.btnAra.Font = new System.Drawing.Font("HK Grotesk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAra.Location = new System.Drawing.Point(449, 41);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(97, 31);
            this.btnAra.TabIndex = 9;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            // 
            // btnTamirEdildi
            // 
            this.btnTamirEdildi.Font = new System.Drawing.Font("HK Grotesk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTamirEdildi.Location = new System.Drawing.Point(632, 239);
            this.btnTamirEdildi.Name = "btnTamirEdildi";
            this.btnTamirEdildi.Size = new System.Drawing.Size(196, 33);
            this.btnTamirEdildi.TabIndex = 3;
            this.btnTamirEdildi.Text = "Tamir Edildi (OK)";
            this.btnTamirEdildi.UseVisualStyleBackColor = true;
            this.btnTamirEdildi.Click += new System.EventHandler(this.btnTamirEdildi_Click);
            // 
            // btnFatura
            // 
            this.btnFatura.Font = new System.Drawing.Font("HK Grotesk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFatura.Location = new System.Drawing.Point(632, 293);
            this.btnFatura.Name = "btnFatura";
            this.btnFatura.Size = new System.Drawing.Size(196, 33);
            this.btnFatura.TabIndex = 10;
            this.btnFatura.Text = "Faturalandır";
            this.btnFatura.UseVisualStyleBackColor = true;
            this.btnFatura.Click += new System.EventHandler(this.btnFatura_Click);
            // 
            // btnParcaBekleniyor
            // 
            this.btnParcaBekleniyor.Font = new System.Drawing.Font("HK Grotesk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParcaBekleniyor.Location = new System.Drawing.Point(632, 172);
            this.btnParcaBekleniyor.Name = "btnParcaBekleniyor";
            this.btnParcaBekleniyor.Size = new System.Drawing.Size(196, 39);
            this.btnParcaBekleniyor.TabIndex = 2;
            this.btnParcaBekleniyor.Text = "Parça Bekleniyor";
            this.btnParcaBekleniyor.UseVisualStyleBackColor = true;
            this.btnParcaBekleniyor.Click += new System.EventHandler(this.btnParcaBekleniyor_Click);
            // 
            // btniade
            // 
            this.btniade.Font = new System.Drawing.Font("HK Grotesk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btniade.Location = new System.Drawing.Point(632, 92);
            this.btniade.Name = "btniade";
            this.btniade.Size = new System.Drawing.Size(196, 56);
            this.btniade.TabIndex = 1;
            this.btniade.Text = "Müşteri Tamir İstemedi İade";
            this.btniade.UseVisualStyleBackColor = true;
            this.btniade.Click += new System.EventHandler(this.btniade_Click);
            // 
            // Kontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 732);
            this.Controls.Add(this.musterilergroup);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btncikis);
            this.Name = "Kontrol";
            this.Text = "MusterilerForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MusterilerForm_Load);
            this.musterilergroup.ResumeLayout(false);
            this.musterilergroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncikis;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox musterilergroup;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btniade;
        private System.Windows.Forms.Button btnParcaBekleniyor;
        private System.Windows.Forms.Button btnFatura;
        private System.Windows.Forms.Button btnTamirEdildi;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox araText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label13;
    }
}