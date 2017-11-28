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
        Araba tuncayinarabasi = new Araba();
        tuncayinarabasi.Marka = "reno";
        tuncayinarabasi.renk = "kırmızı";
        tuncayinarabasi.Motorgucu = 1600;
        tuncayinarabasi.Yolcukapasite = 4;
        tuncayinarabasi.hizlan();
        Response.Write("tuncayın arabasının bilgileri:"
            + tuncayinarabasi.Marka + tuncayinarabasi.Motorgucu + 
            tuncayinarabasi.renk + tuncayinarabasi.Yolcukapasite + tuncayinarabasi.Hiz);

        Araba ayseninarabasi = new Araba();
        ayseninarabasi.Marka = "porş";
        ayseninarabasi.renk = "siyah";
        ayseninarabasi.Motorgucu = 4000;
        ayseninarabasi.Yolcukapasite = 2;
        ayseninarabasi.Hiz = 100;
        Response.Write(ayseninarabasi.bilgiver());
        

    }
 
    protected void Button2_Click1(object sender, EventArgs e)
    {
        int s1 = Convert.ToInt32(sayi1kutu.Text);
        int s2 = Convert.ToInt32(sayi2kutu.Text);
        Hesaplama islem=new Hesaplama ();
        Response.Write("işlemin sonucu" + islem.toplam(s1,s2));
    }
    protected void Button3_Click(object sender, EventArgs e)
    {

        double[] rakamlar = { 6, 9, 87, 5, 45, 12, 32 };
        Hesaplama muhsin=new Hesaplama ();
   
        Response.Write("işlemin sonucu=" + muhsin.coklutoplam(rakamlar));
    }
}