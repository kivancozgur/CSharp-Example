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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte vize = Convert.ToByte(vizetext.Text);
            byte final = Convert.ToByte(finaltext.Text);

            double ort;

            if (butuntext.Text == "")
            {
                ort = (vize * 0.4) + (final * 0.6);
            }
            else
            {
                byte butunleme = Convert.ToByte(butuntext.Text);
                ort = (vize * 0.4) + (butunleme * 0.6);
            }

            if (ort >= 50)
            {
                MessageBox.Show(ort + " ile geçtiniz");
            }
            else
            {
                if (butuntext.Text != "")
                {
                    MessageBox.Show("butunleme ile bile " + ort + " ile kaldın gelme");
                    button1.Enabled = false;
                }
                else
                {
                    MessageBox.Show(ort + " ile kaldın bütünlemyi gir");
                    finaltext.Visible = false;
                    label2.Visible = false;
                    butuntext.Visible = true;
                    label3.Visible = true;
                }
            }//else


        }
    }
}
