using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Collections;
namespace Kivanc_Donem2_Temrin8
{
    class Notlardao
    {
            ArrayList ogrencinotlari = new ArrayList();
            SqlConnection baglanti = Connectionyapici.baglantiyagec();
            SqlCommand komut = new SqlCommand();
            public ArrayList tumogrencilerigetir()
            {
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "select * from notlar,ogrenciler,";
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    Notlar yeninot = new Notlar();
                    yeninot.Yaz1 = Convert.ToInt32(oku["yaz1"].ToString());
                    yeninot.Yaz2 = Convert.ToInt32(oku["yaz2"].ToString());
                    yeninot.Soz = Convert.ToInt32(oku["soz"].ToString());
                    yeninot.Kayitno = Convert.ToInt32(oku["kayitno"].ToString());
                    ogrencinotlari.Add(yeninot);
                }
                baglanti.Close();
                return ogrencinotlari;
            }
           
            public int notkaydet(int ogno, int yaz1, int yaz2, int soz, int dersno)
            {
                int sayi;
                try
                {
                    baglanti.Open();
                    komut.Connection = baglanti;
                    komut.CommandText = "insert into notlar (ogno,yaz1,yaz2,soz,dersno) values(" + ogno + "," + yaz1 + "," + yaz2 + "," + soz + ","+dersno+")";
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
