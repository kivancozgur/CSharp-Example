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
        Ogrenci[] ogrenciler = new Ogrenci[3];


        
        Ogrenci ogr = new Ogrenci();
       
        ogr.Ogno = 9;
        ogr.Adsoyad = "tuncay salı";
        Adres adres = new Adres();
        adres.Cadde = "konak cad";
        adres.Ilce = "yıldırım";
        adres.Il = "bursa";
        ogr.Adres = adres;
        Response.Write(ogr.bilgial());
    }
}