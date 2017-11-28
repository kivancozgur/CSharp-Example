using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Kedi
/// </summary>
public class Kedi:Hayvan 
{
	public Kedi()
	{
        
		//
		// TODO: Add constructor logic here
		//
	}
    public override string sescikar()
    {
        return "miyav";
    }
    public override bool Equals(object obj)
    {
        return base.Equals(obj);
    }
    public override string ToString()
    {
        return "aloo";
    }
}