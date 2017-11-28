using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Urunler : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Write("hoşgeldiniz"+ Session["ad"]);
        if (Session["kontrol"] == null)
        {
            Response.Write("ürünleri görmek için üye giriş yapmalısınız");
            Response.End();
        }
    }
}