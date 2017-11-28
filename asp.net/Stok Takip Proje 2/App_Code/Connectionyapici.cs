using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

public class Connectionyapici
{
    public static SqlConnection baglantiyagec()
    {
        SqlConnection baglanti = new SqlConnection();
        baglanti.ConnectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\ASUS\\Documents\\Takip.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
        return baglanti;
    }
}