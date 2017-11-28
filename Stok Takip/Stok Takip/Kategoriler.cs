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
    public partial class Kategoriler : Form
    {
        public Kategoriler()
        {
            InitializeComponent();
        }
        Kategorilerdao kategoriis = new Kategorilerdao();
        private void Kategoriler_Load(object sender, EventArgs e)
        {
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.TextAlign = ContentAlignment.MiddleRight;
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = kategoriis.kategorikaydet(textBox1.Text.ToString());
            if (sayi == 1) MessageBox.Show("Kategori Başarıyla Kaydedildi!");
            else MessageBox.Show("Kategoriyi kaydedederken bir hata oluştu lütfen tekrar deneyiniz.");


        }
    }
}
