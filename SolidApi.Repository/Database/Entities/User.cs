using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SolidApi.Repository.Database.Entities
{
   public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        public Company Company { get; set; }

        public IEnumerable<UserToCompany> UserToCompanies { get; set; }
    }
}
