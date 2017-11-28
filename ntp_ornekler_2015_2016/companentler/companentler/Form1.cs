using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace companentler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          button1.BackColor=Color.Blue;
          Form2 formum2 = new Form2();
          formum2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(sayi1text.Text);
        }

        private void butontopla_Click(object sender, EventArgs e)
        {
            int sayi1 =Convert.ToInt32(sayi1text.Text);
            int sayi2 = Convert.ToInt32(sayi2text.Text);
            int toplam = sayi1 + sayi2;
            MessageBox.Show("sayılarımızın toplamı=" + toplam);

        }

        private void butoncarp_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(sayi1text.Text);
            int sayi2 = Convert.ToInt32(sayi2text.Text);
            MessageBox.Show("sayıların çarpımı=" + (sayi1*sayi2));
        }
    }
}
