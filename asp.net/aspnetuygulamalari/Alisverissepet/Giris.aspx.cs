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


        if (Application["toplamziy"] == null)
        {
            Application["toplamziy"] = 1;
        }
        else
        {
            if (Session["giriskont"] == null)
            {
                int topziy = Convert.ToInt32(Application["toplamziy"]);
                topziy++;
                Application["toplamziy"] = topziy;
            }
            Session["giriskont"] = "ok";
        }
        mesaj.Text = "toplam ziyaretçi sayısı=" + Application["toplamziy"];
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (kuladitext.Text.Equals("admin") && sifretext.Text.Equals("12345"))
        {
            Response.Redirect("urunler.aspx");
        }
        else
        {
            hata.Text ="kullanıcı adi veya şifre hataalı";
        }
    }
}