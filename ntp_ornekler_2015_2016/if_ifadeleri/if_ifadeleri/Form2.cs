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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte notdegeri = Convert.ToByte (textBox1.Text);
            if (notdegeri >= 0 && notdegeri <= 100)
            {
                if (notdegeri >= 50) MessageBox.Show("geçtin");
                else
                {
                    MessageBox.Show("kaldın");
                }
            }//birinci if
            else
            {
                MessageBox.Show("not degeri 0 ila 100 arasında olmalıdır");
            }
        }
    }
}
