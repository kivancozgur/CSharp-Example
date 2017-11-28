using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data.SqlClient;

namespace veritabani_mvc
{
    class Ogrencilerdao
    {
        ArrayList ogrencilistesi = new ArrayList();
        SqlConnection baglanti = Connectionyapici.baglantiyagec();
        SqlCommand komut = new SqlCommand();
        public ArrayList tumogrencilerigetir()
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "select * from ogrenciler";
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                Ogrenci ogr = new Ogrenci();
                ogr.Ogno=Convert.ToInt32(oku["ogno"].ToString());
                ogr.Ogadsoyad = oku["ogadsoyad"].ToString();
                ogr.Tckimlik = Convert.ToInt32(oku["tckimlik"].ToString());
                ogr.Dogtar= Convert.ToDateTime(oku["dogtar"].ToString());
                ogr.Adres = oku["adres"].ToString();
                ogrencilistesi.Add(ogr);
            }
            baglanti.Close();
            return ogrencilistesi;
        }
        public Ogrenci istenilenogrenci(int ogno)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText="select * from ogrenciler where ogno="+ogno;
            SqlDataReader oku = komut.ExecuteReader();
            oku.Read();
            Ogrenci ogr = new Ogrenci();
            ogr.Ogno = Convert.ToInt32(oku["ogno"].ToString());
            ogr.Ogadsoyad = oku["ogadsoyad"].ToString();
            ogr.Tckimlik = Convert.ToInt32(oku["tckimlik"].ToString());
            ogr.Dogtar = Convert.ToDateTime(oku["dogtar"].ToString());
            ogr.Adres = oku["adres"].ToString();
            baglanti.Close();
            return ogr;
        }
        public int ogrencikaydet(int ogno, String adsoyad, long tckimlik, DateTime dogtar, String adres)
        {
            int sayi;
            try
            {
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "insert into ogrenciler (ogno,ogadsoyad,dogtar,tckimlik,adres) values(" + ogno + ",'" + adsoyad + "',convert(datetime,'" + dogtar + "',103)," + tckimlik + ",'" + adres + "')";
                sayi = komut.ExecuteNonQuery();
                baglanti.Close();
            }
            catch (SqlException)
            {
                sayi = 0;
            }
            return sayi;
        }
        public int ogrencisil(int ogno)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "delete from ogrenciler where ogno=" + ogno;
            int sayi = komut.ExecuteNonQuery();
            baglanti.Close();
            return sayi;
        }
        public int ogrencidegistir(int ogno, String adsoyad, long tckimlik, DateTime dogtar, String adres)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "update ogrenciler set ogadsoyad='" + adsoyad + "',tckimlik=" + tckimlik + ",dogtar=convert(datetime,'" + dogtar + "',103),adres='" + adres + "'where ogno=" + ogno;
            int sayi = komut.ExecuteNonQuery();
            baglanti.Close();
            return sayi;
        }
    }
}
