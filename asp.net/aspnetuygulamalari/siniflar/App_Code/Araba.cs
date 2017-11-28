using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Araba
/// </summary>
public class Araba
{
	


 
    String renk;
    public void Setrenk(String renk)
    {
        this.renk = renk;
    }
    public String Getrenk()
    {
        return renk;
    }

    private int motorgucu;

    public int Motorgucu
    {
        get { return motorgucu; }
        set { motorgucu = value; }
    }
    private int yolcukapasite;

    public int Yolcukapasite
    {
        get { return yolcukapasite; }
        set { yolcukapasite = value; }
    }
    private String marka;

    public String Marka
    {
        get { return marka; }
        set { marka = value; }
    }
    private int hiz;

    public int Hiz
    {
        get { return hiz; }
        set { hiz = value; }
    }
 int subapsayisi;

    public Araba()
	{
        renk = "pembe";
        motorgucu = 1500;
        marka = "reno";
	}

    public Araba(String rengi, int motorguc, String markasi,int yolcukapasite)
    {
        renk = rengi;
        motorgucu = motorguc;
        marka = markasi;
        this.yolcukapasite = yolcukapasite;
    }
 public void hizlan()
 {
     hiz += 15;
 }
 public void hizlan(int kackm)
 {
     hiz += kackm;
 }

 public void yavasla()
 {
     hiz -= 30;
 }

 public void yavasla(int kackm)
 {
     hiz -= kackm;
 }
 public String bilgiver()
 {

     String veri="Arabnın rengi" + renk + "markası=" +
         marka + "motorgücü=" + motorgucu +"yolcu kapasitesi=" +
         yolcukapasite +"şu anki hızı=" + hiz ;
     return veri;
 }
}