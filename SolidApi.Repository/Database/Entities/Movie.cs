using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SolidApi.Repository.Database.Entities
{
   public class Movie
    {
        [Key]
        public int Id { get; set; }

        public string Tittle { get; set; }
    }
}
