using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace params_sonsuzparametre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] sayilar = new int[5];
            sayilar[0] = 10;
            sayilar[1] = 20;
            sayilar[2] = 10;
            sayilar[3] = 40;
            sayilar[4] = 50;
            MessageBox.Show(toplam(sayilar).ToString()); ;
        }

        public int toplam(params int[] sayilar)
        {
            int toplam = 0;
            foreach (int say in sayilar)
            {
                toplam += say;
            }
            return toplam;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Ogrenci[] ogrencilistesi = new Ogrenci[5];
            Ogrenci yeniogr = new Ogrenci();
            yeniogr.Adsoyad = "tuncay salı";
            yeniogr.Ogno = 5;
            yeniogr.Adres = "bursa";
            ogrencilistesi[0] = yeniogr;
            Ogrenci yeniogr1 = new Ogrenci();
            yeniogr1.Adsoyad = "ahmet top";
            yeniogr1.Ogno = 2;
            yeniogr1.Adres = "izmşr";
            ogrencilistesi[1] = yeniogr1;
            ogrecigoster(ogrencilistesi);
        }


        public void ogrecigoster(params Object[] ogrenciler)
        {
            

            foreach (Object gelengenci in ogrenciler)
            {
                if (gelengenci.GetType() == typeof(Ogrenci))
                {
                    MessageBox.Show("doğru");
                }
                MessageBox.Show(((Ogrenci)gelengenci).Adsoyad);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
