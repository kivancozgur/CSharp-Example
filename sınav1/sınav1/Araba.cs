using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Araba
    {
        private String marka;
        private String vites;
        private int motorgucu;
        private Boolean durum;
        private int hiz;
       public Araba()
        {
        }
       public Araba(String marka, String vites, int motorguc)
       {
           this.marka = marka;
           this.vites = vites;
           this.motorgucu = motorguc;
       }

        public void setMarka(String marka)
        {
            this.marka = marka;

        }
        public void setVites(String vites)
        {
            this.vites= vites;

        }
        public void setMotorgucu(int motorguc)
        {
            this.motorgucu = motorguc;

        }

        public String getMarka()
        {
            return marka;
        }
        public String getVites()
        {
            return vites;
        }
        public int getMotorgucu()
        {
            return motorgucu ;
        }

        public void calis()
        {
            durum = true;
        }

        public void dur()
        {
            durum = false;
            hiz = 0;
        }

        public String hizlan(int km)
        {
            String s="";
            if (durum == true)
            {
                hiz += km;
                s = "Aracınızın şu anki hızı=" + hiz;
            }
            else
            {
                s="Araç Duruyor hizlanamaz.Önce Çalıştırın";
            }
            return s;
        }

        public String yavasla(int km)
        {
            String s="";
            if (hiz <= 0)
            {
                s = "Araç zaten durmuş durumda yavaşlayamaz";
            }
            else
            {
                hiz -= km;
                s = "Aracın şu anki hızı=" + hiz;
            }
            return s;
        }

        public String bilgial()
        {
            String sonuc="";
            sonuc = "Aracınızın markası=" + marka + " Aracınızın vites tipi=" + vites +
                "Aracınızın motor gücü=" + motorgucu + "araç şu an ";
            if (durum == true)
            {
                sonuc += "çalışıyor ve hızı =" + hiz.ToString();
            }
            else
            {
                sonuc += "duruyor";
            }
            return sonuc;
        }
    }
}
