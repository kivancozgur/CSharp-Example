using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kivanctemrin4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (object sehirler in listBox1.SelectedItems)
                listBox2.Items.Add(sehirler);

            for (int i = 0; i <= 4; i++)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (object sehirler in listBox2.SelectedItems)
                listBox1.Items.Add(sehirler);

            for (int i = 0; i <= 4; i++)
            {
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
        }
    
    
    }
}
