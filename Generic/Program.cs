using System;
using System.Collections.Generic;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[] { 1, 2, 3 };
            Console.WriteLine(dizi.Length);//3 yazar.
            Console.WriteLine("-------------------------------------------");


            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");
            

            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("İstanbul");
            sehirler2.Add("İstanbul");
            sehirler2.Add("İstanbul");
            sehirler2.Add("İstanbul");
            

            Console.WriteLine(sehirler2.Count); // 4 yazdı.
            Console.WriteLine("-------------------------------------------");

            
            

        }
    }

    class MyList<T> //Buraya Generic class denir.  Typedan geldiği için <T> yazdık.
    {
        T[] _array; // datanın kendisi.
        T[] _tempArray; // yedeği almak için bunu yazdık(geçici array)

        public MyList()  // MyListi newlediğimizde burası çalışıyor.
        {
            _array = new T[0]; //0 elemanlı bir erray yapmış olduk. 
        }
        public void Add(T item) //eleman ekleme kısmı
        {
            _tempArray = _array; //_tempArray _tempArray'in referansını tutuyor.
            _array = new T[_array.Length + 1]; // 1 tane daha erray ekletiyor. Fakat sorun yeni referans alacagından (newden dolayı) öncegi degerin yedeğini almak lazım. Onuda  _tempArray kullanıyoruz.

            for (int i = 0; i < _tempArray.Length; i++)
            {
                _tempArray[i] = _array[i];
            }

            _array[_array.Length - 1]= item;
        }
        
       
        public int Count //Properties propfull kullandık. //_Array içindeki deger sayısını verir.
        {
            get { return _array.Length; }
        }


    }
}
