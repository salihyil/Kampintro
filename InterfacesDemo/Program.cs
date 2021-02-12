using System;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //şirketin 3 tane çalışan olsun. işci, yönetici, robotlar hepsinin ortak özelliği worker olması. Ve ortak metotları Work,Eat,GetSalary 
            // Fakat robot eat ve GetSalary olmaz. Bu yüzden Çoklu İmplementasyon yapmamız gerekti.

            Manager manager = new Manager();
            Worker worker = new Worker();
            Robot robot = new Robot();
            IWorker[] workers = new IWorker[3] {manager,worker, robot };
            foreach (var worker1 in workers)
            {
                worker1.Work();
            }
            IEat[] eats = new IEat[2] { manager, worker};
            foreach (var eat in eats)
            {
                eat.Eat();
            }
        }

        interface IWorker
        {
            void Work();

        }
        interface IEat
        {
            void Eat();

        }
        interface ISalary
        {
            void GetSalary();

        }
        class Manager : IWorker, IEat, ISalary //Çoklu İmplementasyon classların birden fazla ınterfacesi olmasıdır.
        {
            public void Work()
            {
                Console.WriteLine("Manager work");
            }
            public void Eat()
            {
                Console.WriteLine("Manager eat");
            }

            public void GetSalary()
            {
                throw new NotImplementedException();
            }

            
        }
        class Worker : IWorker,IEat, ISalary
        {
            public void Work()
            {
                Console.WriteLine("Worker work");
            }
            public void Eat()
            {
                Console.WriteLine("Worker eat");
            }

            public void GetSalary()
            {
                throw new NotImplementedException();
            }

            
        }

        class Robot : IWorker
        {
            public void Work()
            {
                Console.WriteLine("Robot work");
            }
        }
    }
}
