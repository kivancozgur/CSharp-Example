using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
public partial class Ziyaretci : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
       


        if (Session["adsoyad"] == null)
        {
            mesaj.Text = "hoşgeldin misafir ziyaretçi";
        }
        else
        {
            HyperLink3.Visible = true;
       
            mesaj.Text = "Hoşgeldiniz " + Session["adsoyad"];
        }

        if (Page.IsPostBack == false)
        {
            ArrayList kategorilistesi = new Kategoridao().tumkategorilerigetir();
            foreach (Kategori alinankate in kategorilistesi)
            {
                MenuItem men = new MenuItem();
                men.Text = alinankate.Kateadi;
                men.NavigateUrl = "urunler.aspx?kateno=" + alinankate.Kateno;
                Menu1.Items.Add(men);
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Uye uye = new Uyelerdao().uyegiriskontrol(kuladitext.Text, sifretext.Text);

        if (uye.Uyeid != 0)
        {
            Session["adsoyad"] = uye.Adsoyad;
            mesaj.Text = "hoşgeldin" + uye.Adsoyad;
            Session["uyeid"] = uye.Uyeid;
            HyperLink3.Visible = true;
        }
        else
        {
            mesaj.Text = "kullanıcı adı veya şifren yanlış";
        }

    }
}
