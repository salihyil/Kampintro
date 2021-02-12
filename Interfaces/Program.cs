using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // InterfacesIntro();
            //Demo();
            SqlServerCustomerDal sqlServerCustomerDal = new SqlServerCustomerDal();
            OracleCustomerDal oracleCustomerDal = new OracleCustomerDal();
            MySqlCustomerDal mySqlCustomerDal = new MySqlCustomerDal();

            ICustomerDal[] customerDals = new ICustomerDal[3] { sqlServerCustomerDal, oracleCustomerDal, mySqlCustomerDal };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add(); //Sql Added. Oracle Added. MySql Added.
            }


        }



        private static void Demo()
        {
            SqlServerCustomerDal sqlServerCustomerDal = new SqlServerCustomerDal();
            OracleCustomerDal oracleServerCustomerDal = new OracleCustomerDal();


            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(sqlServerCustomerDal);
            customerManager.Delete(oracleServerCustomerDal);
            customerManager.Update(sqlServerCustomerDal);

        }
        private static void InterfacesIntro()
        {
            /*
            Customer customer = new Customer() {Id=1, FirstName="Salih", LastName="Yılmaz"};
            */
            PersonManager personManager = new PersonManager();
            personManager.Add(new Customer() { Id = 1, FirstName = "Salih", LastName = "Yılmaz", Adress = "Ankara" }); //Cıktısı Salih

            Student student = new Student { Id = 1, FirstName = "Murat", LastName = "Demir", Departmant = "Computer" };
            //ctrl+k ile ctrl+d kodları düzenler.
            Customer customer = new Customer { Id = 2, FirstName = "Ayşe", LastName = "Meşe", Adress = "istanbul" };
            personManager.Add(student); // Çıktısı Murat olcak. Mesela public void Add(Customer customer) yazdıgımız için student kullanamadık ama IPerson Kullansak student classın verilere ulaşırız.
            personManager.Add(customer);// Cıktısı Ayşe
        }
        interface IPerson //soyut nesne insan
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        class Customer : IPerson //somut nesne müsteride bir insan
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Adress { get; set; }
        }
        class Student : IPerson //ögrencide bir insan
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Departmant { get; set; }
        }
        class PersonManager
        {
            public void Add(IPerson person1) //person1 parameter istediğimiz adı verebiliriz.
            {
                Console.WriteLine(person1.FirstName);
            }
        }
    }
}
