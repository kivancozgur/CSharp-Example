using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kalitim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci ogr1 = new Ogrenci();
            ogr1.Ogno = 406;
            ogr1.Ad = "Kıvanç";
            ogr1.Kilo = 65;
            ogr1.Boy = 180;
            MessageBox.Show(ogr1.bilgioku());

            Ogretmen ogretmen1 = new Ogretmen();
            ogretmen1.Ad = "Tuncay";
            ogretmen1.Boy = 180;
            ogretmen1.Sacrengi = "Siyah";
            MessageBox.Show(ogretmen1.bilgioku());
        }
    }
}
