using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace paramslar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci[] adam = new Ogrenci[5];
            Ogrenci ogr = new Ogrenci();
            ogr.Adsoyad = "Kıvanç";
            ogr.Sınıf = "11A";
            ogr.Numara = 406;
            ogr.Adres="Hamitler Bursa";
            adam[0] = ogr;
            Ogrenci ogr1 = new Ogrenci();
            ogr1.Adsoyad = "Elif";
            ogr1.Sınıf = "11A";
            ogr1.Numara = 1520;
            ogr1.Adres = "Hamitler Bursa";
            adam[1] = ogr1;
            ogrencigoster(adam);

        }
        public void ogrencigoster(params Object[] ogrenciler)
        {
            foreach (Object gelenogr in ogrenciler)
            {
                MessageBox.Show("Ad Soyad : " +((Ogrenci)gelenogr).Adsoyad+"   Numara : "+((Ogrenci)gelenogr).Numara+"   Sınıf : "+((Ogrenci)gelenogr).Sınıf);
            }
        }
    }
}
