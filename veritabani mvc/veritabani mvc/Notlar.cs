using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace veritabani_mvc
{
    class Notlar
    {
        private Ogrenci ogno;

        internal Ogrenci Ogno
        {
            get { return ogno; }
            set { ogno = value; }
        }
        private byte yaz1;

        public byte Yaz1
        {
            get { return yaz1; }
            set { yaz1 = value; }
        }
        private byte yaz2;

        public byte Yaz2
        {
            get { return yaz2; }
            set { yaz2 = value; }
        }
        private byte soz;

        public byte Soz
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
