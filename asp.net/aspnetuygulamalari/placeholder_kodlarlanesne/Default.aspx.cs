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
        TextBox kutum = new TextBox();
        kutum.ID = "ad";
        PlaceHolder1.Controls.Add(kutum);
        HyperLink linkim = new HyperLink();
        linkim.NavigateUrl = "http://www.meb.gov.tr";
        linkim.Text = "bana tıkla";
       // PlaceHolder1.Controls.Add(linkim);
        Page.Controls.Add(linkim);
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Write(Request.Form["ad"]);
    }
}