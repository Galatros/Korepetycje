using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SolidApi.Repository.Database.Entities
{
   public class Series
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Tittle { get; set; }

        public Company Company { get; set; }
    }
}
