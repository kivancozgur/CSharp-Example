using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    HttpCookie cerezim = new HttpCookie("bilgi");
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Cookies["bilgi"] != null)//ziyaretçi pc de varmı yokmu die bak varsa
        {
            cerezim =Request.Cookies["bilgi"];
            kuladi.Text = cerezim["kuladi"];
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        String kullaniciadi = kuladi.Text;
        String sifrebilgisi = sifre.Text;
        if (kullaniciadi.Equals("butgem") && sifrebilgisi.Equals("12345"))
        {//şifre bilindi ise
            if (CheckBox1.Checked == true)//beni anımsa seçili ise
            {
                cerezim["kuladi"] = kuladi.Text;
                cerezim.Expires = DateTime.Now.AddYears(1);
                Response.Cookies.Add(cerezim);
            }
            Response.Redirect("Anasayfa.aspx");
        }
        else
        {
            Response.Write("kullanıcı adınız veya şifreniz hatalı");
            kuladi.Text = "";
            sifre.Text = "";
        }
    }
}