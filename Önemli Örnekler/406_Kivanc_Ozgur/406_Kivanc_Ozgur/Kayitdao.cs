using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Collections;
namespace _406_Kivanc_Ozgur
{
    class Kayitdao
    {
        ArrayList ogrencilistesi = new ArrayList();
        SqlConnection baglanti = Connectionyapici.baglantiyagec();
        SqlCommand komut = new SqlCommand();
        public ArrayList tumkayitlar()
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "select * from Kayit";
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                Kayit insan = new Kayit();
                insan.Adisoyadi = oku["adisoyadi"].ToString();
                insan.Tcno = oku["tcno"].ToString();
                insan.Ilce = oku["ilce"].ToString();
                insan.Ay = oku["ay"].ToString();
                insan.Odenenmiktar = Convert.ToInt32(oku["odenenmiktar"].ToString());
                ogrencilistesi.Add(insan);
            }
            baglanti.Close();
            return ogrencilistesi;
        }
        
        public int insankaydet(String adisoyadi, String tcno, String ilce,String ay, int odenenmiktar)
        {
            int sayi;
            try
            {
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "insert into kayit (adisoyadi,tcno,ilce,ay,odenenmiktar) values('"+adisoyadi+"','"+tcno+"','"+ilce+"','"+ay+"',"+odenenmiktar+")";
                sayi = komut.ExecuteNonQuery();
                baglanti.Close();
            }
            catch (SqlException)
            {
                sayi = 0;
            }
            return sayi;
        }
        public int insansil(String ay)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "delete from kayit where ay=" + ay;
            int sayi = komut.ExecuteNonQuery();
            baglanti.Close();
            return sayi;
        }
        public int insandegistir(String adisoyadi, String tcno, String ilce, String ay, int odenenmiktar)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "update kayit set adisoyadi='" + adisoyadi + "',tcno='" + tcno + "',ilce='"+ilce+"',ay='" + ay + "'where odenenmiktar=" + odenenmiktar;
            int sayi = komut.ExecuteNonQuery();
            baglanti.Close();
            return sayi;

        }
    }
}
