using Homework5_Game_.Abstract;
using Homework5_Game_.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5_Game_.Concrete
{
    public class SalesManager : ISalesService
    {
        public void Sales(Game game, Gamer gamer, Campaign campaign)
        {
            Console.WriteLine(gamer.FirstName + " İsimli Oyuncu " + game.GameName + " İsimli Oyunu " + campaign.CampaignName + "Bu  Kampyadan Yararlanarak " + game.Price + " TL'ye Aldı");
        }

        internal void Sales(Gamer gamer1, Game game1, Campaign campaign1)
        {
            throw new NotImplementedException();
        }
    }
}
