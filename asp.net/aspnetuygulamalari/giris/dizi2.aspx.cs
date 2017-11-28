using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class dizi2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int[,] matris=new int[3,2];
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                matris[i, j] =Convert.ToInt32
  (Microsoft.VisualBasic.Interaction.InputBox("sayi gir", "bilgi girişi", "", 100, 100));

            }//ikinci for

        }//ilk for

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                TextBox1.Text =TextBox1.Text + matris[i, j].ToString();
               
            }
            TextBox1.Text = TextBox1.Text + "\n";
        }
    }
}