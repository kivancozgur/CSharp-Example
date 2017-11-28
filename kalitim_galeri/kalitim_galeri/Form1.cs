using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        ArrayList araclar = new ArrayList();
        int otosay, denizsay, agirsay;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("bir araç seçiniz");
            }
            else if (comboBox1.Text == "Otomobil")
            {
                Otomobil oto = new Otomobil();
                oto.Marka = markatext.Text;
                oto.Model = modeltext.Text;
                oto.Uretimyili = int.Parse(uretimyilitext.Text);

                if (otosay != 3)
                {
                    otosay++;
                    araclar.Add(oto);
                    MessageBox.Show(otosay + ". otomobil girilmiştir");
                }
                else
                {
                    MessageBox.Show("otomobiller dolmuştur");
                }
               
            }
            else if (comboBox1.Text == "Deniz Aracı")
            {
               Denizarac deniz = new Denizarac();
                deniz.Marka = markatext.Text;
                deniz.Model = modeltext.Text;
               deniz.Uretimyili = int.Parse(uretimyilitext.Text);
                
                if (denizsay != 3)
                {
                    denizsay++;
                    araclar.Add(deniz);
                    MessageBox.Show(denizsay  + ". deniz aracı girilmiştir");
                }
                else
                {
                    MessageBox.Show("deniz araçları  dolmuştur");
                }
              
            }
            else if (comboBox1.Text == "Ağır Vasıta")
            {
                Agirvasita agir = new Agirvasita();
               agir.Marka = markatext.Text;
                agir.Model = modeltext.Text;
                agir.Uretimyili = int.Parse(uretimyilitext.Text);
                
                if ( agirsay!= 3)
                {
                    agirsay++;
                    araclar.Add(agir);
                    MessageBox.Show(agirsay + ". ağır vasıta girilmiştir");
                }
                else
                {
                    MessageBox.Show("ağır vasıtalar dolmuştur");
                }
             
            }
            if (otosay == 3 && denizsay == 3 && agirsay == 3)
            {
                button2.Visible = true;
                listBox1.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Object alinan in araclar)
            {
                if (((Arac)alinan).Marka == markatext.Text && ((Arac)alinan).Model == modeltext.Text)
                {
                    listBox1.Items.Add(((Arac)alinan).Marka);
                    listBox1.Items.Add(((Arac)alinan).Model);
                    listBox1.Items.Add(((Arac)alinan).Uretimyili);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
