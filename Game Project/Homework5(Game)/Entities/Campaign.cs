using Homework5_Game_.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5_Game_.Entities
{
  public   class Campaign:IEntity
    {
        public int Id { get; set; }
        public string CampaignName { get; set; }
    }
}
