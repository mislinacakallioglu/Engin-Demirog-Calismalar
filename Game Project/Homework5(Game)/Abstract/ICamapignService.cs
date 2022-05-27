using Homework5_Game_.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5_Game_.Abstract
{
   public  interface ICamapaignService
    {
        void Add(Campaign campaign);
        void Update(Campaign campaign);
        void Delete(Campaign campaign);
    }
}
