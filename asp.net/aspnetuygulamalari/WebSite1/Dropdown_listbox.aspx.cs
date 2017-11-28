using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Dropdown_listbox : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Response.Write(DropDownList1.SelectedItem.Text );
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Write(ListBox1.Items.FindByText("kestell"));
    }
}