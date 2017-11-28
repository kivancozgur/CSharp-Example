using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Drawing.Printing;
namespace stok_programi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection bag = ConnectionYapici.baglantiyagec();
        OleDbCommand kmt = new OleDbCommand();
        public DataTable tablo = new DataTable();
        string DosyaYolu, DosyaAdi = "";
        int id;

        public void listele()
        {
            tablo.Clear();
            bag.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select stokAdi,stokModeli,stokSeriNo,stokAdedi,stokTarih,kayitYapan From stokbil", bag);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            adtr.Dispose();
            bag.Close();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Columns[0].HeaderText = "STOK ADI";
            dataGridView1.Columns[1].HeaderText = "STOK MODELİ";
            dataGridView1.Columns[2].HeaderText = "STOK SERİNO";
            dataGridView1.Columns[3].HeaderText = "STOK ADEDİ";
            dataGridView1.Columns[4].HeaderText = "STOK TARİH";
            dataGridView1.Columns[5].HeaderText = "KAYIT YAPAN";
            dataGridView1.Columns[0].Width = 120;
            dataGridView1.Columns[1].Width = 120;
            dataGridView1.Columns[2].Width = 120;
            dataGridView1.Columns[3].Width = 80;
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[5].Width = 120;

        }
                                 //      >>>>>>>>> F  O  R  M <<<<<<<<<<<
        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

                             //     >>>>>>>>> S  T  O  K     E  K  L  E <<<<<<<<<<<
        private void btnStokEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Trim() == "") errorProvider1.SetError(textBox1, "Boş geçilmez");
                    else errorProvider1.SetError(textBox1, "");
                if (textBox2.Text.Trim() == "") errorProvider1.SetError(textBox2, "Boş geçilmez");
                    else errorProvider1.SetError(textBox2, "");
                if (textBox3.Text.Trim() == "") errorProvider1.SetError(textBox3, "Boş geçilmez");
                    else errorProvider1.SetError(textBox3, "");
                if (textBox4.Text.Trim() == "") errorProvider1.SetError(textBox4, "Boş geçilmez");
                    else errorProvider1.SetError(textBox4, "");
                if (textBox5.Text.Trim() == "") errorProvider1.SetError(textBox5, "Boş geçilmez");
                    else errorProvider1.SetError(textBox5, "");

                if (textBox1.Text.Trim() != "" && textBox2.Text.Trim() != "" && textBox3.Text.Trim() != "" && textBox4.Text.Trim() != "" && textBox5.Text.Trim() != "")
                {
                 bag.Open();
                   kmt.Connection = bag;
                     kmt.CommandText = "INSERT INTO stokbil(stokAdi,stokModeli,stokSeriNo,stokAdedi,stokTarih,kayitYapan,dosyaAdi) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + dateTimePicker1.Text + "','" + textBox5.Text + "','" + DosyaAdi + "') ";
                       kmt.ExecuteNonQuery();
                         kmt.Dispose();
                           bag.Close();
                             for (int i = 0; i < this.Controls.Count; i++)
                                {
                                    if (this.Controls[i] is TextBox) this.Controls[i].Text = "";
                                }
                        listele();
                      if (DosyaAdi != "") File.WriteAllBytes(DosyaAdi, File.ReadAllBytes(DosyaAc.FileName));
                  MessageBox.Show("Kayıt İşlemi Tamamlandı ! ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
                catch 
                {
                    MessageBox.Show("Kayıtlı Seri No !");
                    bag.Close(); 
                }           
        }

                                 //  >>>>>>>>> S  T  O  K    S  İ  L <<<<<<<<<<<
        private void btnStokSil_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult cevap;
                cevap = MessageBox.Show("Kaydı silmek istediğinizden eminmisiniz", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes && dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim() != "")
                {
                    bag.Open();
                    kmt.Connection = bag;
                    kmt.CommandText = "DELETE from stokbil WHERE stokSeriNo='" + dataGridView1.CurrentRow.Cells[2].Value.ToString() + "' ";
                    kmt.ExecuteNonQuery();
                    kmt.Dispose();
                    bag.Close();
                    listele();
                }
            }
            catch
            {
                MessageBox.Show("Stok Silinirken Hata Oluştu!");
                bag.Close();
            }
        }

                            //  >>>>>>>>> S  T  O  K    G  Ü  N  C  E  L  L  E  <<<<<<<<<<<
        private void btnStokGuncelle_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Trim() != "" && textBox2.Text.Trim() != "" && textBox3.Text.Trim() != "" && textBox4.Text.Trim() != "" && textBox5.Text.Trim() != "")
            {
                string sorgu = "UPDATE stokbil SET stokAdi='" + textBox1.Text + "',stokModeli='" + textBox2.Text + "',stokSeriNo='" + textBox3.Text + "',stokAdedi='" + textBox4.Text + "',stokTarih='" + dateTimePicker1.Text + "',kayitYapan='" + textBox5.Text + "',dosyaAdi='" + DosyaAdi + "' WHERE id=" + id;
                OleDbCommand kmt = new OleDbCommand(sorgu, bag);
                bag.Open();
                kmt.ExecuteNonQuery();
                kmt.Dispose();
                bag.Close();
                listele();
                if (DosyaAdi != "") File.WriteAllBytes(DosyaAdi, File.ReadAllBytes(DosyaAc.FileName));
                MessageBox.Show("Güncelleme İşlemi Tamamlandı !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Boş Alan Bırakmayınız !");
            }
        }

                            //  >>>>>>>>> A  R  A    B  U  T  T  O  N  U  <<<<<<<<<<<
        private void btnAra_Click(object sender, EventArgs e)
        {
            dataGridView1.Location = new Point(68, 420);
            dataGridView1.Height = 180;
            dataGridView1.Width = 720;
            groupAra.Visible = true;
            btnAra.Visible = false;
            btnAradim.Visible = true;
            groupyazdir.Visible = false;
            btnyazdirbitti.Visible = false;
            yazdirbtn.Visible = true;
        }

                                //  >>>>>>>>> R  E  S  İ  M    E  K  L  E <<<<<<<<<<<
        private void btnResimEkle_Click(object sender, EventArgs e)
        {

            if (DosyaAc.ShowDialog() == DialogResult.OK)
            {
                foreach (string i in DosyaAc.FileName.Split('\\'))
                {
                    if (i.Contains(".jpg")) { DosyaAdi = i; }
                    else if (i.Contains(".bmp")) { DosyaAdi = i; }
                    else if (i.Contains(".png")) { DosyaAdi = i; }
                    else if (i.Contains(".gif")) { DosyaAdi = i; }
                    else { DosyaYolu += i + "\\"; }
                }
                pictureBox1.ImageLocation = DosyaAc.FileName;
                MessageBox.Show("Resim Başarıyla Eklendi Şimdi Stok Güncelleye/Kayıda Basınız");
            }
            else
            {
                MessageBox.Show("Herhangi bir Resim Girilmedi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

                        //  >>>>>>>>> R  E  S  I  M     S  İ  L <<<<<<<<<<<
        private void btnResimSil_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "";
            DosyaAdi = "";
            MessageBox.Show("Resim Başarıyla Silindi Şimdi Stok Güncelleye/Kayıda Basınız");
        }
                        //  >>>>>>>>> Ç  I  K  I  Ş     Y  A  P  <<<<<<<<<<<
        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
                         //  >>>>>>>>> D  A  T  A  G  R  I  D     A  Y  A  R  L  A  R  I <<<<<<<<<<<
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            try
            {
                kmt = new OleDbCommand("select * from stokbil where stokSeriNo='" + dataGridView1.CurrentRow.Cells[2].Value.ToString() + "'", bag);
                bag.Open();
                OleDbDataReader oku = kmt.ExecuteReader();
                oku.Read();
                if (oku.HasRows)
                {
                    pictureBox1.ImageLocation = oku[7].ToString();
                    id=Convert.ToInt32(oku[0].ToString());
                }
                bag.Close();
            }
            catch
            {
                bag.Close();
            }
        }

                        //  >>>>>>>>> T  E  X  T  1   A  Y  A  R  I  <<<<<<<<<<<
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != (char)08 && e.KeyChar != (char)44)
            {
                e.Handled = true;
                MessageBox.Show("Sadece Harf Girişi Yapabilirsiniz ! ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

                        //  >>>>>>>>> T  E  X  T  2    A  Y  A  R  I  <<<<<<<<<<<
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != (char)08 && e.KeyChar != (char)44)
            {
                e.Handled = true;
                MessageBox.Show("Sadece Harf Girişi Yapabilirsiniz ! ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

                     //  >>>>>>>>> T  E  X  T  4    A  Y  A  R  I  <<<<<<<<<<<
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08 && e.KeyChar != (char)44)
            {
                e.Handled = true;
                MessageBox.Show("Sadece Sayı Girişi Yapabilirsiniz ! ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);               
            }            
        }
                    
                    //  >>>>>>>>> T  E  X  T  5    A  Y  A  R  I  <<<<<<<<<<<
        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != (char)08 && e.KeyChar != (char)44)
            {
                e.Handled = true;
                MessageBox.Show("Sadece Harf Girişi Yapabilirsiniz ! ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }      
        }

        private void adbtn_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * From stokbil", bag);
            if (adText.Text.Trim() == "")
            {
                tablo.Clear();
                kmt.Connection = bag;
                kmt.CommandText = "Select * from stokbil";
                adtr.SelectCommand = kmt;
                adtr.Fill(tablo);
            }
            if (Convert.ToBoolean(bag.State) == false)
            {
                bag.Open();
            }
            if (adText.Text.Trim() != "")
            {
                adtr.SelectCommand.CommandText = " Select * From stokbil" +
                     " where(stokAdi='" + adText.Text + "' )";
                tablo.Clear();
                adtr.Fill(tablo);
                bag.Close();
                adText.Text = "";
            }
        }

        private void modelbtn_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * From stokbil", bag);
            if (modelText.Text.Trim() == "")
            {
                tablo.Clear();
                kmt.Connection = bag;
                kmt.CommandText = "Select * from stokbil";
                adtr.SelectCommand = kmt;
                adtr.Fill(tablo);
            }
            if (Convert.ToBoolean(bag.State) == false)
            {
                bag.Open();
            }
            if (modelText.Text.Trim() != "")
            {
                adtr.SelectCommand.CommandText = " Select * From stokbil" +
                     " where(stokModeli='" + modelText.Text + "')";
                tablo.Clear();
                adtr.Fill(tablo);
                bag.Close();
                modelText.Text = "";
            }
        }

        private void kaydedenbtn_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * From stokbil", bag);
            if (kayitText.Text.Trim() == "")
            {
                tablo.Clear();
                kmt.Connection = bag;
                kmt.CommandText = "Select * from stokbil";
                adtr.SelectCommand = kmt;
                adtr.Fill(tablo);
            }
            if (Convert.ToBoolean(bag.State) == false)
            {
                bag.Open();
            }
            if (kayitText.Text.Trim() != "")
            {
                adtr.SelectCommand.CommandText = " Select * From stokbil" +
                     " where(kayitYapan='" + kayitText.Text + "' )";
                tablo.Clear();
                adtr.Fill(tablo);
                bag.Close();
                kayitText.Text = "";
            }
        }



        private void seribut_Click(object sender, EventArgs e)
        {
             
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * From stokbil", bag);
            if (seriText.Text.Trim() == "")
            {
                tablo.Clear();
                kmt.Connection = bag;
                kmt.CommandText = "Select * from stokbil";
                adtr.SelectCommand = kmt;
                adtr.Fill(tablo);
            }
            if (Convert.ToBoolean(bag.State) == false)
            {
                bag.Open();
            }
            if (seriText.Text.Trim() != "")
            {
                adtr.SelectCommand.CommandText = " Select * From stokbil" +
                     " where(stokSeriNo='" + seriText.Text + "' )";
                tablo.Clear();
                adtr.Fill(tablo);
                bag.Close();
                seriText.Text = "";
            }
        
        }
        private void adText_TextChanged(object sender, EventArgs e)
        {

        }

        private void gizlebtn_Click(object sender, EventArgs e)
        {
          
           
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void btnAradim_Click(object sender, EventArgs e)
        {
            groupAra.Visible = false;
            dataGridView1.Location = new Point(68, 303);
            dataGridView1.Height = 302;
            btnAradim.Visible = false;
            btnAra.Visible = true;
        }

        private void yazdirbtn_Click(object sender, EventArgs e)
        {
            groupyazdir.Visible = true;
            groupAra.Visible = false;
            btnyazdirbitti.Visible = true;
            yazdirbtn.Visible = false;
            dataGridView1.Location = new Point(68, 380);
            dataGridView1.Height = 220;
            dataGridView1.Width = 720;
            btnAra.Visible = true;
            btnAradim.Visible = false;
        }
        int i = 0;
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font baslik = new System.Drawing.Font("Times",12,FontStyle.Bold);
            Font altbaslik = new System.Drawing.Font("Arial",11,FontStyle.Regular);
            System.Drawing.Printing.PageSettings p = printDocument1.DefaultPageSettings;
            int x = 95, y = 135, say = dataGridView1.Rows.Count;
            say=say-2;
            e.Graphics.DrawLine(new Pen(Color.Black,2),p.Margins.Left,75,p.PaperSize.Width-p.Margins.Right,75);
            e.Graphics.DrawString("Stok Adı", baslik, Brushes.Black, 100, 75);
            e.Graphics.DrawString("Stok Modeli", baslik, Brushes.Black, 225, 75);
            e.Graphics.DrawString("Seri No", baslik, Brushes.Black, 375, 75);
            e.Graphics.DrawString("Stok Adedi", baslik, Brushes.Black, 500, 75);
            e.Graphics.DrawString("Stok Tarihi", baslik, Brushes.Black, 6257, 75);
            e.Graphics.DrawLine(new Pen(Color.Black, 2), p.Margins.Left, 95, p.PaperSize.Width - p.Margins.Right, 95);
            while (i <= say)
            {
                x += 25;
                e.Graphics.DrawString (dataGridView1.Rows[i].Cells[1].Value.ToString(), altbaslik, Brushes.Black, 100,x);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[2].Value.ToString(), altbaslik, Brushes.Black, 225, x);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[3].Value.ToString(), altbaslik, Brushes.Black, 375, x);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[4].Value.ToString(), altbaslik, Brushes.Black, 500, x);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[5].Value.ToString(), altbaslik, Brushes.Black, 625, x);
                i++;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnyazdirbitti_Click(object sender, EventArgs e)
        {
             groupAra.Visible = false;
            groupyazdir.Visible = false;
            dataGridView1.Location = new Point(68, 303);
            dataGridView1.Height = 302;
            dataGridView1.Width = 703;
            btnAradim.Visible = false;
            btnAra.Visible = true;
            btnyazdirbitti.Visible = false;
            yazdirbtn.Visible = true;
        
        }
        


    }
}
