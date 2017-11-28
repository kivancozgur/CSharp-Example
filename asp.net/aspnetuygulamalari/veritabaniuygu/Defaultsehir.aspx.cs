using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
public partial class Defaultsehir : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {

    SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\deneme.mdf;Integrated Security=True;User Instance=True");
            baglanti.Open();
            SqlCommand komut = new SqlCommand();
            SqlDataReader oku;
            komut.Connection = baglanti;
            komut.CommandText = "select * from sehirler order by sehiradi asc";
            oku = komut.ExecuteReader();
            int i = 0;
            while (oku.Read())
            {
                DropDownList1.Items.Add(oku["sehiradi"].ToString());
                DropDownList1.Items[i].Value = oku["plaka"].ToString();
                i++;
            }
            oku.Close();
            baglanti.Close();
        }
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Response.Write(DropDownList1.SelectedValue);

    }
}