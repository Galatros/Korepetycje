using System;
using System.Collections.Generic;
using System.Text;

namespace SolidApi.Repository.Database.Entities
{
    public class UserToCompany
    {
        public int CompanyId { get; set; }
        public int UserId { get; set; }
        public Company Company { get; set; }
        public User User { get; set; }
    }
}
