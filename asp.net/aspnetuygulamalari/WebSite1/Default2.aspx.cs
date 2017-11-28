using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Kedi cat1 = new Kedi();
        Response.Write(cat1.sescikar());
       Kedi cat2 = new Kedi();
       Response.Write(cat2);
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Ogrenci ogr1 = new Ogrenci();
        Ogrenci ogr2 = new Ogrenci();
        ogr1.Ogno = 15;
        ogr2.Ogno = 25;
        if (ogr1.Equals(ogr2))
        {
            Response.Write("aynılar");
        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
 Phpohoshopplıugib  ef1 = new Efekt();
     photoshopluginuygula(ef1);
     if (ef1 is Ogrenci)
     {
         Response.Write("oldu");
     }

    }
    public void photoshopluginuygula(Phpohoshopplıugib p1)
    {
        Response.Write(p1.cizdir());
        

    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        ArrayList arabalar= new ArrayList();
        arabalar.Add("porş");
        arabalar.Add("reno");
        arabalar.Add("fiat");
        Response.Write(arabalar[1]);
    }
}