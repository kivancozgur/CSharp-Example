using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kivanc_temrin2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i=5;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "coskunoz" && textBox2.Text == "12345")
            {
                Form2 form2 = new Form2();
                form2.Show();
            }
            else {
                i = i - 1;
                MessageBox.Show("Hatalı Giriş Kalan =" + i);
                if (i == 0)
                {
                    MessageBox.Show("5 kez hatalı girdiniz");
                    button1.Enabled = false;
                }
            }

        }
    }
}
