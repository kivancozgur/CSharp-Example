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

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Page.IsValid == false)
        {
            Response.Write("sayfa doğrulamadı veritabanına kayıt yapılamıyor");

        }else
        {
            Response.Write("kayıt yapıldı");
        }
    }
    protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
    {
        if (sifre1kutu.Text.Length < 6)
        {
            args.IsValid = false;
        }
        else
        {
            args.IsValid = true;
        }
    }
}