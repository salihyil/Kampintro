using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {//Burada sepete urun ekleme islemi yapabiliriz.

        public void Ekle(Urun yeni, Urun urun2) // naber degısken ismini istedigini yazabilirsin
        {// Bu daha doğru tercih edilmesi gereken yazım türü alttakine göre
            Console.WriteLine("Tebrikler. Sepete eklendi : " + yeni.Adi + "  " + yeni.Fiyati);

        }


        public void Ekle2(Urun urun1)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi!   " + "StokAdedi: " + urun1.StokAdedi);
        }

        public void deneme(string a)
        {
            Console.WriteLine(a);
        }


    }
}



