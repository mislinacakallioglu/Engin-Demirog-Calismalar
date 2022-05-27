using Homework5_Game_.Adapters;
using Homework5_Game_.Concrete;
using Homework5_Game_.Entities;
using System;

namespace Homework5_Game_
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer();

            gamer1.Id = 1;
            gamer1.FirstName = "Mislina";
            gamer1.LastName = "Çakallıoğlu";
            gamer1.DateOfBirth = "26.12.1999";
            gamer1.NationalityId = "12356789011";

            Gamer gamer2 = new Gamer();
            
            gamer2.Id = 2;
            gamer2.FirstName = "Enes";
            gamer2.LastName = "Çakallıoğlu";
            gamer2.DateOfBirth = "02.01.1995";
            gamer2.NationalityId = "12356789012";

            Game game1 = new Game();

            game1.Id = 1;
            game1.GameName = "NFS";
            game1.GamePrice = 200;

            Game game2 = new Game();
            
            game2.Id = 2;
            game2.GameName = "Counter Strike";
            game2.GamePrice = 100;


            Campaign campaign1 = new Campaign();

            campaign1.Id = 1;
            campaign1.CampaignName = "Hızlı Araba Sürelim";

            Campaign campaign2 = new Campaign();

            campaign2.Id = 2;
            campaign2.CampaignName = "Hızlı Hareket Edelim";

            GamerManager gamer = new GamerManager(new MernisServiceAdapter());
            gamer.Add(gamer1);
            
            SalesManager salesManager = new SalesManager();
            salesManager.Sales(gamer1, game1, campaign1);

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(new Campaign());

            GameManager gameManager = new GameManager();
            gameManager.Delete(game1);
        }
    }
}
