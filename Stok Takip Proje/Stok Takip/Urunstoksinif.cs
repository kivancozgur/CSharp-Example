using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stok_Takip
{
    class Urunstoksinif
    {
        int kayıtno, stoksayısı, kritikstoksayısı;

        public int Kritikstoksayısı
        {
            get { return kritikstoksayısı; }
            set { kritikstoksayısı = value; }
        }

        public int Stoksayısı
        {
            get { return stoksayısı; }
            set { stoksayısı = value; }
        }

        public int Kayıtno
        {
            get { return kayıtno; }
            set { kayıtno = value; }
        }
        string modelkodu;

        public string Modelkodu
        {
            get { return modelkodu; }
            set { modelkodu = value; }
        }
    }
}
