using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
namespace örnek
{
    public partial class Not_rapor_kullanimi : Form
    {
        public Not_rapor_kullanimi()
        {
            InitializeComponent();
        }
        
        public void bilgiyaz()
        {
            Notlardao notisi = new Notlardao();
            ArrayList notlistesi = notisi.tumogrencinotugetir();
            listView1.View = View.Details;//view haline getirip üzerinde işlem yapmak için
            listView1.Columns.Add("Ogrenci Numarası", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Ad soyad", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Dersin Adı", 50, HorizontalAlignment.Center);
            listView1.Columns.Add("Yazılı 1", 50, HorizontalAlignment.Center);
            listView1.Columns.Add("yazılı 2", 50, HorizontalAlignment.Center);
            listView1.Columns.Add("Sözlü", 50, HorizontalAlignment.Center);
            listView1.Columns.Add("Ortalama", 100, HorizontalAlignment.Center);
            foreach (Notlar not in notlistesi)
            {
                int sira = listView1.Items.Count;
                listView1.Items.Add(not.Ogno.Ogno.ToString());
                listView1.Items[sira].SubItems.Add(not.Ogno.Ogadsoyad.ToString());
                listView1.Items[sira].SubItems.Add(not.Dersno.Dersadi.ToString());
                listView1.Items[sira].SubItems.Add(not.Yaz1.ToString());
                listView1.Items[sira].SubItems.Add(not.Yaz2.ToString());
                listView1.Items[sira].SubItems.Add(not.Soz.ToString());
                int ort = (not.Yaz1 + not.Yaz2 + not.Soz) / 3;
                listView1.Items[sira].SubItems.Add(ort.ToString());
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bilgiyaz();
            
        }

        private void ognotext_TextChanged(object sender, EventArgs e)
        {
            Notlardao notisi = new Notlardao();
            ArrayList notlistesi = notisi.tumogrencinotugetir();
            listView1.View = View.Details;//view haline getirip üzerinde işlem yapmak için
            listView1.Columns.Add("Ogrenci Numarası", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Ad soyad", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Dersin Adı", 50, HorizontalAlignment.Center);
            listView1.Columns.Add("Yazılı 1", 50, HorizontalAlignment.Center);
            listView1.Columns.Add("yazılı 2", 50, HorizontalAlignment.Center);
            listView1.Columns.Add("Sözlü", 50, HorizontalAlignment.Center);
            listView1.Columns.Add("Ortalama", 100, HorizontalAlignment.Center);
            foreach (Notlar not in notlistesi)
            {
                
                int sira = listView1.Items.Count;
                listView1.Items.Add(not.Ogno.Ogno.ToString());
                listView1.Items[sira].SubItems.Add(not.Ogno.Ogadsoyad.ToString());
                listView1.Items[sira].SubItems.Add(not.Dersno.Dersadi.ToString());
                listView1.Items[sira].SubItems.Add(not.Yaz1.ToString());
                listView1.Items[sira].SubItems.Add(not.Yaz2.ToString());
                listView1.Items[sira].SubItems.Add(not.Soz.ToString());
                int ort = (not.Yaz1 + not.Yaz2 + not.Soz) / 3;
                listView1.Items[sira].SubItems.Add(ort.ToString());
            }
        }
    }
}
