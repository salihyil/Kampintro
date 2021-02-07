using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> liste = new List<string>() { "ali" };

            MyList<string> isimler = new MyList<string>();  //Kendi List<>'imizi yazdık.
            isimler.Add("Engin");       //MyList<int> isimler olsaydı. Add() icinde int bir deger girilmeliydi.
            isimler.Add("Murat");

            Console.WriteLine(isimler.Lenght);
            Console.WriteLine(liste.Count);

            foreach (var item in isimler.Items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
