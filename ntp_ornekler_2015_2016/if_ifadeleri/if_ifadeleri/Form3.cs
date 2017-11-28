using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace if_ifadeleri
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte notdegeri = Convert.ToByte(textBox1.Text);

            if (notdegeri >= 0 && notdegeri <= 100)
            {
                if (notdegeri >= 0 && notdegeri <= 49) MessageBox.Show("kaldın");
                else if (notdegeri >= 50 && notdegeri <= 69) MessageBox.Show("orta");
                else if (notdegeri >= 70 && notdegeri <= 84) MessageBox.Show("iyi");
                else MessageBox.Show("pekiyi");
            }
            else
            {
                MessageBox.Show("not degeri 0 ila 100 arası olmalı");
            }
        }
    }
}
