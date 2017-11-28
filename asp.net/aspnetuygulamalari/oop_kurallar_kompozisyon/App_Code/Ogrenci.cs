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

    Adres adres;

    public Adres Adres
    {
        get { return adres; }
        set { adres = value; }
    }

	public Ogrenci()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public String bilgial()
    {
        String sonuc;
        sonuc = "öğrencinin nosu=" + ogno + "ogrencinin adı soyadı=" + adsoyad +
            "öğrenci adresi" + adres.Cadde + "--" + adres.Ilce + "--" + adres.Il;
        return sonuc;
    }
}