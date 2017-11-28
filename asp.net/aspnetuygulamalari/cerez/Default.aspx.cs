using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    HttpCookie cerezim = new HttpCookie("bilgim");
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
       
        cerezim["ad"] = "tuncay";
        cerezim["soyad"] = "salı";
        cerezim.Expires = DateTime.Now.AddMonths(5);
        Response.Cookies.Add(cerezim);

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        if (Request.Cookies["bilgim"] != null)
        {
            cerezim = Request.Cookies["bilgim"];
            Response.Write(cerezim["ad"] + cerezim["soyad"]);
        }
        else
        {
            Response.Write("çerez yok okunmadı");
        }
    }
}