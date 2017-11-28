using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Stok_Takip
{
    public partial class Urunler : Form
    {
        public Urunler()
        {
            InitializeComponent();
        }
        Urunlerdao urunisi = new Urunlerdao();
        SqlConnection baglanti = Connectionyapici.baglantiyagec();
        SqlCommand komut = new SqlCommand();
        int sonuc = 0;
        private void Urunler_Load(object sender, EventArgs e)
        {
            kaydetbut.ImageAlign = ContentAlignment.MiddleLeft;
            kaydetbut.TextAlign = ContentAlignment.MiddleRight;
            baglanti.Open();
            komut.Connection = baglanti;
            SqlDataReader oku;
            komut.CommandText = "select * from anakategori,parcalar ";
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                parcasec.Items.Add(oku["parcaad"].ToString());
                comboBox1.Items.Add(oku["kategoriad"].ToString());
               fiyatlist.Items.Add(oku["birimfiyat"].ToString());

            }
            baglanti.Close();
           
        }

        private void kaydetbut_Click(object sender, EventArgs e)
        {
            urunisi.urunkaydet(Convert.ToInt32(modelnotext.Text),Convert.ToInt32(label2.Text));
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void secbut_Click(object sender, EventArgs e)
        {
            try
            {
            secilenparca.Items.Add(parcasec.SelectedItem);
            parcasec.Items.Remove(parcasec.SelectedItem);
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Lütfen İşleminizi Kontrol Edin ! ");
            }
            for (int i = 0; i < fiyatlist.Items.Count; i++)
            {
                
                sonuc += Convert.ToInt32(fiyatlist.Items[i]);
                }
            label2.Text = sonuc.ToString();
         
        }

        private void geribut_Click(object sender, EventArgs e)
        {
            try
            {
                parcasec.Items.Add(secilenparca.SelectedItem);
                secilenparca.Items.Remove(secilenparca.SelectedItem);
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Lütfen İşleminizi Kontrol Edin ! ");
            }
            for (int i = 0; i < fiyatlist.Items.Count; i++)
            {
                sonuc -= Convert.ToInt32(fiyatlist.Items[i]);
                
            }
            label2.Text = sonuc.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void secilenparca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
