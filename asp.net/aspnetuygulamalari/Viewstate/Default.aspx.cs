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
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        int secim = Convert.ToInt32( DropDownList1.SelectedValue);
        switch (secim)
        {
            case 16:
                ListBox1.Items.Add("nilüfer");
                ListBox1.Items.Add("kestel");
                ListBox1.Items.Add("keles");
                break;
            case 6:
                ListBox1.Items.Add("çankaya");
                ListBox1.Items.Add("etlik");
                ListBox1.Items.Add("mamak");
                break;
        }
    }
    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Response.Write(ListBox1.SelectedItem.Text);
    }
}