using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
namespace HashTable___SortedList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Hashtable ogrencilistesi = new Hashtable();
        Ogrenci ogr1 = new Ogrenci();
        private void button1_Click(object sender, EventArgs e)
        {
            
            ogr1.Adsoyad = textBox1.Text;
            ogr1.Numara = Convert.ToInt32(textBox2.Text);
            ogr1.Sınıf = comboBox1.Text;
            ogr1.Adres = textBox3.Text;
            ogrencilistesi.Add(ogr1.Numara, ogr1);
            MessageBox.Show("Kaydedildi");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.Text = " ";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x;
            x=Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Numara Gir", "Numara", "", -1 ,- 1));
            Ogrenci bulunan = (Ogrenci)ogrencilistesi[x];
            MessageBox.Show("Adı Soyadı: " + bulunan.Adsoyad +
              "\r\n" + "Numarası: " + bulunan.Numara +
              "\r\n" + "Sınıf: " + bulunan.Sınıf +
              "\r\n" + "Adresi: " + bulunan.Adres);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;
            string x;
             x = comboBox2.Text;
             Ogrenci sınıf = (Ogrenci)ogrencilistesi[x];
             if (ogr1.Sınıf == x)
             {
                 listBox1.Items.Add(ogrencilistesi);
                 
             }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
