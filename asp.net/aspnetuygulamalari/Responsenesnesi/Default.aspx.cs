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
        Response.Redirect("sayfa2.aspx");

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Write("<img src=img/koala.jpg>");
        Response.End();
        Response.Write("nbr len osman");
    }
}