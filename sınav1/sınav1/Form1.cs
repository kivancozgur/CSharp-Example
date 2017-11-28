using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Araba arac = new Araba();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            arac.calis();

        }

        private void button2_Click(object sender, EventArgs e)
        {
           MessageBox.Show( arac.hizlan(Convert.ToInt32(kmtext.Text)));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            arac.dur();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(arac.yavasla(Convert.ToInt32(kmtext.Text)));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(arac.bilgial());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            arac.setMarka(comboBox1.Text);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            arac.setVites(comboBox2.Text);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            arac.setMotorgucu(Convert.ToInt32(comboBox3.Text));
        }
    }
}
