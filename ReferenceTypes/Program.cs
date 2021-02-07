using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //int,decimal,float,enum,boolean value type
            int sayi1 = 10;
            int sayi2 = 20;
            sayi1 = sayi2;
            sayi2 = 30;
            Console.WriteLine(sayi1); //20 yazacak.

            Console.WriteLine("--------------------------------------- ");

            //array, class, interface reference type 
            int[] sayilar1 = new int[] { 1, 2, 3 };                //stack heap 2 ksıım var. new int[] yazılınca heap oluşur. 
            int[] sayilar2 = new int[] { 10, 20, 30 };
            sayilar1 = sayilar2;
            sayilar2[0] = 1000;
            Console.WriteLine(sayilar1[0]); // 1000 yazdı.
            Console.WriteLine(sayilar1[1]); // 20 yazdı.
            Console.WriteLine(sayilar1[2]); // 30 yazdı.

            Console.WriteLine("--------------------------------------- ");

            Person person1 = new Person();
            person1.FirstName = "Engin";
            
            Person person2 = new Person();
            
            person2 = person1;
            person1.FirstName = "Derin";
            Console.WriteLine(person2.FirstName); // Derin yazacak.


            Console.WriteLine("--------------------------------------- ");
            Customer customer = new Customer();
            customer.FirstName = "Salih";

            customer.CreditCardNumber = "1234567890";

            Employee employee = new Employee();
            employee.FirstName = "Kadir";
            employee.EmployeeNumber = 987;

            // customer = employee;  Birbirine eşitleyemeyiz.    Cannot implicitly convert type 'ReferenceTypes.Program.Employee' to 'ReferenceTypes.Program.Customer'   

            Console.WriteLine("--------------------------------------- ");

            //Peki person degiskenlerinde Customer classındaki degiskenleri nasıl kullanabiliriz?

            Person person3 = customer;  //class Customer:Person yazdıgımız için eşitleyebiliyoruz.
            
            customer.FirstName="Ahmet";
            Console.WriteLine(person3.FirstName);  //Ahmet
            Console.WriteLine(((Customer)person3).CreditCardNumber); //1234567890 //person3'de Customer classın içindeki veri tiplerini kullanabilmek.

            Console.WriteLine("-------------------personManager.Add(employee);--------------------");

            PersonManager personManager = new PersonManager();
            personManager.Add(employee); //Kadir yazacak.
            personManager.Add(customer); // Ahmet yazacak



        }

        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

        }
        class Customer:Person //:Person yazınca Yukarıda tanımladıgımız customer degişkenine Person classındaki verileri kullanabileceğimizi söylüyoruz.
                               //41.satırda customer.FirstName = "Salih";
        {
            public string CreditCardNumber { get; set; }
            
        }

        //base class:  Person
        class Employee:Person
        {
            public int EmployeeNumber { get; set; }
        }

        class PersonManager
        {
            public void Add(Person person)
            {
                Console.WriteLine(person.FirstName);
            }
        }

        
    }
}
