using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kivanc_Donem2_Temrin_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci[] adam = new Ogrenci[1];
            Ogrenci ogr = new Ogrenci();
            ogr.Adsoyad = "Kıvanç";
            ogr.Numara = 406;
            adam[0] = ogr;
            Aslan[] arslan = new Aslan[1];
            Aslan yeniarslan = new Aslan();
            yeniarslan.Cinsiyet = "Erkek";
            yeniarslan.Renk = "Turuncu";
            arslan[0] = yeniarslan;
            Elma[]elma = new Elma[1];
            Elma yenielma = new Elma();
            yenielma.Renk = "Yeşil";
            elma[0] = yenielma;
            secim(adam);
            secim(arslan);
            secim(elma);
        }
        public void secim(params Object[] sec)
        {
            foreach (Object gelen in sec)
            {
                MessageBox.Show("Ad Soyad : " + ((Ogrenci)gelen).Adsoyad + "   Numara : " + ((Ogrenci)gelen).Numara);
                MessageBox.Show("Aslan Renk : " + ((Aslan)gelen).Renk + "     Cinsiyet :" + ((Aslan)gelen).Cinsiyet);
                MessageBox.Show("Elma Renk : " + ((Elma)gelen).Renk);
            }
        }
    }
}
