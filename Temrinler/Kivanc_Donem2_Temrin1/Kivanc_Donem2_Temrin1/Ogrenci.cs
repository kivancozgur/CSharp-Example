using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kivanc_Donem2_Temrin1
{
    class Ogrenci
    {
        private String adsoyad;
        public String Adsoyad
        {
            get { return adsoyad; }
            set { adsoyad = value; }
        }
        private String adres;
        public String Adres
        {
            get { return adres; }
            set { adres = value; }
        }
        private int numara;
        public int Numara
        {
            get { return numara; }
            set { numara = value; }
        }
        private Int64 tckimlik;
        public Int64 Tckimlik
        {
            get { return tckimlik; }
            set { tckimlik = value; }
        }
        private double ort;
        public double Ort
        {
            get { return ort; }
            set { ort = value; }
        }
    }
}
