using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class while3_derece_fah : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int derece = 0;
        double fah = 0;
        Response.Write("<table border=1>");
        Response.Write("<tr><td>Derece</td><td>Fahrenayt</td></tr>");
        while (derece <= 100)
        {
          
            fah = derece * 1.8 + 32;
          
            Response.Write("<tr><td>" + derece + "</td><td>" + fah + "</td></tr>");
            derece++;

        }
        Response.Write("</table>");
    }
}