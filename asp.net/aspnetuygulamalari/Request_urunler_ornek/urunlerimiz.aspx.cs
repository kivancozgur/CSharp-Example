using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class urunlerimiz : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            String[] cepteller = { "Seçiniz", "nokia", "samsung", "lg", "iphone" };
            String[] guller = { "Seçiniz", "Kırmızı gül", "mor gül", "sarı gül", "beyaz gül" };
            String kateno = Request.QueryString["kateno"];
            switch (kateno)
            {
                case "11":
                    foreach (String alinan in cepteller)
                    {
                        DropDownList1.Items.Add(alinan);
                    }
                    Response.Write("Ana kategori Elektronik alt kategori=Cep tel");
                    break;
                case "21":
                    foreach (String alinan in guller)
                    {
                        DropDownList1.Items.Add(alinan);
                    }
                    Response.Write("Ana kategori çiçek alt kategori=Tek gül");
                    break;
            }
        }//if postback
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        String secim = DropDownList1.SelectedValue;
        if (secim.Equals("Kırmızı gül"))
        {
            Image1.ImageUrl = "img/kirmizi.jpg";
            Label1.Text = "29 tl";
        }
        else if (secim.Equals("samsung"))
        {
            Image1.ImageUrl = "img/samsung2.jpg";
            Label1.Text = "500 tl";
        }

    }
}