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
    public partial class Urunstok : Form
    {
        public Urunstok()
        {
            InitializeComponent();
        }

        private void Urunstok_Load(object sender, EventArgs e)
        {
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.TextAlign = ContentAlignment.MiddleRight;
        }
    }
}
