using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Server1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //Response.Write(Server.HtmlEncode("tuncay<hr>"));
      //  Response.Redirect("server2.aspx?adi=" + Server.UrlEncode("tuncay&sali"));
       // Response.Write(Server.MapPath("server2.aspx"));
    }
}