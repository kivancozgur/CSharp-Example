using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Runtime.InteropServices;

namespace Teknik_Servis
{
    public partial class AnaForm2 : Form
    {
        public AnaForm2()
        {
            InitializeComponent();
        }

        private void cikisbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

     

        OleDbConnection bag = Connection.baglantiyagec();
        OleDbCommand kmt = new OleDbCommand();
        public DataTable tablo = new DataTable();
        private void btnMusteriKayit_Click(object sender, EventArgs e)
        {

        }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // x-coordinate of upper-left corner
            int nTopRect, // y-coordinate of upper-left corner
            int nRightRect, // x-coordinate of lower-right corner
            int nBottomRect, // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        private void AnaForm_Load(object sender, EventArgs e)
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
        }
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

        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            musterilergroup.Visible = true;
            durumgroup.Visible = false;
            listele();

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
                    kmt.CommandText = "INSERT INTO islem(musAdi,Marka,Model,Durum) VALUES ('" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells[6].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells[7].Value.ToString() + "','" + btnTamirEdildi.Text + "') ";
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

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult cevap;
                cevap = MessageBox.Show("Kaydı silmek istediğinizden eminmisiniz", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes && dataGridView2.CurrentRow.Cells[0].Value.ToString().Trim() != "")
                {
                    bag.Open();
                    kmt.Connection = bag;
                    kmt.CommandText = "DELETE from islem WHERE seriNu='"+dataGridView2.CurrentRow.Cells[0].Value.ToString()+"' ";
                    kmt.ExecuteNonQuery();
                    kmt.Dispose();
                    bag.Close();
                    durumlistele();
                }
            }
            catch
            {
                MessageBox.Show("Stok Silinirken Hata Oluştu!");
                bag.Close();
            }
        
        }
        public DataTable tablo1 = new DataTable();
        public void durumlistele()
        {
            tablo1.Clear();
            bag.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * From islem", bag);
            adtr.Fill(tablo1);
            dataGridView2.DataSource = tablo1;
            adtr.Dispose();
            bag.Close();
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Columns[1].Width = 120;
            dataGridView2.Columns[2].Width = 120;
            dataGridView2.Columns[3].Width = 120;
            dataGridView2.Columns[4].Width = 180;
        }

        private void btnDurum_Click(object sender, EventArgs e)
        {
            durumlistele();
            musterilergroup.Visible = false;
            durumgroup.Visible = true;
            
        }

        private void btnoturum_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * From musteri", bag);
            if (araText.Text.Trim() == "")
            {
                tablo.Clear();
                kmt.Connection = bag;
                kmt.CommandText = "Select * from musteri";
                adtr.SelectCommand = kmt;
                adtr.Fill(tablo);
            }
            if (Convert.ToBoolean(bag.State) == false)
            {
                bag.Open();
            }
            if (araText.Text.Trim() != "")
            {
                adtr.SelectCommand.CommandText = "Select * From musteri" +
                     " where(musteriAdi='" + araText.Text + "')";
                tablo.Clear();
                adtr.Fill(tablo);
                bag.Close();
                araText.Text = "";
            }
        }
    }
}
