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
    public partial class MusteriKayitForm : Form
    {
        public MusteriKayitForm()
        {
            InitializeComponent();
        }
        OleDbConnection bag = Connection.baglantiyagec();
        OleDbCommand kmt = new OleDbCommand();
        public DataTable tablo = new DataTable();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
            if (seriText.Text.Trim() == "") errorProvider1.SetError(seriText, "Boş geçilmez");
            else errorProvider1.SetError(seriText, "");
            if (urunText.Text.Trim() == "") errorProvider1.SetError(urunText, "Boş geçilmez");
            else errorProvider1.SetError(urunText, "");
            if (markaText.Text.Trim() == "") errorProvider1.SetError(markaText, "Boş geçilmez");
            else errorProvider1.SetError(markaText, "");
            if (modelText.Text.Trim() == "") errorProvider1.SetError(modelText, "Boş geçilmez");
            else errorProvider1.SetError(modelText, "");
            if (adText.Text.Trim() == "") errorProvider1.SetError(adText, "Boş geçilmez");
            else errorProvider1.SetError(adText, "");
            if (adresText.Text.Trim() == "") errorProvider1.SetError(adresText, "Boş geçilmez");
            else errorProvider1.SetError(adresText, "");
            if (telefonText.Text.Trim() == "") errorProvider1.SetError(telefonText, "Boş geçilmez");
            else errorProvider1.SetError(telefonText, "");
            if (tanimText.Text.Trim() == "") errorProvider1.SetError(tanimText, "Boş geçilmez");
            else errorProvider1.SetError(tanimText, "");

            if (adText.Text.Trim() != "" && adresText.Text.Trim() != "" && telefonText.Text.Trim() != "" && dateTimePicker1.Text.Trim() != "")
            {
                bag.Open();
                kmt.Connection = bag;
                kmt.CommandText = "INSERT INTO musteri(musteriAdi,adres,Telefon,AlisTarihi,seriNo,urunTipi,Marka,Model,Tanim) VALUES ('" + adText.Text + "','" + adresText.Text + "','" + telefonText.Text + "','" + dateTimePicker1.Text + "','" + seriText.Text + "','" + urunText.Text + "','" + markaText.Text + "','" + modelText.Text + "','"+tanimText.Text+"')";

                kmt.ExecuteNonQuery();
                kmt.Dispose();
                bag.Close();
                for (int i = 0; i < this.Controls.Count; i++)
                {
                    if (this.Controls[i] is TextBox) this.Controls[i].Text = "";
                }
                MessageBox.Show("Kayıt İşlemi Tamamlandı ! ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            }
                catch{
                MessageBox.Show("Kayıtlı Seri No !");
                    bag.Close(); 
                }
            }

        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            Kontrol yeni = new Kontrol();
            yeni.Show();
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MusteriKayitForm_Load(object sender, EventArgs e)
        {

        }
        }
    }
