using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
public partial class _Default : System.Web.UI.Page
{
    Takipdao takipisleri = new Takipdao();
    protected void Page_Load(object sender, EventArgs e)
    {
        Connectionyapici.baglantiyagec();
    }

    protected void Kaydetbtn_Click(object sender, EventArgs e)
    {
       /* int sayi= */takipisleri.stokkaydet(Uruntext.Text,Convert.ToInt32(Adettext.Text));
        
          /* if (sayi != 0)
        {
            Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Başlık", "<script>alert('Kayıt Başarıyla Kaydedildi');</script>");
        }

        else Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Başlık", "<script>alert('Kayıt Kaydedilirken Hata Oluştu');</script>");*/
           Page.Response.Redirect(Page.Request.Url.ToString(), true);
    }

       
       
    protected void Silbtn_Click(object sender, EventArgs e)
    {
        /*int sayi = */takipisleri.stoksil(Uruntext.Text);
       /* if (sayi != 0)
        {
            Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Başlık", "<script>alert('Kayıt Başarıyla Silindi');</script>");
            takiplistesi = takipisleri.tumstogugetir();
        }

        else Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Başlık", "<script>alert('Kayıt Silinirken Hata Oluştu');</script>");*/
        Page.Response.Redirect(Page.Request.Url.ToString(), true);
    }
}