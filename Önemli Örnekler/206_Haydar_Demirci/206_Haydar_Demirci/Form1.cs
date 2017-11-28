using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _206_Haydar_Demirci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'haydar71DataSet1.kayıt1' table. You can move, or remove it, as needed.
            this.kayıt1TableAdapter.Fill(this.haydar71DataSet1.kayıt1);
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.ConnectionString = "Data Source=LAB6-6;Initial Catalog=Haydar71;Integrated Security=True";
                cmd.Connection = con;
                cmd.CommandText = "Insert Into kayıt1(adisoyadi,tcno,ilce,ay,ödenenmiktar)values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "'," + textBox5.Text + ")";
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                this.kayıt1TableAdapter.Fill(this.haydar71DataSet1.kayıt1);
            }
            catch
            {
                MessageBox.Show("sayısal yerlere harf girmeyelim");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con.ConnectionString = "Data Source=LAB6-6;Initial Catalog=Haydar71;Integrated Security=True";
                cmd.Connection = con;
                cmd.CommandText = "Delete From kayıt1 where ay='" + textBox4.Text + "'";
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                this.kayıt1TableAdapter.Fill(this.haydar71DataSet1.kayıt1);
            }
            catch
            {
                MessageBox.Show("sayısal yerlere harf girmeyelim");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                con.ConnectionString = "Data Source=LAB6-6;Initial Catalog=Haydar71;Integrated Security=True";
                cmd.Connection = con;
                cmd.CommandText = "Update kayıt1 set adisoyadi='" + textBox1.Text + "',ay='" + textBox4.Text + "',tcno='" + textBox2.Text + "',ilce='" + textBox3.Text + "',ödenenmiktar='" + textBox5.Text + "'where adisoyadi='" + textBox1.Text + "'and ay='" + textBox4.Text + "'";
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                this.kayıt1TableAdapter.Fill(this.haydar71DataSet1.kayıt1);
            }
            catch
            {
                MessageBox.Show("sayısal yerlere harf girmeyelim");
            }
            }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string a, b;
                con.ConnectionString = "Data Source=LAB6-6;Initial Catalog=Haydar71;Integrated Security=True";
                cmd.Connection = con;
                cmd.CommandText = "Select max(ödenenmiktar) From kayıt1";
                con.Open();
                cmd.CommandText = "Select *From kayıt1 where ödenenmiktar like'%" + cmd.ExecuteScalar() + "%'";
                SqlDataReader oku;
                oku = cmd.ExecuteReader();
                while (oku.Read())
                {
                    MessageBox.Show("en çok ödenen miktar" + oku["ödenenmiktar"] + "   " + oku["ay"] + "ayında ödenmiştir");
                }
            }
            catch
            {
                MessageBox.Show("sayısal yerlere harf girmeyelim");
            }
 
                
               
            
            
            con.Close();
            
            
            
            

        }
    }
}
