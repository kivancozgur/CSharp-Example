using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Collections;
using System.Data;
/// <summary>
/// Summary description for Urundao
/// </summary>
public class Urundao
{

    SqlConnection bag = new Connectionyapici().baglantiyagec();
    SqlCommand komut = new SqlCommand();
    SqlDataReader oku;
    public int urunkaydet(String urunadi, double fiyat, String aciklama, String resim, int kateno)
    {
        bag.Open();
        komut.Connection = bag;
        komut.CommandText = "insert into urunler (urunadi,fiyat,aciklama,resim,kateno) values ('" +
urunadi + "'," + fiyat + ",'" + aciklama + "','" + resim + "'," + kateno + ")";
        int sayi = komut.ExecuteNonQuery();
        bag.Close();
        return sayi;
    }

    public ArrayList urungetir(int baslangicyeri, int kateno)
    {
        ArrayList urunler = new ArrayList();
        bag.Open();
SqlDataAdapter adaptor = new SqlDataAdapter("select * from urunler where kateno=" + kateno, bag);
        DataSet ds = new DataSet();
        adaptor.Fill(ds,baslangicyeri,9, "urunler");

        foreach (DataRow satir in ds.Tables["urunler"].Rows)
        {
            Urun urun = new Urun();
            urun.Urunid = Convert.ToInt32(satir["urunid"]);
            urun.Urunadi = satir["urunadi"].ToString();
            urun.Fiyat = Convert.ToDouble(satir["fiyat"]);
            urun.Aciklama = satir["aciklama"].ToString();
            urun.Resim = satir["resim"].ToString();
            Kategori kat = new Kategoridao().tekkategetir(kateno);
            urun.Kategori = kat;
            urunler.Add(urun);
        }
        bag.Close();
        return urunler;


       


    }

    public int urunsayisi(int kateno)
    {
        bag.Open();
        komut.Connection = bag;
        komut.CommandText = "select count(*) from urunler where kateno=" + kateno;
        int sayi =Convert.ToInt32( komut.ExecuteScalar());
        bag.Close();
        return sayi;
    }

    public Urun tekurungetir(int urunid)
    {
        bag.Open();
        komut.Connection = bag;
        komut.CommandText = "select * from urunler where urunid=" + urunid;
        oku = komut.ExecuteReader();
        oku.Read();
        Urun urun = new Urun();
        urun.Urunid = Convert.ToInt32(oku["urunid"]);
        urun.Urunadi = oku["urunadi"].ToString();
        urun.Resim = oku["resim"].ToString();
        urun.Aciklama = oku["aciklama"].ToString();
        urun.Fiyat=Convert.ToDouble(oku["fiyat"]);
        Kategori kat = new Kategoridao().tekkategetir(Convert.ToInt32(oku["kateno"]));
        urun.Kategori = kat;
        bag.Close();
        return urun;
    }
	public Urundao()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}