using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        int sec =Convert.ToInt32( DropDownList1.SelectedValue);
        switch (sec)
        {
            case 1:
                DropDownList2.Items.Add("Seçiniz");
                DropDownList2.Items[0].Value = "0";
                DropDownList2.Items.Add("Cep Tel");
                DropDownList2.Items[1].Value = "11";
                DropDownList2.Items.Add("TV");
                DropDownList2.Items[2].Value = "12";
                break;

        }
    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        Response.Redirect("default5.aspx?kateno=" + DropDownList2.SelectedValue);
    }
}