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

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Ogrenci og1 = new Ogrenci();
        og1.Adsoyad = "kamil ok";
        og1.Ogno = 25;
        //Response.Write(og1);
        Ogrenci og2 = new Ogrenci();
        og2.Adsoyad = "osman tan";
        og2.Ogno = 25;
        if (og1.Equals(og2))
        {
            Response.Write("öğrenciler aynı");
        }
        else
        {
            Response.Write("ogrenciler farklı");
        }
    }
}