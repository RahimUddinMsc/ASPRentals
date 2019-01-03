using AspRentals.Dtos;
using AspRentals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AspRentals.Controllers.Api
{
    public class NewRentalsController : ApiController
    {

        private ApplicationDbContext _context;

        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }

        //create new rental obj for table
        [HttpPost]
        public IHttpActionResult CreateNewRental(NewRentalDto newRental)
        {

            if (newRental.MovieIds.Count == 0)
                return BadRequest("No movie ids have been given");

            var customer = _context.Customers.SingleOrDefault(c => c.Id == newRental.CustomerId);

            if (customer == null)
                return BadRequest("Customer not found");

            var movies = _context.Movies.Where(m => newRental.MovieIds.Contains(m.id)).ToList() ;

            if (movies.Count != newRental.MovieIds.Count)
                return BadRequest("Movie id not found");

            foreach (var movie in movies)
            {
                if (movie.NumberAvailable == 0)
                    return BadRequest("Movie is not available");

                movie.NumberAvailable--;

                var rental = new Rental
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now
                };

                _context.Rentals.Add(rental);
            }

            _context.SaveChanges();

            return Ok();
        }

    }
}
