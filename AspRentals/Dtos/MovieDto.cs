using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AspRentals.Dtos
{
    public class MovieDto
    {
        public int id { get; set; }

        [Required]
        public String name { get; set; }

        [Required]
        public DateTime? ReleaseDate { get; set; }

        [Required]
        public DateTime DateAdded { get; set; }

        [Required]
        [Range(1, 20)]
        public short NumberInStock { get; set; }

        public GenreDto Genre { get; set; }

        [Required]
        public int GenreId { get; set; }
    }
}