using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
      String yol= Server.MapPath ("");
   //   Response.Write(yol);
    // Directory.CreateDirectory(yol + "/resim");
     // Directory.Delete(yol + "/resim");
     /* if (Directory.Exists(yol + "/resim") == true)
      {
          Response.Write("klaor var");
      }
      else
      {
          Response.Write("klasör yok");
      }*/

    /*  String[] klasorler = Directory.GetDirectories(yol);

      foreach (String alinan in klasorler)
      {
          ListBox1.Items.Add(alinan);
      }*/
   /*   String[] dosyalar = Directory.GetFiles(yol + "/img");
      foreach (String alinan in dosyalar)
      {
          ListBox1.Items.Add(alinan);
      }*/
        
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        String yol = Server.MapPath("");
        //File.Copy(yol + "/img/ana1.jpg", yol + "/resim/baba1.jpg");
        //File.Move(yol + "/img/ana1.jpg", yol + "/resim/ana1.jpg");
       // File.Delete(yol + "/resim/baba1.jpg");
       
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
}