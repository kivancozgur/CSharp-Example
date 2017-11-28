using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sınıflar_kaldıgecti
{
    class Ogrenci
    {
        int yas;
        String adsoyad, adres;

        public void setAdsoyad(string adsoyad)
        {
            this.adsoyad=adsoyad;
        }
        public String getAdsoyad()
        {
            return adsoyad;
        }
        public void setYas(int yas)
        {
            this.yas = yas;

        }
        public int getYas()
        {
            return yas;
        }
        public Ogrenci()
        {

        }
        public Ogrenci(int yas, String adsoyad,String adres)
        {
            this.adsoyad = adsoyad;
            this.yas = yas;
            this.adres = adres;

        }
        public String hesapla(int y1,int y2,int y3,int s1,int s2)
        {
            int ortalama = (y1 + y2 + y3 + s1 + s2) / 5;
            if (ortalama >= 50)
                return "geçti";
            else
            {
                return "kaldı";
            }
        }

    }
}
