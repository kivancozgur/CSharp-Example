using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Siparislik
/// </summary>
public class Siparislik
{
    Urun urun;

    public Urun Urun
    {
        get { return urun; }
        set { urun = value; }
    }
    int adet;

    public int Adet
    {
        get { return adet; }
        set { adet = value; }
    }
    DateTime sip_tarihi;

    public DateTime Sip_tarihi
    {
        get { return sip_tarihi; }
        set { sip_tarihi = value; }
    }
    int sipno;

    public int Sipno
    {
        get { return sipno; }
        set { sipno = value; }
    }


	public Siparislik()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}