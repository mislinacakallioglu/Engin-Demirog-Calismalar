using Homework5_Game_.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5_Game_.Entities
{
    public class Game:IEntity
    {
        public int Id { get; set; }
        public int GamePrice { get; set; }

        public string GameName { get; set; }
    }
}
