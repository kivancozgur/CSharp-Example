using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kivanc_Donem2_Temrin1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Ogrenci[] ogrenciler = new Ogrenci[5];
        Ogrenci ogr1 = new Ogrenci();
        private void button1_Click(object sender, EventArgs e)
        {
            double not1, not2, not3;
            ogr1.Adsoyad = textBox1.Text;
            ogr1.Numara = Convert.ToInt32(textBox2.Text);
            ogr1.Tckimlik = Convert.ToInt64(textBox3.Text);
            ogr1.Adres = textBox4.Text;
            MessageBox.Show("Kaydedildi" +
                 "\r\n" + "Adı Soyadı: " + ogr1.Adsoyad +
                 "\r\n" + "Numarası: " + ogr1.Numara +
                 "\r\n" + "Tc Kimliği: " + ogr1.Tckimlik +
                 "\r\n" + "Adresi: " + ogr1.Adres);
            not1 = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("1.Not" + "" + "" + ""));
            not2 = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("2.Not" + "" + "" + ""));
            not3 = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("3.Not" + "" + "" + ""));
            ogr1.Ort = (not1 + not2 + not3) / 3;
            if (ogr1.Ort < 50)
            { MessageBox.Show("Ortalamanız = " + ogr1.Ort + " ile Kaldınız"); }
            else
            { MessageBox.Show("Ortalamanız = " + ogr1.Ort + " ile Geçtiniz"); }
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int x;
            x=Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Numarasını Giriniz","",""));
            listBox1.Items.Clear();
            if(ogr1.Numara==x)
            { listBox1.Items.Add("Adı Soyadı: "+ogr1.Adsoyad);
            listBox1.Items.Add("Numarası: " + ogr1.Numara);
            listBox1.Items.Add("Tc Kimliği: " + ogr1.Tckimlik);
            listBox1.Items.Add("Adresi: " + ogr1.Adres);
            listBox1.Items.Add("Ortalaması: " + ogr1.Ort);
            }
            
        }
    }
}
