using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temrin_Geliştirme
{
    class Dortislem
    {
        int sayi1, sayi2, secim;
        public void setSayi1(int sayi1)
        {
            this.sayi1=sayi1;
        }
        public int getSayi1(int sayi1)
        {
            return sayi1;
        }
        public void setSayi2(int sayi2)
        {
            this.sayi2 = sayi2;
        }
        public int getSayi2(int sayi2)
        {
            return sayi2;
        }
        public void setSecim(int secim)
        {
            this.secim = secim;
        }
        public int getSecim(int secim)
        {
            return secim;
        }
        public Dortislem()
        {}
        public Dortislem(int sayi1,int sayi2, int secim)
        {
            this.sayi1 = sayi1;
            this.sayi2 = sayi2;
            this.secim = secim;
        }
        public int hesapla()
        {
            int sonuc=0;
            switch (secim)
            {
                case 1:
                    sonuc =sayi1 + sayi2;
                    break;
                case 2:
                    sonuc = sayi1 - sayi2;
                    break;
                case 3:
                    sonuc = sayi1 * sayi2;
                    break;
                case 4:
                    sonuc = sayi1 / sayi2;
                    break;
            }
            return sonuc;
        }
    }
}
