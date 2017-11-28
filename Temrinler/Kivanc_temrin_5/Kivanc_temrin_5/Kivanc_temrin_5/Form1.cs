using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kivanc_temrin_5
{
    public partial class Form1 : Form
    {
        int sayac = 0, tahmin, saniye = 0, dakika = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
             
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            if (saniye == 6000) dakika++;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random sayi = new Random();
            int sayi1 = sayi.Next(100);
            timer1.Start();
            while (sayac < 5)
            {
                {
                    tahmin = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Tahmininizi Giriniz:" + tahmin));
                    if (tahmin == sayi1)
                    {
                        MessageBox.Show("DOĞRU BİLDİNİZ SAYI= " + sayi1);
                        timer1.Stop();
                        MessageBox.Show("Oyunda Kaldığınız Süre" + dakika + " Dakika" + saniye + " Saniye");
                    }
                    else if (tahmin <= sayi1)
                    {
                        MessageBox.Show("Yanlış Tahmin Sayıyı Büyüt");
                    }
                    else if (tahmin >= sayi1)
                    {
                        MessageBox.Show("Yanlış Tahmin Sayıyı Küçült");
                    }
                    sayac++;
                    if (sayac == 5)
                    {
                        MessageBox.Show("5 Hakkınız Bitti");
                        timer1.Stop();
                        MessageBox.Show("Oyunda Kaldığınız Süre" + dakika + " Dakika" + saniye + " Saniye");
                        MessageBox.Show(Convert.ToString("Doğru cevap : " + sayi1));
                    }
                }
            }
        }
    }
}
