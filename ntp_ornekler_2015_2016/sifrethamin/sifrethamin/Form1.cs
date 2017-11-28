using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sifrethamin
{
    public partial class Form1 : Form
    {
        int uretilensayi, sn, dak, hak;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random uret = new Random();
           uretilensayi = uret.Next(100);
            MessageBox.Show(uretilensayi.ToString());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sn++;
            if (sn == 60) dak++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();

            while (true)
            {
                int tahmin=Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Tahmininizi girin","","",-1,-1));

                if (hak != 5)
                {
                    if (tahmin != uretilensayi)
                    {
                        if (tahmin < uretilensayi) MessageBox.Show("tahmin  küçük büyük gir");
                        if (tahmin > uretilensayi) MessageBox.Show("tahmin  büyük küçük gir");
                        hak++;
                    }
                    else
                    {
                        timer1.Stop();
                        MessageBox.Show("bildiniz şu kadar " + dak + " dakika " + sn + " saniye içinde bildiniz");
                        hak = 5;
                    }
                }//hak blogu
                else
                {
                    MessageBox.Show("hakkınız bitti");
                    timer1.Stop();
                    MessageBox.Show(" şu kadar " + dak + " dakika " + sn + " saniye oyunda kaldınız");

                }
                if (hak == 5) break;


            }//while
        }
    }
}
