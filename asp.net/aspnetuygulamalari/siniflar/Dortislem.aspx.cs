using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Dortislem : System.Web.UI.Page
{
    Islem islem = new Islem();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void toplaradio_CheckedChanged(object sender, EventArgs e)
    {
        islem.sayi1 = Convert.ToInt32(sayi1kutu.Text);
        islem.sayi2 = Convert.ToInt32(sayi2kutu.Text);
      Response.Write ("sayıların toplamı=" +  islem.hesaplama(1));
    }
    protected void cikarradio_CheckedChanged(object sender, EventArgs e)
    {
        islem.sayi1 = Convert.ToInt32(sayi1kutu.Text);
        islem.sayi2 = Convert.ToInt32(sayi2kutu.Text);
        Response.Write("sayıların toplamı=" + islem.hesaplama(2));
    }
    protected void carpradio_CheckedChanged(object sender, EventArgs e)
    {
        islem.sayi1 = Convert.ToInt32(sayi1kutu.Text);
        islem.sayi2 = Convert.ToInt32(sayi2kutu.Text);
        Response.Write("sayıların toplamı=" + islem.hesaplama(3));
    }
    protected void bolradio_CheckedChanged(object sender, EventArgs e)
    {
        islem.sayi1 = Convert.ToInt32(sayi1kutu.Text);
        islem.sayi2 = Convert.ToInt32(sayi2kutu.Text);
        Response.Write("sayıların toplamı=" + islem.hesaplama(4));
    }
}