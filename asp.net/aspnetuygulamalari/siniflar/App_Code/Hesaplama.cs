using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Hesaplama
/// </summary>
public class Hesaplama
{
	public Hesaplama()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public double toplam(int x, int y)
    {
        double sonuc = x + y;
        return sonuc;
    }
    public double coklutoplam(double[] sayilar)
    {
     double toplam = 0;
        foreach (double alinan in sayilar)
        {
            toplam += alinan;
        }
        return toplam;
    }
}