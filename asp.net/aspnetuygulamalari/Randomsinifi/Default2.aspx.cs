using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Random uret = new Random();
        String[] harfler = { "a", "b", "d", "e", "v" };
        String ilkharf = harfler[uret.Next(0, 4)];
        String ikinciharf = harfler[uret.Next(0, 4)];
        int rakam1 = uret.Next(0, 9);
        int rakam2 = uret.Next(0, 9);
        int rakam3 = uret.Next(0, 9);
        Image1.ImageUrl = "img/" + rakam1 + ".gif";
        Image2.ImageUrl = "img/" + rakam2 + ".gif";
        Image3.ImageUrl = "img/" + ilkharf + ".gif";
        Image4.ImageUrl = "img/" + rakam3 + ".gif";
        Image5.ImageUrl = "img/" + ikinciharf + ".gif";
    }
}