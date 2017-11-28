using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace _406_Kivanc_Ozgur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int index = -1;
        ArrayList insanlistesi = new ArrayList();
        Kayitdao insanisleri = new Kayitdao();
        public void bilgiyaz()
        {
            try
            {
                tcnotext.Text = ((Kayit)insanlistesi[index]).Tcno.ToString();
                adtext.Text = ((Kayit)insanlistesi[index]).Adisoyadi.ToString();
                ilcetext.Text = ((Kayit)insanlistesi[index]).Ilce.ToString();
                aytext.Text = ((Kayit)insanlistesi[index]).Ay.ToString();
                miktartext.Text = ((Kayit)insanlistesi[index]).Odenenmiktar.ToString();
            }
            catch (ArgumentOutOfRangeException)
            {
                if (index < 0) index++;
                else index--;
                MessageBox.Show("Kayıtlar Bitti");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.Columns.Clear();
            listView1.Columns.Add("Ad Soyad", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("No", 75, HorizontalAlignment.Left);
            listView1.Columns.Add("Doğum Tarihi", 200, HorizontalAlignment.Left);
            listView1.Columns.Add("Tc Kimlik", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("Adres", 150, HorizontalAlignment.Left);
            insanlistesi = insanisleri.tumkayitlar();

        }

        private void kadetbut_Click(object sender, EventArgs e)
        {
            int secim = Convert.ToInt32(MessageBox.Show("Kayıt kaydedilsinmi", "soru", MessageBoxButtons.YesNo));
            if (secim == 6)
            {
                int sayi = insanisleri.insankaydet(adtext.Text, tcnotext.Text, ilcetext.Text, aytext.Text, Convert.ToInt32(miktartext.Text));
                if (sayi != 0)
                {
                    MessageBox.Show("Kayıt Kaydedildi");
                    insanlistesi = insanisleri.tumkayitlar();
                }
                else MessageBox.Show("Kayıt Kaydedilemedi");
            }
        }

        private void guncellebut_Click(object sender, EventArgs e)
        {
            
            int secim = Convert.ToInt32(MessageBox.Show("kayıt değiştirilsinmi", "soru", MessageBoxButtons.YesNo));
            if (secim == 6)
            {
                int sayi = insanisleri.insandegistir(adtext.Text, tcnotext.Text, ilcetext.Text, aytext.Text, Convert.ToInt32(miktartext.Text));
                if (sayi != 0)
                {
                    MessageBox.Show("Kayıt Değiştirildi");
                   insanlistesi = insanisleri.tumkayitlar();
                }
                else MessageBox.Show("Kayıt Değiştirilemedi");
            }
        }
    }
}















/*int sira = listView1.Items.Count;
listView1.Items.Add(adtxt.Text);
listView1.Items[sira].SubItems.Add(notxt.Text);
listView1.Items[sira].SubItems.Add(dogtarpicker.Text);
listView1.Items[sira].SubItems.Add(tckimliktxt.Text);
listView1.Items[sira].SubItems.Add(adrestxt.Text);*/





/* ------------FOORRRMMM -------------
       
        private void guncellebtn_Click(object sender, EventArgs e)
        {
            int secim = Convert.ToInt32(MessageBox.Show("kayıt değiştirilsinmi", "soru", MessageBoxButtons.YesNo));
            if (secim == 6)
            {
                int sayi = ogrenciisleri.ogrencidegistir(Convert.ToInt32(notxt.Text), adtxt.Text, Convert.ToInt32(tckimliktxt.Text), dogtarpicker.Value, adrestxt.Text);
                if (sayi != 0)
                {
                    MessageBox.Show("Kayıt Değiştirildi");
                    ogrencilistesi = ogrenciisleri.tumogrencilerigetir();
                }
                else MessageBox.Show("Kayıt Değiştirilemedi");
            }
        }

        private void silbtn_Click(object sender, EventArgs e)
        {
             int secim = Convert.ToInt32(MessageBox.Show("Kayıt Silinsinmi", "soru", MessageBoxButtons.YesNo));
            if (secim == 6)
            {
                int sayi = ogrenciisleri.ogrencisil(Convert.ToInt32(notxt.Text));
                if (sayi != 0)
                {
                    MessageBox.Show("Kayıt Silindi");
                    ogrencilistesi = ogrenciisleri.tumogrencilerigetir();
                }
                else MessageBox.Show("Kayıt Silinemedi");
            }
            notxt.Clear();
            adtxt.Clear();
            adrestxt.Clear();
            tckimliktxt.Clear();
        }

        private void tablobtn_Click(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.Columns.Clear();
            listView1.Columns.Add("Ad Soyad", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("No", 50, HorizontalAlignment.Left);
            listView1.Columns.Add("Doğum Tarihi", 200, HorizontalAlignment.Left);
            listView1.Columns.Add("Tc Kimlik", 200, HorizontalAlignment.Left);
            listView1.Columns.Add("Adres", 200, HorizontalAlignment.Left);
            int sira = listView1.Items.Count;
            listView1.Items.Add(adtxt.Text);
            listView1.Items[sira].SubItems.Add(notxt.Text);
            listView1.Items[sira].SubItems.Add(dogtarpicker.Text);
            listView1.Items[sira].SubItems.Add(tckimliktxt.Text);
            listView1.Items[sira].SubItems.Add(adrestxt.Text);

        }

        private void kaydetbtn_Click(object sender, EventArgs e)
        { 
           
     

        private void ileribut_Click(object sender, EventArgs e)
        {
            index++;
            bilgiyaz();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            index--;
            bilgiyaz();
        }

        private void arabtn_Click_1(object sender, EventArgs e)
        {
            if (notxt.Text == "") { MessageBox.Show("Lütfen Numara Giriniz"); }
            else
            {
                ArrayList ogrencitorbasi = ogrenciisleri.tumogrencilerigetir();
                foreach (Ogrenci gelenogr in ogrencitorbasi)
                {
                   

                }

            }
        }
    }
}
*/
