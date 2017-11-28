using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Switch2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void sehirler_SelectedIndexChanged(object sender, EventArgs e)
    {
        ilceler.Items.Clear();
        int secilenil = Convert.ToInt32(sehirler.SelectedItem.Value);
        switch (secilenil)
        {
            case 16:
                ilceler.Items.Add("Yıldırım");
                ilceler.Items.Add("kestel");
                ilceler.Items.Add("nilüfer");
                break;
            case 6:
                ilceler.Items.Add("çankaya");
                ilceler.Items.Add("yenimahalle");
                break;
            case 34:
                ilceler.Items.Add("şişli");
                ilceler.Items.Add("üsküdar");
                break;
            default :
                Response.Write("lütfen bir il seçiniz");
                break;

        }//switch
    }
}