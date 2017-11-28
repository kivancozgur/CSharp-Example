using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;
namespace Kivanc_Donem2_Temrin8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = Connectionyapici.baglantiyagec();
            SqlCommand komut = new SqlCommand();
                 
        int index = -1;
        ArrayList ogrencilistesi = new ArrayList();
        Ogrencilerdao ogrenciisleri = new Ogrencilerdao();
        Notlardao notisleri = new Notlardao();
       
        public void bilgiyaz()
        {
            try
            {
                ogsec.Text = ((Ogrenci)ogrencilistesi[index]).Ogno.ToString();
                derscombo.Text = ((Dersler)ogrencilistesi[index]).Dersno.ToString();
                yaz1txt.Text=((Notlar)ogrencilistesi[index]).Yaz1.ToString();
                yaz2txt.Text = ((Notlar)ogrencilistesi[index]).Yaz2.ToString();
                soztxt.Text = ((Notlar)ogrencilistesi[index]).Soz.ToString();
            }
            catch (ArgumentOutOfRangeException)
            {
                if (index < 0) index++;
                else index--;
                MessageBox.Show("Kayıtlar Bitti");
            }
        }
        private void silbtn_Click(object sender, EventArgs e)
        {
            ogrenciisleri.ogrencisil(ogsec.Text);
            yaz1txt.Clear();
            yaz2txt.Clear();
            soztxt.Clear();
        }

        private void ileribtn_Click(object sender, EventArgs e)
        {
            index++;
            bilgiyaz();
        }

        private void geribtn_Click(object sender, EventArgs e)
        {
            index--;
            bilgiyaz();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            komut.Connection = baglanti;
                
                komut.CommandText = "select * from dersler order by dersno";
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    derscombo.Items.Add(oku["dersadi"]);

                }
                baglanti.Close();
                baglanti.Open();
                komut.CommandText = "select * from ogrenciler";
                SqlDataReader okur = komut.ExecuteReader();
                while (okur.Read())
                {
                    ogsec.Items.Add(okur["ogno"]);

                }
                baglanti.Close();
            ogrencilistesi = ogrenciisleri.tumogrencilerigetir();
           
        }

        private void kaydetbtn_Click(object sender, EventArgs e)
        {
            notisleri.notkaydet(Convert.ToInt32(ogsec.Text),Convert.ToInt32(yaz1txt.Text),Convert.ToInt32(yaz2txt.Text),Convert.ToInt32(soztxt.Text),Convert.ToInt32(derscombo.Text));
        }
    }
}