using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Uye
/// </summary>
public class Uye
{
    private int uyeid;

    public int Uyeid
    {
        get { return uyeid; }
        set { uyeid = value; }
    }
    private String kuladi;

    public String Kuladi
    {
        get { return kuladi; }
        set { kuladi = value; }
    }
    private String sifre;

    public String Sifre
    {
        get { return sifre; }
        set { sifre = value; }
    }
    private String adsoyad;

    public String Adsoyad
    {
        get { return adsoyad; }
        set { adsoyad = value; }
    }
    private DateTime dogtar;

    public DateTime Dogtar
    {
        get { return dogtar; }
        set { dogtar = value; }
    }
    private Boolean cins;

    public Boolean Cins
    {
        get { return cins; }
        set { cins = value; }
    }
    private String adres;

    public String Adres
    {
        get { return adres; }
        set { adres = value; }
    }
    private Sehirler sehir;

    public Sehirler Sehir
    {
        get { return sehir; }
        set { sehir = value; }
    }
    private String email;

    public String Email
    {
        get { return email; }
        set { email = value; }
    }
    private Meslek meslek;

    public Meslek Meslek
    {
        get { return meslek; }
        set { meslek = value; }
    }

	public Uye()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}