using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Ogrenci
/// </summary>
public class Ogrenci
{
    int ogno;
    public int Ogno
    {
        get { return ogno; }
        set { ogno = value; }
    }
    String adsoyad;
    public String Adsoyad
    {
        get { return adsoyad; }
        set { adsoyad = value; }
    }
	public Ogrenci()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public override string ToString()
    {
        return adsoyad;
    }
    public override bool Equals(object obj)
    {
        bool sonuc;
        if (this.Ogno == ((Ogrenci)obj).Ogno)
        {
            sonuc = true;
        }
        else
        {
            sonuc = false;
        }
        return sonuc;
    }
}