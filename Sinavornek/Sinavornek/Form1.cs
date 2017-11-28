using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
namespace Sinavornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int index = -1;
        ArrayList ogrencilistesi = new ArrayList();
        Ogrencilerdao ogrenciisleri = new Ogrencilerdao();
        public void bilgiyaz()
        {
            try
            {
                notxt.Text = ((Ogrenci)ogrencilistesi[index]).Ogno.ToString();
                adtxt.Text = ((Ogrenci)ogrencilistesi[index]).Ogadsoyad.ToString();
                dogtarpicker.Value = ((Ogrenci)ogrencilistesi[index]).Dogtar;
                adrestxt.Text = ((Ogrenci)ogrencilistesi[index]).Adres;
                tckimliktxt.Text = ((Ogrenci)ogrencilistesi[index]).Tckimlik.ToString();
            }
            catch (ArgumentOutOfRangeException)
            {
                if (index < 0) index++;
                else index--;
                MessageBox.Show("Kayıtlar Bitti");
            }
        }
        private void ileribtn_Click(object sender, EventArgs e)
        {
            index++;
            bilgiyaz();
        }

        private void geribtn_Click(object sender, EventArgs e)
        {
            index--;
            bilgiyaz();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ogrencilistesi = ogrenciisleri.tumogrencilerigetir();
        }

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
            ogrencilistesi = ogrenciisleri.tumogrencilerigetir();
            ogrenciisleri.ogrencisil(Convert.ToInt32(notxt.Text));

            notxt.Clear();
            adtxt.Clear();
            adrestxt.Clear();
            tckimliktxt.Clear();
        }

        private void tablobtn_Click(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.Columns.Add("Ad Soyad", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("No", 30, HorizontalAlignment.Left);
            listView1.Columns.Add("Doğum Tarihi", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("Tc Kimlik", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Adres", 150, HorizontalAlignment.Left);
            int sira = listView1.Items.Count;
            listView1.Items.Add(adtxt.Text);
            listView1.Items[sira].SubItems.Add(notxt.Text);
            listView1.Items[sira].SubItems.Add(dogtarpicker.Text);
            listView1.Items[sira].SubItems.Add(tckimliktxt.Text);
            listView1.Items[sira].SubItems.Add(adrestxt.Text);

        }

        private void ilkbtn_Click(object sender, EventArgs e)
        {
            index = 1;
            bilgiyaz();
        }

        private void sonbtn_Click(object sender, EventArgs e)
        {
            index = 4;
            bilgiyaz();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }
    }
}
