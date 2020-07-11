using System.ComponentModel.DataAnnotations;

namespace SolidApi.Repository.Database.Entities
{
   public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public Company Company { get; set; }
    }
}
