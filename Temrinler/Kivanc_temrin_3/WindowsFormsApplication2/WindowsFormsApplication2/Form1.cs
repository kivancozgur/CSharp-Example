using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int deger;
        private void cmbox_SelectedIndexChanged(object sender, EventArgs e)
        {

            deger = Convert.ToInt32(cmbox.SelectedIndex);
            switch (deger)
            {
                case 0:
                    lbl1.Text = "Karenin Kenarı";
                    btn.Visible = true;
                    txt1.Visible = true;
                    txt2.Visible = false;
                    lbl2.Visible = false;
                    txt1.Clear();
                    break;
                case 1:
                    lbl1.Text = "Dairenin Yarıçapı";
                    btn.Visible = true;
                    txt1.Visible = true;
                    txt2.Visible = false;
                    lbl2.Visible = false;
                    txt1.Clear();
                    break;
                case 2:
                    lbl1.Text = "Silindirin Yüksekliği";
                    lbl2.Text = "Silindirin Taban Yarıçapı";
                    btn.Visible = true;
                    txt1.Visible = true;
                    lbl2.Visible = true;
                    txt2.Visible = true;
                    txt1.Clear();
                    txt2.Clear();
                    break;
                case 3:
                    lbl1.Text = "Üçgenin Yüksekliği";
                    lbl2.Text = "Üçgenin Tabanı";
                    btn.Visible = true;
                    txt1.Visible = true;
                    lbl2.Visible = true;
                    txt2.Visible = true;
                    txt1.Clear();
                    txt2.Clear();
                    break;
                default:
                    MessageBox.Show("Lütfen Adam Akıllı Sayı Giriniz");
                    break;
            }

        }
        const double pi = 3.14;
        private void btn_Click(object sender, EventArgs e)
        {

            double kare1, karealan, daire1, dairealan, sil1, sil2, silalan, ücgen1, ücgen2, ücgenalan;
            deger = Convert.ToInt32(cmbox.SelectedIndex);
            switch (deger)
            {
                case 0:
                    kare1 = Convert.ToInt32(txt1.Text);
                    karealan = kare1 * kare1;
                    MessageBox.Show("Kare'nin Alanı = " + karealan);
                    break;
                case 1:
                    daire1 = Convert.ToInt32(txt1.Text);
                    dairealan = pi * (daire1 * daire1);
                    MessageBox.Show("Daire'nin Alanı = " + dairealan);
                    break;
                case 2:
                    sil1 = Convert.ToInt32(txt1.Text);
                    sil2 = Convert.ToInt32(txt2.Text);
                    silalan = (2 * pi) * (sil1 * sil2);
                    MessageBox.Show("Silindirin'nin Alanı = " + silalan);
                    break;
                case 3:
                    ücgen1 = Convert.ToInt32(txt1.Text);
                    ücgen2 = Convert.ToInt32(txt2.Text);
                    ücgenalan = (ücgen1 * ücgen2) / 2;
                    MessageBox.Show("Üçgen'nin Alanı = " + ücgenalan);
                    break;
                default:
                    MessageBox.Show("Lütfen Alanı Hesaplanacak Geometrik Şekli Seçiniz");
                    break;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
                if (WindowState == FormWindowState.Normal)
                {
                    WindowState = FormWindowState.Maximized;
                }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }
    }
}

