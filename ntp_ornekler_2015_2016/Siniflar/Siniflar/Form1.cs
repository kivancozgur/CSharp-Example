using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Siniflar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* Bisiklet tuncayinbisikleti = new Bisiklet();
            tuncayinbisikleti.hizlan(30);
            
            tuncayinbisikleti.vitesdegistir(3);
            tuncayinbisikleti.frenyap(10);
            MessageBox.Show("tuncayın bisikleti hızı=" + tuncayinbisikleti.hizdegerial().ToString()
                + "Tuncayın bisikleti vites=" + tuncayinbisikleti.vitesdegerigeridon().ToString());
            Bisiklet sibelinbisikleti = new Bisiklet();
            sibelinbisikleti.hizlan(15);
            sibelinbisikleti.vitesdegistir(5);
            sibelinbisikleti.frenyap(2);
            MessageBox.Show("sibelin bisikleti hızı=" + sibelinbisikleti.hizdegerial().ToString()
               + "sibelin bisikleti vites=" + sibelinbisikleti.vitesdegerigeridon().ToString());*/

            Bisiklet sametinbisikleti = new Bisiklet(20, "pembe");
            MessageBox.Show(sametinbisikleti.hizdegerial().ToString());
            sametinbisikleti.Sethiz(40);
            MessageBox.Show(sametinbisikleti.Gethiz().ToString ());
            sametinbisikleti.Vites = 5;
            MessageBox.Show(sametinbisikleti.Vites.ToString());

        }
    }
}
