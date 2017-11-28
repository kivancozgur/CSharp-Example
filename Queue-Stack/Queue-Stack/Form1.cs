using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
namespace Queue_Stack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Queue yazilar = new Queue(6);
            yazilar.Enqueue("Kıvanç");
            yazilar.Enqueue("Elif");
            yazilar.Enqueue("Ümmü");
            yazilar.Enqueue(1998);
            yazilar.Enqueue(true);
            yazilar.Enqueue(14);
            MessageBox.Show(yazilar.Dequeue().ToString());
            MessageBox.Show(yazilar.Dequeue().ToString());
            MessageBox.Show(yazilar.Dequeue().ToString());
            MessageBox.Show(yazilar.Dequeue().ToString());
            MessageBox.Show(yazilar.Dequeue().ToString());
            MessageBox.Show(yazilar.Dequeue().ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stack yazilar= new Stack(6);
            yazilar.Push("Kıvanç");
            yazilar.Push("Elif");
            yazilar.Push("Ümmü");
            yazilar.Push(1998);
            yazilar.Push(true);
            yazilar.Push(14);
            MessageBox.Show(yazilar.Pop().ToString());
            MessageBox.Show(yazilar.Pop().ToString());
            MessageBox.Show(yazilar.Pop().ToString());
            MessageBox.Show(yazilar.Pop().ToString());
            MessageBox.Show(yazilar.Pop().ToString());
            MessageBox.Show(yazilar.Pop().ToString());
        }
    }
}
