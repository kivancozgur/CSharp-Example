using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using System.Data.SqlClient;
/// <summary>
/// Summary description for Sehirdao
/// </summary>
public class Sehirdao
{
    SqlConnection bag = new Connectionyapici().baglantiyagec();
    public ArrayList tumsehirlerigetir()
    {
        ArrayList sehirlerlistesi = new ArrayList();
        
        bag.Open();
        SqlCommand komut = new SqlCommand("select * from sehirler order by sehiradi asc", bag);
        SqlDataReader oku = komut.ExecuteReader();
        while (oku.Read())
        {
            Sehirler sehir = new Sehirler();
            sehir.Sehiradi = oku["sehiradi"].ToString();
            sehir.Plaka = Convert.ToInt32(oku["plaka"]);
            sehirlerlistesi.Add(sehir);

        }
        oku.Close();
            bag.Close();
        return sehirlerlistesi;
    }

    public int sehirkaydet(int plaka, String sehiradi)
    {
        int sayi = 0;
        try
        {
            bag.Open();
            SqlCommand komut = new SqlCommand();
            komut.Connection = bag;
            komut.CommandText =
        "insert into sehirler(plaka,sehiradi) values (" + plaka + ",'" + sehiradi + "')";
            sayi = komut.ExecuteNonQuery();
           

            bag.Close();
        }
        catch (Exception)
        {
        }
        return sayi;
    }



	public Sehirdao()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}