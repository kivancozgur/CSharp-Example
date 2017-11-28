using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proxy1deneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pen kalem;
            Graphics vector;
            int ortaX = 140, ortaY = 140;
            kalem = new Pen(Color.Blue);
            vector = CreateGraphics();
            vector.DrawLine(kalem ,0, ortaY,500, ortaY);
            vector.DrawLine(kalem, ortaX, 0, ortaX, 500);
        }
    }
}
