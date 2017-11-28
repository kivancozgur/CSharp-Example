using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Collections;
/// <summary>
/// Summary description for Meslekdao
/// </summary>
public class Meslekdao
{
    SqlConnection bag = new Connectionyapici().baglantiyagec();
    public ArrayList tummesleklerigetir()
    {
        ArrayList mesleklerlistesi = new ArrayList();

        bag.Open();
        SqlCommand komut = new SqlCommand("select * from meslek order by meslekad asc", bag);
        SqlDataReader oku = komut.ExecuteReader();
        while (oku.Read())
        {
            Meslek mes = new Meslek();
           mes.Meslekad = oku["meslekad"].ToString();
            mes.Meslekid = Convert.ToInt32(oku["meslekid"]);
           mesleklerlistesi.Add(mes);

        }
        oku.Close();
        bag.Close();
        return mesleklerlistesi;

    }

	public Meslekdao()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}