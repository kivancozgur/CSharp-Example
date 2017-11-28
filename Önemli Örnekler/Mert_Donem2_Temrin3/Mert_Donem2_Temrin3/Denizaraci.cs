using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mert_Donem2_Temrin3
{
    class Denizaraci:Arac
    {
        string govdetipi;

        public string Govdetipi
        {
            get { return govdetipi; }
            set { govdetipi = value; }
        }
        int motorsay;

        public int Motorsay
        {
            get { return motorsay; }
            set { motorsay = value; }
        }
    }
}
