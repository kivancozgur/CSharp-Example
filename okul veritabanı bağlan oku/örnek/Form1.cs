using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace örnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = Connectionyapici.baglantiyagec();
            SqlCommand komut = new SqlCommand();
            SqlDataReader oku;
            baglanti.Open();
        
            komut.CommandText = "select * from ogrenciler order by ogadsoyad";
            komut.Connection = baglanti;
            oku = komut.ExecuteReader();
            while(oku.Read())
            {
                comboBox1.Items.Add(oku["ogadsoyad"].ToString());

            }
            baglanti.Close();
        }
    }
}
