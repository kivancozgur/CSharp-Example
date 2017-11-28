using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Staticmetotdegisken
{
    class Personel
    {
        private String adsoyad;
        private int perno;
       public static int sayac;
       public const int yas = 5;
        public String Adsoyad
        {
            get { return adsoyad; }
            set { adsoyad = value; }
        }
           
        public int Perno
        {
            get { return perno; }
            set { perno = value; }
        }

        public Personel()
        {
            sayac++;
        }
        public Personel(String adsoyad, int perno)
        {
            yas = 8;
            sayac++;
            this.adsoyad = adsoyad;
            this.perno = perno;
        }
        public static int personelsayisi()
        {
            
            return sayac;
        }
    }
}
