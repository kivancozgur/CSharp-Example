using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace @for
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          /*   int toplam = 0;
            for (int i = 1; i <= 100; i+=2)
            {
               
                toplam += i;
            }
            MessageBox.Show(toplam.ToString());
           * */

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(listBox1.SelectedItem.ToString());
            foreach (Object sehir in listBox1.SelectedItems)
            {
                MessageBox.Show(sehir.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
              Random uret = new Random();
            int sayi = uret.Next(100);
            MessageBox.Show(sayi.ToString());
        }
    }
}
