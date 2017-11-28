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
    public partial class chekboxform : Form
    {
        public chekboxform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String birlestirici="";

            if (kitapcek.Checked == true) birlestirici = birlestirici + "kitap okumak, ";

            if (yuzcek.Checked == true) birlestirici = birlestirici + " yüzme,";

            if (uycek.Checked == true) birlestirici = birlestirici + " uyku,";

            if (koscek.Checked == true) birlestirici = birlestirici + "kosma";

            MessageBox.Show("hobileriniz =" + birlestirici);
        }

        private void yuzcek_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("merhaba");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
