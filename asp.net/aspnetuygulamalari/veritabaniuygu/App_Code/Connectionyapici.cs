using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
/// <summary>
/// Summary description for Connectionyapici
/// </summary>
public class Connectionyapici
{
    public SqlConnection baglantiyagec()
    {
SqlConnection baglanti=new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\deneme.mdf;Integrated Security=True;User Instance=True");
return baglanti;
    }

	public Connectionyapici()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}