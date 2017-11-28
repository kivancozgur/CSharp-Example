using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temrin_Geliştirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Dortislem islem = new Dortislem();
            islem.setSayi1(Convert.ToInt32(sayi1text.Text));
            islem.setSayi2(Convert.ToInt32(sayi2text.Text));
            if (radioButton1.Checked == true) islem.setSecim(1);
            if (radioButton2.Checked == true) islem.setSecim(2);
            if (radioButton3.Checked == true) islem.setSecim(3);
            if (radioButton4.Checked == true) islem.setSecim(4);
            MessageBox.Show("Sonuç= " + islem.hesapla());
        }
       
    }
}
