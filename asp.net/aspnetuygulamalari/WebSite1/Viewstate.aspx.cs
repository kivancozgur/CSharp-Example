using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Viewstate : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        int sec = Convert.ToInt32(DropDownList1.SelectedValue);
        switch (sec)
        {
            case 16:
                ListBox1.Items.Add("nilüfer");
                ListBox1.Items.Add("yıldırım");
                ListBox1.Items.Add("kestel");
                break;
        }
    }
    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Response.Write(ListBox1.SelectedValue);
    }
}