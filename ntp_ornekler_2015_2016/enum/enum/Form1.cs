using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace @enum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        enum aylar
        {
            OCAK,ŞUBAT,MART,NİSAN,MAYIS
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //aylar ay = aylar.ŞUBAT;
            //MessageBox.Show(Convert.ToInt32(ay).ToString());
           String[] aylistesi= Enum.GetNames(typeof(aylar));
           foreach (String ay in aylistesi)
           {
               comboBox1.Items.Add(ay);
           }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          Boolean KONTROL=  Enum.IsDefined(typeof(aylar), "NİSAN");
          if (KONTROL == true) MessageBox.Show("arana değer bulundu");
          else MessageBox.Show("aranan değer bulunamadı");
        }
    }
}
