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
        Kedi cat1 = new Kedi();
        Response.Write(cat1.sescikar());
        Kopek dog1 = new Kopek();
        Response.Write(dog1.sescikar());
    }
}