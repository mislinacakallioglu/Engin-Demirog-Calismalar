using Homework5_Game_.Abstract;
using Homework5_Game_.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5_Game_.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("Oyun Eklendi : "+ game.GameName);
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Oyun Silindi : " + game.GameName);
        }

        public void Update(Game game)
        {
            Console.WriteLine("Oyun Güncellendi : " + game.GameName);
        }
    }
}
