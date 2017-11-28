using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Staticdegisken : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Personel p1 = new Personel("tuncay salı", 35);
        Personel p2 = new Personel("kamil abi", 45);
        Personel p3 = new Personel();
        Response.Write("personel sayısı=" + Personel.sayac);
        
    }
}