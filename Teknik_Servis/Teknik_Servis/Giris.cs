using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Teknik_Servis
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (kulaniciaditext.Text == "ceyhun" && sifretext.Text == "123" || kulaniciaditext.Text == "muhammed" && sifretext.Text == "123")
            {
                AnaForm yeni = new AnaForm();
                girisgroup.Visible = false;
                yeni.ShowDialog();
                girisgroup.Visible = true;
                
            }
            else
            {
                if (kulaniciaditext.Text == "kivanc" && sifretext.Text == "123" || kulaniciaditext.Text == "tahsin" && sifretext.Text == "123")
                {
                   
                    AnaForm2 yeni1 = new AnaForm2();
                    girisgroup.Visible = false;
                    yeni1.ShowDialog();
                    girisgroup.Visible = true;
                   
                   

                }
                else {
                    MessageBox.Show("Hatalı Kullanıcı Adı Şifre");
                }
            }
            
           
        }

        
        private void kullaniciaditext_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
