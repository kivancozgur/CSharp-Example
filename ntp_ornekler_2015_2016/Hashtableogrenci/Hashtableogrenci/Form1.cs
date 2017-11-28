using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
namespace Hashtableogrenci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Hashtable ogrencilistesi = new Hashtable();
        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci yeniogr = new Ogrenci();
            yeniogr.Adsoyad = adtext.Text;
            yeniogr.Ogno = Convert.ToInt32(ognotext.Text);
            yeniogr.Adres = adrestext.Text;
            ogrencilistesi.Add(yeniogr.Ogno, yeniogr);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int aranan=Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Aradığınız ogrenci no gir", "giriş", "", -1, -1));
            Ogrenci bulunanogrenci=(Ogrenci)ogrencilistesi[aranan];
            MessageBox.Show("öğrencinin adı=" + bulunanogrenci.Adsoyad + "adresi=" + bulunanogrenci.Adres);
        }
    }
}
