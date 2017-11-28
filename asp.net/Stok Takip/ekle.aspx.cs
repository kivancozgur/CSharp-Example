using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ekle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        int deger;
        deger = SqlDataSource1.Insert();

        if (deger > 0)
        {
            Label1.Text = "Kayıt Başarılı";
        }
        else
            Label1.Text = "Kayıt Yapılamadı Tekrar Deneyin.!";
            Response.Redirect("kitap.aspx");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        TextBox1.Text = "";//Textbox1 in içeriği silinir.
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox1.Focus();//İmleci Textbox1 e getirmek için kullanılır.
        Label1.Text = "";
    }
}