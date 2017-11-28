using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class image_button_imagemap : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        TextBox metinkutu = new TextBox();
        metinkutu.ID = "ad";
        PlaceHolder1.Controls.Add(metinkutu);
        PlaceHolder1.Controls.Add(new LiteralControl("isim"));
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Write(Request.Form["ad"]);
    }
}