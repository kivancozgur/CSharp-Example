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
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (kuladitext.Text.Equals("admin") && sifretext.Text.Equals("12345"))
        {
            MultiView1.ActiveViewIndex = 1;
        }
      
    }
  
    protected void Button4_Click1(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 0;
         Button4.Visible = false;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 2;
        int kisisayisi = Convert.ToInt32(kackisitext.Text);
        for (int i = 1; i <= kisisayisi; i++)
        {
            TableRow satir = new TableRow();
            for (int j = 1; j <= 2; j++)
            {
                TableCell hucre = new TableCell();
                hucre.BorderColor = System.Drawing.Color.Black;
                hucre.BorderStyle = BorderStyle.Solid;
                hucre.BorderWidth = 1;
                TextBox kutum = new TextBox();
                if (j == 1) kutum.ID = "ad" + i;
                if (j == 2) kutum.ID = "not" + i;
                    hucre.Controls.Add(kutum);
                satir.Cells.Add(hucre);
                }
            Table1.Rows.Add(satir);
            }

        }
    protected void Button3_Click(object sender, EventArgs e)
    {
        int toplam = Convert.ToInt32(Request.Form["not1"]);
        MultiView1.ActiveViewIndex = 3;
        int enb = Convert.ToInt32(Request.Form["not1"]);
       int enbindex = 1;
       int enk = Convert.ToInt32(Request.Form["not1"]);
       int enkindex = 1;
         int kisisayisi = Convert.ToInt32(kackisitext.Text);
         for (int i = 2; i <= kisisayisi; i++)
         {
             toplam += Convert.ToInt32(Request.Form["not" + i]);
             if (enb < Convert.ToInt32(Request.Form["not" + i]))
             {
                 enb = Convert.ToInt32(Request.Form["not" + i]);
                 enbindex = i;
             }
             if (enk > Convert.ToInt32(Request.Form["not" + i]))
             {
                 enk = Convert.ToInt32(Request.Form["not" + i]);
                 enkindex = i;
             }
         }//for
        Response.Write("en büyük not değeri=" + enb + "kişinin ismi" + Request.Form["ad"+enbindex]);
        Response.Write("en küçük not değeri=" + enk + "kişinin ismi" + Request.Form["ad" + enkindex]);
        Response.Write("ortalama=" + toplam / kisisayisi);
    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        TextBox1.Text = Calendar1.SelectedDate.ToShortDateString();
        Calendar1.Visible = false;
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Calendar1.Visible = true;
    }
}
