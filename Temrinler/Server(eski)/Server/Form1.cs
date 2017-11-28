using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Server
{
    public partial class Form1 : Form
    {
        Thread t;
        IPAddress ipadresimiz;
        TcpListener dinle;
        Socket soket;
        NetworkStream ag;
        StreamReader oku;
        StreamWriter yaz;
        public delegate void ricdegis(string text);
        public Form1()
        {
            InitializeComponent();
        }
        // Serverde Method_1
        public void okumayabasla()
        {
            soket = dinle.AcceptSocket();
            ag = new NetworkStream(soket);
            oku = new StreamReader(ag);
            while (true)
            {
                try
                {
                    string yazi = oku.ReadLine();
                    ekranabas(yazi);
                }
                catch
                {
                    return;
                }
            }
        }
        // Serverde Method_2 (Gelen Veriyi richTextBox icine yazdirmak icin)
        public void ekranabas(string s)
        {
            if (this.InvokeRequired)
            {
                ricdegis degis = new ricdegis(ekranabas);
                this.Invoke(degis, s);
            }
            else
            {
                s = "Server: " + s;
                richTextBox1.AppendText(s + "n");
            }

        }
        // Serverde Method_3 (Serverimizin Port dinlemesine baslamsi icin)
        private void dinlemeye_basla()
        {
            try
            {
                ipadresimiz = IPAddress.Parse("127.0.0.1");
                dinle = new TcpListener(ipadresimiz, Convert.ToInt16(textBox1.Text));
                dinle.Start();
                t = new Thread(new ThreadStart(okumayabasla));
                t.Start();
                richTextBox1.AppendText(DateTime.Now.ToString() + " Dinleme baslatildi...n");
            }
            catch (Exception)
            {

                MessageBox.Show("Dinleme baslatilamadi");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dinlemeye_basla();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")

                //Burda bos alan göndermeyi önlüyoruz...
                return;
            else
            {
                yaz = new StreamWriter(ag);
                yaz.WriteLine(textBox2.Text);
                yaz.Flush();
                richTextBox1.AppendText(textBox2.Text + "n");
                textBox2.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ag.Close();
        }
    }
}
