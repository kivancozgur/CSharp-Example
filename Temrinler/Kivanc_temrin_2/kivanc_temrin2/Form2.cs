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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            double vize = Convert.ToDouble(textBox1.Text);
            double final = Convert.ToDouble(textBox2.Text);
            double ortalama;
             if (textBox3.Text == "")
          {
             ortalama = (vize * 0.4) + (final * 0.6);
          }
            else 
          {
            int bütünleme = Convert.ToInt16(textBox3.Text);
            ortalama = (vize * 0.4) + (bütünleme * 0.6);
          }
            if (ortalama >= 50)
          { 
             MessageBox.Show("Geçtiniz Ortalamanız= "+ortalama);
          }
            else
           {
            if(textBox3.Text !="")
              {
                MessageBox.Show("Bütlerden kaldınız Notunuz= "+ortalama+" Eylülde gelin");
                button1.Enabled=false;
              }
              else
            {
                MessageBox.Show("kaldınız notunuz= "+ortalama+" bütünleme notunu giriniz");
                textBox2.Visible=false;
                label2.Visible=false;
                label3.Visible=true;
                textBox3.Visible=true;
             }
            }
            
        }
    }
}
