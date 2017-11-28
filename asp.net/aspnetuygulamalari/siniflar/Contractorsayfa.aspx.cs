using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Contractorsayfa : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
      /* Araba tuncayinarabasi = new Araba();
        tuncayinarabasi.renk = "yeşil";
        tuncayinarabasi.marka = "ford";
        tuncayinarabasi.motorgucu = 1400;
        Response.Write(tuncayinarabasi.bilgiver());

        Araba kamilinarabasi = new Araba();
        Response.Write(kamilinarabasi.bilgiver());*/
   
        Araba suzanarabasi = new Araba("siyah", 2500, "alfa",5);
        suzanarabasi.hizlan();
        suzanarabasi.hizlan();
        suzanarabasi.hizlan(Convert.ToInt32(hiztext.Text));
        suzanarabasi.yavasla();
        suzanarabasi.yavasla(20);
    Response.Write(suzanarabasi.bilgiver());

      /*  Araba omerinarabasi = suzanarabasi;
        omerinarabasi.Setrenk("yeşil");
        Response.Write(omerinarabasi.Getrenk());
        omerinarabasi.Motorgucu = 1600;
       Response.Write("omerin arabası=" + omerinarabasi.bilgiver());
       Response.Write("suzanın arabası" + suzanarabasi.bilgiver());*/
    }
}