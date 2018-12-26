using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace AspRentals.Models
{
    public class Movie
    {
        public int id { get; set; }

        [Required]
        [Display(Name = "Name")]
        public String name { get; set; }
        
        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }

        public DateTime DateAdded { get; set; }

        [Required]
        [Display(Name = "Number In Stock")]
        public short NumberInStock { get; set; }


        public Genre Genre { get; set; }
        public int GenreId { get; set; }
    }
}