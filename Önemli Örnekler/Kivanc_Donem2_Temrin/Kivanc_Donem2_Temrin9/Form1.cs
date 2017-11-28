using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Kivanc_Donem2_Temrin9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string ilktarih,ikincitarih;
        int ogno,dersno;

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            { 
                MessageBox.Show("Lütfen Numara Giriniz"); 
            }
            else 
            { 
                ogno = Convert.ToInt32(textBox1.Text); 
            }
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString="Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\okul.mdf;Integrated Security=True;User Instance=True";
            SqlCommand komut = new SqlCommand();
            SqlDataReader oku;
            baglanti.Open();
            komut.CommandText ="select * from ogrenciler where ogno= "+ogno;
            komut.Connection = baglanti;
            oku = komut.ExecuteReader();
            listBox1.Items.Clear();
            while (oku.Read())
            {
                listBox1.Items.Add(oku["ogadsoyad"].ToString());
            }
            baglanti.Close();
        }
        private void dersbut_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "") 
            { 
                MessageBox.Show("Lütfen Ders Seçiniz"); 
            }
            else 
            { 
                dersno = comboBox1.SelectedIndex;
                dersno=dersno+1;       
            }
            
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\okul.mdf;Integrated Security=True;User Instance=True";
            SqlCommand komut = new SqlCommand();
            SqlDataReader oku;
            baglanti.Open();
            komut.CommandText = "select * from notlar where dersno= " + dersno;
            komut.Connection = baglanti;
            oku = komut.ExecuteReader();
            listBox1.Items.Clear();
            
            while (oku.Read())
            {
                listBox1.Items.Add("Öğrenci Numarası : "+oku["ogno"].ToString());
                listBox1.Items.Add("1.Yazılı : "+oku["yaz1"].ToString());
                listBox1.Items.Add("2.Yazılı : "+oku["yaz2"].ToString());
                listBox1.Items.Add("Sözlü : "+oku["soz"].ToString());
            }
            baglanti.Close();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\okul.mdf;Integrated Security=True;User Instance=True";
            SqlCommand komut = new SqlCommand();
            SqlDataReader oku;
            baglanti.Open();
            komut.CommandText = "select * from dersler order by dersno";
            komut.Connection = baglanti;
            oku = komut.ExecuteReader();
            listBox1.Items.Clear();

            while (oku.Read())
            {
                comboBox1.Items.Add(oku["dersadi"].ToString());
            }
            baglanti.Close();
        }


        private void tarihbut_Click(object sender, EventArgs e)
        {
            
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\okul.mdf;Integrated Security=True;User Instance=True";
            SqlCommand komut = new SqlCommand();
            SqlDataReader oku;
            baglanti.Open();
            komut.CommandText = "select * from Ogrenciler WHERE (dogtar BETWEEN '"+ilktarih+"' AND '"+ikincitarih+"')";
            komut.Connection = baglanti;
            oku = komut.ExecuteReader();
            listBox1.Items.Clear();
            while (oku.Read())
            {
                listBox1.Items.Add(oku["dogtar"].ToString());

            }
            baglanti.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ikincitarih = dateTimePicker1.Value.ToShortDateString();
            MessageBox.Show("İkinci Tarihiniz Seçildi : " + ikincitarih);
        }

        private void ilktarbut_Click(object sender, EventArgs e)
        {
            ilktarih = dateTimePicker1.Value.ToShortDateString();
            MessageBox.Show("İlk Tarihiniz Seçildi : " + ilktarih);
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
