using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kivanc_Donem2_Temrin3
{
    class Denizaraci:Arac
    {
        string govde;
        int motorsayisi;

        public int Motorsayisi
        {
            get { return motorsayisi; }
            set { motorsayisi = value; }
        }
        public string Govde
        {
            get { return govde; }
            set { govde = value; }
        }
        
    }
}
