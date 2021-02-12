using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class KonutKrediManager : IKrediManager  //IKrediManager üzerine gelip implement interface diyoruz. Altta metotları oto yazıyor.
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Konut kredi ödeme planı hesaplandı.");
        }
    }
}
