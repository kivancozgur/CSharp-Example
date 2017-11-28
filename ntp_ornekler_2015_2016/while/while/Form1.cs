using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace @while
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          /*  int sayac = 1;
            while (sayac<=5)
            {
                
                MessageBox.Show(sayac + "-->tuncay");
                sayac++;
            }//while*/
           /* int toplam=0, sayac = 0;
            while (sayac <= 100)
            {
                toplam += sayac;
                sayac += 2;
            }//while
            MessageBox.Show(toplam.ToString());*/
            int i = 0;
            while (i <= 100)
            {
                comboBox1.Items.Add(i);
               // if (i == 30) break;
                if (i == 30) continue;
                i++;
                
            }
          /**  do
            {


            }while (şart)*/
        }
    }
}
