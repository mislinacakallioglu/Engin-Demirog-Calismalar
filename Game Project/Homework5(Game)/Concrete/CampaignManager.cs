using System;
using System.Collections.Generic;
using System.Text;
using Homework5_Game_.Abstract;
using Homework5_Game_.Entities;

namespace Homework5_Game_.Concrete
{
    public class CampaignManager : ICamapaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya Eklendi : " + campaign.CampaignName);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya Silindi : " + campaign.CampaignName);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya Güncellendi : " + campaign.CampaignName);
        }
    }
}
