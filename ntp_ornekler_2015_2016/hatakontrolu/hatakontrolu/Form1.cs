using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hatakontrolu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int sayi1 = Convert.ToInt32(textBox1.Text);
                int sayi2 = Convert.ToInt32(textBox2.Text);
                sonuc.Text = (sayi1 + sayi2).ToString();
            }//try

            catch (FormatException)
            {
                MessageBox.Show("lütfen sayı giriniz");
            }
            catch (OverflowException)
            {
                MessageBox.Show("lütfen büyük sayı girmeyin");
            }
            catch (Exception)
            {
                MessageBox.Show("bilinmeyen hata progrtamcıyı ara");
            }
        }
    }
}
