using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Anasayfa : System.Web.UI.Page
{
    HttpCookie cerez = new HttpCookie("bilgim");
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["kontrol"] == null)
        {

            if (Request.Cookies["bilgim"] != null)
            {
                cerez = Request.Cookies["bilgim"];
                int ziysayi = Convert.ToInt32(cerez["ziysayi"]);
                ziysayi++;
                cerez["ziysayi"] = ziysayi.ToString();
                cerez.Expires = DateTime.Now.AddYears(1);
                Response.Cookies.Add(cerez);
                Response.Write("bu sayfamızı=" + ziysayi + ".ziyaretiniz");
                Session["kontrol"] = "ok";
            }
            else
            {
                cerez["ziysayi"] = "1";
                cerez.Expires = DateTime.Now.AddYears(1);
                Response.Cookies.Add(cerez);
                Response.Write("bu sayfamızı ilk ziyaretiniz");
            }
        }
        else
        {
            cerez = Request.Cookies["bilgim"];
            int ziysayi = Convert.ToInt32(cerez["ziysayi"]);
            Response.Write("bu sayfamızı=" + ziysayi + ".ziyaretiniz");

        }
        

    }
}