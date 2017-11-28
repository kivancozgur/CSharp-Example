using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Collections;
public partial class sehirbilgisimvc : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
      /*  ArrayList sehirlistesi = new ArrayList();
        Sehirdao sehirisleri = new Sehirdao();
        sehirlistesi = sehirisleri.tumsehirlerigetir();*/

      ArrayList sehirlistesi = new Sehirdao().tumsehirlerigetir();
        int i = 0;
        foreach (Sehirler alinasehir in sehirlistesi)
        {
            DropDownList1.Items.Add(alinasehir.Sehiradi);
            DropDownList1.Items[i].Value = alinasehir.Plaka.ToString();
            i++;

        }

     
    }
}