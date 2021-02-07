using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        //snippet hazır kodlar demek    
        public int Id { get; set; }
        public int CategoryId { get; set; }  //refereans anahtarlar 2. srıaya yazarız kod okunurlu arttırır.
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

        //CRUD : creade read update delete
    }
}
