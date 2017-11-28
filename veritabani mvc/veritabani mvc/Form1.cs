using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
namespace veritabani_mvc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Ogrencilerdao ogrenciisleri = new Ogrencilerdao();
        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList ogrencitorbasi = ogrenciisleri.tumogrencilerigetir();
            foreach (Ogrenci gelenogr in ogrencitorbasi)
            {
                listBox1.Items.Add(gelenogr.Ogno+ " "+ gelenogr.Ogadsoyad +" "+ gelenogr.Dogtar +" "+ gelenogr.Tckimlik +" "+ gelenogr.Adres);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArrayList ogrencitorbası = ogrenciisleri.tumogrencilerigetir();
            foreach(Ogrenci gelenogrenci in ogrencitorbası)
            {
                comboBox1.Items.Add(gelenogrenci.Ogno);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ogrenci ogr =ogrenciisleri.istenilenogrenci(Convert.ToInt32(comboBox1.SelectedItem.ToString()));
            listBox1.Items.Clear();
            listBox1.Items.Add(ogr.Ogno+" / "+ogr.Ogadsoyad+" / "+ogr.Tckimlik+" / "+ogr.Tckimlik);
        }
    }
}
