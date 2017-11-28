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
    public partial class Kontrol : Form
    {
        public Kontrol()
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
            dataGridView1.Columns[0].Width = 120;
            dataGridView1.Columns[1].Width = 120;
            dataGridView1.Columns[2].Width = 210;
            dataGridView1.Columns[3].Width = 120;
            dataGridView1.Columns[4].Width = 180;
            dataGridView1.Columns[5].Width = 120;
            dataGridView1.Columns[6].Width = 120;
            dataGridView1.Columns[7].Width = 120;
            dataGridView1.Columns[8].Width = 220;

        }


        private void MusterilerForm_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTamirEdildi_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult cevap;
                cevap = MessageBox.Show("Tamir Edildi Mi", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {
                    bag.Open();
                    kmt.Connection = bag;
                    kmt.CommandText = "INSERT INTO islem(musAdi,Marka,Model,Durum) VALUES ('" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells[6].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells[7].Value.ToString() + "','" + btnTamirEdildi.Text+ "') ";
                    kmt.ExecuteNonQuery();
                    kmt.Dispose();
                    bag.Close();
                    MessageBox.Show("Tamir İşlemi Tamamlandı");
                }
            }

            catch
            {
                MessageBox.Show("Stok Silinirken Hata Oluştu!");
                bag.Close();
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btniade_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult cevap;
                cevap = MessageBox.Show("İade Edilecek Mi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {
                    bag.Open();
                    kmt.Connection = bag;
                    kmt.CommandText = "INSERT INTO islem(musAdi,Marka,Model,Durum) VALUES ('" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells[6].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells[7].Value.ToString() + "','" + btniade.Text + "') ";
                    kmt.ExecuteNonQuery();
                    kmt.Dispose();
                    bag.Close();
                    MessageBox.Show("İade İşlemi Tamamlandı");
                }
            }

            catch
            {
                MessageBox.Show("Stok Silinirken Hata Oluştu!");
                bag.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Durum yeni3 = new Durum();
            yeni3.Show();
        }

        private void btnParcaBekleniyor_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult cevap;
                cevap = MessageBox.Show("Parça Bekleniyor Mu?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {
                    bag.Open();
                    kmt.Connection = bag;
                    kmt.CommandText = "INSERT INTO islem(musAdi,Marka,Model,Durum) VALUES ('" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells[6].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells[7].Value.ToString() + "','" + btnParcaBekleniyor.Text + "') ";
                    kmt.ExecuteNonQuery();
                    kmt.Dispose();
                    bag.Close();
                    MessageBox.Show("Parça Bekleme İşlemine Alındı");
                }
            }

            catch
            {
                MessageBox.Show("Stok Silinirken Hata Oluştu!");
                bag.Close();
            }
        }

        private void btnFatura_Click(object sender, EventArgs e)
        {

        }
    }
}
