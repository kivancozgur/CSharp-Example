using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stok_Takip
{
    class Urunlersinif
    {
        int modelno, kategorino;

        public int Kategorino
        {
            get { return kategorino; }
            set { kategorino = value; }
        }

        public int Modelno
        {
            get { return modelno; }
            set { modelno = value; }
        }
        string modelkodu;

        public string Modelkodu
        {
            get { return modelkodu; }
            set { modelkodu = value; }
        }
        float toplamfiyat;

        public float Toplamfiyat
        {
            get { return toplamfiyat; }
            set { toplamfiyat = value; }
        }
    }
}
