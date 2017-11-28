using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using CrystalDecisions.CrystalReports.Engine;
public partial class Siparisraporum : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataSet ds = new Siparisdao().siparisrapor();
        ReportDocument rapor = new ReportDocument();
        rapor.Load(Server.MapPath("Siparisraporu.rpt"));
        rapor.SetDataSource(ds);
        raporgosterici.ReportSource = rapor;
    }
}