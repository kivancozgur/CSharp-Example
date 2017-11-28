using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class islem : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int sayi1 = Convert.ToInt32(sayi1kutu.Text);
        int sayi2 = Convert.ToInt32(sayi2kutu.Text);
        int toplam;
        toplam = sayi1 + sayi2;
        Response.Write(toplam.ToString());
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        int sayi1 = Convert.ToInt32(sayi1kutu.Text);
        int sayi2 = Convert.ToInt32(sayi2kutu.Text);
        int fark = sayi1 - sayi2;
        Response.Write("sayiların farkı=" + fark.ToString());
    }
    protected void Carpmabutonu_Click(object sender, EventArgs e)
    {
        int sayi1 = Convert.ToInt32(sayi1kutu.Text);
        int sayi2 = Convert.ToInt32(sayi2kutu.Text);
        int carpim = sayi1 * sayi2;
        Response.Write("sayıların çarpımı=" + carpim.ToString());
    }
}