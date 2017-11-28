using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Urun
/// </summary>
public class Urun
{
    int urunid;

    public int Urunid
    {
        get { return urunid; }
        set { urunid = value; }
    }
    String urunadi;

    public String Urunadi
    {
        get { return urunadi; }
        set { urunadi = value; }
    }
    double fiyat;

    public double Fiyat
    {
        get { return fiyat; }
        set { fiyat = value; }
    }
    String aciklama;

    public String Aciklama
    {
        get { return aciklama; }
        set { aciklama = value; }
    }
    Kategori kategori;

    public Kategori Kategori
    {
        get { return kategori; }
        set { kategori = value; }
    }

    String resim;

    public String Resim
    {
        get { return resim; }
        set { resim = value; }
    }




	public Urun()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}