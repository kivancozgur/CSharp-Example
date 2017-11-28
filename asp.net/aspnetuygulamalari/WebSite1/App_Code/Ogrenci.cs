using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Ogrenci
/// </summary>
public class Ogrenci
{
	public Ogrenci()
	{
		//
		// TODO: Add constructor logic here
		//
	}
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
    public override string ToString()
    {
        return adsoyad;
    }
    public override bool Equals(object obj)
    {
        bool sonuc=false;
       if (this.ogno ==((Ogrenci)obj).ogno)
       {
         sonuc=true;
       }
       return sonuc;
    }
   
}