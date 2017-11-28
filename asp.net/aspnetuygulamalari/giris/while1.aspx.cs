using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class while1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int sayac = 0;
        while (sayac < 100)
        {
            sayac++;
            if (sayac == 30) continue;
            Response.Write(sayac +"=butgem<br>");
        }


    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        int i = 0;
        int toplam = 0;
        while (i < 100)
        {
            i+=2;
            toplam += i;
            
        }
        Response.Write("toplam=" + toplam.ToString());
    }
}