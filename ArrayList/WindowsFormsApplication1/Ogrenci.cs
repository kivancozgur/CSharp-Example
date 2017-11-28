using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Ogrenci
    {
        int no;
        public int No
        {
            get { return no; }
            set { no = value; }
        }
        String adsoyad;
        public String Adsoyad
        {
            get { return adsoyad; }
            set { adsoyad = value; }
        }
        public Ogrenci()
        {
 
        }
        public Ogrenci(int no, String adsoyad)
        {
            this.no = no;
            this.adsoyad = adsoyad;
        }
        
    }
}
