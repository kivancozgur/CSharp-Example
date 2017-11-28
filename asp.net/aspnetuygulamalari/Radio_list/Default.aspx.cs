using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        RadioButtonList1.SelectedIndex = 4;
        RadioButton2.Checked = true;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (RadioButton1.Checked == true)
        {
            Response.Write("bay");
        }
    }
    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {

    }
    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
       // Response.Write(RadioButtonList1.SelectedItem.Text);
       // Response.Write(RadioButtonList1.SelectedIndex);
    }
}