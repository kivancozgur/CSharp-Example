using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Stok_Takip
{
    public partial class Parcastokk : Form
    {
        public Parcastokk()
        {
            InitializeComponent();
        }
        Parcalardao parcais = new Parcalardao();
        void parcaadyukleme()
        {
            comboBox1.Items.Clear();
            ArrayList parcalist = parcais.tumparcalarigetir();
            foreach (Parcalarsınıf gelenparca in parcalist)
            {
                comboBox1.Items.Add(gelenparca.Parcaad);

            }
        }

        private void Parcastokk_Load(object sender, EventArgs e)
        {
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.TextAlign = ContentAlignment.MiddleRight;
            parcaadyukleme();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = parcais.parcastokkaydet(comboBox1.SelectedItem.ToString(),Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
            if (sayi == 1) MessageBox.Show("Parça Stoğu Başarıyla Kaydedildi!");
            else MessageBox.Show("Parça Stoğunu kaydedederken bir hata oluştu lütfen tekrar deneyiniz.");
            parcaadyukleme();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            parcaadyukleme();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            parcaadyukleme();
        }
    }
}
