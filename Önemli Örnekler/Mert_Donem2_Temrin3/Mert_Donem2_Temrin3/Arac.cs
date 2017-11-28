using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mert_Donem2_Temrin3
{
    class Arac
    {
        string marka, model;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public string Marka
        {
            get { return marka; }
            set { marka = value; }
        }
        int üretimyili, motorgucu;

        public int Motorgucu
        {
            get { return motorgucu; }
            set { motorgucu = value; }
        }

        public int Üretimyili
        {
            get { return üretimyili; }
            set { üretimyili = value; }
        }
    }
}
