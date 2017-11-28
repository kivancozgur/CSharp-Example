using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
namespace _406_Kivanc_Ozgur
{
    class Connectionyapici
    {
        public static SqlConnection baglantiyagec()
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\veritabani.mdf;Integrated Security=True;User Instance=True";
            return baglanti;
        }
    }
}
