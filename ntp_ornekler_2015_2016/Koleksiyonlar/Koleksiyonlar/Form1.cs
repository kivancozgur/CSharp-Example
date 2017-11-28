using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
namespace Koleksiyonlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList kitaplar = new ArrayList();
        private void Form1_Load(object sender, EventArgs e)
        {
            kitaplar.Add("macera");
            kitaplar.Add("korku");
            kitaplar.Add("polisiye");
            kitaplar.Add("bilim kurgu");
            kombodoldur();
            //MessageBox.Show(kitaplar[2].ToString());
        }

        public void kombodoldur()
        {

            for (int i = 0; i < kitaplar.Count; i++)
            {
                comboBox1.Items.Add(kitaplar[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kitaplar.Insert(2, 25);
            comboBox1.Items.Clear();
            kombodoldur();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kitaplar.Clear();
            comboBox1.Items.Clear();
            kombodoldur();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            kitaplar.Remove("korku");

            //kitaplar.RemoveAt(1);
            kombodoldur();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hashtable sehirler = new Hashtable();
            sehirler.Add(16, "bursa");
            sehirler.Add(34, "istanbul");
            sehirler.Add(27, "antep");
           // sehirler.Add(27, "mardin");
          //  MessageBox.Show(sehirler[34].ToString());
            foreach (DictionaryEntry element in sehirler)
            {
                comboBox1.Items.Add(element.Value);
            }
        }
    }
}
