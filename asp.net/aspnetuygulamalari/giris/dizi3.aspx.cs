using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class dizi3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        String[][] aile = new String[3][];
        aile[0] = new String[] { "ahmet tokmak", "ayşe tokmak" };
        aile[1] = new String[] { "bart simsın", "cart simsın", "kart simsın" };
        aile[2] = new String[] { "hayrullah", "seyfullah", "emurallulah", "eyvallah" };

        for (int i = 0; i < aile[0].Length; i++)
        {
            ListBox1.Items.Add(aile[0][i]);

        }
        for (int i = 0; i < aile[1].Length; i++)
        {
            ListBox2.Items.Add(aile[1][i]);

        }
        for (int i = 0; i < aile[2].Length; i++)
        {
            ListBox3.Items.Add(aile[2][i]);

        }
    }
}