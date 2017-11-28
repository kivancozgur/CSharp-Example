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
    protected void Radioyerli_CheckedChanged(object sender, EventArgs e)
    {
        ListBox1.Items.Clear();
        ListBox2.Items.Clear();
        String[] yerli = { "Tofaş", "doğan", "serçe", "şahin", "anadol" };
        foreach (String eleman in yerli)
        {
            ListBox1.Items.Add(eleman);

        }
    }
    protected void Radioyabanci_CheckedChanged(object sender, EventArgs e)
    {
        ListBox1.Items.Clear();
        ListBox2.Items.Clear();
        String[] yabanci= { "Porş", "mersedes", "jaguar", "jeep", "ford" };
        foreach (String eleman in yabanci)
        {
            ListBox1.Items.Add(eleman);

        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {

       String[] siliencekler = new String[ListBox1.Items.Count];
        for (int i = 0; i < ListBox1.Items.Count; i++)
        {
            if (ListBox1.Items[i].Selected)
            {
                ListBox2.Items.Add(ListBox1.Items[i].Text);
            siliencekler[i] = ListBox1.Items[i].Text;
              
            }
        }//

     foreach (String silinecek in siliencekler)
        {
            ListBox1.Items.Remove(silinecek);
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        String[] siliencekler = new String[ListBox2.Items.Count];
        for (int i = 0; i < ListBox2.Items.Count; i++)
        {
            if (ListBox2.Items[i].Selected)
            {
                ListBox1.Items.Add(ListBox2.Items[i].Text);
                siliencekler[i] = ListBox2.Items[i].Text;

            }
        }//

        foreach (String silinecek in siliencekler)
        {
            ListBox2.Items.Remove(silinecek);
        }
    }
}