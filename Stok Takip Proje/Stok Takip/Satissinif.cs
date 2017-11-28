using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stok_Takip
{
    class Satissinif
    {
        int kayitno, satisadet;

        public int Satisadet
        {
            get { return satisadet; }
            set { satisadet = value; }
        }

        public int Kayitno
        {
            get { return kayitno; }
            set { kayitno = value; }
        }
        string modelkodu;

        public string Modelkodu
        {
            get { return modelkodu; }
            set { modelkodu = value; }
        }
    }
}
