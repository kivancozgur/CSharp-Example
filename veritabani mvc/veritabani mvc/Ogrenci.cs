using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace veritabani_mvc
{
    class Ogrenci
    {
        private int ogno;

        public int Ogno
        {
            get { return ogno; }
            set { ogno = value; }
        }
        private String ogadsoyad;

        public String Ogadsoyad
        {
            get { return ogadsoyad; }
            set { ogadsoyad = value; }
        }
        private DateTime dogtar;

        public DateTime Dogtar
        {
            get { return dogtar; }
            set { dogtar = value; }
        }
        private long tckimlik;

        public long Tckimlik
        {
            get { return tckimlik; }
            set { tckimlik = value; }
        }
        private String adres;

        public String Adres
        {
            get { return adres; }
            set { adres = value; }
        }
    }
}
