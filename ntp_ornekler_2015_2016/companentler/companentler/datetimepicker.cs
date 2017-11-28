using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace companentler
{
    public partial class datetimepicker : Form
    {
        public datetimepicker()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (ilktarih.Text != "")
            {
                dogtartext.Text = dateTimePicker1.Value.ToShortDateString();
            }
            if (ilktarih.Text == "")
            {
                ilktarih.Text = dateTimePicker1.Value.ToShortDateString();
            }
          
        }
    }
}
