using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
public partial class Sepetekle : System.Web.UI.Page
{
    ArrayList musterisepet = new ArrayList();
    double toplamfiyat = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["uyeid"] == null)
        {
            Response.Write("Bu sayfayı görebilmek için üye girişi yapınız<a href=uyekayit.aspx>uye olmak için tıklatınız</a>");
            Response.End();
        }
 ImageButton1.Attributes.Add("onClick", "return confirm('Siparişi Onaylıyormusunuz');");
 if (Page.IsPostBack == false)
 {
     for (int i = 0; i <= 3; i++)
     {
         Table1.Rows[0].Cells[i].BorderColor = System.Drawing.Color.Gray;
         Table1.Rows[0].Cells[i].BorderStyle = BorderStyle.Solid;
         Table1.Rows[0].Cells[i].BorderWidth = 1;
     }//for

     int urunid=Convert.ToInt32(Request.QueryString["urunid"]);
     Urun urun = new Urundao().tekurungetir(urunid);

   
   

     if (Session["sepet"] != null)//daha önceden sepet varsa
     {
         musterisepet = (ArrayList)Session["sepet"];
     }

     Boolean buldu = false;
     int j = 0;
     foreach (Object alinanurun in musterisepet)
     {
         if (((Sepetlik)alinanurun).Urun.Urunid == urunid)//sepete daha önceden varsa
         {
             buldu = true;
             ((Sepetlik)musterisepet[j]).Adet++;
         }
         j++;
     }

     if (buldu == false)//ürün daha önceden yoksa
     {
         Sepetlik yeniurun = new Sepetlik();
         yeniurun.Urun = urun;
         yeniurun.Adet = 1;
         musterisepet.Add(yeniurun);
     }

     Session["sepet"] = musterisepet;//sepet kaybolmasın die sessiona atılır

     yaz();

 }//if
    
    }//page load
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        if (Session["sepet"] != null)//daha önceden sepet varsa
        {
            musterisepet = (ArrayList)Session["sepet"];
        }
        int i=0;
        ArrayList silinecektorbasi = new ArrayList();
        foreach (Object alinanurun in musterisepet)
        {
String yeniadet=Request.Form["adet"+((Sepetlik)alinanurun).Urun.Urunid];
((Sepetlik)musterisepet[i]).Adet = Convert.ToInt32(yeniadet);

String silinecekid = Request.Form["sil" + ((Sepetlik)alinanurun).Urun.Urunid];
if (silinecekid == "on" || yeniadet == "")
{
    silinecektorbasi.Add(i);
}
i++;
        }

        foreach (int j in silinecektorbasi)
        {
            musterisepet.RemoveAt(j);
        }

        Session["sepet"] = musterisepet;
        yaz();
    }

    public void yaz()
    {
        foreach (Sepetlik alinanurun in musterisepet)
        {
            TableRow satir = new TableRow();
            for (int i = 0; i <= 3; i++)
            {
                TableCell hucre = new TableCell();
                hucre.BorderColor = System.Drawing.Color.Gray;
                hucre.BorderStyle = BorderStyle.Solid;
                hucre.BorderWidth = 1;
                satir.Cells.Add(hucre);
            }
            satir.Cells[0].Text = alinanurun.Urun.Urunadi;
            satir.Cells[1].Text = alinanurun.Urun.Fiyat.ToString();
            TextBox kutu = new TextBox();
            kutu.ID = "adet" + alinanurun.Urun.Urunid;
            kutu.Text = alinanurun.Adet.ToString();
            satir.Cells[2].Controls.Add(kutu);
            CheckBox silcek = new CheckBox();
            silcek.ID = "sil" + alinanurun.Urun.Urunid;
            satir.Cells[3].Controls.Add(silcek);
            Table1.Rows.Add(satir);
            toplamfiyat += alinanurun.Urun.Fiyat * alinanurun.Adet;
        }
        mesaj.Text = "Sepetimizi toplamı=" + toplamfiyat + "Tl";
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        musterisepet = (ArrayList)Session["sepet"];
        int sipno = new Siparisdao().siparisgec(musterisepet, Convert.ToInt32(Session["uyeid"]));
        Label1.Text = "Siparişiniz Alınmıştır.Sipno=" + sipno;
        yaz();
    }
}