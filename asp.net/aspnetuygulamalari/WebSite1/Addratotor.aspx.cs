using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Addratotor : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int d = ((int)DateTime.Now.DayOfWeek);
        Response.Write(d);
   switch (d)
   {
       case 0:
           AdRotator1.KeywordFilter = "esite";
           break;
     
   }
    }
}