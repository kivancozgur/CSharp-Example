using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Ogrenci2
/// </summary>
public class Ogrenci2
{
    String[] adlar = new String[2];

    public String[] Adlar
    {
        get { return adlar; }
        set { adlar = value; }
    }
    int[] notlar = new int[3];

    public int[] Notlar
    {
        get { return notlar; }
        set { notlar = value; }
    }
    int[] ortalamalar = new int[2];

	public Ogrenci2()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public void hesapla(int ogrencino)
    {
        int toplam = 0;
        foreach (int nott in notlar)
        {
            toplam += nott;
        }
        ortalamalar[ogrencino] = toplam / 3;
    }

    public String sirala()
    {
        String sonuc;
        int enb=0;
        int enk=0;
        for (int i = 0; i < 2; i++)
        {
            if (ortalamalar[enb]<ortalamalar[i]) enb=i;
            if (ortalamalar[enk] >ortalamalar[i]) enk = i;
        }
sonuc = "en büyük not" + adlar[enb] + "isimli öğrenciye " + ortalamalar[enb] + "ortalama ile aittir" + "en küçük not" 
+ adlar[enk] + "isimli öğrenciye " + ortalamalar[enk] + "ortalama ile aittir";
    return sonuc;
    }
}