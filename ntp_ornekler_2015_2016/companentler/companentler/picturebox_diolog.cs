using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace companentler
{
    public partial class picturebox_diolog : Form
    {
        public picturebox_diolog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image=Image.FromFile("d:\\resim\\koala.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "resim dosyası|*.jpg|excel dosyası|*.xls";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                String dosyabilgisi = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(dosyabilgisi);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            textBox1.Font = fontDialog1.Font;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            textBox1.ForeColor = colorDialog1.Color;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            MessageBox.Show(folderBrowserDialog1.SelectedPath);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            this.Opacity = (double)trackBar1.Value / 100;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show(domainUpDown1.Text);
        }

        private void picturebox_diolog_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <= 100; i++)
            {
                domainUpDown1.Items.Add(i);
            }
        }

     
    }
}
