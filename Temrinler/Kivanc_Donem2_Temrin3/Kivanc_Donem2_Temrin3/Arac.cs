using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kivanc_Donem2_Temrin3
{
    class Arac
    {
        string marka, model;
        int uretim, motorgücü;


        public int Motorgücü
        {
            get { return motorgücü; }
            set { motorgücü = value; }
        }

        public int Uretim
        {
            get { return uretim; }
            set { uretim = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public string Marka
        {
            get { return marka; }
            set { marka = value; }
        }
        public Arac()
        { 
        }
        public Arac(string marka,string model,int uretim,int motorgücü)
        {
            this.marka = marka;
            this.model = model;
            this.uretim = uretim;
            this.motorgücü = motorgücü;
            
        }
      
    }
}
