using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kivanc_temrin_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String kelime = " Ülkeye Yararlı Bir \n İnsan Olmak İçin \n Vergi Ödemenin Şimdi \n Tam Zamanı.";
        private void button1_Click(object sender, EventArgs e)
        {
           
            int kelime1 = 1, satır = 1, harf = 0;
            for (int i = 0; i < kelime.Length; i++)
            {
                harf++;
                string karakter = kelime.Substring(i, 1);
               if(karakter==" ")
                {
                    kelime1++;
                    harf--;
                }
               if(karakter=="\n")
                {
                    satır++;
                    harf--;
                    kelime1--;
                }
                if (karakter == ".")
                {
                    kelime1--;
                    harf--;
                }
            }
            MessageBox.Show(kelime);
            MessageBox.Show("Harf Sayısı: " + harf + " Kelime Sayısı : " + kelime1 + " Satır Sayısı : " + satır);

        }

    }
}
