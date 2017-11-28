using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace vizefina
{
    public partial class Form1 : Form
    {

        int hak = 5;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (kuladitext.Text == "kamil" && sifretext.Text == "12345")
            {
                Form2 formum2 = new Form2();
                formum2.Show();
            }
            else
            {
                hak--;
                MessageBox.Show("bilemediniz kalan hakkınız=" + hak);
                if (hak == 0) button1.Enabled = false;
            }

        }
    }
}
