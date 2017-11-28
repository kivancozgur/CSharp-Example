using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class table : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        TableRow satir = new TableRow();
        TableCell hucre = new TableCell();
        hucre.BorderStyle = BorderStyle.Solid;
        hucre.BorderColor = System.Drawing.Color.Black;
        hucre.BorderWidth = 1;
        satir.Cells.Add(hucre);
        Table1.Rows.Add(satir);
    }
}