using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        ArrayList arabalar = new ArrayList();
        arabalar.Add("porş");
        arabalar.Add("fiat");
        arabalar.Add("reno");
        arabalar.Add("kia");
        foreach (String alinan in arabalar)
        {
            Response.Write(alinan);
        }

    }
}