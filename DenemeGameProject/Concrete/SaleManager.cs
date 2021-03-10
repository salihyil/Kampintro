using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;
using DenemeGameProject.Abstract;
using DenemeGameProject.Entities;

namespace DenemeGameProject.Concrete
{
    class SaleManager : ISaleService
    {
        
        public void Sale(Sale sale)
        {
            if (sale.OrderNumber==50)
            {
                Console.WriteLine("{0} tl satış oldu.",sale.OrderNumber);
                Console.WriteLine("Kampanya eklendi.");
            }
            else
            {
                Console.WriteLine("Satış olmadı.");
            }
        }
    }
}
