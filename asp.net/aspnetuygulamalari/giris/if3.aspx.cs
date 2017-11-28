using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class if3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int notdegeri = Convert.ToInt32(notkutusu.Text);
        if (notdegeri >= 0 && notdegeri <= 5)
        {
            if (notdegeri == 5)
            {
                Response.Write("pekiyi");
            }
            else if (notdegeri == 4)
            {
                Response.Write("iyi");
            }
            else if (notdegeri == 3)
            {
                Response.Write("orta");
            }
            else if (notdegeri == 2)
            {
                Response.Write("geçer");
            }
            else if (notdegeri == 0 || notdegeri == 1)
            {
                Response.Write("kaldın");
            }
        }//il if bitişi
        else
        {
            Response.Write("not değeri 0 ila 5 arasında olmalıdır");
        }
    }
}