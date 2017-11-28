using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
public partial class Uyegoster : System.Web.UI.Page
{
    ArrayList uyelerlistesi = new ArrayList();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            
            uyelerlistesi = new Uyelerdao().tumuyelerigetir();

            yaz();
        }
    }
    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        int secim = Convert.ToInt32(RadioButtonList1.SelectedValue);
        emailtext.Visible = false;
        Sehirlistesi.Visible = false;
    
        switch (secim)
        {
            case 1:
                emailtext.Visible = true;
                break;
            case 2:
                Sehirlistesi.Visible = true;
                ArrayList sehirlerimiz = new Sehirdao().tumsehirlerigetir();
                int i = 1;
                foreach (Sehirler alinansehir in sehirlerimiz)
                {
                    Sehirlistesi.Items.Add(alinansehir.Sehiradi);
                    Sehirlistesi.Items[i].Value = alinansehir.Plaka.ToString();
                    i++;
                }
                break;
            case 0:

                uyelerlistesi = new Uyelerdao().tumuyelerigetir();
        yaz();
        break;

        }
    }
    protected void emailtext_TextChanged(object sender, EventArgs e)
    {
       
       
      
        uyelerlistesi = new Uyelerdao().kriteregoregetir(emailtext.Text,0);
        yaz();
       
    }
    public void yaz()
    {
        int i = 1;
        foreach (Uye alinanuye in uyelerlistesi)
        {
            TableRow satir = new TableRow();

            for (int j = 1; j <= 9; j++)
            {
                TableCell hucre = new TableCell();
                hucre.BorderStyle = BorderStyle.Solid;
                hucre.BorderWidth = 1;
                satir.Cells.Add(hucre);

            }
            Table1.Rows.Add(satir);
            Table1.Rows[i].Cells[0].Text = alinanuye.Uyeid.ToString();
            Table1.Rows[i].Cells[1].Text = alinanuye.Adsoyad;
            Table1.Rows[i].Cells[2].Text = alinanuye.Kuladi;
            Table1.Rows[i].Cells[3].Text = alinanuye.Dogtar.ToShortDateString();
            if (alinanuye.Cins == true) Table1.Rows[i].Cells[4].Text = "bay";
            if (alinanuye.Cins == false) Table1.Rows[i].Cells[4].Text = "bayan";
            Table1.Rows[i].Cells[5].Text = alinanuye.Sehir.Sehiradi;
            Table1.Rows[i].Cells[6].Text = alinanuye.Email;
            HyperLink link = new HyperLink();
            link.Text = "Değiştir";
            link.NavigateUrl = "uyedegistir.aspx?uyeid=" + alinanuye.Uyeid;
            Table1.Rows[i].Cells[7].Controls.Add(link);
            HyperLink link2 = new HyperLink();
            link2.Text = "sil";
            link2.NavigateUrl = "uyesil.aspx?uyeid=" + alinanuye.Uyeid;
            Table1.Rows[i].Cells[8].Controls.Add(link2);
            i++;

        }
    }
    protected void Sehirlistesi_SelectedIndexChanged(object sender, EventArgs e)
    {
       
        uyelerlistesi = new Uyelerdao().kriteregoregetir("",Convert.ToInt32(Sehirlistesi.SelectedValue));
        yaz();
    }
}