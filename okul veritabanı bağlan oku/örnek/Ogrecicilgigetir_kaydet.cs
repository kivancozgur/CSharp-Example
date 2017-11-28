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
    public partial class Ogrecicilgigetir_kaydet : Form
    {

        Ogrencilerdao ogrenciisleri = new Ogrencilerdao();
     
        public Ogrecicilgigetir_kaydet()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList ogrencitorbasi = ogrenciisleri.tumogrencilerigetir();
          
           foreach (Ogrenci gelenogrenci in ogrencitorbasi)
           {
               listBox1.Items.Add(gelenogrenci.Ogno + gelenogrenci.Ogadsoyad + gelenogrenci.Tckimlik);

           }
        }

        private void Ogrecicilgigetir_kaydet_Load(object sender, EventArgs e)
        {
            ArrayList ogrencitorbasi = ogrenciisleri.tumogrencilerigetir();
            foreach (Ogrenci gelenogrenci in ogrencitorbasi)
            {
               comboBox1.Items.Add(gelenogrenci.Ogno);

            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          Ogrenci ogr= ogrenciisleri.istenilenogrencigetir(Convert.ToInt32(comboBox1.SelectedItem.ToString()));
          listBox1.Items.Clear();
          listBox1.Items.Add(ogr.Ogno + ogr.Ogadsoyad + ogr.Tckimlik);
        }

        private void Kaydet_Click(object sender, EventArgs e)
        {
            int sayi=ogrenciisleri.ogrencikaydet(Convert.ToInt32(ognotext.Text),
                adsoyadtext.Text,Convert.ToInt32(tckimliktext.Text),dogtar.Value,adrestext.Text);
            if (sayi == 1) MessageBox.Show("kayıt yapıldı");
            else MessageBox.Show("kayıt yapılamadı verileri tekarar kontrol edildi");
        }
    }
}
