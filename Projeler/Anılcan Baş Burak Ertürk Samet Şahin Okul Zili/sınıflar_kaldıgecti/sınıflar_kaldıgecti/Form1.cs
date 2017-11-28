using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sınıflar_kaldıgecti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci ogr = new Ogrenci();
            ogr.setAdsoyad(textBox1.Text);
            ogr.setYas(Convert.ToInt32(textBox2.Text));
            MessageBox.Show(ogr.getAdsoyad() + " adlı " ogr.getYas() + " yaşında ki öğrenci " + comboBox1.Text + " dersinden ");

        }
    }
}
