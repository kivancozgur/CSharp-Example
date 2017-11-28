using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Application1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {int topsay=0;
        if (Application["toplamziysay"] == null)
        {
            Application["toplamziysay"] = 1;
            topsay = 1;
        }
        else
        {
  topsay=int.Parse(Application["toplamziysay"].ToString());
            topsay++;
            Application["toplamziysay"] = topsay;
        }
        Response.Write("Siteyi toplam ziyaretçi sayısı=" + topsay.ToString());
       
    }
}