using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //implement= uygulamak
    interface IKrediManager  //interface benim şablonum görevi görüyor. interface okunurluğu arttırmak için Başına IKrediManager I gelir.
    {                        //Bir interface sunu anlatır.Bu interface kullanılıcaksa içindeki metotdun kullanması zorunludur. İnterface arayüz şablon bu şablona uyulmaz zorunda demek.          
        void Hesapla();       //İhtiyac,Taşıt,konutManagerların hepsinde hesapla() BiseyYap() olacak ama kendi içlerinde farklı degerler işlemler döndürecekleri için. KrediManageri İnterface yapıyoruz.
        void BiseyYap();
    }

    
        
    
}
