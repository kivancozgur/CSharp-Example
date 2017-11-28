using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace metot_islemler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
    
        }

        void dortislemgizle()
        {
            panelalan.Visible = false;
            panelkare.Visible = false;
            panelucgen.Visible = false;
            panelsayilar.Visible = false;
            panel4islem.Visible = false;
        }

        private void radio4islem_CheckedChanged(object sender, EventArgs e)
        {
            dortislemgizle();
            panel4islem.Visible = true;
        }

        private void radioalan_CheckedChanged(object sender, EventArgs e)
        {
            dortislemgizle();
            panelalan.Visible = true;
        }

        void islemgizle()
        {
            toplacheck.Visible = false;
            cikarcheck.Visible = false;
            panelsayilar.Visible = true;
        }

        private void toplacheck_CheckedChanged(object sender, EventArgs e)
        {
            if (toplacheck.Checked == true) islemgizle();
            else islemgoster();
            toplacheck.Visible = true;
        }

        void islemgoster()
        {
            toplacheck.Visible = true;
            cikarcheck.Visible = true;
            panelsayilar.Visible = false;
        }

        int dortislemyap(int s1, int s2, int secim)
        {
            switch (secim)
            {
                case 1:
                    return s1 + s2;
                case 2:
                    return s1 - s2;
                default :
                    return 0;
            }
        }

        private void hesapbuton_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(sayi1text.Text);
            int sayi2 = Convert.ToInt32(sayi2text.Text);
            if (toplacheck.Checked == true) MessageBox.Show("toplam sonucu=" + dortislemyap(sayi1, sayi2, 1));
            else if (cikarcheck.Checked == true) MessageBox.Show("cikarma sonucu=" + dortislemyap(sayi1, sayi2, 2));
        }

        private void cikarcheck_CheckedChanged(object sender, EventArgs e)
        {
            if (cikarcheck.Checked == true) islemgizle();
            else islemgoster();
           cikarcheck.Visible = true;
        }
    }
}
