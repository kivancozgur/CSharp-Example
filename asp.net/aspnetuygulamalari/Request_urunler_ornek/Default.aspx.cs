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

    }
    protected void kategorilistesi_SelectedIndexChanged(object sender, EventArgs e)
    {
        Altkategoriler.Items.Clear();
        int secim = Convert.ToInt32(kategorilistesi.SelectedValue);
        switch (secim)
        {
            case 1:
                Altkategoriler.Items.Add("Seçiniz");
                Altkategoriler.Items[0].Value = "0";
                Altkategoriler.Items.Add("Cep TEL");
                Altkategoriler.Items[1].Value = "11";
                   Altkategoriler.Items.Add("LCD TV");
                Altkategoriler.Items[2].Value = "12";
                break;
            case 2:
                Altkategoriler.Items.Add("Seçiniz");
                Altkategoriler.Items[0].Value = "0";
                Altkategoriler.Items.Add("Tek Gül");
                Altkategoriler.Items[1].Value = "21";
                Altkategoriler.Items.Add("Çelenk");
                Altkategoriler.Items[2].Value = "22";
                break;
        
        }
    }
    protected void Altkategoriler_SelectedIndexChanged(object sender, EventArgs e)
    {
        Response.Redirect("urunlerimiz.aspx?kateno=" + Altkategoriler.SelectedValue);
    }
}