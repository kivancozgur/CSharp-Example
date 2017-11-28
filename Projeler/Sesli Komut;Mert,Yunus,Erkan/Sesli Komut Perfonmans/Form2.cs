using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;//internetten bulduğumuz kapatma metodunu çalıştırmak için gerekli olan referans.

namespace Sesli_Komut_Perfonmans
{
    public partial class Form2 : Form
    {
        int a = 1;
        public Form2()
        {
            InitializeComponent();
        }
        void Shutdown()//kapatma metodu.
        {
            ManagementBaseObject mboShutdown = null;
            ManagementClass mcWin32 = new ManagementClass("Win32_OperatingSystem");
            mcWin32.Get();

            // You can't shutdown without security privileges
            mcWin32.Scope.Options.EnablePrivileges = true;
            ManagementBaseObject mboShutdownParams =
                     mcWin32.GetMethodParameters("Win32Shutdown");

            // Flag 1 means we want to shut down the system. Use "2" to reboot.
            mboShutdownParams["Flags"] = "1";
            mboShutdownParams["Reserved"] = "0";
            foreach (ManagementObject manObj in mcWin32.GetInstances())
            {
                mboShutdown = manObj.InvokeMethod("Win32Shutdown",
                                               mboShutdownParams, null);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Form formum = new Form1();
            formum.Dispose();
            timer1.Start();    
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            timer1.Stop();
            MessageBox.Show("Bilgisiyarı kapatma işlemi iptal edildi,öbür forma geri dönülüyor");
            Form2.ActiveForm.Hide();//formu kapatınca,bilgisiyarı kapatma işlemi iptal ediliyor.
            Form formum = new Form1();
            formum.ShowDialog();
            



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == 10)
            {
                timer1.Stop();
                MessageBox.Show("Bilgisiyar Kapanıyor");
                Shutdown();
            }
            else
            
            label3.Text = a.ToString();
            progressBar1.Value += 1; a = a + 1;
           
            
        }
        }
    }

