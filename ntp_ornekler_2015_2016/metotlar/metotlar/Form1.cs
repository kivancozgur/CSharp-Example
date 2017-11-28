using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace metotlar
{
    public partial class Form1 : Form
    {
        int x;
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            int a;
            a = 5;
          // toplamaislemi();
         /*  int sayi1 = Convert.ToInt32(textBox1.Text);
           int sayi2 = Convert.ToInt32(textBox2.Text);
           MessageBox.Show("sayıların toplamı=" + (sayi1 + sayi2));*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            toplamaislemi(6, 15);
          //  toplamaislemi();
           /* int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            MessageBox.Show("sayıların toplamı=" + (sayi1 + sayi2));*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(toplamaislemi2(5, 6).ToString()); ;
           // toplamaislemi(Convert.ToInt32(textBox1.Text),Convert.ToInt32(textBox2.Text));
            //toplamaislemi();
            MessageBox.Show("işlem tamam");
           /* int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            MessageBox.Show("sayıların toplamı=" + (sayi1 + sayi2));*/
        }

     /*   void toplamaislemi()
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            MessageBox.Show("sayıların toplamı=" + (sayi1 + sayi2));
        }*/
        void toplamaislemi(int s1,int s2)
        {
            MessageBox.Show("sonuc=" + (s1 + s2));
        }

        int toplamaislemi2(int s1, int s2)
        {
            int toplam = s1 + s2;
            return toplam;
        }
    }
}
