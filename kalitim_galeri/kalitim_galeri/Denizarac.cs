using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Denizarac:Arac
    {
        string govdetipi;

        public string Govdetipi
        {
            get { return govdetipi; }
            set { govdetipi = value; }
        }
        int motorsayisi;

        public int Motorsayisi
        {
            get { return motorsayisi; }
            set { motorsayisi = value; }
        }
    }
}
