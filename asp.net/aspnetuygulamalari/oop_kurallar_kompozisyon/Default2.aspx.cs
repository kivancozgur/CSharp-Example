using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Ogrenci[] ogrenciler = new Ogrenci[3];

        for (int i = 0; i < 3; i++)//b,lgileri aldık
        {
            Ogrenci ogr = new Ogrenci();
            ogr.Ogno = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox
                ((i + 1) + ".öğrenci nosunu girin", "", "", 100, 100));
            ogr.Adsoyad = Microsoft.VisualBasic.Interaction.InputBox
                ((i + 1) + ".öğrenci ad soyadını girin", "", "", 100, 100);
            Adres adres = new Adres();
            adres.Cadde = Microsoft.VisualBasic.Interaction.InputBox
                ((i + 1) + ".öğrencinin cadde adını girin", "", "", 100, 100);
            adres.Ilce = Microsoft.VisualBasic.Interaction.InputBox
                ((i + 1) + ".öğrencinin ilcesini girin", "", "", 100, 100);
            adres.Il = Microsoft.VisualBasic.Interaction.InputBox
                ((i + 1) + ".öğrencinin ilini girin", "", "", 100, 100);
            ogr.Adres = adres;

            ogrenciler[i] = ogr;
        }

        int arananno = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox
                ("Aradığınız öğrencinin nosunu girin", "", "", 100, 100));

        bool kontrol=false;
        for (int i = 0; i < 3; i++)
        {
            if (ogrenciler[i].Ogno == arananno)
            {
                Response.Write(ogrenciler[i].bilgial());
                kontrol = true;
                break;
            }

        }//ikinci for

        if (kontrol == false) Response.Write("bu numaralı kayıt yok");
    }
}