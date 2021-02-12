using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla(); // alttakiyle aynı sorucu veriyor.

            //Interfacelerde o interfacesi implementte eden classın referens numarasını tutabiliyor. 
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager(); //ihtiyacKrediManager instance oluşturduk.
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            //Bu 3'ü ekranda kullanılabilecek kredi türleri diye düşün. 
            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(ihtiyacKrediManager);

            Console.WriteLine("\n------------------List<IKrediManager>-------- basvuruManager. KrediOnBilgilendirmesiYap(krediler);-----------------\n");
            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager };
            basvuruManager.KrediOnBilgilendirmesiYap(krediler);// Ekran çıktısı İhtiyac kredi ödeme planı hesaplandı.  
                                                               //               Taşıt kredisi ödeme planı hesaplandı.

            Console.WriteLine("\n-------basvuruManager.BasvuruYap(ihtiyacKrediManager, databaseLoggerService);-----------\n");
            //basvuruManager.BasvuruYap(ihtiyacKrediManager,new DatabaseLoggerService());  Böylede yazılabilirdi new DatabaseLoggerService() kısmı
                
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            IKrediManager esnafKrediManager = new EsnafKrediManager();
            //basvuruManager.BasvuruYap(new EsnafKrediManager(), new SmsLoggerService());
            List<ILoggerService> loggers = new List<ILoggerService>() { databaseLoggerService, fileLoggerService,new SmsLoggerService() };

            basvuruManager.BasvuruYap(esnafKrediManager , loggers);
            /*Ekran Çıktısı Esnaf kredi planı hesaplandı.
                            Veritabanına loglandı.
                            Dosyaya loglandı.  
                            Sms loglandı.            */

            

        }
    }
}
