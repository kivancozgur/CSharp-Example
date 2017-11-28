using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ogrencisayafasi : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Ogrenci ogr = new Ogrenci();
  ogr.adsoyad=Microsoft .VisualBasic.Interaction.InputBox ("öğrenci adını girin","","",100,100);
    ogr.no=Convert.ToInt32 (Microsoft .VisualBasic.Interaction.InputBox ("öğrenci nosu girin","","",100,100));
    ogr.adres = Microsoft.VisualBasic.Interaction.InputBox("öğrenci adresini girin", "", "", 100, 100);
    String dersadi = Microsoft.VisualBasic.Interaction.InputBox("Ders adını girin", "", "", 100, 100);
    int[] notlar = new int[100];
    int i = 0;
    while (true)
    {
        notlar[i]=Convert.ToInt32(Microsoft .VisualBasic.Interaction.InputBox
            ("öğrencinin"+ (i+1) +" notunu girin","","",100,100));
        i++;
        int secim = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox
            ("Devam edecekmisin 1-Evet 2-Hayır", "", "", 100, 100));
        if (secim == 2) break;
    }//while
    Response.Write("öğrencinin ADI=" + ogr.adsoyad + "ÖĞRENCİNİN nosu=" + ogr.no + "Adresi=" +
ogr.adres);
    Response.Write(dersadi + " dersinden öğrenci" + ogr.hesaplama(notlar));


    }
}