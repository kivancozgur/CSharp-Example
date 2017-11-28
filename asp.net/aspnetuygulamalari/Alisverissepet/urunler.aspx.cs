using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class urunler : System.Web.UI.Page
{
    HttpCookie cerezim = new HttpCookie("bilgi");
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["saykontrol"] == null)
        {
            if (Request.Cookies["bilgi"] != null)
            {

                cerezim = Request.Cookies["bilgi"];
                int sayi = Convert.ToInt32(cerezim["ziysay"]);
                sayi++;
                cerezim["ziysay"] = sayi.ToString();
                cerezim.Expires = DateTime.Now.AddYears(1);
                Response.Cookies.Add(cerezim);
                mesaj.Text = "Bu sayfayı ziyaret sayınız=" + sayi;
                Session["saykontrol"] = "ok";

            }
            else
            {
                cerezim["ziysay"] = "1";
                cerezim.Expires = DateTime.Now.AddYears(1);
                Response.Cookies.Add(cerezim);
                mesaj.Text = "Bu sayfayı ziyaret sayınız=1";
            }
        }
        else
        {
          cerezim = Request.Cookies["bilgi"];
           mesaj.Text ="Bu sayfayı ziyaret sayınız=" + cerezim["ziysay"];
        }
    }
    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {
        Session["secim"] = "1";
        Response.Redirect("urundetay.aspx");
    }
    protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
    {
        Session["secim"] = "2";
        Response.Redirect("urundetay.aspx");
    }
    protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
    {
        Session["secim"] = "3";
        Response.Redirect("urundetay.aspx");
    }
}