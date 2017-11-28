using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for araba
/// </summary>
public class araba:Arac 
{
    String renk;
    int hiz;
    public static int s;
    private const int a = 9;

    public int A
    {
        get { return a; }
    } 


    public int Hiz
    {
        get { return hiz; }
        set { hiz = value; }
    }
    public String Renk
    {
        get { return renk; }
        set { renk = value; }
    }
    int motorgucu;

    public int Motorgucu
    {
        get { return motorgucu; }
        set { motorgucu = value; }
    }
	public araba()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public araba(String aractangelen,String renk, int motorgucu):base(aractangelen)
    {
  
        this.renk = renk;
        this.motorgucu = motorgucu;
    }
    public araba(int hiz)
    {
        this.hiz = hiz;
    }
    public void hizlan()
    {
     
        hiz += 10;
    }

    public int toplam(int x,int y)
{
    int t=x+y;
    return t;

}
    public double coklutatlim(double[] rakamlar,int x)
{
   double t = 0;
    foreach (double sayi in rakamlar)
    {
        t += sayi;

    }
    return t;
}
    public  override void  yavasla()
    {
        Aracttangelen = "arabada değişti";
    }
}