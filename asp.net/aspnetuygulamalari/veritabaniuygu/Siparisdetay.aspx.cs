using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
public partial class Siparisdetay : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int sipno = Convert.ToInt32(Request.QueryString["sipno"]);
        ArrayList siparisimiz = new Siparisdao().siparisleriniz(0, sipno);
        double toplamtutar = 0;
        foreach (Siparislik alinan in siparisimiz)
        {
            TableRow satir = new TableRow();
            for (int i = 0; i <= 3; i++)
            {
                TableCell hucre = new TableCell();
                hucre.BorderStyle = BorderStyle.Solid;
                hucre.BorderColor = System.Drawing.Color.Gray;
                hucre.BorderWidth = 1;
                satir.Cells.Add(hucre);
            }
            satir.Cells[0].Text = alinan.Urun.Urunadi;
            satir.Cells[1].Text = alinan.Adet.ToString(); 
            satir.Cells[2].Text = alinan.Urun.Fiyat.ToString();
            Image resim = new Image();
            resim.Height = 80;
            resim.Width = 80;
            resim.ImageUrl = "urunresim/" + alinan.Urun.Resim;
            satir.Cells[3].Controls.Add(resim);
            toplamtutar += alinan.Urun.Fiyat * alinan.Adet;
            Table1.Rows.Add(satir);
        }
        Label1.Text = "Bu siparişin toplamı=" + toplamtutar;
    }
}