using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
namespace veritabani_mvc
{
    public partial class Formilerigeri : Form
    {
        public Formilerigeri()
        {
            InitializeComponent();
        }
        int index = -1;
        ArrayList ogrencilistesi = new ArrayList();
        Ogrencilerdao ogrenciisleri = new Ogrencilerdao();
       
        private void button2_Click(object sender, EventArgs e)
        {
            index++;
            bilgiyaz();
        }
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

        private void Silbtn_Click(object sender, EventArgs e)
        {
            ogrencilistesi = ogrenciisleri.tumogrencilerigetir();
            ogrenciisleri.ogrencisil(Convert.ToInt32(notxt.Text));
           
            notxt.Clear();
            adtxt.Clear();
            adrestxt.Clear();
            tckimliktxt.Clear();
        }

        private void Formilerigeri_Load(object sender, EventArgs e)
        {

           ogrencilistesi= ogrenciisleri.tumogrencilerigetir();
        }

        private void geribut_Click(object sender, EventArgs e)
        {
            index--;
            bilgiyaz();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int secim =Convert.ToInt32(MessageBox.Show("kayıt değiştirilsinmi","soru",MessageBoxButtons.YesNo));
            if(secim==6)
            {int sayi=ogrenciisleri.ogrencidegistir(Convert.ToInt32(notxt.Text),adtxt.Text,Convert.ToInt32(tckimliktxt.Text),dogtarpicker.Value,adrestxt.Text);
                if(sayi!=0)
                {
                    MessageBox.Show("Kayıt Değiştirildi");
                    ogrencilistesi=ogrenciisleri.tumogrencilerigetir();
                }
                else MessageBox.Show("Kayıt Değiştirilemedi");
        }
        }
    }
}
