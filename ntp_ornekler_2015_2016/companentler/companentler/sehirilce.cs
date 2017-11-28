using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace companentler
{
    public partial class sehirilce : Form
    {
        public sehirilce()
        {
            InitializeComponent();
        }

        private void ilcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ilcelist.Items.Clear();

            if (ilcombo.SelectedItem.ToString() == "ankara")
            {
                ilcelist.Items.Add("kızılay");
                ilcelist.Items.Add("mamak");
                ilcelist.Items.Add("etimesgut");
            }//ankara if

            if (ilcombo.SelectedItem.ToString() == "bursa")
            {
                ilcelist.Items.Add("nilüfer");
                ilcelist.Items.Add("emek");
                ilcelist.Items.Add("yıldırım");
            }//ankara if


        }

        private void ilcelist_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(ilcelist.SelectedItem.ToString());
        }
    }
}
