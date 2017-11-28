using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default6 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        for (int i=1;i<=10;i++)
  {
      TableRow satir = new TableRow();
      for (int j = 1; j <= 4; j++)
      {
          TableCell hucre = new TableCell();
          hucre.BorderStyle =BorderStyle.Solid;
          hucre.BorderWidth =1;
          if (j == 1) hucre.Text = "Urun" + j;
          if (j == 2) hucre.Text = (10 * i).ToString();
          if (j == 3)
          {
              TextBox kutu = new TextBox();
              kutu.ID = "adet" + i;
              hucre.Controls.Add(kutu);
          }
          if (j == 4)
          {
             HyperLink  link = new HyperLink();
             link.Text = "detay" + i;
              
              hucre.Controls.Add(link);
          }
          satir.Cells.Add(hucre);
      }
      Table1.Rows.Add(satir);


 }


    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int topadet = 0;
        int topfiy = 0;
        for (int i = 1; i <= 10; i++)
        {
            if (Request.Form["adet" + i] != "")
            {
                topadet = topadet + Convert.ToInt32(Request.Form["adet" + i].ToString());
                topfiy = topfiy + Convert.ToInt32(Request.Form["adet" + i].ToString())
                    *Convert.ToInt32(Table1.Rows[i].Cells[1].Text);
            }
        }
        Response.Write("toplam adet=" + topadet);
        Response.Write("toplam fiy=" + topfiy);
    }
}