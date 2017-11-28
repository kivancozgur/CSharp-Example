using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class dizi4_enbuyukkucuknot : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            int[] notlar = new int[3];
            String[] isimler = new String[3];
            
            for (int i = 0; i < 3; i++)
            {
       isimler[i] = Microsoft.VisualBasic.Interaction.InputBox
                    (i + 1 + "öğrencinin ismini girin", "giriş", "", 100, 100);

 notlar[i] = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox
   (isimler[i] + " öğrencisinin notunu giriniz", "not girişi", "", 100, 100));
            }

            int enb = notlar[0];
            int enk = notlar[0];
            String kisim = isimler[0];
            String bisim = isimler[0];

            for (int i = 0; i < 3; i++)
            {
                if (enk > notlar[i])
                {
                    enk = notlar[i];
                    kisim = isimler[i];
                }

                if (enb < notlar[i])
                {
                    enb = notlar[i];
                    bisim = isimler[i];
                }
            }

            Response.Write("en büyük not" + enb + "ile " + bisim + "li öğrenciye aittir");
            Response.Write("en küçük not" + enk + "ile " + kisim + " li öğrenciye aittir");

        }//try

        catch (FormatException)
        {
            Response.Write("not için sayı girmeniz gerek");
        }
        catch (Exception)
        {
            Response.Write("bilinmeyen hata programcınızı arayın");
        }


    }
}