using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CrystalDecisions.CrystalReports.Engine;
using System.Data;
using System.Collections;
public partial class UyeRaporla : System.Web.UI.Page
{
    DataSet ds;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            ArrayList sehirlerimiz = new Sehirdao().tumsehirlerigetir();
            int i = 1;
            foreach (Sehirler alinansehir in sehirlerimiz)
            {
                sehirlist.Items.Add(alinansehir.Sehiradi);
                sehirlist.Items[i].Value = alinansehir.Plaka.ToString();
                i++;
            }


            ds = new Uyelerdao().uyeraporu(0, "", 1);
            yaz();
        }
    }
    protected void sehirlist_SelectedIndexChanged(object sender, EventArgs e)
    {
        ds = new Uyelerdao().uyeraporu(Convert.ToInt32(sehirlist.SelectedItem.Value), "", 0);
        yaz();
    }
    public void yaz()
    {
        ReportDocument rapor = new ReportDocument();
        rapor.Load(Server.MapPath("Uyeraporla.rpt"));
        rapor.SetDataSource(ds);
        raporgosterici.ReportSource = rapor;
    }
    protected void emailtext_TextChanged(object sender, EventArgs e)
    {
        ds = new Uyelerdao().uyeraporu(0, emailtext.Text , 0);
        yaz();
    }
    protected void tumuradio_CheckedChanged(object sender, EventArgs e)
    {
        ds = new Uyelerdao().uyeraporu(0, "", 1);
        yaz();
    }
}