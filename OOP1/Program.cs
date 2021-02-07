using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int, doublei,bool.... deger tiptir.
            //dizi, class, abstract class, interface... referans tiptir.

            Product product1 = new Product();  //1 nolu urun
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product { Id = 2, CategoryId = 5, UnitsInStock = 5, ProductName = "Kalem", UnitPrice = 35 }; //2 nolu urun

            //PascalCase Classların ilk harf büyük harfle baslar. 
            //camelCasede  ilk harf kücük sonraki büyük yazılır.
            //   sol stack                           sağ heap
            ProductService productService = new ProductService();

            product1.ProductName = "dolap";
            product1.CategoryId = 20; ;
            product1.UnitPrice = 400;
            product2.Id = 2;
            productService.Add(product1); 
            Console.WriteLine(product1.ProductName); //kamera yazdı. Metotun içinde değiştikten sonra deger o oldu.
            Console.WriteLine(product1.CategoryId); //10 yazdı.
            Console.WriteLine(product1.UnitPrice); //400 yazdı. // Burda metotun içinde UnitPrice değiştirilmedi. Değer tip olarak en son 400 yazdıgımız için bu yazdıırıldı.

            Console.WriteLine("-----------------------------");
            int number1 = 20;
            int number2 = 100;
            var result2 = Deneme(number1,number2);
            Console.WriteLine(result2);//130
            Console.WriteLine(number1);//20 cıktı. ref olarak yazsakdık number1=30 olacaktı.s

            Console.WriteLine("-----------------------------");
            int sayi = 100;
            productService.BirseyYap(sayi); //99 
            Console.WriteLine(sayi); //100
            Console.WriteLine("-----------------------------");

            int toplamaSonucu = productService.Topla(3, 6);
            Console.WriteLine(toplamaSonucu*2); //9*2=18'i gösterir.









        }

        static int Deneme(int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }
    }
        
}
