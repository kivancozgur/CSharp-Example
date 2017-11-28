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
      
   //Response.Write(adsoyad.Text);
        int sayi1;
        sayi1= 25;
        byte sayi2;
        sayi2 = 50;
        sayi1 = 100;
        sayi1= sayi1 + 43;
        sayi2 =Convert.ToByte(sayi2+ 20);
        String ad = "kamil";
       String sonuc = ad + sayi1;
        int toplam = sayi1 + sayi2;
        int x = 5;
        x = x + 1;
        x += 1;
        x -= 2;
        int y = 2;
        y *= 2;
        int z = 10;
        z /= 2;
        int son = (x + 2) * y + z;
        x = 100;
        son = 100 %15;
        x = x ^ 2;
        String w = "5";
        son = Convert.ToInt32(w) + 8;
        Response.Write(son);
        adsoyad.Text = toplam.ToString();
       
    }
   
}