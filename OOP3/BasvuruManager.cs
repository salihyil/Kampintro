using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager //Bir krediye başvuru yapıcaz.
    {
        //Burada method injection yapılıyor. 
        public void BasvuruYap(IKrediManager krediManager , List<ILoggerService> loggerServices)  //Buraya hangi kredi gerekiyosa onu göndertip işlem yaptıtabiliriz.
        {
            //Birden fazla logger yollamak istiyorsak smslogger, filelogger,databaselogger gibi
            
            //Basvuran bilgilerini degerlendirme
            krediManager.Hesapla() ;
            //IloggerService.Log(); //Sistemde hangi log seçilmişse onu logla demek bu.

            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }

            /* Tüm basvurular  konut kredisi üzerinden hesaplanır aşağıdakini yazarsak.Tüm basvurular konut kredisine bağımlı oldu.)
            IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            ihtiyacKrediManager.Hesapla(); */
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler) //Birden fazla kredinin hesabını yapmak istiyorsak List<IKrediManager>
        {
            foreach (var kredi in krediler)  //Burda her bir kredi türlerini tek tek bakar.
            {
                kredi.Hesapla();
            }

        }
    }
}
