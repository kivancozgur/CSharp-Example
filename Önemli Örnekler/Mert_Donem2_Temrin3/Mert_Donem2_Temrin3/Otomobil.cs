using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mert_Donem2_Temrin3
{
    class Otomobil:Arac
    {
        int tekerleksay, vitessay;

        public int Vitessay
        {
            get { return vitessay; }
            set { vitessay = value; }
        }

        public int Tekerleksay
        {
            get { return tekerleksay; }
            set { tekerleksay = value; }
        }
    }
}
