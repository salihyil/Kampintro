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
            sepetManager.deneme("naber");
            

            Console.WriteLine("\n----------Metotlar------------\n");

            // Default Parametreli Metotlarla Çalışmak Default en son parametreen verilerek yapılır.
           
            
            Console.WriteLine("\n----------Metotlar------------\n");
            static void Hesapla()
            {
                Console.Write("Kısa kenarı girin :");
                int kisaKenar = Convert.ToInt32(Console.ReadLine());
                Console.Write("Uzun kenarı girin :");
                int uzunKenar = Convert.ToInt32(Console.ReadLine());
                int alan = kisaKenar * uzunKenar;
                Console.WriteLine("Alan = {0}", alan);
            }
            Hesapla();

            Console.WriteLine("\n----------Overloading------------\n");

            Console.WriteLine(Multiply(1,2));
            Console.WriteLine(Multiply(1,2,3));






        }
        static int Multiply(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;

        }

        static int Multiply(int sayi1, int sayi2, int sayi3)
        {
            return sayi1 * sayi2 * sayi3;

        }
        
            
       
    }
}

