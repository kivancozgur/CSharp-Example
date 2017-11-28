using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Arac
/// </summary>
public class Arac
{
    String aracttangelen;

    public String Aracttangelen
    {
        get { return aracttangelen; }
        set { aracttangelen = value; }
    }
    public Arac(String aractangelen)
    {
        this.aracttangelen = aractangelen;
    }
    public virtual void yavasla()
    {
        aracttangelen = "araçç";
    }
    public Arac()
    {

    }
}