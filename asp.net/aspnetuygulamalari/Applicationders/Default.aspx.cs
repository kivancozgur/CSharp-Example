using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Application["toplamziy"] == null)
        {
            Application["toplamziy"] = 1;
            Response.Write("Toplam ziyaretçi sayısı=" + Application["toplamziy"]);
        }
        else
        {
            int topziy =int.Parse(Application["toplamziy"].ToString());
            topziy++;
            Application["toplamziy"] = topziy;
            Response.Write("toplam ziyaretçi sayısı=" + topziy);
        }
    }
}