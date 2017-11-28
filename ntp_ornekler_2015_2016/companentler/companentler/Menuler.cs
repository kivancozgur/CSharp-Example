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
    public partial class Menuler : Form
    {
        public Menuler()
        {
            InitializeComponent();
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog filedialog = new OpenFileDialog();
            filedialog.ShowDialog();
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void renkDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog renk = new ColorDialog();
            renk.ShowDialog();
            textBox1.ForeColor = renk.Color;
        }
    }
}
