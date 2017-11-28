using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.IO;
public partial class Urunekle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            ArrayList kategoriler = new ArrayList();
            kategoriler = new Kategoridao().tumkategorilerigetir();
            int i=1;
            foreach (Kategori alinan in kategoriler)
            {
                kategoriliste.Items.Add(alinan.Kateadi);
                kategoriliste.Items[i].Value=alinan.Kateno.ToString();
                i++;
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        resimekle();
    }

    public void resimekle()
    {
        String uzanti = Path.GetExtension(FileUpload1.FileName);

        if (uzanti.Equals(".jpg") || uzanti.Equals(".gif") || uzanti.Equals(".png"))
        {
            if (FileUpload1.HasFile == true)
            {
                FileUpload1.SaveAs(Server.MapPath("urunresim/") + FileUpload1.FileName);

            }
            else
            {
                Response.Write("dosya seçtiğini yerde yok");
            }



        }
        else
        {
            Response.Write("lütfen bir resim dosyaısı seçiniz");
        }

    //   veritabaninakaydet();
    }

    public void veritabaninakaydet()
    {
        int sayi = new Urundao().urunkaydet(urunaditext.Text,
            Convert.ToDouble(fiyattext.Text), aciklamatext.Text,
            FileUpload1.FileName, Convert.ToInt32(kategoriliste.SelectedValue));
        if (sayi != 0)
        {
            Response.Write("urun başarı ile kaydedildi");
        }
        else
        {
            Response.Write("urunaditext kayıt edilemesi");

        }
        Image1.ImageUrl = "urunresim/" + FileUpload1.FileName;
    }
}