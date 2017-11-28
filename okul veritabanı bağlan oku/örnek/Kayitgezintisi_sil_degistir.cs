using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
namespace örnek
{
    public partial class Kayitgezintisi_sil_degistir : Form
    {
        int index = -1;
        Ogrencilerdao ogrenciisleri = new Ogrencilerdao();
        ArrayList ogrencilistesi = new ArrayList();
        public Kayitgezintisi_sil_degistir()
        {
            InitializeComponent();
        }

        private void Kayitgezintisi_sil_degistir_Load(object sender, EventArgs e)
        {
            ogrencilistesi = ogrenciisleri.tumogrencilerigetir();

        }

        private void buttonileri_Click(object sender, EventArgs e)
        {index++;

        bilgiyaz();
        }

        private void butongeri_Click(object sender, EventArgs e)
        {
            index--;
            bilgiyaz();

        }
        public void bilgiyaz()
        {
            try
            {
                ognotext.Text = ((Ogrenci)ogrencilistesi[index]).Ogno.ToString();
                adsoyadtext.Text = ((Ogrenci)ogrencilistesi[index]).Ogadsoyad.ToString();
                tckimliktext.Text = ((Ogrenci)ogrencilistesi[index]).Tckimlik.ToString();
                adrestext.Text = ((Ogrenci)ogrencilistesi[index]).Adres.ToString();
                dogtar.Value = ((Ogrenci)ogrencilistesi[index]).Dogtar;
            }
            catch (ArgumentOutOfRangeException)
            {
                if (index < 0) index++;
                else index--;
                MessageBox.Show("kayıtlar bitti");
            }
        }

        private void buttonsil_Click(object sender, EventArgs e)
        {
           int sayi= ogrenciisleri.ogrencisil(Convert.ToInt32(ognotext.Text));
           if (sayi != 0)
           {
               MessageBox.Show("kayıt silindi");
               ogrencilistesi = ogrenciisleri.tumogrencilerigetir();
           }

           else MessageBox.Show("kayıt silinmedi");

        }

        private void buttondegistir_Click(object sender, EventArgs e)
        {
           int secim= Convert.ToInt32 (MessageBox.Show ("kayıt değiştirilsinmi","soru",MessageBoxButtons.YesNo));
           if (secim == 6)
           {
               int sayi = ogrenciisleri.ogrencidegistir(Convert.ToInt32(ognotext.Text),
                   adsoyadtext.Text, Convert.ToInt32(tckimliktext.Text), dogtar.Value, adrestext.Text);

               if (sayi != 0)
               {
                   MessageBox.Show("kayıt değiştirildi");
                   ogrencilistesi = ogrenciisleri.tumogrencilerigetir();
               }

               else MessageBox.Show("kayıt değiştirilemedi");

           }//değiştirme onay ifi
        }

    }
}
