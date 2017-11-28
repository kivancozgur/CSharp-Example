using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class if4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (bayanradio.Checked == true)
        {
            Response.Write("bayan seçili");
        }
        else if (bayradio.Checked == true)
        {
            Response.Write("bay seçili");
        }
        int sonuc = 3 ^ 3;
        Response.Write(sonuc);
    }
}