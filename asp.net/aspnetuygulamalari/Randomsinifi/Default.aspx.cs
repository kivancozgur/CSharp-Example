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
        Random sayi = new Random();
      //int uretilensayi=  sayi.Next(1,1000);
     // Response.Write(uretilensayi);
     // Image1.ImageUrl = "img/3.gif";
        String[] harfler = { "a", "b", "d" };
       // int ilkharfrakam = ;
        Image1.ImageUrl = "img/" + harfler[sayi.Next(0, 2)] + ".gif";
    }
}