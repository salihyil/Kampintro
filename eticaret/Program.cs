using System;

namespace eticaret
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            Product product2 = new Product();
            Product product3 = new Product();

            product1.productName = "iphone";
            product1.productPrice = 12000;

            product2.productName = "samsung";
            product2.productPrice = 10000;

            product3.productName = "xiaomi";
            product3.productPrice = 8000;

            Product[] products = new Product[] { product1, product2, product3 };

            Console.WriteLine("for\n");
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].productName + " " + products[i].productPrice + " tl'dir. ");
            }
            Console.WriteLine("\nforeach\n");

            foreach (var urunler in products)
            {
                Console.WriteLine(urunler.productName + " " + urunler.productPrice + " tl'dir. ");
            }

            Console.WriteLine("\nwhile\n");

            int a = 0;
            while (products.Length > a)
            {
                Console.WriteLine(products[a].productName + " " + products[a].productPrice + " tl'dir. ");
                    a++;
            }

        }
    }
    class Product
    {
        public string productName { get; set; }
        public double productPrice { get; set; }
        

    }
}
