using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace Okul_Zili
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void goster()
        {
            SoundPlayer zil = new SoundPlayer();
            string konum = "E:\\ekozilla\\WindowsFormsApplication1\\bin\\Debug\\crazy forg.wav";
            zil.SoundLocation = konum;
            zil.Play();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        string yol;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            
            SoundPlayer zil = new SoundPlayer();
            string konum = yol;
            zil.SoundLocation = konum;

            label18.Text = DateTime.Now.ToLongTimeString();
            label16.Text = DateTime.Now.ToShortDateString();
            if (label18.Text == textBox1.Text)
            {

                goster();

                label1.BackColor = Color.Red;

            }
            if (label18.Text == textBox2.Text)
            {

                goster();

                label1.BackColor = Color.Red;

            }
            if (label18.Text == textBox3.Text)
            {

                goster();

                label1.BackColor = Color.White;
                label2.BackColor = Color.Red;

            }
            if (label18.Text == textBox4.Text)
            {

                goster();

                label2.BackColor = Color.Red;
            }
            if (label18.Text == textBox5.Text)
            {

                goster();

                label2.BackColor = Color.White;
                label3.BackColor = Color.Red;
            }
            if (label18.Text == textBox6.Text)
            {

                goster();

                label3.BackColor = Color.Red;
            }
            if (label18.Text == textBox7.Text)
            {

                goster();

                label3.BackColor = Color.White;
                label4.BackColor = Color.Red;
            }
            if (label18.Text == textBox8.Text)
            {

                goster();

                label4.BackColor = Color.Red;
            }
            if (label18.Text == textBox9.Text)
            {

                goster();

                label4.BackColor = Color.White;
                label5.BackColor = Color.Red;
            }
            if (label18.Text == textBox10.Text)
            {

                goster();

                label5.BackColor = Color.Red;
            }
            if (label18.Text == textBox11.Text)
            {

                goster();

                label5.BackColor = Color.White;
                label6.BackColor = Color.Red;
            }
            if (label18.Text == textBox12.Text)
            {

                goster();

                label6.BackColor = Color.Red;
            }
            if (label18.Text == textBox13.Text)
            {

                goster();

                label6.BackColor = Color.White;
                label7.BackColor = Color.Red;
            }
            if (label18.Text == textBox14.Text)
            {

                goster();

                label7.BackColor = Color.Red;
            }
            if (label18.Text == textBox15.Text)
            {

                goster();

                label7.BackColor = Color.White;
                label8.BackColor = Color.Red;
            }
            if (label18.Text == textBox16.Text)
            {

                goster();

                label8.BackColor = Color.Red;
            }
            if (label18.Text == textBox17.Text)
            {

                goster();

                label8.BackColor = Color.White;
                label9.BackColor = Color.Red;
            }
            if (label18.Text == textBox18.Text)
            {

                goster();

                label9.BackColor = Color.Red;
            }
            if (label18.Text == textBox19.Text)
            {

                goster();

                label9.BackColor = Color.White;
                label10.BackColor = Color.Red;
            }
            if (label18.Text == textBox20.Text)
            {

                goster();

                label10.BackColor = Color.Red;
            }
            if (label18.Text == textBox21.Text)
            {

                goster();

                label10.BackColor = Color.White;
                label11.BackColor = Color.Red;
            }
            if (label18.Text == textBox22.Text)
            {

                goster();

                label11.BackColor = Color.Red;
            }
            if (label18.Text == textBox23.Text)
            {

                goster();

                label11.BackColor = Color.White;
                label12.BackColor = Color.Red;
            }
            if (label18.Text == textBox24.Text)
            {

                goster();

                label12.BackColor = Color.Red;
                
            }
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void yenilebut_Click(object sender, EventArgs e)
        {

        }

        private void muzbut_Click(object sender, EventArgs e)
        {
            Form müzik = new Form2();
            müzik.Show();

        }
    }
}
