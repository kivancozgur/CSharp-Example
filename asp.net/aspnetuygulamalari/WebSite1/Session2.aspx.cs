using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Session2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Write(Session["veri"]);
        Response.Write("id niz=" + Session.SessionID);
       // Session.Timeout = 10;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        
       Session.Abandon();
        //Session.RemoveAll();
        Response.Redirect("session3.aspx");
    }
}