using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kivanc_Donem2_Temrin8
{
    class Notlar
    {
        private Ogrenci ogno;

        internal Ogrenci Ogno
        {
            get { return ogno; }
            set { ogno = value; }
        }
        private int yaz1;

        public int Yaz1
        {
            get { return yaz1; }
            set { yaz1 = value; }
        }
        private int yaz2;

        public int Yaz2
        {
            get { return yaz2; }
            set { yaz2 = value; }
        }
        private int soz;

        public int Soz
        {
            get { return soz; }
            set { soz = value; }
        }
        private Dersler dersno;

        internal Dersler Dersno
        {
            get { return dersno; }
            set { dersno = value; }
        }
        private int kayitno;

        public int Kayitno
        {
            get { return kayitno; }
            set { kayitno = value; }
        }
    }
}
