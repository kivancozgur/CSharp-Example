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
        
        if (Page.IsPostBack == false)//sayfa ilk kez yüklendiğinde üretim ve hak veriliyor
        {
            Random uret = new Random();
            int sayi = uret.Next(1, 50);
            Response.Write(sayi);
            Session["sayi"] = sayi;
            Session["hak"] = 5;
        }
        yaz();
        if (Session["end"] != null)
        {
            Response.Write("hakkın bitti kardeş yeni oturum aç");
            Response.End();
        }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
       //tahmin eden kişi tespit ve artım
        if (Application["tahminkisi"] == null)
        {
            Application["tahminkisi"] = 1;
            yaz();
        }
        else
        {
            if (Session["kontrol"] == null)
            {
                int tahkisi = int.Parse(Application["tahminkisi"].ToString());
                tahkisi++;
                Application["tahminkisi"] = tahkisi;
                yaz();
            }
        }
        Session["kontrol"] = "ok";
        //tahmin bölümü

        int tahmin = Convert.ToInt32(tahmintext.Text);
        if (tahmin == Convert.ToInt32(Session["sayi"].ToString()))
        {
            Response.Write(Session["hak"] + ". hakknızda bildiniz");

            if (Application["bilenkisi"] == null)
            {
                Application["bilenkisi"] = 1;
                yaz();
            }
            else
            {
                int bilkisi = int.Parse(Application["bilenkisi"].ToString());
                bilkisi++;
                Application["bilenkisi"] = bilkisi;
                yaz();

            }//else
        }//bilirse if

        if (tahmin > Convert.ToInt32(Session["sayi"].ToString()))
        {
            Response.Write("tahmininiz büyük küçültün");
            Session["hak"] = Convert.ToInt32(Session["hak"].ToString()) - 1;
        }
        else if (tahmin < Convert.ToInt32(Session["sayi"].ToString()))
        {
            Response.Write("tahmininiz küçük Büyültün");
            Session["hak"] = Convert.ToInt32(Session["hak"].ToString()) - 1;
        }

        if (Convert.ToInt32(Session["hak"].ToString()) == 0)
        {
            
            Session["end"] = "ok";
        }


    }//buton click

    void yaz()
    {
        Label1.Text = "tahmin eden kişi sayısı=" + Application["tahminkisi"];
        Label2.Text = "Bilen kişi sayısı=" + Application["bilenkisi"];
    }
}