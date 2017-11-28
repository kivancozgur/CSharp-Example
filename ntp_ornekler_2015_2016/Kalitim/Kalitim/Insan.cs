using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kalitim
{
    class Insan
    {
        string ad;

        public string Ad
        {
            get { return ad; }
            set { ad = value; }
        }
        string sacrengi;

        public string Sacrengi
        {
            get { return sacrengi; }
            set { sacrengi = value; }
        }
        int boy;

        public int Boy
        {
            get { return boy; }
            set { boy = value; }
        }
        int kilo;

        public int Kilo
        {
            get { return kilo; }
            set { kilo = value; }
        }
        public String bilgioku()
        {
            return ad + sacrengi + boy + kilo;
        }
    }
}
