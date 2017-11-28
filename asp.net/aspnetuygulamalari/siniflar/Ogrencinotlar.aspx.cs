using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Ogrencinotlar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Ogrenci2 ogrenislemi = new Ogrenci2();
        String[] adlar = new String[2];
        int[] notlar = new int[3];
        String dersadi;

        for (int i = 0; i < 2; i++)//öğrenci adlarını alan ve clasa gönderen kısım
        {
            adlar[i] = Microsoft.VisualBasic.Interaction.InputBox
                ((i + 1) + ".öğrencinin adını girin", "", "", 100, 100);

        }
ogrenislemi.Adlar = adlar;

dersadi = Microsoft.VisualBasic.Interaction.InputBox("Ders adını girin", "", "", 100, 100);

for (int i = 0; i < 2; i++)
      {
 for (int j = 0; j < 3; j++)
         {
                notlar[j]=Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox
  (dersadi + "dersinden" +adlar[i] + "isimli öğrencinin"+(j+1) +". notunu girin","","",100,100));

            }
            ogrenislemi.Notlar = notlar;
            ogrenislemi.hesapla(i);

        }//dış for

     Response.Write(   ogrenislemi.sirala());
    }
}