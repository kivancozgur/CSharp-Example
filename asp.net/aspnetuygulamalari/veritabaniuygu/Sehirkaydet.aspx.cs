using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Sehirkaydet : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Sehirdao sehirisleri = new Sehirdao();
        try
        {
            int s = sehirisleri.sehirkaydet(Convert.ToInt32(plakatext.Text), sehiradtext.Text);
            if (s == 1) Response.Write("kayıt yapıldı");
            else Response.Write("kayıt yapılamadı");
        }
        catch(FormatException)
        {
            Response.Write("plaka sayı olmalı");
        }

    }
}