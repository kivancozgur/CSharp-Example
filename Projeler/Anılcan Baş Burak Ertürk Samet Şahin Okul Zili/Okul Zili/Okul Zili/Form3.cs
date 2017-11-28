using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace Okul_Zili
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void aktar()
        {
            string baglan, sorgu;
            baglan = "Provider=microsoft.ace.oledb.12.0;Data Source=ekozilla.accdb";
            sorgu = "select*from zil order by ders";
            OleDbConnection baglantı = new OleDbConnection(baglan);
            OleDbCommand yeni = new OleDbCommand(sorgu, baglantı);
            baglantı.Open();
            OleDbDataReader data;
            data = yeni.ExecuteReader();
            while (data.Read())
            {
                if (data[0].ToString() == "1")
                {
                    textBox1.Text = data[1].ToString();
                    textBox2.Text = data[2].ToString();
                }
                if (data[0].ToString() == "2")
                {
                    textBox3.Text = data[1].ToString();
                    textBox4.Text = data[2].ToString();
                }
                if (data[0].ToString() == "3")
                {
                    textBox5.Text = data[1].ToString();
                    textBox6.Text = data[2].ToString();
                }
                if (data[0].ToString() == "4")
                {
                    textBox7.Text = data[1].ToString();
                    textBox8.Text = data[2].ToString();
                }
                if (data[0].ToString() == "5")
                {
                    textBox9.Text = data[1].ToString();
                    textBox10.Text = data[2].ToString();
                }
                if (data[0].ToString() == "6")
                {
                    textBox11.Text = data[1].ToString();
                    textBox12.Text = data[2].ToString();
                }
                if (data[0].ToString() == "7")
                {
                    textBox13.Text = data[1].ToString();
                    textBox14.Text = data[2].ToString();
                }
                if (data[0].ToString() == "8")
                {
                    textBox15.Text = data[1].ToString();
                    textBox16.Text = data[2].ToString();
                }
                if (data[0].ToString() == "9")
                {
                    textBox17.Text = data[1].ToString();
                    textBox18.Text = data[2].ToString();
                }
                if (data[0].ToString() == "10")
                {
                    textBox19.Text = data[1].ToString();
                    textBox20.Text = data[2].ToString();
                }
                if (data[0].ToString() == "11")
                {
                    textBox21.Text = data[1].ToString();
                    textBox22.Text = data[2].ToString();
                }
                if (data[0].ToString() == "12")
                {
                    textBox23.Text = data[1].ToString();
                    textBox24.Text = data[2].ToString();
                }
            }
            data.Close();
            baglantı.Close();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            aktar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numara;
            numara = 1;
            string baglan, sorgu;
            baglan = "Provider=microsoft.ace.oledb.12.0;Data Source=ekozilla.accdb";
            sorgu = "Update zil set[giriş]='" + textBox1.Text + "',[çıkış]='" + textBox2.Text + "' where [ders]=" + numara + " ";
            OleDbConnection baglantı = new OleDbConnection(baglan);
            OleDbCommand yeni = new OleDbCommand(sorgu, baglantı);
            baglantı.Open();
            yeni.ExecuteNonQuery();
            baglantı.Close();

            int numara2;
            numara2 = 2;
            string baglan2, sorgu2;
            baglan2 = "Provider=microsoft.ace.oledb.12.0;Data Source=ekozilla.accdb";
            sorgu2 = "Update zil set[giriş]='" + textBox3.Text + "',[çıkış]='" + textBox4.Text + "' where [ders]=" + numara2 + " ";
            OleDbConnection baglantı2 = new OleDbConnection(baglan2);
            OleDbCommand yeni2 = new OleDbCommand(sorgu2, baglantı2);
            baglantı2.Open();
            yeni2.ExecuteNonQuery();
            baglantı2.Close();

            int numara3;
            numara3 = 3;
            string baglan3, sorgu3;
            baglan3 = "Provider=microsoft.ace.oledb.12.0;Data Source=ekozilla.accdb";
            sorgu3 = "Update zil set[giriş]='" + textBox5.Text + "',[çıkış]='" + textBox6.Text + "' where [ders]=" + numara3 + " ";
            OleDbConnection baglantı3 = new OleDbConnection(baglan3);
            OleDbCommand yeni3 = new OleDbCommand(sorgu3, baglantı3);
            baglantı3.Open();
            yeni3.ExecuteNonQuery();
            baglantı3.Close();

            int numara4;
            numara4 = 4;
            string baglan4, sorgu4;
            baglan4 = "Provider=microsoft.ace.oledb.12.0;Data Source=ekozilla.accdb";
            sorgu4 = "Update zil set[giriş]='" + textBox7.Text + "',[çıkış]='" + textBox8.Text + "' where [ders]=" + numara4 + " ";
            OleDbConnection baglantı4 = new OleDbConnection(baglan4);
            OleDbCommand yeni4 = new OleDbCommand(sorgu4, baglantı4);
            baglantı4.Open();
            yeni4.ExecuteNonQuery();
            baglantı4.Close();

            int numara5;
            numara5 = 5;
            string baglan5, sorgu5;
            baglan5 = "Provider=microsoft.ace.oledb.12.0;Data Source=ekozilla.accdb";
            sorgu5 = "Update zil set[giriş]='" + textBox9.Text + "',[çıkış]='" + textBox10.Text + "' where [ders]=" + numara5 + " ";
            OleDbConnection baglantı5 = new OleDbConnection(baglan5);
            OleDbCommand yeni5 = new OleDbCommand(sorgu5, baglantı5);
            baglantı5.Open();
            yeni5.ExecuteNonQuery();
            baglantı5.Close();

            int numara6;
            numara6 = 6;
            string baglan6, sorgu6;
            baglan6 = "Provider=microsoft.ace.oledb.12.0;Data Source=ekozilla.accdb";
            sorgu6 = "Update zil set[giriş]='" + textBox11.Text + "',[çıkış]='" + textBox12.Text + "' where [ders]=" + numara6 + " ";
            OleDbConnection baglantı6 = new OleDbConnection(baglan6);
            OleDbCommand yeni6 = new OleDbCommand(sorgu6, baglantı6);
            baglantı6.Open();
            yeni6.ExecuteNonQuery();
            baglantı6.Close();

            int numara7;
            numara7 = 7;
            string baglan7, sorgu7;
            baglan7 = "Provider=microsoft.ace.oledb.12.0;Data Source=ekozilla.accdb";
            sorgu7 = "Update zil set[giriş]='" + textBox13.Text + "',[çıkış]='" + textBox14.Text + "' where [ders]=" + numara7 + " ";
            OleDbConnection baglantı7 = new OleDbConnection(baglan7);
            OleDbCommand yeni7 = new OleDbCommand(sorgu7, baglantı7);
            baglantı7.Open();
            yeni7.ExecuteNonQuery();
            baglantı7.Close();

            int numara8;
            numara8 = 8;
            string baglan8, sorgu8;
            baglan8 = "Provider=microsoft.ace.oledb.12.0;Data Source=ekozilla.accdb";
            sorgu8 = "Update zil set[giriş]='" + textBox15.Text + "',[çıkış]='" + textBox16.Text + "' where [ders]=" + numara8 + " ";
            OleDbConnection baglantı8 = new OleDbConnection(baglan8);
            OleDbCommand yeni8 = new OleDbCommand(sorgu8, baglantı8);
            baglantı8.Open();
            yeni8.ExecuteNonQuery();
            baglantı8.Close();

            int numara9;
            numara9 = 9;
            string baglan9, sorgu9;
            baglan9 = "Provider=microsoft.ace.oledb.12.0;Data Source=ekozilla.accdb";
            sorgu9 = "Update zil set[giriş]='" + textBox17.Text + "',[çıkış]='" + textBox18.Text + "' where [ders]=" + numara9 + " ";
            OleDbConnection baglantı9 = new OleDbConnection(baglan9);
            OleDbCommand yeni9 = new OleDbCommand(sorgu9, baglantı9);
            baglantı9.Open();
            yeni9.ExecuteNonQuery();
            baglantı9.Close();

            int numara10;
            numara10 = 10;
            string baglan10, sorgu10;
            baglan10 = "Provider=microsoft.ace.oledb.12.0;Data Source=ekozilla.accdb";
            sorgu10 = "Update zil set[giriş]='" + textBox19.Text + "',[çıkış]='" + textBox20.Text + "' where [ders]=" + numara10 + " ";
            OleDbConnection baglantı10 = new OleDbConnection(baglan10);
            OleDbCommand yeni10 = new OleDbCommand(sorgu10, baglantı10);
            baglantı10.Open();
            yeni10.ExecuteNonQuery();
            baglantı10.Close();

            int numara11;
            numara11 = 11;
            string baglan11, sorgu11;
            baglan11 = "Provider=microsoft.ace.oledb.12.0;Data Source=ekozilla.accdb";
            sorgu11 = "Update zil set[giriş]='" + textBox21.Text + "',[çıkış]='" + textBox22.Text + "' where [ders]=" + numara11 + " ";
            OleDbConnection baglantı11 = new OleDbConnection(baglan11);
            OleDbCommand yeni11 = new OleDbCommand(sorgu11, baglantı11);
            baglantı11.Open();
            yeni11.ExecuteNonQuery();
            baglantı11.Close();

            int numara12;
            numara12 = 12;
            string baglan12, sorgu12;
            baglan12 = "Provider=microsoft.ace.oledb.12.0;Data Source=ekozilla.accdb";
            sorgu12 = "Update zil set[giriş]='" + textBox23.Text + "',[çıkış]='" + textBox24.Text + "' where [ders]=" + numara12 + " ";
            OleDbConnection baglantı12 = new OleDbConnection(baglan12);
            OleDbCommand yeni12 = new OleDbCommand(sorgu11, baglantı12);
            baglantı12.Open();
            yeni12.ExecuteNonQuery();
            baglantı12.Close();
        }

    }
}
