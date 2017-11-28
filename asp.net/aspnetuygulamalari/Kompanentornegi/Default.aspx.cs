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
        Textkutusu text1 = new Textkutusu();
        kompanentekle(text1);
        Buton bu1 = new Buton();
        kompanentekle(bu1);
    }

    public void kompanentekle(Kompanent nesne)
    {
        Response.Write(nesne.cizdir());
    }
}