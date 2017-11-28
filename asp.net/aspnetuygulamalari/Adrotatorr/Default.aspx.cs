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
     int gun=(int)DateTime.Now.DayOfWeek;
     switch (gun)
     {
         case 2:
             AdRotator1.KeywordFilter = "esite";
             break;

     }
    }
}