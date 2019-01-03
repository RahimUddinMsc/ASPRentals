using AspRentals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace AspRentals.ViewModel
{
    public class ManageMovieViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }

        public int id { get; set; }

        [Required]
        [Display(Name = "Name")]
        public String name { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }        

        [Required]
        [Range(1, 20)]
        [Display(Name = "Number In Stock")]
        public short NumberInStock { get; set; }
        
        [Required]
        public int GenreId { get; set; }

        public ManageMovieViewModel()
        {
            id = 0;
        }

        public ManageMovieViewModel(Movie movie)
        {
            id = movie.id;
            name = movie.name;
            ReleaseDate = movie.ReleaseDate;
            NumberInStock = movie.NumberInStock;
            GenreId = movie.GenreId;
        }

    }
}