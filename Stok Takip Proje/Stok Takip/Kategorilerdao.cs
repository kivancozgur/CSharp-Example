using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data.SqlClient;

namespace Stok_Takip
{
    class Kategorilerdao
    {
        SqlConnection baglanti = Connectionyapici.baglantiyagec();
        SqlCommand komut = new SqlCommand();
        public int kategorikaydet(string kategoriad)
        {
            int sayi;
            try
            {
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "insert into anakategori(kategoriad) values ('" + kategoriad + "')";
                
                sayi = komut.ExecuteNonQuery();
                baglanti.Close();
            }
            catch (SqlException)
            {
                sayi = 0;
            }
            return sayi;

        }
    }
}
