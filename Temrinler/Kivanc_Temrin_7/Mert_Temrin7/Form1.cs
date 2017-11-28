using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mert_Temrin7
{
    public partial class Form1 : Form
    {
        

        int sayi1, sayi2;
        int ücgenyük, ücgenkenar, kare, daire, silindiryük, silindiryari;

        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            islemac();


        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            islemkapa();



        }
        void islemac()
        {

            checkBox1.Visible = true;
            checkBox2.Visible = true;
            checkBox3.Visible = true;
            checkBox4.Visible = true;
            checkBox5.Visible = false;
            checkBox6.Visible = false;
            checkBox7.Visible = false;
            checkBox8.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            textBox1.Text = "0";
            textBox2.Text = "0";


        }
        void islemkapa()
        {
            checkBox1.Visible = false;
            checkBox2.Visible = false;
            checkBox3.Visible = false;
            checkBox4.Visible = false;
            checkBox5.Visible = true;
            checkBox6.Visible = true;
            checkBox7.Visible = true;
            checkBox8.Visible = true;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;

            label1.Visible = false;
            label2.Visible = false;
            textBox2.Visible = false;
            textBox1.Visible = false;
            textBox3.Text = "0";
            textBox4.Text = "0";

        }
        void dörtislem()
        {
            button1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
        }
        void toplamaislem()
        {
            button1.Visible = true;
            checkBox2.Visible = false;
            checkBox3.Visible = false;
            checkBox4.Visible = false;
        }
        void cikarmaislem()
        {
            button1.Visible = true;
            checkBox1.Visible = false;
            checkBox3.Visible = false;
            checkBox4.Visible = false;
        }
        void carpmaislem()
        {
            button1.Visible = true;
            checkBox1.Visible = false;
            checkBox2.Visible = false;
            checkBox4.Visible = false;
        }
        void bölmeislem()
        {
            checkBox1.Visible = false;
            checkBox2.Visible = false;
            checkBox3.Visible = false;
        }
        void göster()
        {
            checkBox1.Visible = true;
            checkBox2.Visible = true;
            checkBox3.Visible = true;
            checkBox4.Visible = true;
            label1.Visible = false;
            label2.Visible = false;
            textBox2.Visible = false;
            textBox1.Visible = false;

        }
        void göster2()
        {
            checkBox5.Visible = true;
            checkBox6.Visible = true;
            checkBox7.Visible = true;
            checkBox8.Visible = true;
            label3.Visible = false;
            label4.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;

        }
        void ücgenalan()
        {
            button1.Visible = true;
            checkBox6.Visible = false;
            checkBox7.Visible = false;
            checkBox8.Visible = false;
            label3.Visible = true;
            label4.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            label3.Text = ("Üçgenin Tabanı: ");
            label4.Text = ("Üçgenin Yüksekliği: ");
        }
        void karealan()
        {
            button1.Visible = true;
            checkBox5.Visible = false;
            checkBox6.Visible = false;
            checkBox8.Visible = false;
            label3.Visible = true;
            label4.Visible = false;
            textBox3.Visible = true;
            textBox4.Visible = false;
            label3.Text = ("Karenin Kenar Uzunluğu: ");

        }
        void dairealan()
        {
            button1.Visible = true;
            checkBox5.Visible = false;
            checkBox7.Visible = false;
            checkBox8.Visible = false;
            label3.Visible = true;
            label4.Visible = false;
            textBox3.Visible = true;
            textBox4.Visible = false;
            label3.Text = ("Dairenin Yarıçapını Giriniz: ");

        }
        void silindiralan()
        {
            button1.Visible = true;
            checkBox5.Visible = false;
            checkBox6.Visible = false;
            checkBox7.Visible = false;
            label3.Visible = true;
            label4.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            label3.Text = ("Silindirin Yüksekliğini Giriniz: ");
            label4.Text = ("Silindirin Yarıçapını Giriniz: ");

        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                dörtislem();
                toplamaislem();
            }
            else göster();

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                dörtislem();
                cikarmaislem();
            }
            else göster();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                dörtislem();
                carpmaislem();
            }
            else göster();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                dörtislem();
                bölmeislem();
            }
            else göster();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButton1.Checked == true)
                {
                    sayi1 = Convert.ToInt16(textBox1.Text);
                    sayi2 = Convert.ToInt16(textBox2.Text);
                }
                else
                {

                    daire = Convert.ToInt16(textBox3.Text);
                    ücgenkenar = Convert.ToInt16(textBox3.Text);
                    ücgenyük = Convert.ToInt32(textBox4.Text);
                    kare = Convert.ToInt16(textBox3.Text);

                    silindiryari = Convert.ToInt16(textBox3.Text);
                    silindiryük = Convert.ToInt16(textBox4.Text);
                }
                if (radioButton1.Checked == true)
                {
                    if (checkBox1.Checked == true)
                    {
                        MessageBox.Show("Sonuç: " + (sayi1 + sayi2));
                    }
                    else if (checkBox2.Checked == true)
                    {
                        MessageBox.Show("Sonuç: " + (sayi1 - sayi2));
                    }
                    else if (checkBox3.Checked == true)
                    {
                        MessageBox.Show("Sonuç: " + (sayi1 * sayi2));
                    }
                    else if (checkBox4.Checked == true)
                    {
                        MessageBox.Show("Sonuç: " + (sayi1 / sayi2));
                    }
                    else
                    {
                        MessageBox.Show("LÜTFEN SEÇİM YAPINIZ!!");
                    }
                }//if
                else
                {
                    if (checkBox5.Checked == true)
                    {
                        int ücgenalan = (ücgenyük * ücgenkenar) / 2;
                        MessageBox.Show("Üçgenin Sonucu: " + ücgenalan);

                    }
                    else if (checkBox7.Checked == true)
                    {
                        MessageBox.Show("Karenin Sonucu: " + (kare * kare));
                    }
                    else if (checkBox6.Checked == true)
                    {
                        int dairealan = 3 * (daire * daire);
                        MessageBox.Show("Daire Sonucu: " + (dairealan));
                    }
                    else if (checkBox8.Checked == true)
                    {
                        MessageBox.Show("Silindir Sonucu: " + (silindiryük * silindiryari));
                    }
                    else
                    {
                        MessageBox.Show("LÜTFEN BİR SEÇİM YAPINIZ!!");
                    }
                }
            }
            catch (OverflowException)
            {
                MessageBox.Show("Çok Büyük Sayı Girdiniz Lütfen Daha Küçük Sayı Giriniz!!!");
            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen bir sayı giriniz!!");

            }
            catch (Exception)
            {
                MessageBox.Show("BİLİNMEYEN HATA!");
            }
        }
        


           
           

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox5.Checked == true)
            {
                ücgenalan();
            }
            else göster2();
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                karealan();
            }
            else göster2();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                dairealan();
            }
            else göster2();
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                silindiralan();
            }
            else göster2();

        }

    }

}










