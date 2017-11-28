using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace @switch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int deger = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Bölüm Seçin 1-bilişim 2-makina 3-elktrik 4-biyo", "Seçiminiz", "0", -1, -1));
            switch (deger)
            {
                case 1:
                    MessageBox.Show("bilişim sınıfları 10 a ,10p,11a,11k");
                    break;
                case 2:
                    MessageBox.Show("makina sınıfları 10 m ,10k,11m,11p");
                    break;
                case 3:
                    MessageBox.Show("elektri sınıfları 10 s ,10z,11d,11e");
                    break;
                default :
                    MessageBox.Show("yanlış seçim girsdin");
                    break;
            }//switch
        }
    }
}