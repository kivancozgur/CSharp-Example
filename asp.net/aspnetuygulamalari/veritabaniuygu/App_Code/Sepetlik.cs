using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Sepetlik
/// </summary>
public class Sepetlik
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



	public Sepetlik()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}