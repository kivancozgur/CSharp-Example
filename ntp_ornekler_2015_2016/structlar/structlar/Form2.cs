using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace structlar
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        class Dikdortgenclass
        {
           public int kisa, uzun;
            public Dikdortgenclass()
            {

            }

            public int alanhesapla()
            {
                return kisa * uzun;
            }

        }//class


        struct Dikdortgenstruct
        {
            int kisa;
            int uzun;


            public Dikdortgenstruct(int kis,int uz)
            {
                kisa = kis;
                uzun = uz;
            }

            public int alanhesapla()
            {
                return kisa * uzun;

            }

        }//struct
        private void button1_Click(object sender, EventArgs e)
        {
            Dikdortgenstruct structislemi = new Dikdortgenstruct(5, 6);
            MessageBox.Show(structislemi.alanhesapla().ToString());

            Dikdortgenclass classislemi = new Dikdortgenclass();
            classislemi.kisa = 10;
            classislemi.uzun = 20;
            MessageBox.Show(classislemi.alanhesapla().ToString());
        }
    }
}
