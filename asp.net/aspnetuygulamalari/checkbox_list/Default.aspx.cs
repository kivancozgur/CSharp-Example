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

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (CheckBox1.Checked == true)
        {
            Response.Write(CheckBox1.Text);
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        CheckBoxList1.Items.Add("spor");
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
       // Response.Write(CheckBoxList1.SelectedItem.Text);
        String sonuc="";
        for (int i = 0; i < CheckBoxList1.Items.Count; i++)
        {
            if (CheckBoxList1.Items[i].Selected)
            {
                sonuc = sonuc + CheckBoxList1.Items[i].Text;
            }
        }
        Response.Write("hobileriniz=" + sonuc);
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        CheckBoxList1.RepeatDirection = RepeatDirection.Vertical;
    }
    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {

    }
    protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}