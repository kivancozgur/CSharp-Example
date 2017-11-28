using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Staticmetotdegisken
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personel p1 = new Personel("kamil ok", 1);
            Personel p2 = new Personel("tuncay salı", 2);
            //MessageBox.Show(p1.personelsayisi().ToString());
           // MessageBox.Show(Personel.sayac.ToString());
            MessageBox.Show(Personel.personelsayisi().ToString());
        }
    }
}
