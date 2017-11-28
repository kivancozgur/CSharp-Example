using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
namespace Teknik_Servis
{
    public partial class MusterilerForm : Form
    {
        public MusterilerForm()
        {
            InitializeComponent();
        }
        OleDbConnection bag = Connection.baglantiyagec();
        OleDbCommand kmt = new OleDbCommand();
        public DataTable tablo = new DataTable();
        public void listele()
        {
            tablo.Clear();
            bag.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * From musteri", bag);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            adtr.Dispose();
            bag.Close();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Columns[1].HeaderText = "Müşteri Adı";
            dataGridView1.Columns[3].HeaderText = "Telefon";
            dataGridView1.Columns[4].HeaderText = "Alış Tarihi";
            dataGridView1.Columns[5].HeaderText = "Ürün Tipi";
            dataGridView1.Columns[6].HeaderText = "Marka";
            dataGridView1.Columns[7].HeaderText = "Model";
            dataGridView1.Columns[8].HeaderText = "Tanim";
            dataGridView1.Columns[2].HeaderText = "Adres";
            dataGridView1.Columns[0].Width = 80;
            dataGridView1.Columns[1].Width = 80;
            dataGridView1.Columns[2].Width = 80;
            dataGridView1.Columns[3].Width = 80;
            dataGridView1.Columns[4].Width = 80;
            dataGridView1.Columns[5].Width = 80;
            dataGridView1.Columns[6].Width = 80;
            dataGridView1.Columns[7].Width = 80;

        }
        private void MusterilerForm_Load(object sender, EventArgs e)
        {
            listele();
        }
    }
}
