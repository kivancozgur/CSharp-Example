using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
public partial class uyekayit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {int uyeid=0;
            if (Session["uyeid"]==null) uyeid = Convert.ToInt32(Request.QueryString["uyeid"]);
            else  uyeid=Convert.ToInt32(Session["uyeid"]);
            ViewState["uyeid"] = uyeid;
                Uye uye = new Uyelerdao().tekuyegetir(uyeid);
            kuladitext.Text = uye.Kuladi;
            sifre1.Text = uye.Sifre;
            sifre2.Text = uye.Sifre;
            adsoyad.Text = uye.Adsoyad;
            dogtar.Text = uye.Dogtar.ToShortDateString();
            adres.Text = uye.Adres;
            email.Text = uye.Email;
            if (uye.Cins == true) bayradio.Checked = true;
            else bayanradio.Checked = true;

            sehirler.Items[0].Text = uye.Sehir.Sehiradi;
            sehirler.Items[0].Value = uye.Sehir.Plaka.ToString();
            meslekler.Items[0].Text = uye.Meslek.Meslekad;
            meslekler.Items[0].Value = uye.Meslek.Meslekid.ToString();



            ArrayList sehirlerimiz = new Sehirdao().tumsehirlerigetir();
            int i = 1;
            foreach (Sehirler alinansehir in sehirlerimiz)
            {
                sehirler.Items.Add(alinansehir.Sehiradi);
                sehirler.Items[i].Value = alinansehir.Plaka.ToString();
                i++;
            }

            ArrayList mesleklerimiz = new Meslekdao().tummesleklerigetir();
            int j = 1;
            foreach (Meslek alinanmeslek in mesleklerimiz)
            {
                meslekler.Items.Add(alinanmeslek.Meslekad);
                meslekler.Items[j].Value = alinanmeslek.Meslekid.ToString();
                j++;
            }

        }

      
    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        dogtar.Text = Calendar1.SelectedDate.ToShortDateString();
        Calendar1.Visible = false;
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Calendar1.Visible = true;
    }
    protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
    {
        if (bayradio.Checked == false && bayanradio.Checked == false)
        {
            args.IsValid = false;
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int cins=0;
        if (bayradio.Checked) cins=-1;

        if (Page.IsValid == true)
        {
            Uyelerdao uyeisi = new Uyelerdao();
         int say=   uyeisi.uyedegistir(kuladitext.Text, sifre1.Text, adsoyad.Text, dogtar.Text,
cins, adres.Text, Convert.ToInt32(sehirler.SelectedValue), email.Text, 
Convert.ToInt32(meslekler.SelectedValue),Convert.ToInt32(ViewState["uyeid"]));
         if (say != 0) Response.Write("kayıt değiştirildi");
         else Response.Write("kayıt değiştirilmedi");
        }
    }
    protected void CustomValidator2_ServerValidate(object source, ServerValidateEventArgs args)
    {
        if (sifre1.Text.Length < 6)
        {
            args.IsValid = false;
        }
    }
}