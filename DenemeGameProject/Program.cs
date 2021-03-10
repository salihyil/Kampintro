using System;
using DenemeGameProject.Concrete;
using DenemeGameProject.Entities;

namespace DenemeGameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new GamerValidationManager() );
            gamerManager.GamerAdd(new Gamer(){Id = 1,FirstName = "salih",LastName = "yılmaz"});

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.CampaignAdd(new Campaign(){CampaignName = "İndirim"});

            SaleManager saleManager = new SaleManager();
            saleManager.Sale(new Sale(){OrderNumber = 50});






        }
    }
}
