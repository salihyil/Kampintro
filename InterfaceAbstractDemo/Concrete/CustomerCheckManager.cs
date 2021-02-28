using System;
using System.Collections.Generic;
using System.Text;
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using MernisServiceReference1;

namespace InterfaceAbstractDemo.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService //Burda diğer şirketlerde mernis sisteme geçmek isterse diye yazıyoruz.
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            //MernisServiceReference.KPSPublicSoapClient client = new KPSPublicSoapClient();   //CheckIfRealPerson içine böyle yazmak önerilmiyor. Çünkü yarın birgün mernis değil başka birşey kullanılırsa sistemimiz çalışmaz. Kendi veritabanımızı  kullanıcaz desek yine sıkıntı çıkarır.

            return true;
        }
    }
}
