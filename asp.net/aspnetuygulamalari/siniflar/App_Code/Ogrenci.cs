using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Ogrenci
/// </summary>
public class Ogrenci
{
    public int no;
    public String adsoyad;
    public String adres;
	public Ogrenci()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public String hesaplama(int[] notlar)
    {
        String sonuc;
        int toplam = 0;
        int sayac = 0;
        foreach (int alinan in notlar)
        {
            toplam += alinan;
            if (alinan !=0) sayac++;
        }
        int ort = toplam / sayac;
        if (ort >= 50) sonuc = "Geçti";
        else sonuc = "kaldı";
        return sonuc;
    }

}