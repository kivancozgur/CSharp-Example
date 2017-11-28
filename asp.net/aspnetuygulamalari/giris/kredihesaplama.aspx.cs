using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class kredihesaplama : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void kreditip_SelectedIndexChanged(object sender, EventArgs e)
    {
        vade.Items.Clear();
        int secim = Convert.ToInt32(kreditip.SelectedValue);
            switch (secim)
            {
                case 1:
                    for (int i = 1; i <= 36; i++)
                    {
                        vade.Items.Add(i.ToString());
                    }
                    break;
                case 2:
                    for (int i = 1; i <= 120; i++)
                    {
                        vade.Items.Add(i.ToString());
                    }
                    break;
                case 3:
                    for (int i = 1; i <= 60; i++)
                    {
                        vade.Items.Add(i.ToString());
                    }
                    break;
               
            }//switch
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        double  toplamtutar;
        double ayliktaksit;
        double oran;
        double carpan;
        double faizoran=0;
        int vadedeger = Convert.ToInt32(vade.SelectedValue);
        int secim = Convert.ToInt32(kreditip.SelectedValue);
        switch (secim)
        {
            case 1:
                faizoran = 1.3;
                break;
            case 2:
                faizoran = 0.8;
                break;
            case 3:
                faizoran = 1.1;
                break;

        }//switch
        oran = ((vadedeger + 1) / 2) * faizoran;
        carpan = oran / 100 + 1;
        ayliktaksit = (Convert.ToInt32(kredimiktar.Text) * carpan) / vadedeger;
        toplamtutar = ayliktaksit * vadedeger;
        ayliktext.Text = ayliktaksit.ToString();
        toplamtext.Text = toplamtutar.ToString();
        faizorantext.Text = faizoran.ToString();

        Response.Write ("<table border=1>");
        Response.Write("<tr><td>Ödeme Tarihi</td><td>Aylik Taksit</td><td>Kalan miktar</td></tr>");
        DateTime tarih=DateTime.Now ;
        for (int i = 1; i <= vadedeger; i++)
        {

   Response.Write("<tr><td>" + tarih.AddMonths(i).ToShortDateString() + "</td><td>" +
     ayliktaksit.ToString () + "</td><td>" + (toplamtutar -(ayliktaksit*i)) + "</td></tr>" );

        }

        Response.Write("</table>");
    }


   
}