using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class while2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int sayac = 0;
        while (sayac < 200)
        {
            sayac++;
            kackerelistesi.Items.Add(sayac.ToString());


        }
    }
    protected void kackerelistesi_SelectedIndexChanged(object sender, EventArgs e)
    {
        String bilgi = bilgikutusu.Text;
        int kackez = Convert.ToInt32(kackerelistesi.SelectedItem.Text);
        int sayac=0;
        Response.Write("<table border=1>");
        while (sayac < kackez)
        {
            sayac++;
            
            Response.Write("<tr><td>" + sayac + "</td><td>" + bilgi + "</td></tr>");
          
        }
        Response.Write("</table>");
    }
}