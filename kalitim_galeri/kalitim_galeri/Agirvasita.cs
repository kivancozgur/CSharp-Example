using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Agirvasita:Arac
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
        int agirlikkapasite;

        public int Agirlikkapasite
        {
            get { return agirlikkapasite; }
            set { agirlikkapasite = value; }
        }

    }
}
