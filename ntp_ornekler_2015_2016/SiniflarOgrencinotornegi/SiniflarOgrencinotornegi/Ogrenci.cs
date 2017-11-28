using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SiniflarOgrencinotornegi
{
    class Ogrenci
    {
        private String adsoyad;
        private int yas;
        private String adres;

        public Ogrenci()
        {
        }
        public Ogrenci(String adsoyad, int yas, String adres)
        {
            this.adsoyad = adsoyad;
            this.yas = yas;
            this.adres = adres;
        }

        public String Adsoyad
        {
            get { return adsoyad; }
            set { adsoyad = value; }
        }
        public String Adres
        {
            get { return adres; }
            set { adres = value; }
        }
        public int Yas
        {
            get { return yas; }
            set { yas = value; }
        }

        public String durumhesapla(String dersadi, int y1, int y2, int s1)
        {
            int ort = (y1 + y2 + s1 ) /3;
            if (ort >= 50) return adsoyad + "isimli " + yas +" yaşında " + adres + " adresli" +
              " öğrenci " + dersadi   + " dersinden " + ort + " ile geçtin";
            else return adsoyad + "isimli " + yas + " yaşında " + adres + " adresli" +
              " öğrenci " + dersadi + " dersinden " + ort + " ile kaldı";
         
        }
    }
}
