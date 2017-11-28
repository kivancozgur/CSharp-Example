using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace stringfonk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String kelime = "kamil";
            //MessageBox.Show(kelime.Length.ToString());
           // MessageBox.Show(kelime.IndexOf("z").ToString());
          //  MessageBox.Show(kelime.Replace("i", "ü"));
           // MessageBox.Show(kelime.Substring(2,2));
           // MessageBox.Show(kelime.ToUpper());
            MessageBox.Show("tuncay \n salı"); 
        }
    }
}
