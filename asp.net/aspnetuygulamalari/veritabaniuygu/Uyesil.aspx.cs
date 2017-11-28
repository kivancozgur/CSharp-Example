using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Uyesil : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int uyeid = Convert.ToInt32(Request.QueryString["uyeid"]);
        int sayi = new Uyelerdao().uyesil(uyeid);
        if (sayi != 0)
        {
            Response.Write("kayıt silindi");
            Response.Write("<a href=uyegoster.aspx>uyeleri goster</a>");
        }
        else
        {
            Response.Write("kayıt silinemedi");
        }
    }
}