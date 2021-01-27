using System;

namespace classIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Kurs kurs1 = new Kurs(); // Sanki sen kendi veri türünü yazıyo gibi dusun
            kurs1.KursAdi = "c#";
            kurs1.Egitmen = "engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs(); // Sanki sen kendi veri türünü yazıyo gibi dusun
            kurs2.KursAdi = "java";
            kurs2.Egitmen = "kerem varış";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs(); // Sanki sen kendi veri türünü yazıyo gibi dusun
            kurs3.KursAdi = "python";
            kurs3.Egitmen = "berkay bilgin";
            kurs3.IzlenmeOrani = 80;

            //Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + ": " + kurs.Egitmen);
            }

        }
        
    }
    class Kurs
    {
        //prop özellik demek. burda kursun 3 özelliği var diyoz
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
