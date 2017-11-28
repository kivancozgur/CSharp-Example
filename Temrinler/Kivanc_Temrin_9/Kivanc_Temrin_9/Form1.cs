using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kivanc_Temrin_9
{
    public partial class Form1 : Form
    {
             struct Personel
                {
                   public int no, sgk;
                   public String ad, soyad, dogum;
                }

             Personel[] personeldizi = new Personel[10];
             Personel yenipersonel = new Personel();
            
        public Form1()
        {
            InitializeComponent();
        }

        private void Kaydetbut_Click(object sender, EventArgs e)
        {
           
            for (int i = 0; i < 10; i++)
            {
                
                yenipersonel.no = Convert.ToInt32(textBox1.Text);
                yenipersonel.ad = textBox2.Text;
                yenipersonel.soyad = textBox3.Text;
                yenipersonel.sgk = Convert.ToInt32(textBox4.Text);
                yenipersonel.dogum = dateTimePicker1.Text;
                personeldizi[i] = yenipersonel;
               
                if (i == 10)
                {
                    Kaydetbut.Enabled = false; 
                }
                
            }

            MessageBox.Show("Personel Kaydedildi");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void Aramabut_Click(object sender, EventArgs e)
        {
            Microsoft.VisualBasic.Interaction.InputBox("Arama");
            listBox1.Visible = true;
            textBox1.Visible=false;
            textBox2.Visible=false;
            textBox3.Visible=false;
            textBox4.Visible = false;
            dateTimePicker1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            listBox1.Items.Add("Personel No = " + yenipersonel.no);
            listBox1.Items.Add("Personel Adı = " + yenipersonel.ad);
            listBox1.Items.Add("Personel Soyadı = " + yenipersonel.soyad);
            listBox1.Items.Add("Personel SGK No = " + yenipersonel.sgk);
            listBox1.Items.Add("Personel Doğum Tarihi = " + yenipersonel.dogum);

            
        }

        private void Temizlebut_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Visible = false;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            dateTimePicker1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            Kaydetbut.Enabled = true;
            listBox1.Items.Remove("Personel No = " + yenipersonel.no);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
