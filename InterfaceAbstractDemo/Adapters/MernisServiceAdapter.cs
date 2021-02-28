using System;
using System.Collections.Generic;
using System.Text;
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using MernisServiceReference1;


namespace InterfaceAbstractDemo.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
           KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
           return client.TCKimlikNoDogrulaAsync(
               new TCKimlikNoDogrulaRequest
                   (new TCKimlikNoDogrulaRequestBody(customer.NationalityId,customer.FirstName,customer.LastName,customer.DateOfBirth))).Result.Body.TCKimlikNoDogrulaResult;

           //


        }
    }
}
