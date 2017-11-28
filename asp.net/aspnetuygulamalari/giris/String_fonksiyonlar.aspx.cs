using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class String_fonksiyonlar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //String veri = "butgem:tuncay:osman:kamil:ayşe";
       // Response.Write(veri.Length);
        //Response.Write (veri.Replace("ut","at"));
        //Response.Write(veri.Substring(2, 3));
      //  Response.Write(veri.ToUpper());
       // TextBox1.Text = veri.Trim();
        //Response.Write(veri.IndexOf("xe"));
      /* String[] isimler= veri.Split(':');
       foreach (String alinan in isimler)
       {
           Response.Write(alinan + "<br>");
       }*/
        String ad = "tuncay";
        Response.Write(ad.Equals("Tuncay"));
    }
}