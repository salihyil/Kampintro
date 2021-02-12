using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Corporate(Tüzel-Kurumsal demek)
    //miras=(inheritance)
    class TuzelMusteri:Musteri //Burası tüzelmüsteri musteri içindeki özellikleri kullanabilsin demek.
    {
        
        
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
