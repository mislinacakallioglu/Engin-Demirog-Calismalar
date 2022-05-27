using Homework5_Game_.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5_Game_.Abstract
{
   public interface IGamerService
    {
        void Add(Gamer gamer);
        void Delete(Gamer gamer);
        void Update(Gamer gamer);
    }
}
