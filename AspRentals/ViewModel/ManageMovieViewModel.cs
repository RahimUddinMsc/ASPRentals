using AspRentals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspRentals.ViewModel
{
    public class ManageMovieViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        public Movie Movie { get; set; }
        
    }
}