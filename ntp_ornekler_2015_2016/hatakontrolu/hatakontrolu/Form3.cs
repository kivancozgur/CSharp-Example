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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int sayi1 = Convert.ToInt32(textBox1.Text);
                int sayi2 = Convert.ToInt32(textBox2.Text);
                String islemsec = textBox3.Text;
                switch (islemsec)
                {

                    case "+":
                        MessageBox.Show("toplama sonucu=" + (sayi1 + sayi2));
                        break;
                    case "-":
                        MessageBox.Show("çıkarmna sonucu=" + (sayi1 - sayi2));
                        break;
                    case "*":
                        MessageBox.Show("çarpma sonucu=" + (sayi1 * sayi2));
                        break;
                    case "/":
                        MessageBox.Show("bolme sonucu=" + (sayi1 / sayi2));
                        break;
                    default:
                        throw new InvalidOperationException("geçersiz işlem");
                }//switch
            }//try
            catch (FormatException)
            {
                MessageBox.Show("sayı giriniz");
            }
            catch (OverflowException)
            {
                MessageBox.Show("küçük sayı gir");
            }
            catch (InvalidOperationException hata)
            {
                MessageBox.Show(hata.Message);
            }
            catch(Exception)
            {
                MessageBox.Show("bilinmeyen hata");

            }
        }
    }
}