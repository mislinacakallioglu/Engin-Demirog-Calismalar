using Homework5_Game_.Abstract;
using Homework5_Game_.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5_Game_.Concrete
{
    public class GamerManager : IGamerService
    {
        IGamerCheckService _gamerCheckService;
        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }
        public void Add(Gamer gamer)
        {
            if (_gamerCheckService.CheckGamerService(gamer))
                Console.WriteLine("Oyuncu Eklendi : " + gamer.FirstName);

            else
                Console.WriteLine("Böyle bir oyuncu bulunmamaktadır.Tekrar deneyiniz!");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Silindi : " + gamer.FirstName);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Güncellendi : " + gamer.FirstName);
        }
    }
}
