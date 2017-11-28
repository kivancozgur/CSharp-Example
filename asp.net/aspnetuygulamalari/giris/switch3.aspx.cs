using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class switch3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void islemlistesi_SelectedIndexChanged(object sender, EventArgs e)
    {
        Panelucgen.Visible = false;
        paneldaire.Visible = false;
        Panelkare.Visible = false;
        Button1.Visible = true;
        int secim = Convert.ToInt32(islemlistesi.SelectedValue);
        switch (secim)
        {
            case 1:
                Panelkare.Visible = true;
                break;
            case 2:
                Panelucgen.Visible = true;
                break;
            case 3:
                paneldaire.Visible = true;
                break;
            default:
                Button1.Visible = false;
                break;

        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int secim = Convert.ToInt32(islemlistesi.SelectedValue);
        switch (secim)
        {
            case 1:
                int a = Convert.ToInt32(karekutu.Text);
              double sonuc = Math.Pow(a, 2);
                Response.Write("kare alanı=" + sonuc.ToString());
                break;
            case 2:
                int taban = Convert.ToInt32(ucgentabankutu.Text);
                int yukseklik = Convert.ToInt32(ucgenyukseklikkutu.Text);
                int s = (taban * yukseklik) / 2;
                Response.Write("üçgen alanı=" + s.ToString());
                break;
            case 3:
                int yarcap = Convert.ToInt32(yaricapkutu.Text);
                double dairesonuc=Math.PI*yarcap*yarcap;
                Response.Write("daire alanı=" + dairesonuc.ToString());
                break;
        }
    }
}