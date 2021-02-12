using System;

namespace Inheritance //Kalıtım, miras
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Customer customer = new Customer();
            Student student = new Student();

            Person[] persons = new Person[3]{ person1,customer,student };
            person1.FirstName = "salih";
            customer.FirstName = "engin";
            student.FirstName = "derin";

            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }

        }

    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Customer : Person
    {
        public string City { get; set; }
    }
    class Student : Person
    {
        public string Departmant { get; set; }

    }

}