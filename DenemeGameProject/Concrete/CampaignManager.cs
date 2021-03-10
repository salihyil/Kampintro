using System;
using System.Collections.Generic;
using System.Text;
using DenemeGameProject.Abstract;
using DenemeGameProject.Entities;

namespace DenemeGameProject.Concrete
{
    class CampaignManager : ICampaignService
    {
        
        public void CampaignAdd(Campaign campaign)
        {
            Console.WriteLine("{0} Kampanyası  eklendi.",campaign.CampaignName);

        }

        public void CampaignDelete(Campaign campaign)
        {
            Console.WriteLine("Kampanya silindi.");
        }

        public void CampaignUpdate(Campaign campaign)
        {
            Console.WriteLine("Kampanya güncellendi.");
        }
    }
}
