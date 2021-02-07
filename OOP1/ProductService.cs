using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductService
    {
        public void Add(Product urun)
        {
            urun.ProductName = "kamera";
            urun.CategoryId = 10;
            Console.WriteLine(urun.ProductName + "eklendi.");
            
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName+" güncellendi.");
        }



























        public int Topla(int sayi1 , int sayi2)
        {
            int result = sayi1 + sayi2;
            return result;
           
        }
        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1+sayi2);
        }

        public void BirseyYap(int sayi)
        {
            sayi = 99;
            Console.WriteLine(sayi);
        }
            
    }
}
