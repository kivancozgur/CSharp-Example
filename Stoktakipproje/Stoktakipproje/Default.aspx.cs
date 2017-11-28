using System;

using System.Configuration;

using System.Data;

using System.Web;

using System.Web.Security;

using System.Web.UI;

using System.Web.UI.HtmlControls;

using System.Web.UI.WebControls;

using System.Web.UI.WebControls.WebParts;



public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!Page.IsPostBack)
        {

            DataTable dt = new DataTable();

            dt.Columns.Add("UrunAdi");

            dt.Columns.Add("Miktar");

            DataRow drow = dt.NewRow();

            drow["UrunAdi"] = "Seçiniz";

            drow["Miktar"] = "0";

            dt.Rows.Add(drow);

            Session["Dt"] = dt;

            rptMain.DataSource = Session["Dt"];

            rptMain.DataBind();

        }
    }

    protected void rptMain_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "Add")
        {

            DataTable dt = (DataTable)Session["Dt"];

            DataRow drow = dt.NewRow();

            drow["UrunAdi"] = ((DropDownList)e.Item.FindControl("DrpUrunList")).SelectedItem.Text;

            drow["Miktar"] = ((TextBox)e.Item.FindControl("txtMiktar")).Text;

            dt.Rows.Add(drow);

            Label1.Text = "İşlem yapılacak toplam adet : " + dt.Rows.Count.ToString();

            rptMain.DataSource = Session["Dt"];

            rptMain.DataBind();

        }
        else if (e.CommandName == "Delete")
        {

            DataTable dt = (DataTable)Session["Dt"];

            dt.Rows.RemoveAt(0);

            rptMain.DataSource = Session["Dt"];

            rptMain.DataBind();

        }
    }

    private void DrplistUrunler(DropDownList drp)
    {
        for (int i = 0; i < 5; i++)
        {
            ListItem li = new ListItem("ÜRÜN ADI", "1");
            drp.Items.Add(li);
        }
    }

    protected void rptMain_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {

        DropDownList drp1 = (DropDownList)e.Item.FindControl("DrpUrunList");

        if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
        {

            DrplistUrunler(drp1);

        }
    }
}