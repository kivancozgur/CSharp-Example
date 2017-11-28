using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Subaru
/// </summary>
public class Subaru:Araba 

{
    String model;

    public String Model
    {
        get { return model; }
        set { model = value; }
    }
    int uretimyili;

    public int Uretimyili
    {
        get { return uretimyili; }
        set { uretimyili = value; }
    }

    public Subaru(String model, int uretyili,String yakittipi,String kasatipi):base(yakittipi,kasatipi)
    {
        this.model = model;
        this.uretimyili = uretyili;
    }
    public Subaru()
    {

    }
}