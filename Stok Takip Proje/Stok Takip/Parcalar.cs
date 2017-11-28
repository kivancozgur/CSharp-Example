using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Stok_Takip
{
    public partial class Parcalar : Form
    {
        public Parcalar()
        {
            InitializeComponent();
        }
        Parcalardao parcais = new Parcalardao();
        private void Parcalar_Load(object sender, EventArgs e)
        {
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.TextAlign = ContentAlignment.MiddleRight;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = parcais.parcakaydet(Convert.ToInt32(parcanotxt.Text), parcaadtxt.Text, Convert.ToInt32(birimfiyattxt.Text));
            if (sayi == 1) MessageBox.Show("Parça kaydedildi!");
            else MessageBox.Show("Parça kaydedilemedi lütfen tekrar deneyiniz!");
        }
    }
}
