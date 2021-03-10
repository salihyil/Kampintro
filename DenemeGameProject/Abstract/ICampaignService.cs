using System;
using System.Collections.Generic;
using System.Text;
using DenemeGameProject.Entities;

namespace DenemeGameProject.Abstract
{
    interface ICampaignService
    {
        void CampaignAdd(Campaign campaign);
        void CampaignDelete(Campaign campaign);
        void CampaignUpdate(Campaign campaign);
    }
}
