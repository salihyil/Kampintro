using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService   //ortak kod implementasyonu var.O yüzden bu class oluşturuldu. NeroCustomerManager ve StarbucksCustomerManager da yazılacaktı.
    {//abstract class yapıyoruz.
        
        public virtual void Save(Customer customer) // virtual kullandık.
        {//Veritabanına yazma kodu yazılacak normalde buraya

            Console.WriteLine("Saved to db: " + customer.FirstName);
        }
    }
}
