using Homework5_Game_.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5_Game_.Entities
{
    public class Gamer:IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }
        public string NationalityId { get; set; }
    }
}
