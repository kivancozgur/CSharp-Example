using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kivanc_Donem2_Temrin3
{
    class Agirarac:Arac
    {
        int vitessayisi, tekerleksayisi, agirlik;

        public int Agirlik
        {
            get { return agirlik; }
            set { agirlik = value; }
        }

        public int Tekerleksayisi
        {
            get { return tekerleksayisi; }
            set { tekerleksayisi = value; }
        }

        public int Vitessayisi
        {
            get { return vitessayisi; }
            set { vitessayisi = value; }
        }
    }
}
