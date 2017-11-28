using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SiniflarOgrencinotornegi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci ogr = new Ogrenci(adsoyadtext.Text,Convert.ToInt32(yastext.Text),adrestext.Text);
           // ogr.Adres = adrestext.Text;
            String durum=ogr.durumhesapla(derscombo.Text,Convert.ToInt32(y1text.Text),
                Convert.ToInt32(y2text.Text),Convert.ToInt32(soztext.Text));
            MessageBox.Show(durum);

        }
    }
}
