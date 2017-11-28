using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
public partial class Urunler : System.Web.UI.Page
{
    int kateno;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["uyeid"] == null)
        {
 Response.Write("Bu sayfayı görebilmek için üye girişi yapınız<a href=uyekayit.aspx>uye olmak için tıklatınız</a>");
            Response.End();
        }

     kateno = Convert.ToInt32(Request.QueryString["kateno"]);
        int sayfano;
        if (Request.QueryString["sayfano"] == null)
        {
            sayfano = 1;
        }
        else
        {
            sayfano = Convert.ToInt32(Request.QueryString["sayfano"]);
        }
        int baslangicyeri = (sayfano - 1) * 9;
        ArrayList urunler = new Urundao().urungetir(baslangicyeri, kateno);

        int i = 0;
        int j = 0;
        foreach (Urun alinanurun in urunler)
        {
            Image resim = new Image();
            resim.ImageUrl = "urunresim/" + alinanurun.Resim;
            resim.Height = 80;
            resim.Width = 80;
            Table1.Rows[i].Cells[j].Controls.Add(resim);
             Table1.Rows[i].Cells[j].Controls.Add(new LiteralControl("<br>Ürünadi:" +
                 alinanurun.Urunadi +"<br>Fiyatı:" + alinanurun.Fiyat + "<br>"));
             HyperLink link = new HyperLink();
             link.ImageUrl = "img/sepete_ekle.jpg";
           //  link.NavigateUrl = "sepetekle.aspx?urunid=" + alinanurun.Urunid;
             link.Attributes.Add("onclick", "return GB_showCenter('SEPETİNİZ','../sepetekle.aspx?urunid=" + alinanurun.Urunid + "',600,600);");
             Table1.Rows[i].Cells[j].Controls.Add(link);
             j++;
             if (j % 3 == 0)
             {
                 j = 0;
                 i++;
                 if (i == 3) break;
             }
        }
        sayfala(sayfano);
    }

    public void sayfala(int sayfano)
    {
        int toplamkayit = new Urundao().urunsayisi(kateno);
        int toplamsayfa;
        if (toplamkayit % 9 == 0)
        {
            toplamsayfa = toplamkayit / 9;
        }
        else
        {
            toplamsayfa = toplamkayit / 9 + 1;
        }

        String yazimiz = "Sayfalar--->";
        if (sayfano > 1)
        {
            yazimiz = yazimiz + "<a href=urunler.aspx?sayfano=" + (sayfano - 1) + "&kateno=" +
            kateno + "><img src=img/once.gif height=20 witdh=20></a>";
        }

        for (int i = 1; i <= toplamsayfa; i++)
        {
            if (sayfano == i) yazimiz += "<b><i>" + i + "</i></b>";
            else yazimiz += "<a href=urunler.aspx?sayfano=" + i +
                "&kateno=" + kateno + ">" + i + "</a>";
        }

        if (sayfano < toplamsayfa)
        {
            yazimiz = yazimiz + "<a href=urunler.aspx?sayfano=" + (sayfano + 1) + "&kateno=" +
           kateno + "><img src=img/sonra.gif height=20 witdh=20></a>";
        }
        Label1.Text = yazimiz;
    }
}