using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class if2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int notdegeri = Convert.ToInt32(notkutusu.Text);
        
        if (notdegeri >= 0 && notdegeri <= 100)
        {
            if (notdegeri >= 45)
            {
                Response.Write("geçtiniz");
            }//ifin bitişi
            else
            {
                Response.Write("kaldınız");
            }//else in bitişi

        }//ilk if bitişi
        else
        {

    Response.Write("not değeri 0 ila 100 arasında olmalı geçersiz not");
        }

    }// buton click bitişi
}