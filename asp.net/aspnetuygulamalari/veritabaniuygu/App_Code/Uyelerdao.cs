using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using System.Data.SqlClient;
using System.Data;
/// <summary>
/// Summary description for Uyelerdao
/// </summary>
public class Uyelerdao
{
    ArrayList uyelistesi = new ArrayList();
    SqlConnection bag = new Connectionyapici().baglantiyagec();
    SqlCommand komut = new SqlCommand();
    SqlDataReader oku;
    public ArrayList tumuyelerigetir()
    {
       
       
        bag.Open();
      
        komut.Connection = bag;
        komut.CommandText ="select * from uyeler,sehirler,meslek " + 
       "where uyeler.sehir=sehirler.plaka and uyeler.meslek=meslek.meslekid";

        yaz();

        bag.Close();
        return uyelistesi;
    }

    public ArrayList kriteregoregetir(String email,int plaka)
    {
        bag.Open();
        komut.Connection = bag;
        if (plaka == 0)
        {
            komut.CommandText = "select * from uyeler,sehirler,meslek " +
          "where uyeler.sehir=sehirler.plaka and uyeler.meslek=meslek.meslekid and email like'%" + email + "'";
        }
        else
        {
          komut.CommandText  = "select * from uyeler,sehirler,meslek " +
      "where uyeler.sehir=sehirler.plaka and uyeler.meslek=meslek.meslekid and sehir=" + plaka;
        }
      
        yaz();
        bag.Close();
        return uyelistesi;
    }

    public void yaz()
    {
        oku = komut.ExecuteReader();
        while (oku.Read())
        {
            Uye uye = new Uye();
            uye.Adres = oku["adres"].ToString();
            uye.Adsoyad = oku["adsoyad"].ToString();
            uye.Cins = Convert.ToBoolean(oku["cinsiyet"]);
            uye.Dogtar = Convert.ToDateTime(oku["dogtar"]);
            uye.Email = oku["email"].ToString();
            uye.Kuladi = oku["kuladi"].ToString();
            uye.Sifre = oku["sifre"].ToString();
            uye.Uyeid = Convert.ToInt32(oku["uyeid"]);
            Sehirler sehir = new Sehirler();
            sehir.Plaka = Convert.ToInt32(oku["plaka"].ToString());
            sehir.Sehiradi = oku["sehiradi"].ToString();
            uye.Sehir = sehir;
            Meslek mes = new Meslek();
            mes.Meslekid = Convert.ToInt32(oku["meslekid"]);
            mes.Meslekad = oku["meslekad"].ToString();
            uye.Meslek = mes;
            uyelistesi.Add(uye);
        }
    }

    public int uyekaydet(String kuladi, String sifre, String adsoyad, String dogtar, 
        int cins, String adres, int sehir, String email, int meslek)
    {
     
        bag.Open();
        komut.Connection = bag;
 komut.CommandText = "insert into uyeler(kuladi,sifre,adsoyad,dogtar,cinsiyet,adres,sehir,email,meslek) values ('" +
kuladi + "','" + sifre + "','" + adsoyad + "',convert(datetime,'" + dogtar + "',103)," + cins + ",'" + adres + "'," +
sehir + ",'" + email + "'," + meslek + ")";
       int sayi= komut.ExecuteNonQuery();

     
        bag.Close();
        return sayi;
    }


    public Uye uyegiriskontrol(String kuladi, String sifre)
    {
        Uye uye = new Uye();
        try
        {
            bag.Open();
            komut.Connection = bag;
            komut.CommandText = "select * from uyeler where kuladi='" +
                kuladi + "' and sifre='" + sifre + "'";
            oku = komut.ExecuteReader();
            oku.Read();
            uye.Adsoyad = oku["adsoyad"].ToString();
            uye.Uyeid = Convert.ToInt32(oku["uyeid"]);
            bag.Close();
        }
        catch (Exception)
        {

        }
        return uye;
      

    }

    public int uyesil(int uyeid)
    {
        bag.Open();
        komut.Connection = bag;
        komut.CommandText = "delete from uyeler where uyeid=" + uyeid;
        int sayi = komut.ExecuteNonQuery();
        bag.Close();
        return sayi;

    }

    public Uye tekuyegetir(int uyeid)
    {
        bag.Open();
        komut.Connection = bag;
        komut.CommandText = "select * from uyeler,sehirler,meslek where " + 
        "uyeler.sehir=sehirler.plaka and "+
        "uyeler.meslek=meslek.meslekid and uyeid=" + uyeid;
        oku = komut.ExecuteReader();
        oku.Read();
        Uye uye = new Uye();
        uye.Adres = oku["adres"].ToString();
        uye.Adsoyad = oku["adsoyad"].ToString();
        uye.Cins = Convert.ToBoolean(oku["cinsiyet"]);
        uye.Dogtar = Convert.ToDateTime(oku["dogtar"]);
        uye.Email = oku["email"].ToString();
        uye.Kuladi = oku["kuladi"].ToString();
        uye.Sifre = oku["sifre"].ToString();
        uye.Uyeid = Convert.ToInt32(oku["uyeid"]);
        Sehirler sehir = new Sehirler();
        sehir.Plaka = Convert.ToInt32(oku["plaka"].ToString());
        sehir.Sehiradi = oku["sehiradi"].ToString();
        uye.Sehir = sehir;
        Meslek mes = new Meslek();
        mes.Meslekid = Convert.ToInt32(oku["meslekid"]);
        mes.Meslekad = oku["meslekad"].ToString();
        uye.Meslek = mes;
        bag.Close();
        return uye;
    
    }

    public int uyedegistir(String kuladi, String sifre, String adsoyad, String dogtar,
        int cins, String adres, int sehir, String email, int meslek,int uyeid)
    {
        bag.Open();
        komut.Connection = bag;
        komut.CommandText = "update uyeler set kuladi='" + kuladi + "',sifre='" + sifre +
"',adsoyad='" + adsoyad + "',dogtar=convert(datetime,'" + dogtar + "',103),cinsiyet=" + cins +
",adres='" + adres + "',sehir=" + sehir + ",email='" + email + "',meslek=" + meslek +
 " where uyeid=" + uyeid;
        int sayi = komut.ExecuteNonQuery();
        bag.Close();
        return sayi;
    }

    public DataSet uyeraporu(int plaka,String email,int tumu)
    {
        bag.Open();
        Uyelerdataset ds = new Uyelerdataset();
        SqlDataAdapter adaptor;
        if (tumu != 0)
        {
             adaptor = new SqlDataAdapter("select * from uyeler", bag);
        }
        else if (plaka != 0)
        {
             adaptor = new SqlDataAdapter("select * from uyeler where sehir=" + plaka, bag);
        }
        else
        {
            adaptor = new SqlDataAdapter("select * from uyeler where email like'%" + email + "%'", bag);
        }
        adaptor.Fill(ds, "uyeler");
        return ds;
        bag.Close();
    }
    
    public Uyelerdao()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}