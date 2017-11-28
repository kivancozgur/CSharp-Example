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
    public partial class prosesbar : Form
    {
        public prosesbar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          progressBar1.Maximum = 1000;  
            //progressBar1.Value = 20;
            for (int sayac = 0; sayac <= progressBar1.Maximum; sayac++)
            {
                progressBar1.Value = sayac;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value != progressBar1.Maximum)
            {
                progressBar1.Value = progressBar1.Value + 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
