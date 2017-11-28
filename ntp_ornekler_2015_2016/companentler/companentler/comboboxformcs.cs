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
    public partial class comboboxformcs : Form
    {
        public comboboxformcs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.SelectedItem.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("gaziantep");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Remove("bursa");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox1.Items.RemoveAt(Convert.ToInt32(textBox1.Text));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            comboBox1.Sorted = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.SelectedIndex.ToString());
        }
    }
}
