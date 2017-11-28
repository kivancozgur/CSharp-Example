using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Random sayi = new Random();
        int sayi1 = sayi.Next(0, 3);
      // Response.Write(sayi1);
       String[] harfler = { "c", "z", "v", "m" };
      Response.Write( harfler[sayi1]);
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        //Response.Redirect("default2.aspx");
        Response.Write("<img src=img/lale.jpg>");
        Response.Clear();
        Response.Write("kamil");
    }
}