using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arraylist_ogrenci_sinif_orneği
{
    class Ogrenci
    {
        int ogno;
        public int Ogno
        {
            get { return ogno; }
            set { ogno = value; }
        }
        String adsoyad;

        public String Adsoyad
        {
            get { return adsoyad; }
            set { adsoyad = value; }
        }

        public Ogrenci()
        { }
        public Ogrenci(int ogno, String adsoyad)
        {
            this.ogno = ogno;
            this.adsoyad = adsoyad;
        }
    }
}
