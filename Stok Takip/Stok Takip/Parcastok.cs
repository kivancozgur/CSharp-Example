using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Stok_Takip
{
    public partial class Parcastok : Form
    {
        public Parcastok()
        {
            InitializeComponent();
        }

        private void Parcastok_Load(object sender, EventArgs e)
        {
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.TextAlign = ContentAlignment.MiddleRight;
        }
    }
}
