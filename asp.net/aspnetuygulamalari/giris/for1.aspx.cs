using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class for1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        for (int i = 0; i < 100; i++)
        {
            Response.Write(i.ToString() +"butgem<br>");
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        int toplam = 0;
        for (int s = 0; s < 100; s++)
        {
            toplam += s;

        }
        Response.Write(toplam.ToString());
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        DateTime tarih = DateTime.Now;
        tarih = tarih.AddMonths(2);
        Response.Write(tarih.ToShortDateString());
    }
}