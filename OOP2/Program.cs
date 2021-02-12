using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {   //implement = uygulamak,yerine getirmek

            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Salih";
            musteri1.Soyadi = "Yılmaz";
            musteri1.TcNo = "123456789010";

            //kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";


            //Gerçek Müsteri(individual) - Tüzel Müşteri(corporate)  2side müşteri ama farklı müsteri tipleri o yüzden birbirlerinin yerine kullanılamaz. 
            //Bunlara 2 farklı class oluşturmak lazım. GercekMusteri ve TuzelMusteri gibi.


            Musteri musteri3 = new GercekMusteri(); // Musteri GercekMusteri referansını tutabiliyor hemde TuzelMusteri
            Musteri musteri4 = new TuzelMusteri(); 
            
            //Eger base sınıfın varsa o referans tutucudur.

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);
            customerManager.Add(musteri3);
            customerManager.Add(musteri4);



        }
    }
}
