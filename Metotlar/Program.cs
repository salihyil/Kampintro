using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
     

            Urun urun1 = new Urun(); //Urun classda bir değişken tanımlayacagın zaman
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";
            urun1.StokAdedi = 10;
            

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";
            

            Urun[] urunler = new Urun[] {urun1,urun2 }; //genelde bu urun1  bir veri kaynagından gelir.

            foreach (Urun urunum in urunler)  //urunlerin içinde tek tek geziyor. urun1 ile urun2 gibi
            {/*urunum kısmına istediğin yazılabilir*/

                Console.WriteLine(urunum.Adi);
                Console.WriteLine(urunum.Fiyati);
                Console.WriteLine(urunum.Aciklama);
                Console.WriteLine("------------");

            }

            Console.WriteLine("\n----------Metotlar------------\n");

            //instance - örnek
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1,urunler[0]); // urun1 ile metotdaki naber aynı oldugunu belirtik.
            sepetManager.Ekle(urun2,urun2);
            sepetManager.Ekle2(urun1);
            

        }

    }
    
}
