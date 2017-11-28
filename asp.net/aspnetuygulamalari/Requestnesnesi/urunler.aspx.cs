using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class urunler : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int id = Convert.ToInt32(Request.QueryString["id"]);
        switch (id)
        {
            case 1:
                Image1.ImageUrl = "img/ana.jpg";
                Response.Write ("ürünün markası gigabyte slx34 f,yatı:35");
                break;
            case 2:
                 Image1.ImageUrl = "img/hdd.jpg";
                Response.Write ("ürünün markası samsung f,yatı:350");
                break;
 case 3:
                 Image1.ImageUrl = "img/ram.jpg";
                Response.Write ("ürünün markası kingston f,yatı:350");
                break;
        }
    }
}