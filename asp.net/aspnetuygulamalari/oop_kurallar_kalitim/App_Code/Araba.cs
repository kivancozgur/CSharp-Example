using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Araba
/// </summary>
public class Araba:Arac 
{
    String kasatipi;

    public String Kasatipi
    {
        get { return kasatipi; }
        set { kasatipi = value; }
    }
    String yakittipi;

    public String Yakittipi
    {
        get { return yakittipi; }
        set { yakittipi = value; }
    }

    public Araba(String yakittipi,String kasatipi)
    {
        this.Yakittipi = yakittipi;
        this.kasatipi = kasatipi;
    }

    public Araba()
    {

    }

}