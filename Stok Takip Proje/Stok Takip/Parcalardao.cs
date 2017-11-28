using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data.SqlClient;

namespace Stok_Takip
{
    class Parcalardao
    {
        SqlConnection baglanti = Connectionyapici.baglantiyagec();
        SqlCommand komut = new SqlCommand();
        public int parcakaydet(int parcano, string parcaad, float birimfiyat)
        {
            int sayi;
            try
            {
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "insert into parcalar (parcano,parcaad,birimfiyat) values (" + parcano + " , '" + parcaad + "'," + birimfiyat + ")";

                sayi = komut.ExecuteNonQuery();
                baglanti.Close();
            }
            catch (SqlException)
            {
                sayi = 0;
                baglanti.Close();
            }
            return sayi;
        }
        public int parcastokkaydet(string parcaad,int stoksayısı,int kritikstoksayısı)
        {
            int sayi;
            try
            {
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "insert into parcastok(parcaad,stoksayısı,kritikstoksayısı) values ('" + parcaad + "'," + stoksayısı + " ," + kritikstoksayısı + ")";
               


                sayi = komut.ExecuteNonQuery();
                baglanti.Close();
            }
            catch (SqlException)
            {
                sayi = 0;
                baglanti.Close();
            }
            return sayi;
        }
        public ArrayList tumparcalarigetir()
        {
            ArrayList parcatorbasi = new ArrayList();

            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "select * from parcalar order by parcano";
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                Parcalarsınıf yeniparca = new Parcalarsınıf();
                yeniparca.Parcano = Convert.ToInt32(oku["parcano"].ToString());
                yeniparca.Parcaad = oku["parcaad"].ToString();
                yeniparca.Birimfiyat = Convert.ToInt32(oku["birimfiyat"].ToString());
                parcatorbasi.Add(yeniparca);
                
                
            }
            baglanti.Close();
            return parcatorbasi;

        }
    }
}
