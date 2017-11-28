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
            ogr1.Ogno = 5;
            ogr1.Ad = "osman";
            ogr1.Boy = 170;
            MessageBox.Show(ogr1.bilgioku());

            Ogretmen ogrt1 = new Ogretmen();
            ogrt1.Ad = "tuncay";
            ogrt1.Kilo = 75;
            MessageBox.Show(ogrt1.bilgioku());

        }
    }
}
