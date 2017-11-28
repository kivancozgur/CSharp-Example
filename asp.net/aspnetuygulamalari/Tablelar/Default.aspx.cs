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
        TableRow satir = new TableRow();
        TableCell hucre = new TableCell();
        hucre.BorderColor = System.Drawing.Color.Black;
        hucre.BorderStyle = BorderStyle.Solid;
        hucre.BorderWidth = 1;
        hucre.Text = "zehra";
        satir.Cells.Add(hucre);
        Table1.Rows.Add(satir);
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        for (int i = 1; i <= 10; i++)
        {
            TableRow satir = new TableRow();
            for (int j = 1; j <= 2; j++)
            {
                TableCell hucre = new TableCell();
                hucre.BorderColor = System.Drawing.Color.Black;
                hucre.BorderStyle = BorderStyle.Solid;
                hucre.BorderWidth = 1;
                TextBox kutum = new TextBox();
                kutum.ID = "ad" + i + j;
                hucre.Controls.Add(kutum);
                satir.Cells.Add(hucre);
            }
            Table1.Rows.Add(satir);


        }
        Table1.Rows[0].Cells[2].Text 
    }
}