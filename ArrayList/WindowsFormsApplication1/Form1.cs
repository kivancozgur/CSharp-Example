using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList ogrencilistesi = new ArrayList();
     
        private void button1_Click(object sender, EventArgs e)
        {
            bool kontrol = false; ;
            Ogrenci ogr = new Ogrenci();
            ogr.No=Convert.ToInt32(Interaction.InputBox("No Gir", "Öğrenci Numarası", "", -1, -1));
            ogr.Adsoyad = Interaction.InputBox("Adı Gir", "Öğrenci Adı", "", -1, -1);
            foreach (Ogrenci siradakiogrenci in ogrencilistesi)
            {
                if (siradakiogrenci.No == ogr.No) kontrol = true;
            }
            if (kontrol == false)
            { ogrencilistesi.Add(ogr); }
            else { MessageBox.Show("Bu Numaralı Bir Öğrenci Var"); }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            foreach (Ogrenci siradaki in ogrencilistesi)
            {
                listBox1.Items.Add(siradaki.No + " | " + siradaki.Adsoyad);
            }

        }
        
    }
}
