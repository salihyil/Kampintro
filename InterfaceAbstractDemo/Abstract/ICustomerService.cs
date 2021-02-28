using System;
using System.Collections.Generic;
using System.Text;
using InterfaceAbstractDemo.Entities;

namespace InterfaceAbstractDemo.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer); // iki firmada save yapmayı istiyor. starbucks ile nero örnekte.  
    }
}
