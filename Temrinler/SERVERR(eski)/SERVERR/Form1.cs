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
namespace SERVERR
{
    public partial class Form1 : Form
    {
        Thread t;
        TcpListener dinle;
        Socket soket;
        NetworkStream ag;
        StreamReader oku;
        StreamWriter yaz;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (TxtBox_Name.Text != "")
            {

                dinle = new TcpListener(System.Net.IPAddress.Any, Convert.ToInt32(TxtBox_Dinleme_port.Text));
                dinle.Start();
                t = new Thread(new ThreadStart(okumayabasla));
                t.Start();
            }
            else MessageBox.Show("Lütfen isminizi giriniz!");
        }
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
                { return; }
            }
        }
        public delegate void ricdegis(string text);

        public void ekranabas(string s)
        {
            if (this.InvokeRequired)
            {
                ricdegis degis = new ricdegis(ekranabas);
                this.Invoke(degis, s);
            }
            else
            {
                RtxtBox_Sohbet.AppendText(s + "\n");
            }
        }
        private void RtxtBox_Ileti_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13) // enter e basıldıında
            {
                RtxtBox_Sohbet.AppendText("Ben: " + RtxtBox_Ileti.Text + "\n");
                yaz = new StreamWriter(ag);
                yaz.WriteLine(TxtBox_Name.Text + ": " + RtxtBox_Ileti.Text);
                yaz.Flush();
                RtxtBox_Ileti.Text = "";
            }
        }

    }
}
