using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cerez : System.Web.UI.Page
{
    HttpCookie cerezim= new HttpCookie("bilgi");
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
      
        cerezim["ad"]="tuncay";
        cerezim["soyad"]="salı";
       
      cerezim.Expires = DateTime.Now.AddYears(2);
        Response.Cookies.Add(cerezim);
      
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
       
         if (Request.Cookies["Bilgi"] != null)
	        {
           cerezim = Request.Cookies["Bilgi"];
	           Response.Write(cerezim["ad"] + cerezim["soyad"]);
        }
        else

            Response.Write("Bilgi bulunamadı");
	    }



    }
