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
      

        for (int i = 1; i < 10; i++)
        {
            DateTime tarih=DateTime.Now;
           tarih= tarih.AddMonths(i);
            Response.Write(tarih.ToShortDateString() + "<br>");
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        String[] arabalar=new String[5];
        arabalar[0] = "porş";
        arabalar[4] = "porş";
        int[,] sayilar = new int[3, 2];
        sayilar[0, 1] = 4;
        TextBox1.Text = "kamil";
        TextBox1.Text = TextBox1.Text + "\r\n";
        TextBox1.Text = TextBox1.Text+ "osman";
        for (int i = 0; i < 5; i++)
        {
            String sayi = Microsoft.VisualBasic.Interaction.InputBox("sayi gir", "", "", 100, 100);
            TextBox1.Text = TextBox1.Text + sayi;
            TextBox1.Text = TextBox1.Text + "\r\n";
           
        }
        double a = 24.25;
        int z= Convert.ToInt32(a);
        Response.Write(z);
       
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        araba benimarabam = new araba();
        //araba aysearaba = new araba("kırmızı", 6000);
       // araba kamilinarabasi = aysearaba;
     //   kamilinarabasi.Renk = "pembe";
    
     //   Response.Write("ayşenin arabası=" + aysearaba.Renk);
        benimarabam.yavasla();
        Response.Write(benimarabam.Aracttangelen);
        benimarabam.Renk = "yeşil";
        Response.Write(benimarabam.Renk);
        benimarabam.hizlan();
        Response.Write(benimarabam.Hiz);
        Response.Write(benimarabam.toplam(5, 9));
        double[] sayilar={6,5,9};
        //Response.Write(benimarabam.coklutatlim(sayilar));
        araba benimaraba2 = new araba(63);
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        try
        {
            int x = Convert.ToInt32(TextBox2.Text);
        }
        catch (FormatException)
        {
       
        }
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        String ad = "tuncay:ahmet:mehmet";
       // String[] adlar = ad.Split(':');
        TextBox2.Text = ad.Trim();
        Response.Write(ad.IndexOf("wa"));
    }
    protected void Button6_Click(object sender, EventArgs e)
    {

        Personel p1 = new Personel("kamil", 34);
        Personel p2 = new Personel("ayşe", 15);
        Response.Write("personel sayısı=" + Personel.sayac );
        Personel[] personeller = new Personel[3];

    }
}