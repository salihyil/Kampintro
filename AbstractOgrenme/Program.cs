using System;

namespace AbstractOgrenme
{
    class Program
    {
        static void Main(string[] args)
        {
            //Abstract classlar hem tamamlanmış hemde tamamlanmamış operasyon içerebilen classdır.

            //MevzuatBase mevzuatBase = new MevzuatBase(); Absract classlar newlenemez.
            AMevzuat aMevzuat = new AMevzuat();
            aMevzuat.Kaydet(); // Kaydet() abstractın içinde ama isteğe bağlı kullanılabiliyor.  

        }

        abstract class MevzuatBase
        {
            public abstract void Degerlendirme(); //Bu tamamlanmamış operasyon
            public void Kaydet() 
            {
                Console.WriteLine("Kaydedildi.");
            }
        }

        class AMevzuat : MevzuatBase
        {
            public override void Degerlendirme()
            {
                Console.WriteLine();
            }
        }
        



        
        ///////////////////////////////////////////////////////////////////////////////////
        class OrnekBase
        {
            //void ddd(); normal classlarda tamamlanmamış operasyon olmaz. 
            public void Naber() 
            { 
                Console.WriteLine("Yazdır");  
            }
            public string ozellik { get; set; }
        }
        
        class Ornek1: OrnekBase // normal class ile normal classda digerinin OrnekBase içindeki metot kullanılması zorunlu değil.
        {
            public int MyProperty { get; set; }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        


    }
}
