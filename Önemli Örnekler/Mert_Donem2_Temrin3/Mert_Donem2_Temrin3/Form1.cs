using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Mert_Donem2_Temrin3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int deniz = 0, agir = 0, otomobil = 0, toplam = 0;
        ArrayList araclist = new ArrayList();
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                artilabel1.Text = "Tekerlek Sayısı: ";
                artilabel2.Text = "Vites Sayısı: ";
                artilabel1.Visible = true;
                artilabel2.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;

            }
            if (comboBox1.SelectedIndex == 1)
            {
                artilabel1.Text = "Gövde tipi: ";//textbox5
                artilabel2.Text = "Motor sayısı: ";//textbox6
                artilabel1.Visible = true;
                artilabel2.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;

            }
            if (comboBox1.SelectedIndex == 2)
            {
                artilabel1.Text = "Ağırlık Sayısı: ";
                artilabel2.Text = "Vites Sayısı: ";
                artilabel3.Text = "Tekerlek Sayısı: ";
                artilabel1.Visible = true;
                artilabel2.Visible = true;
                artilabel3.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;
                textBox7.Visible = true;

            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (toplam < 9)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    if (otomobil < 3)
                    {
                        Otomobil yenioto = new Otomobil();
                        yenioto.Marka = markatext.Text;
                        yenioto.Model = modeltext.Text;
                        yenioto.Motorgucu = Convert.ToInt16(motorguctext.Text);
                        yenioto.Üretimyili = Convert.ToInt16(uretimyıltext.Text);
                        yenioto.Vitessay = Convert.ToInt16(textBox6.Text);
                        yenioto.Tekerleksay = Convert.ToInt16(textBox5.Text);
                        araclist.Add(yenioto);
                        otomobil = otomobil + 1;
                        MessageBox.Show("Otomobil Kaydedildi!");

                    }
                    else MessageBox.Show("Otomobil Doldu");
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    if (deniz < 3)
                    {
                        Denizaraci yenideniz = new Denizaraci();
                        yenideniz.Marka = markatext.Text;
                        yenideniz.Model = modeltext.Text;
                        yenideniz.Motorgucu = Convert.ToInt16(motorguctext.Text);
                        yenideniz.Üretimyili = Convert.ToInt16(uretimyıltext.Text);
                        yenideniz.Govdetipi = textBox5.Text;
                        yenideniz.Motorsay = Convert.ToInt16(textBox6.Text);
                        deniz = deniz + 1;
                        araclist.Add(yenideniz);
                        MessageBox.Show("Deniz Aracı Kaydedildi!");
                    }
                    else MessageBox.Show("Deniz Aracı Doldu");
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    if (agir < 3)
                    {
                        Agirvasita yeniagir = new Agirvasita();
                        yeniagir.Marka = markatext.Text;
                        yeniagir.Model = modeltext.Text;
                        yeniagir.Motorgucu = Convert.ToInt16(motorguctext.Text);
                        yeniagir.Üretimyili = Convert.ToInt16(uretimyıltext.Text);
                        yeniagir.Agirliksay = Convert.ToInt16(textBox5.Text);
                        yeniagir.Vitessay = Convert.ToInt16(textBox6.Text);
                        yeniagir.Tekerleksay = Convert.ToInt16(textBox7.Text);
                        agir = agir + 1;
                        araclist.Add(yeniagir);
                        MessageBox.Show("Ağır Vasıta Kaydedildi");

                    }
                    else MessageBox.Show("Ağır Vasıta Doldu");
                }
                toplam = toplam + 1;
            }
            else MessageBox.Show("En fazla bu kadar araç girebilirsiniz");
            temizle();
        }
        public void temizle()
        {
            markatext.Clear();
            modeltext.Clear();
            uretimyıltext.Clear();
            motorguctext.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            
        
        

        }
        private void button2_Click(object sender, EventArgs e)
        {
            
            listBox1.Visible = true;
            listBox1.Items.Clear();
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            artilabel1.Visible = false;
            artilabel2.Visible = false;
            artilabel3.Visible = false;
            foreach (Arac aracarama in araclist)
            {
                
                if (aracarama.Marka == markatext.Text && aracarama.Model == modeltext.Text)
                {

                    listBox1.Items.Add("Marka : " + aracarama.Marka);
                    listBox1.Items.Add("Model : " + aracarama.Model);
                    listBox1.Items.Add("Motor Gücü : " + aracarama.Motorgucu);
                    listBox1.Items.Add("Üretim Yılı : " + aracarama.Üretimyili);
                }
               
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
