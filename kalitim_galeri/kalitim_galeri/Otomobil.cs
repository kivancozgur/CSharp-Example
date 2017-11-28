using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Otomobil:Arac
    {
        int tekerleksay;

        public int Tekerleksay
        {
            get { return tekerleksay; }
            set { tekerleksay = value; }
        }
        int vitessay;

        public int Vitessay
        {
            get { return vitessay; }
            set { vitessay = value; }
        }
    }
}
