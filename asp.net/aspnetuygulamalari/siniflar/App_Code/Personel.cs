using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Personel
/// </summary>
public class Personel
{
    const int karisimdegeri = 10;
    String adsoyad;
    public static int sayac;
    public String Adsoyad
    {
        get { return adsoyad; }
        set { adsoyad = value; }
    }
    int yas;

    public int Yas
    {
        get { return yas; }
        set { yas = value; }
    }

	public Personel()
	{
        sayac++;
		//
		// TODO: Add constructor logic here
		//
	}
    public Personel(String ad, int yas)
    {
       
        sayac++;
        this.adsoyad = ad;
        this.yas = yas;
    }
}