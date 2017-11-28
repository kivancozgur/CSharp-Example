using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Giris : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (kuladi.Text.Equals("admin") && sifre.Text.Equals("12345"))
        {
            Session["kontrol"] = "ok";
            Session["ad"] = "admin";
            Response.Redirect("urunler.aspx");
            
        }
        else
        {
            Response.Write("Kullanıcı adı şifre yanlış");
        }
    }
}