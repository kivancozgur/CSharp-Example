using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
public partial class Siparisleriniz : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ArrayList siparisler = 
            new Siparisdao().siparisleriniz(Convert.ToInt32(Session["uyeid"]),0);
    
        foreach (Siparislik alinanlar in siparisler)
        {
            TableRow satir = new TableRow();
            for (int i = 0; i <= 2; i++)
            {
                TableCell hucre = new TableCell();
                hucre.BorderStyle = BorderStyle.Solid;
                hucre.BorderColor = System.Drawing.Color.Gray;
                hucre.BorderWidth = 1;
                satir.Cells.Add(hucre);
            }
            satir.Cells[0].Text = alinanlar.Sipno.ToString();
            satir.Cells[1].Text = alinanlar.Sip_tarihi.ToShortDateString();
            HyperLink link = new HyperLink();
            link.Text = "detay";
            link.ToolTip = "detay için tıklayınız";
           // link.NavigateUrl = "siparisdetay.aspx?sipno=" + alinanlar.Sipno;
            link.Attributes.Add("onclick", "return GB_showCenter('Sİpariş detay','../Siparisdetay.aspx?sipno=" + alinanlar.Sipno+ "',600,600);");
            satir.Cells[2].Controls.Add(link);
            Table1.Rows.Add(satir);
        }
    }
}