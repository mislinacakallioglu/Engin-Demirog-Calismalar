using Homework5_Game_.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5_Game_.Abstract
{
    public interface IGameService
    {
        void Add(Game game);
        void Update(Game game);
        void Delete(Game game);
    }
}
