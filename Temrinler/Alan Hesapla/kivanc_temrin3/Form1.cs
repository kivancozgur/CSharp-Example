using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kivanc_temrin3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kare, karealan,ücgenalan, silindiryuk, silindircap, silindirdeger, dairedeger, dairecap,ücgenyuk,ücgentab;
            int deger = Convert.ToInt16(comboBox1.SelectedIndex);
            switch (deger)
            {
                case 0:
                    kare = Convert.ToInt16(textBox1.Text);
                    karealan = kare * kare;
                    MessageBox.Show("Alanı " + karealan);
                    break;
                case 1:
                    silindircap = Convert.ToInt16(textBox2.Text);
                    silindiryuk = Convert.ToInt16(textBox3.Text);
                    silindirdeger = ((2 * 3) * (silindircap * silindircap)) + ((2 * 3) * (silindircap * silindiryuk));
                    MessageBox.Show("Silindir Alanı; " + silindirdeger);
                    break;
                case 2:
                    dairecap = Convert.ToInt16(textBox4.Text);
                    dairedeger = 3 * (dairecap * dairecap);
                    MessageBox.Show("Dairenin alanı: " + dairedeger);
                    break;
                case 3:
                    ücgentab = Convert.ToInt16(textBox5.Text);
                    ücgenyuk = Convert.ToInt16(textBox6.Text);
                    ücgenalan = Convert.ToInt16((ücgentab * ücgenyuk) / 2);
                    MessageBox.Show("Ücgenin alanı: " + ücgenalan);
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           int deger;
            deger = Convert.ToInt32(comboBox1.SelectedIndex);
            switch (deger)
            {
                case 0:
                    button1.Visible = true;
                    textBox1.Visible = true;
                    label2.Visible = true;
                    textBox2.Visible = false;
                    label3.Visible = false;
                    textBox3.Visible = false;
                    label4.Visible = false;
                    textBox4.Visible = false;
                    label5.Visible = false;
                    textBox5.Visible = false;
                    label6.Visible = false;
                    textBox6.Visible = false;
                    label7.Visible = false;
                    break;
                case 1:
                    button1.Visible = true;
                    textBox1.Visible = false;
                    label2.Visible = false;
                    textBox2.Visible = true;
                    label3.Visible = true;
                    textBox3.Visible = true;
                    label4.Visible = true;
                    textBox4.Visible = false;
                    label5.Visible = false;
                    textBox5.Visible = false;
                    label6.Visible = false;
                    textBox6.Visible = false;
                    label7.Visible = false;
                    break;
                case 2:
                    button1.Visible = true;
                    textBox1.Visible = false;
                    label2.Visible = false;
                    textBox2.Visible = false;
                    label3.Visible = false;
                    textBox3.Visible = false;
                    label4.Visible = false;
                    textBox4.Visible = true;
                    label5.Visible = true;
                    textBox5.Visible = false;
                    label6.Visible = false;
                    textBox6.Visible = false;
                    label7.Visible = false;
                    break;
                case 3:
                    button1.Visible = true;
                    textBox1.Visible = false;
                    label2.Visible = false;
                    textBox2.Visible = false;
                    label3.Visible = false;
                    textBox3.Visible = false;
                    label4.Visible = false;
                    textBox4.Visible = false;
                    label5.Visible = false;
                    textBox5.Visible = true;
                    label6.Visible = true;
                    textBox6.Visible = true;
                    label7.Visible = true;
                    break;
                    
            }
        }
    }
}
