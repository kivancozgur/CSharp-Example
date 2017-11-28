using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        String yol=Server.MapPath("");
      String[] dosyalar=  Directory.GetFiles(yol);

      foreach (String alinan in dosyalar)
      {
          String dosyaadi = alinan.Substring(yol.Length+1);
          ListBox1.Items.Add(dosyaadi);
      }
    }
}