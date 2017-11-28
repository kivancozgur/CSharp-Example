using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Personel
/// </summary>
public class Personel
{
    String adsoyad;

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
    public static int sayac;

	public Personel()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public Personel(String adsoyad, int yas)
    {
        sayac++;
        this.adsoyad = adsoyad;
        this.yas = yas;
    }
}