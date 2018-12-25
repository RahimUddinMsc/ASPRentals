using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspRentals.Models
{
    public class Movie
    {
        public int id { get; set; }
        public String name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime DateAdded { get; set; }
        public short NumberInStock { get; set; }
        public Genre Genre { get; set; }
        public int GenreId { get; set; }
    }
}