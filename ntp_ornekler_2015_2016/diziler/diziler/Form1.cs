using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace diziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String[] arabalar = new String[5];
            arabalar[2] = "porş";
            arabalar[4] = "volsvagen";
            arabalar[1] = "ferrari";
            arabalar[3] = "reno";
            arabalar[0] = "pejo";
            //Array.Clear(arabalar, 2, 2);
           //Array.Reverse(arabalar);

          // MessageBox.Show(arabalar[4]);
           // MessageBox.Show(Array.IndexOf(arabalar, "reno").ToString());
           /* foreach (String gelenaraba in arabalar)
            {
                MessageBox.Show(gelenaraba);
              
            }*/

            int[] notlar = { 30, 50, 60, 80, 90, 70 };
            MessageBox.Show(notlar.Length.ToString());               
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String[,] isimler = new String[3, 2];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    MessageBox.Show("satir=" + i + "sutun=" + j);
                    isimler[i, j] =
                  Microsoft.VisualBasic.Interaction.InputBox("isim gir gir", "", "", -1, -1);
                }
            }//satir düngüsü

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    textBox1.Text =textBox1.Text + isimler[i, j];
                }
                textBox1.Text = textBox1.Text + "\r\n";
            }//satır dögüsü

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            String[][] aile = new String[3][];
            aile[0] = new String[] { "osman", "ayşe", "fatma" };
            aile[1] = new String[] { "ismail", "tunca", "elif","sebahattin","yunus" };
            aile[2] = new String[] { "osman", "ayşe", "fatma","ramazan","şaban","recep","tuncay" };

            for (int i = 0; i < aile[0].Length; i++)
            {
                listBox1.Items.Add(aile[0][i]);

            }
            for (int i = 0; i < aile[1].Length; i++)
            {
                listBox2.Items.Add(aile[1][i]);

            }
            for (int i = 0; i < aile[2].Length; i++)
            {
                listBox3.Items.Add(aile[2][i]);

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ogrenci[] ogrenciler = new Ogrenci[10];
            Ogrenci ogr1 = new Ogrenci();
            ogr1.Adsoyad = "kıvanç özgür";
            ogr1.Ogno = 2;
            Ogrenci ogr2 = new Ogrenci();
            ogr2.Adsoyad = "sibel şahin";
            ogr2.Ogno = 30;
            ogrenciler[0] = ogr1;
            ogrenciler[1] = ogr2;

            for (int i = 0; i < 2; i++)
            {
                listBox1.Items.Add(ogrenciler[i].Adsoyad.ToString());
            }
        }
    }
}
