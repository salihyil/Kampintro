using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] kurslar = new string[] {"Yazılım Geliştirme Kursu",
            "Programlamaya başlangıç Kursu","java"};
            
           
            for (int i = 0, a = 10; i < kurslar.Length; i++)
            {
                Console.WriteLine(a);
                Console.WriteLine(kurslar[i] );
                
            }
            Console.WriteLine("\n-------\n");

            foreach (string kurs in kurslar) //Kurslar içindekileri tek tek dolaş demek
            {
                Console.WriteLine(kurs );
            }
            
        }
    }
}
