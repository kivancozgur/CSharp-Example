using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace performansodevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }






        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.OverwritePrompt = false;
            save.ShowDialog();


        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            MessageBox.Show(folderBrowserDialog1.SelectedPath);

        }

        private void kayıtbut_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.OverwritePrompt = false;
            save.ShowDialog();

        }

        private void açbut_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            MessageBox.Show(folderBrowserDialog1.SelectedPath);
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveas = new SaveFileDialog();
            saveas.OverwritePrompt = false;
            saveas.ShowDialog();

        }

        private void geriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();



        }

        private void paragrafToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void yazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            
            trackBar1.Maximum = pictureBox1.Height;
            trackBar1.Value = pictureBox1.Height;
            trackBar1.Size = new Size(trackBar1.Value, pictureBox1.Height);



        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void sayfaArkaPlanToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void tomatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.Tomato;
        }

        private void aquaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.Aqua;
        }

        private void azureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.Azure;
        }

        private void pinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.Pink;
        }

        private void turquouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.Turquoise;
        }

        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.Green;
        }

        private void ileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void ileriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //HorizontalAlignment.(Left);


        }

        private void ortaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //HorizontalAlignment.(Center);
            
        }

        private void sağToolStripMenuItem_Click(object sender, EventArgs e)
        {
       // HorizontalAlignment: Right;
          
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.Font = fontDialog1.Font;
        }

        private void renkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.ForeColor = colorDialog1.Color;
        }



        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("c://resim//koala.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            openFileDialog1.Filter = "resim dosyası|*.jpg|excel dosyası|*.xls";
            
            {


                string dosyabilgisi = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(dosyabilgisi);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

            

         

        private void dilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            System.Threading.Thread.CurrentThread.CurrentUICulture =
              new System.Globalization.CultureInfo("cultur");
           
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void uzunlukToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string kelime =( "sibel şahin 11-a elif selen yazıcı 11-a");
           
            MessageBox.Show(kelime.Length.ToString());
           
        }

        private void kelimeYeriniBulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sozcuk= ("sibel şahin 11-a elif selen yazıcı 11-a");
           MessageBox.Show(sozcuk.IndexOf("e").ToString());
        }

        private void büyütToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string kelimeler=("sibel şahin 11-a elif selen yazıcı 11-a");
            MessageBox.Show(kelimeler.ToUpper());
        }

        private void kelimeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
         

      
   




    
    

             

          
             

             
         

       
         

         
             



    



