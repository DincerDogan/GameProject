using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    public class SalesManager : ISalesService
    {
        //Satış
        public void Sales(Game game, Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " - " + game.GameName + " oyununu " + game.GamePrice + " TL'ye satın aldı!" + '\n');
        }
        public void CampaignSales(Game game, Gamer gamer, Campaign campaign)
        {
            int campaignPrice = game.GamePrice - ((game.GamePrice * campaign.DiscountRate) / 100);
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " - " + game.GameName + " oyununu " + campaign.CampaignName + " kampanyası ile %" + campaign.DiscountRate + " indirimle " + campaignPrice + " TL'ye satın aldı!" + '\n');
        }
    }
}
