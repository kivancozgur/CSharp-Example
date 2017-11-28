using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class if5_4islem : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int sayi1 = Convert.ToInt32(sayi1kutu.Text);
        int sayi2 = Convert.ToInt32(sayi2kutu.Text);
        if (toplaradio.Checked == true) 
        {
            int toplam = sayi1 + sayi2;
            Response.Write("sayılarımızın toplamı=" + toplam.ToString());
        }
        else if (cikarradio.Checked)
        {
            int fark = sayi1 - sayi2;
            Response.Write("sayılarımızın farkı=" + fark.ToString());
        }
        else if (carpradio.Checked)
        {
            int carp = sayi1 * sayi2;
            Response.Write("sayıların çarpımı=" + carp.ToString());
        }
        else
        {
            double  ustsonuc = Math.Pow(sayi1, sayi2);
            Response.Write("sonuç=" + ustsonuc.ToString());

        }
    }

}