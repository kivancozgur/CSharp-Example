using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Islem
/// </summary>
public class Islem
{
   public int sayi1;
   public int sayi2;
	public Islem()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public int hesaplama(int secim)
    {
        int sonuc = 0;
        switch (secim)
        {
            case 1:
               sonuc= sayi1 + sayi2;
                return sonuc;
          
            case 2:
  sonuc = sayi1 - sayi2;
                return sonuc;
             
            case 3:
                sonuc = sayi1 *sayi2;
                return sonuc;
               
            case 4:
                sonuc = sayi1 /sayi2;
                return sonuc;
               
        }//switch
        return 0;
    }//metot bitişi
}