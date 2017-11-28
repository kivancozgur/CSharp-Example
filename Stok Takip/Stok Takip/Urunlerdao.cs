using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
namespace Stok_Takip
{
    class Urunlerdao
    {
        SqlConnection baglanti = Connectionyapici.baglantiyagec();
        SqlCommand komut = new SqlCommand();
        public int urunkaydet(int modelkodu,int toplamfiyat)
        {
            int sayi;
            try
            {
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "insert into urunler (modelkodu,toplamfiyat) values(" + modelkodu + "," + toplamfiyat + ")";
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
