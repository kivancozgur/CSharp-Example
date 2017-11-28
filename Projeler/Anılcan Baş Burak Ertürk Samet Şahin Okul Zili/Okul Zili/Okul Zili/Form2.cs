using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;


namespace Okul_Zili
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string[] yol = new string[100];

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void eklebut_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Müzik Seç";

            openFileDialog1.ShowDialog();

            listBox1.Items.Add(openFileDialog1.FileName.ToString());

            string yol = openFileDialog1.FileName.ToString();
            listBox2.Items.Add(Path.GetFileName(yol));

            int a = openFileDialog1.FileName.Length;
            int c = openFileDialog1.FileName.Length;
            string aq = openFileDialog1.FileName.ToString();
        }

        private void kaydetbut_Click(object sender, EventArgs e)
        {
            string bağlanti, sorgu;
            bağlanti = "Provider=microsoft.ace.oledb.12.0;Data Source=ekozilla.accdb";
            sorgu = "INSERT INTO Müzik([Müzikadı],[Müzikyolu]) VALUES('" + listBox2.Items[0].ToString() + "','" + listBox1.Items[0].ToString() + "')";
            OleDbConnection bağlan = new OleDbConnection(bağlanti);
            bağlan.Open();
            OleDbCommand kayit = new OleDbCommand(sorgu, bağlan);
            kayit.ExecuteNonQuery();
            bağlan.Close();
        }
    }
}
