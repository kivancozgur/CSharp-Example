using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Speech.Recognition;//pc nin bizim verdiği komutu algılaması için
using System.Speech.Synthesis;//konuşmamızın sese dönüşmesi için
using System.Threading;
using System.Diagnostics;//sesli komutla program açtırmak için



namespace Sesli_Komut_Perfonmans
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        SpeechSynthesizer synt = new SpeechSynthesizer();
        PromptBuilder pbuilder = new PromptBuilder();//bilgisayarın bize sesli bir dönüş yapması için (Ki pek fazla kullanmadık)
        SpeechRecognitionEngine Rengine = new SpeechRecognitionEngine();
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                label2.Visible = true;
                Choices list = new Choices();
                list.Add(new string[] { "close", "chrome", "open player", "google", "facebook", "twitter", "microsoft", "what time is it", "calculator", "paint", "coding" });//kullanılacak komutları listeledik.
                Grammar gramer = new Grammar(new GrammarBuilder(list));//verdiği komutların ingilizce olduğunu anlıyacak
                try
                {
                    Rengine.RequestRecognizerUpdate();
                    Rengine.LoadGrammar(gramer);
                    Rengine.SpeechRecognized += Rengine_SpeechRecognized;
                    Rengine.SetInputToDefaultAudioDevice();//varsayılan ses aygıtını al
                    Rengine.RecognizeAsync(RecognizeMode.Multiple);
                }
                catch
                {
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Hatasız kul olmaz,programcıyla iletişime geçin!");// :))
            }

        }
        private void Rengine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)//bu metod da switch case ile "Eğer şunu derse şunları yap " dedik.
        {
            try
            {
                textBox1.Text = (e.Result.Text.ToString());
                switch (e.Result.Text)
                {
                    case "what time is it":

                        panel1.Visible = true;
                        timer1.Start();
                        pbuilder.ClearContent();

                        synt.Speak(pbuilder);
                        break;
                    case "coding":
                        ;
                        panel1.Visible = false;
                        Process.Start("devenv.exe");
                        pbuilder.ClearContent();
                        synt.Speak(pbuilder);
                        break;
                    case "paint":
                        panel1.Visible = false;
                        System.Diagnostics.Process.Start("mspaint.exe");
                        pbuilder.ClearContent(); synt.Speak(pbuilder);

                        break;
                    case "calculator":
                        panel1.Visible = false;
                        System.Diagnostics.Process.Start("calc.exe");
                        pbuilder.ClearContent();
                        synt.Speak(pbuilder);
                        break;
                    case "facebook":
                        panel1.Visible = false;
                        System.Diagnostics.Process.Start("http://www.facebook.com");
                        pbuilder.ClearContent(); synt.Speak(pbuilder);
                        break;
                    case "twitter":
                        panel1.Visible = false;
                        System.Diagnostics.Process.Start("http://www.twitter.com");
                        pbuilder.ClearContent(); synt.Speak(pbuilder);
                        break;
                    case "microsoft":
                        panel1.Visible = false;
                        System.Diagnostics.Process.Start("https://www.microsoft.com");
                        pbuilder.ClearContent();synt.Speak(pbuilder);
                        break;

                    case "chrome":
                        Process.Start("Chrome.exe");
                        pbuilder.ClearContent();// BİZE VERECEĞİ SESLİ CEVAP
                        panel1.Visible = false;
                        pbuilder.AppendText("Chrome opening");
                        synt.Speak(pbuilder);
                        break;
                    case "open player":
                        Process.Start("wmplayer.exe");
                        pbuilder.ClearContent();
                        panel1.Visible = false;
                        pbuilder.AppendText("open music player");
                        synt.Speak(pbuilder);
                        break;

                    case "close":
                        panel1.Visible = false;
                        Form1.ActiveForm.Hide();
                        Form formum = new Form2();
                        formum.ShowDialog();
                        Application.Exit();
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Hatasız kul olmaz,programcıyla iletişime geçin!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            Rengine.Dispose(); //sesli komutu durdurdu.
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToLongTimeString();
            label6.Text = DateTime.Now.ToShortDateString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {



        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }
}
