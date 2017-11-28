using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Collections ;
namespace örnek
{
    class Notlardao
    {
        SqlConnection baglanti = Connectionyapici.baglantiyagec();
        SqlCommand komut = new SqlCommand();
        public ArrayList tumogrencinotugetir()
        {
            ArrayList notlistesi = new ArrayList();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "select * from notlar,ogrenciler,dersler where notlar.ogno=ogrenciler.ogno and " +
                "dersler.dersno=notlar.dersno";
        
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                Notlar not = new Notlar();
                not.Yaz1 =Convert.ToByte( oku["yaz1"]);
                not.Yaz2 = Convert.ToByte(oku["yaz2"]);
                not.Soz = Convert.ToByte(oku["soz"]);
                Ogrenci ogr = new Ogrenci();
                ogr.Ogadsoyad=oku["ogadsoyad"].ToString();
                ogr.Ogno = Convert.ToInt32(oku["ogno"].ToString());
                not.Ogno = ogr;
                Dersler ders = new Dersler();
                ders.Dersadi = oku["dersadi"].ToString();
                not.Dersno = ders;
                notlistesi.Add(not);
            }
            baglanti.Close();
                return notlistesi;
        }
    }
}
