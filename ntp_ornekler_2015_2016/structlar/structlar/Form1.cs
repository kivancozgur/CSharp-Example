using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace structlar
{
    public partial class Form1 : Form
    {
        Ogrenci yeniogrenci = new Ogrenci();
        public Form1()
        {
            InitializeComponent();
        }
        struct Ogrenci
        {
           public int ogno;
          public  String ad, soyad;
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            yeniogrenci.ad = adtext.Text;
            yeniogrenci.soyad = soyadtext.Text;
            yeniogrenci.ogno = Convert.ToInt32(notext.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("öğrencinin adı=" + yeniogrenci.ad + " soyadı=" + yeniogrenci.soyad + "no=" + yeniogrenci.ogno);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
