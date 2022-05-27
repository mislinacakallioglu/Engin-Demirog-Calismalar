using Homework5_Game_.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5_Game_.Abstract
{
  public interface ISalesService
    {
        void Sales(Game game, Gamer gamer, Campaign campaign);
    }
}
