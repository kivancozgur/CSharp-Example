using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stok_Takip
{
    class Parcaolusumu
    {
        string modelkodu;

        public string Modelkodu
        {
            get { return modelkodu; }
            set { modelkodu = value; }
        }
        int parcano, kayıtno, adet;

        public int Adet
        {
            get { return adet; }
            set { adet = value; }
        }

        public int Kayıtno
        {
            get { return kayıtno; }
            set { kayıtno = value; }
        }

        public int Parcano
        {
            get { return parcano; }
            set { parcano = value; }
        }

    }
}
