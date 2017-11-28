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
        Tavuk tav1 = new Tavuk();
        Elma elma1 = new Elma();
        Amasyaelması amasya1 = new Amasyaelması();
        Aslan as1 = new Aslan();
        Object[] objeler = new Object[4];
        objeler[0] = tav1;
        objeler[1] = elma1;
        objeler[2] = amasya1;
        objeler[3] = as1;
        foreach (Object alinan in objeler)
        {
            if (alinan is Yenilebilir)
            {
                Response.Write(((Yenilebilir)alinan).nasilyenilir());
            }
            if (alinan is Suyucikarilir)
            {
                Response.Write(((Suyucikarilir)alinan).nasilsuyucikarilir());
            }
        }
    }
}