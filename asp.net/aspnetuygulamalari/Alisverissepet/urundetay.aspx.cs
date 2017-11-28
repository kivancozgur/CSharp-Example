using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class urundetay : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int secim = Convert.ToInt32(Session["secim"]);
        switch(secim)
        {
            case 1:
                Image1.ImageUrl = "img/ana1.jpg";
                Label1.Text = "Asus";
                fiyat1.Text = "300";
                 Image2.ImageUrl = "img/ana2.jpg";
                Label2.Text = "amd";
                fiyat2.Text = "200";
                break;
            case 2:
                Image1.ImageUrl = "img/ram1.jpg";
                Label1.Text = "Kinston";
                fiyat1.Text = "60";
                Image2.ImageUrl = "img/ram2.jpg";
                Label2.Text = "hibel";
                fiyat2.Text = "90";
                break;
            case 3:
                Image1.ImageUrl = "img/hdd1.jpg";
                Label1.Text = "Samsung";
                fiyat1.Text = "400";
                Image2.ImageUrl = "img/hdd2.jpg";
                Label2.Text = "western";
                fiyat2.Text = "200";
                break;
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["sepet"] = Session["sepet"] + "-->" + Label1.Text;
        int varolanfiy = Convert.ToInt32(Session["topfiy"]);
        int topfiy = varolanfiy + Convert.ToInt32(fiyat1.Text);
        Session["topfiy"] = topfiy;
        Response.Redirect("sepet.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Session["sepet"] = Session["sepet"] + "-->" + Label2.Text;
        int varolanfiy = Convert.ToInt32(Session["topfiy"]);
        int topfiy = varolanfiy + Convert.ToInt32(fiyat2.Text);
        Session["topfiy"] = topfiy;
        Response.Redirect("sepet.aspx");
    }
}