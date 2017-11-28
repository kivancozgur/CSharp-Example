using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class dizi1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        String[] arabalar = new String[5];
        arabalar[0] = "porş";
        arabalar[2] = "mersedes";
        arabalar[3] = "bemv";
        arabalar[4] = "reno";
       // Response.Write(arabalar[1]);
      /*  for (int i = 0; i < arabalar.Length; i++)
        {
Response.Write (arabalar[i] +"<br>");
        }*/
     /*   foreach (String alinan in arabalar)
        {
            Response.Write(alinan + "<br>");
        }*/
      //  Array.Clear(arabalar, 2, 2);
      //  Response.Write(arabalar[4]);
      //  Array.Reverse(arabalar);
       // Response.Write(arabalar[0]);
       // Array.Sort(arabalar);
     //   Response.Write(arabalar[3]);
      // Response.Write( Array.IndexOf(arabalar, "fiat"));

        int[] rakamlar = { 1, 5, 7, 9, 15 };
    }
}