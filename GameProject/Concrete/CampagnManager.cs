using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " isimli kampanya eklendi!");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " isimli kampanya silindi!");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " isimli kampanya güncellendi!");
        }
    }
}
