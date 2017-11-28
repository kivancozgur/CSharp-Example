using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
public partial class dosya_klasor : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        String yol = Server.MapPath("");
        Response.Write(yol);
      //Directory.CreateDirectory(yol +"/resim");
      //Directory.Delete(yol + "/resim");
      //  Response.Write(Directory.GetCreationTime(yol + "/resim"));
        if (Directory.Exists(yol + "/resim") == true)
        {
            Response.Write("var");
        }
        else
        {
            Response.Write("yok");
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    { String yol = Server.MapPath("");
   // File.Copy(yol + "/img/4.jpg", yol + "/resim/6.jpg");
   // File.Delete(yol + "/resim/6.jpg");
    File.Move(yol + "/img/4.jpg", yol + "/resim/4.jpg");
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        String yol = Server.MapPath("");
       /* String[] klasorler = Directory.GetDirectories(yol);
        foreach (String alinan in klasorler)
        {
            ListBox1.Items.Add(alinan);
        }*/
        String[] dosyalar = Directory.GetFiles(yol);
         foreach (String alinan in dosyalar)
        {
            ListBox1.Items.Add(alinan);
        }
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        String yol = Server.MapPath("");
     String secilen=   ListBox1.SelectedItem.Text;
        Response.Write(secilen.Substring(yol.Length+1));
    }
}