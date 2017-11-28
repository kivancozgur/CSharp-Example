using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Arac
/// </summary>
public class Arac
{
    int hiz;

    public int Hiz
    {
        get { return hiz; }
        set { hiz = value; }
    }

    int motorhacmi;

    public int Motorhacmi
    {
        get { return motorhacmi; }
        set { motorhacmi = value; }
    }
    int yolcukapasitesi;

    public int Yolcukapasitesi
    {
        get { return yolcukapasitesi; }
        set { yolcukapasitesi = value; }
    }
    String renk;

    public String Renk
    {
        get { return renk; }
        set { renk = value; }
    }

    public void hizlan()
    {
        hiz += 15;
    }

	public Arac()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}