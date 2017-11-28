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
        ListBox1.Items.Add("urfa");
        ListBox1.Items[ListBox1.Items.Count-1].Value = "63";

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        //Response.Write(ListBox1.SelectedItem.Value);
        String sonuc = "";
        for (int i = 0; i < ListBox1.Items.Count; i++)
        {
            if (ListBox1.Items[i].Selected)
            {
                sonuc = sonuc + ListBox1.Items[i].Text;
            }
        }
        Response.Write(sonuc);
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
       // ListBox1.Items.RemoveAt(1);
       //Response.Write( ListBox1.Items.FindByText("mardinnn"));
    }
}