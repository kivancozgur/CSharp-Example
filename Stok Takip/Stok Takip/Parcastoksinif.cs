using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stok_Takip
{
    class Parcastoksinif
    {
        int kayitno, stoksayısı, kritikstoksayısı;

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

        public int Kayitno
        {
            get { return kayitno; }
            set { kayitno = value; }
        }
        string parcaad;

        public string Parcaad
        {
            get { return parcaad; }
            set { parcaad = value; }
        }
    }
}
