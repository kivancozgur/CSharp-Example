using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Collections;
using System.Data;
/// <summary>
/// Summary description for Siparisdao
/// </summary>
public class Siparisdao
{
    SqlConnection bag = new Connectionyapici().baglantiyagec();
    SqlCommand komut = new SqlCommand();
    SqlDataReader oku;
    public int siparisgec(ArrayList musterisepet, int uyeid)
    {
        int sipno;
        bag.Open();
        komut.Connection = bag;
        komut.CommandText = "select max(sipno) from siparisler";

        if (komut.ExecuteScalar().ToString() == null)
        {
            sipno = 1;
        }
        else
        {
            sipno = Convert.ToInt32(komut.ExecuteScalar());
            sipno++;
        }

        foreach (Sepetlik alinanurun in musterisepet)
        {
            komut.CommandText =
                "insert into siparisler(uyeid,urunid,adet,sip_tarihi,sipno) values (" +
                uyeid+"," +alinanurun.Urun.Urunid +","+alinanurun.Adet + 
                ",convert(datetime,'" + DateTime.Now.ToShortDateString() +"',103),"+sipno+")";
            komut.ExecuteNonQuery();
        }
        bag.Close();
        return sipno;
    }

    public ArrayList siparisleriniz(int uyeid,int sipno)
    {
        ArrayList siparisler = new ArrayList();
        bag.Open();
        komut.Connection = bag;
        if (sipno == 0)
        {
            komut.CommandText = "select * from siparisler,urunler where uyeid=" + uyeid +
                " and siparisler.urunid=urunler.urunid order by sip_tarihi desc";
        }
        else
        {
            komut.CommandText = "select * from siparisler,urunler where sipno=" + sipno +
                            " and siparisler.urunid=urunler.urunid";
        }
        oku = komut.ExecuteReader();
        while (oku.Read())
        {
            Siparislik siparislik = new Siparislik();
            siparislik.Adet =Convert.ToInt32( oku["adet"]);
            siparislik.Sip_tarihi = Convert.ToDateTime(oku["sip_tarihi"]);
            siparislik.Sipno = Convert.ToInt32(oku["sipno"]);
        
               Urun urun = new Urun();
        urun.Urunid = Convert.ToInt32(oku["urunid"]);
        urun.Urunadi = oku["urunadi"].ToString();
        urun.Resim = oku["resim"].ToString();
        urun.Aciklama = oku["aciklama"].ToString();
        urun.Fiyat=Convert.ToDouble(oku["fiyat"]);
        siparislik.Urun = urun;
        siparisler.Add(siparislik);

        }
        return siparisler;

        bag.Close();

    }

    public DataSet siparisrapor()
    {
        bag.Open();
        Siparisdataset ds = new Siparisdataset();
        SqlDataAdapter adaptor =
    new SqlDataAdapter("SELECT siparisler.adet, siparisler.sip_tarihi, siparisler.sipno, urunler.urunadi, urunler.fiyat, uyeler.adsoyad " +
"FROM siparisler INNER JOIN urunler ON siparisler.urunid = urunler.urunid INNER JOIN uyeler ON siparisler.uyeid = uyeler.uyeid", bag);
        adaptor.Fill(ds, "siparistable");
        return ds;

        bag.Close();

    }
   
	public Siparisdao()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}