using System;

namespace InheritanceAndInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            IPersonManager customerPerson = new CustomerManager();
            customerPerson.Add(); // Müsteri eklendi. yazacak.

            IPersonManager employeePerson = new EmployeeManager();
            employeePerson.Add(); // Employee eklendi. yazacak.

            Console.WriteLine("------------------------------------------------");

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(customerPerson); //Müsteri eklendi. yazacak.
            projectManager.Add(employeePerson); //Müsteri eklendi. yazacak.
            projectManager.Update(customerPerson);//Müsteri güncellendi. yazacak.
            projectManager.Add(new InternManager()); // Stajyer eklendi. yazacak.
        }

        interface IPersonManager
        {
            void Add();
            void Update();
        }
        class CustomerManager : IPersonManager
        {
            public void Add()
            {
                Console.WriteLine("Müsteri eklendi.");
            }

            public void Update()
            {
                Console.WriteLine("Musteri güncellendi.");
            }
        }
        class EmployeeManager : IPersonManager
        {
            public void Add()
            {
                Console.WriteLine("Employee eklendi.");
            }

            public void Update()
            {
                Console.WriteLine("Employee güncellendi.");
            }
        }
        // Diyelim yeni talep geldi. Stajyer öğrencininde eklenmesi ve güncellenmesi olsun istenirse 
        class InternManager : IPersonManager
        {
            public void Add()
            {
                Console.WriteLine("Stajyer eklendi.");
            }

            public void Update()
            {
                Console.WriteLine("Stajyer güncellendi.");
            }
        }

        class ProjectManager //tüm projeyi tek noktadan yönetmek istesek. 
        {

            //Her zaman bir nesne ile değil birden fazla nesne ile çalışırsın.
            public void Add(IPersonManager personManager)  //IPerson customerPerson = new CustomerManager(); Bunu yazma sebebimiz burda IPerson ile customerPerson ile EmployeePersona ulaşıyoruz. 
            {
                personManager.Add();           
            }
            public void Update(IPersonManager personManager)  //IPerson customerPerson = new CustomerManager(); Bunu yazma sebebimiz burda IPerson ile customerPerson ile EmployeePersona ulaşıyoruz. 
            {
                personManager.Update();
            }
        }

        
    }
    
}
