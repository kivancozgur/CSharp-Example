using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Collections;
/// <summary>
/// Summary description for Kategoridao
/// </summary>
public class Kategoridao
{
    SqlConnection bag = new Connectionyapici().baglantiyagec();
    public ArrayList tumkategorilerigetir()
    {
        ArrayList kategorilistesi = new ArrayList();

        bag.Open();
        SqlCommand komut = new SqlCommand("select * from kategoriler order by kateadi asc", bag);
        SqlDataReader oku = komut.ExecuteReader();
        while (oku.Read())
        {
            Kategori kat = new Kategori();
           kat.Kateadi = oku["kateadi"].ToString();
          kat.Kateno= Convert.ToInt32(oku["kateno"]);
         kategorilistesi.Add(kat);

        }
        oku.Close();
        bag.Close();
        return kategorilistesi;

    }

    public Kategori tekkategetir(int kateno)
    {
          bag.Open();
        SqlCommand komut = new SqlCommand("select * from kategoriler where kateno=" +kateno, bag);
        SqlDataReader oku = komut.ExecuteReader();
        oku.Read();
        Kategori kat = new Kategori();
        kat.Kateadi = oku["kateadi"].ToString();
        kat.Kateno = Convert.ToInt32(oku["kateno"]);
        oku.Close();
        bag.Close();
        return kat;

    }

	public Kategoridao()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}