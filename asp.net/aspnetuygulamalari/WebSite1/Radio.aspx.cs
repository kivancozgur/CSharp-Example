using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Radio : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
      Response.Write(Request.Form["katid"]);
     //   RadioButtonList1.Items.Add("gaziantep");
        Response.Write(RadioButtonList1.SelectedIndex);
        RadioButtonList1.SelectedIndex = 2;
    }
}