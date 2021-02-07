using System;
using System.Collections.Generic;

namespace DictonaryOwn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------OriginalDictonary---------");
            Dictionary<int, string> deneme = new Dictionary<int, string>();
            deneme.Add(3, "ali");
            deneme.Add(2, "ayşe");
            deneme.Add(5, "fatma");

            Console.WriteLine(deneme.Count); //3 yazacak.
            Console.WriteLine(deneme[3]); // ali yazar.
            Console.WriteLine(deneme[2]); // ayşe yazar.
            Console.WriteLine(deneme[5]); // fatma yazar.
            

            Console.WriteLine("\n---------foreach (var denemeler in deneme) Console.WriteLine(denemeler)---------");
            foreach (var denemeler in deneme)
            {
                Console.WriteLine(denemeler);
                //Ekran görüntüsü
                //[3, ali]
                //[2, ayşe]
                //[5, fatma] 
            }
            Console.WriteLine("\n---------foreach (var isim in deneme) Console.WriteLine(isim.Value);---------");
            foreach (var isim in deneme)
            {
                Console.WriteLine(isim.Value);
                //Ekran görüntüsü
                //ali
                //ayşe
                //fatma
            }


            Console.WriteLine("---------MyDictonary---------");
            MyDictionary<int, string> instance = new MyDictionary<int, string>();
            instance.Add(1, "murat");
            instance.Add(2, "hasan");
            instance.Add(3, "burak");
            instance.Add(4, "nisa");
            Console.WriteLine(instance.Count);//4 yazar.
           


            Console.WriteLine("---------MyDictonary2---------");
            MyDictionary<int, string> dayOfWeek = new MyDictionary<int, string>();

            dayOfWeek.Add(1, "Monday");
            dayOfWeek.Add(2, "Tuesday");
            dayOfWeek.Add(3, "Wednesday");
            dayOfWeek.Add(4, "Thursday");
            dayOfWeek.Add(5, "Friday");
            dayOfWeek.Add(6, "Saturday");
            dayOfWeek.Add(7, "Sunday");

            Console.Write(dayOfWeek.Count +" "+ dayOfWeek.GetValue(1)); //7 Monday yazar.

            
        }


    }
    class MyDictionary<TKey, TValue> 
    {
        TKey[] Keys;
        TValue[] Values;
        TKey[] tempKey;
        TValue[] tempValue;
        public MyDictionary()
        {
            Keys = new TKey[0];
            Values = new TValue[0];
        }
        

        public void Add(TKey key, TValue value)
        {
            tempKey = Keys;
            tempValue = Values;

            Keys = new TKey[Keys.Length + 1];
            Values = new TValue[Values.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                Keys[i] = tempKey[i];
                
            }
            for (int i = 0; i < tempValue.Length; i++)
            {
                
                Values[i] = tempValue[i];
            }

            Keys[Keys.Length - 1] = key;
            Values[Values.Length - 1] = value;
        }
        public int Count { get { return Keys.Length; } }

        public TValue GetValue(int key)
        {
            return Values[key-1];
        }


    }
}
