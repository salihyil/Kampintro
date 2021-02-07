using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety- tip güvenliği
            //string kategoriEtiketi = "Kategori";
            //int ogrenciSayisi = 32000;
            //double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false; // buradaki değer verikaynagindan gelir.
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değiştemedi Butonu");
            
            }
                    

            //if 2 kere tab bas
            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }


        }
    }
}
