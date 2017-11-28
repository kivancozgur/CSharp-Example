using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Switch1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int notdegeri = Convert.ToInt32(notkutu.Text);
        switch (notdegeri)
        {
            case 5:
                Response.Write("pekiyi");
                break;
            case 4:
                Response.Write("iyi");
                break;
            case 3:
                Response.Write("orta");
                break;
            case 2:
                Response.Write("geçer");
                break;
            case 1:
                Response.Write("kaldın");
                break;
            case 0:
                Response.Write("kaldın");
                break;
            default :
                Response.Write("yanlış not degeri");
                break;
        }//switch
    }
}