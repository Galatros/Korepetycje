using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SolidApi.Repository.Database.Entities
{
   public class Company
    {
        public string Name { get; set; }

        [Key]
        public int Id { get; set; }
    }
}
