using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kalitim
{
    class Insan
    {
        int boy;

        public int Boy
        {
            get { return boy; }
            set { boy = value; }
        }
        String ad;

        public String Ad
        {
            get { return ad; }
            set { ad = value; }
        }
        String sacrengi;

        public String Sacrengi
        {
            get { return sacrengi; }
            set { sacrengi = value; }
        }
        int kilo;

        public int Kilo
        {
            get { return kilo; }
            set { kilo = value; }
        }
        public String bilgioku()
        {
            return ad + sacrengi + kilo + boy;
        }
        
    }
}
