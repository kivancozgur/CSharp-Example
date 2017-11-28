using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Siniflar
{
    class Bisiklet
    {
       private int hiz = 0;
       private int vites = 1;
       private String renk;
       private int jant;

       public void Sethiz(int hiz)
       {
           this.hiz = hiz;
       }

       public int Gethiz()
       {
           return hiz;
       }

       public void Setrenk(String renk)
       {
           this.renk = renk;
       }

       public String Getrenk()
       {
           return renk;
       }

       public int Vites
       {
           get { return vites; }
           set { vites = value; }

       }

       public int Jant
       {
           get { return jant; }
           set { jant = value; }
       }
       public Bisiklet()
       {
       }

       public Bisiklet(int hizi,String renk)
       {
           hiz = hizi;
           this.renk = renk;
       }

       public Bisiklet(int hiz, int vites, String renk, int jant)
       {
           this.hiz = hiz;
           this.vites = vites;
           this.renk = renk;
           this.jant = jant;
       }
    public  void hizlan(int kackm)
        {
            hiz += kackm;
        }
        public void frenyap(int kackm)
        {
            hiz -= kackm;
        }

        public int hizdegerial()
        {
            return hiz;
        }

        public int vitesdegerigeridon()
        {
            return vites;
        }

        public void vitesdegistir(int vitdeger)
        {
            vites = vitdeger;
        }
    }
}
