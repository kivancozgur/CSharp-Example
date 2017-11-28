using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class server1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
       // Response.Write("tuncay<hr>");
      //  Response.Write(Server.HtmlEncode("tuncay<hr>"));
        Response.Write(Server.MapPath("cerez.aspx"));
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("server2.aspx?adi=" + Server .UrlEncode("tuncay&sali"));
    }
}