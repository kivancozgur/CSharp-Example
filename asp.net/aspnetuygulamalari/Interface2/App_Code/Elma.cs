using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Elma
/// </summary>
public class Elma:Yenilebilir,Suyucikarilir
{
	public Elma()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public String nasilyenilir()
    {
        return "yıka ısır kes ye";
    }
    public String nasilsuyucikarilir()
    {
        return "robota koy çalıştır suyunu iç";
    }
}