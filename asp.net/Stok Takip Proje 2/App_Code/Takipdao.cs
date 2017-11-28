using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Collections;


public class Takipdao
{
    SqlConnection baglanti = Connectionyapici.baglantiyagec();
    SqlCommand komut = new SqlCommand();
    public ArrayList tumstogugetir()
    {
        ArrayList stoklistesi = new ArrayList();
        baglanti.Open();
        komut.Connection = baglanti;
        komut.CommandText = "select * from Takip";
        SqlDataReader oku = komut.ExecuteReader();
        while (oku.Read())
        {
            Takip urun = new Takip();
            urun.Adet = Convert.ToInt32(oku["adet"]);
            urun.Urunadi = (oku["urunadi"]).ToString();
            stoklistesi.Add(urun);
        }
        baglanti.Close();
        return stoklistesi;
    }
    public int stokkaydet(String urunadi,int adet)
    {
        int sayi;
        try
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "insert into takip (urunadi,adet) values ('"+urunadi+"',"+adet+")";
            sayi = komut.ExecuteNonQuery();
            baglanti.Close();
        }
        catch (SqlException)
        {
            sayi = 0;
        }
        return sayi;

    }
    public int stoksil(String urunadi)
    {
        baglanti.Open();
        komut.Connection = baglanti;
        komut.CommandText = "delete from Takip where urunadi='" + urunadi+"'";
        int sayi = komut.ExecuteNonQuery();
        baglanti.Close();
        return sayi;
    }

}