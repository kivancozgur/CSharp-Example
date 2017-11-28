using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
namespace Arraylist_ogrenci_sinif_orneği
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList ogrecilistesi = new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        { bool kontrol=false;
            Ogrenci ogr = new Ogrenci();
            ogr.Ogno = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Öğrencinin nosunu gir", "No giriş", "", -1, -1));
            ogr.Adsoyad = Microsoft.VisualBasic.Interaction.InputBox("Öğrencinin adını gir", "No giriş", "", -1, -1);
            foreach (Ogrenci siradakiogrenci in ogrecilistesi)
            {
                if (siradakiogrenci.Ogno == ogr.Ogno) kontrol = true;
                
            }
            if (kontrol == false)
            {
                ogrecilistesi.Add(ogr);
            }
            else
            {
                MessageBox.Show("bu numarlı adam var");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Ogrenci siradakiogrenci in ogrecilistesi)
            {
                listBox1.Items.Add(siradakiogrenci.Ogno + "-->" + siradakiogrenci.Adsoyad);
            }
        }
    }
}
