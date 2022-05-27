using Homework5_Game_.Abstract;
using Homework5_Game_.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;


namespace Homework5_Game_.Adapters
{
    public class MernisServiceAdapter : IGamerCheckService
    {
        public bool CheckGamerService(Gamer gamer)
        {
            KPSPublicSoapClient _gamer = new KPSPublicSoapClient();
            return _gamer.TCKimlikNoDogrulaAsync(gamer.NationalityId, gamer.FirstName.ToUpper(), gamer.LastName.ToUpper(), gamer.DateOfBirth);
        }
    }
}
