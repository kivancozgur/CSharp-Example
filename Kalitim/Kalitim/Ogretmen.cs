using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kalitim
{
    class Ogretmen:Insan
    {
        int mebbisno;

        public int Mebbisno
        {
            get { return mebbisno; }
            set { mebbisno = value; }
        }
        public Ogretmen()
        { 
        }
    }
}
