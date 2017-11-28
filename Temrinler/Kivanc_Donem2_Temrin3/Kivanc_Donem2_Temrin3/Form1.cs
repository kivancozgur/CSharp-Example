using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
namespace Kivanc_Donem2_Temrin3
{
    public partial class Form1 : Form
    {
        ArrayList aracilistesi = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }
        int otomobilsayi = 0, agirvasitasayi = 0, denizaracsayi = 0;
       
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex== 0)
            {
                motorsayilbl.Visible = false;
                motorsayısıtxt.Visible = false;
                agirliklbl.Visible = false;
                agirliktxt.Visible = false;
                govdelbl.Visible = false;
                govdetxt.Visible = false;
                
            }
            if (comboBox1.SelectedIndex == 1)
            {
                motorsayilbl.Visible = false;
                motorsayısıtxt.Visible = false;
                agirliklbl.Visible = true;
                agirliktxt.Visible = true;
                govdelbl.Visible = false;
                govdetxt.Visible = false;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                motorsayilbl.Visible = true;
                motorsayısıtxt.Visible = true;
                agirliklbl.Visible = false;
                agirliktxt.Visible = false;
                govdelbl.Visible = true;
                govdetxt.Visible = true;
                tekerlektxt.Visible = false;
                tekerleklbl.Visible = false;
                vitessayilbl.Visible = false;
                vitestxt.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("LÜTFEN ARAÇ SEÇİNİZ");
            }
               if (comboBox1.Text=="Otomobil")
                {
                    Otomobil oto = new Otomobil();
                    oto.Marka = markatxt.Text;
                    oto.Model = modeltxt.Text;
                    oto.Motorgücü = Convert.ToInt16(motorgucutxt.Text);
                    oto.Uretim = Convert.ToInt16(uretimtxt.Text);
                
                 if(otomobilsayi<3)
                {   otomobilsayi = otomobilsayi + 1;
                    aracilistesi.Add(oto);
                    MessageBox.Show(otomobilsayi+". OTOMOBİL KAYDEDİLDİ");
                }
               else
                { MessageBox.Show("OTOMOBİL DOLDU"); }
                 }
                if (comboBox1.Text=="Deniz Aracı")
                {
                    Denizaraci deniz = new Denizaraci();
                    deniz.Marka = markatxt.Text;
                    deniz.Model = modeltxt.Text;
                    deniz.Motorgücü = Convert.ToInt16(motorgucutxt.Text);
                    deniz.Uretim = Convert.ToInt16(uretimtxt.Text);
                    deniz.Govde = govdetxt.Text;
                    deniz.Motorsayisi = Convert.ToInt16(motorsayısıtxt.Text);
                    if(denizaracsayi<3)
                    {
                    denizaracsayi = denizaracsayi + 1;
                    MessageBox.Show("DENİZ ARACI KAYDEDİLDİ" + denizaracsayi);
                    aracilistesi.Add(deniz);                    
                    }
                    else
                    { MessageBox.Show("DENİZ ARACI DOLDU"); }
                }
                
                if (comboBox1.Text=="Ağır Vasıta")
                {
                    Agirarac agir = new Agirarac();
                    agir.Marka = markatxt.Text;
                    agir.Model = modeltxt.Text;
                    agir.Motorgücü = Convert.ToInt16(motorgucutxt.Text);
                    agir.Uretim = Convert.ToInt16(uretimtxt.Text);
                    agir.Vitessayisi = Convert.ToInt16(vitestxt.Text);
                    agir.Tekerleksayisi = Convert.ToInt16(tekerlektxt.Text);
                    agir.Agirlik = Convert.ToInt16(agirliktxt.Text);
                    if(agirvasitasayi<3)
                    {
                    agirvasitasayi = agirvasitasayi + 1;
                        aracilistesi.Add(agir);
                    MessageBox.Show(agirvasitasayi+". AĞIR ARAÇ KAYDEDİLDİ" );
                    }
                    else
                    { MessageBox.Show("AĞIR ARAÇ DOLDU"); }
                }
                listBox1.Visible = false;
                markatxt.Text ="";
                modeltxt.Text = "";
                motorgucutxt.Text = "";
                uretimtxt.Text = "";
                vitestxt.Text = "";
               tekerlektxt.Text = "";
               agirliktxt.Text = "";
               govdetxt.Text = "";
               motorsayısıtxt.Text = "";
            }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;
            listBox1.Items.Clear();  
            if (markatxt.Text == "" || modeltxt.Text == "")
            { MessageBox.Show("Araç Bulmak İçin Aracı KAYDEDİN Veya MARKA ve MODEL giriniz");
            listBox1.Visible = false;
            }
            
            foreach (Object gelenarac in aracilistesi)
            {
                if (((Arac)gelenarac).Marka == markatxt.Text && ((Arac)gelenarac).Model == modeltxt.Text)
                {
                    listBox1.Items.Add("Marka :" + ((Arac)gelenarac).Marka);
                    listBox1.Items.Add("Model :" + ((Arac)gelenarac).Model);
                    listBox1.Items.Add("Üretim Yılı :" + ((Arac)gelenarac).Uretim);
                    listBox1.Items.Add("Motor Gücü :" + ((Arac)gelenarac).Motorgücü);
                }
   
               
                
            }

            
        }
     }
 }
    
