using System;
using System.Collections.Generic;
using System.Text;
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;

namespace InterfaceAbstractDemo.Concrete
{
    public class StarbucksCustomerManager : BaseCustomerManager
    {
        private ICustomerCheckService _customerCheckService;

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer) //Önce müsteri kaydettik.
        {

            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer); // Sonra kaydedilen müsteri uyuşuyosa buraya girecek.
            }
            else
            {
                 throw new Exception("Not a valid person."); // Müsteri uyuşmuyorsa Geçerli bir kişi değil. mesajı verecek.
            }
           
            
            

        }

    }
}
