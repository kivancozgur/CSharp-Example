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
    public partial class Form_listviewkullanımı : Form
    {
        Ogrencilerdao ogrenciisleri = new Ogrencilerdao();
        ArrayList ogrencilistesi = new ArrayList();
        public Form_listviewkullanımı()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ogrencilistesi = ogrenciisleri.tumogrencilerigetir();
            listView1.View = View.Details;//view haline getirip üzerinde işlem yapmak için
            listView1.Columns.Add("Ogrenci Numarası", 100, HorizontalAlignment.Center);
           listView1.Columns.Add ("Ad soyad",100,HorizontalAlignment.Center);
           listView1.Columns.Add("Tc Kimlik", 100, HorizontalAlignment.Center);
           listView1.Columns.Add("Doğum Tarihi", 100, HorizontalAlignment.Center);
          foreach (Ogrenci ogr in ogrencilistesi)
            {
                int sira = listView1.Items.Count;
                listView1.Items.Add(ogr.Ogno.ToString());
                listView1.Items[sira].SubItems.Add(ogr.Ogadsoyad.ToString());
                listView1.Items[sira].SubItems.Add(ogr.Tckimlik.ToString());
                listView1.Items[sira].SubItems.Add(ogr.Adres.ToString());
           
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}
