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
       // Araba benimarabam = new Araba();
       // benimarabam.
        Subaru impreza = new Subaru("impreza", 2009, "benzin","heçbek");
     //   Arac arc1 = new Arac();
        Subaru forester = new Subaru();
    }
}