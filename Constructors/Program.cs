using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer(); // Diger türlü yazılışı Customer customer1 = new Customer { Id = 1, FirsName="Salih",LastName="Yılmaz",City="İstanbul"};
            customer1.Id = 1;
            customer1.FirsName = "Salih";
            customer1.LastName = "Yılmaz";
            customer1.City = "İstanbul";

            Customer customer2 = new Customer() { Id = 2, FirsName = "Rauf", LastName = "Denktaş", City = "Rize" };


            Customer customer3 = new Customer(3, "Fatma", "Yılmaz","İstanbul"); // Burada paremetre giriyoruz. () içine yazıyoruz.

            Console.WriteLine(customer1.FirsName);
            Console.WriteLine(customer2.FirsName);
            Console.WriteLine(customer3.FirsName);

        }
    }

    class Customer  //müsterilerin bilgilerini yönettiğimiz bir class
    {
        
        public Customer()  //Customer customer = new Customer();   new Customer(); Burası
        {//BU default constructor

        }
            //constructor bir metot gibi çalışır.
        public Customer(int id,string firstName, string lastName, string city)  //Overloading yapılabilinir.
        {
            //Metot parametreleri camelCase yazılır.
            Id = id;
            FirsName = firstName;
            LastName = lastName;
            City = city;

        }

        public int Id { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }       
}
