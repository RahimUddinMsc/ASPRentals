using AspRentals.Dtos;
using AspRentals.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AspRentals.Controllers.Api
{
    public class MoviesApiController : ApiController
    {
        ApplicationDbContext _context;

        public MoviesApiController()
        {
            _context = new ApplicationDbContext();
        }
        
        //Get all Movies
        public IHttpActionResult GetMovies(string query = null)
        {
            var moviesQuery = _context.Movies.Include(m => m.Genre).Where(m => m.NumberAvailable > 0);

            if (!string.IsNullOrWhiteSpace(query))
                moviesQuery = moviesQuery.Where(m => m.name.Contains(query));

            var movieDto = moviesQuery.ToList().Select(Mapper.Map<Movie, MovieDto>);

            return Ok(movieDto);
        }

        //Get Movie       
        public IHttpActionResult GetMovie(int id)
        {
            var movieInDb = _context.Movies.SingleOrDefault(m => m.id == id);

            if (movieInDb == null)
                return NotFound();

            return Ok(Mapper.Map<Movie, MovieDto>(movieInDb));
        }

        //Create Movie
        //Post
        [HttpPost]
        public IHttpActionResult CreateMovie(MovieDto movieDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var movieInDb = Mapper.Map<MovieDto, Movie>(movieDto);

            _context.Movies.Add(movieInDb);
            _context.SaveChanges();

            movieDto.id = movieInDb.id;

            return Created(new Uri(Request.RequestUri + "/" + movieInDb.id.ToString()), movieInDb);

        }

        //Edit Movie
        //Post
        [HttpPut]
        public void EditMovie(int id, MovieDto movieDto)
        {
            if (!ModelState.IsValid)
                BadRequest();

            var movieInDb = _context.Movies.SingleOrDefault(m => m.id == id);

            if (movieInDb == null)
                NotFound();

            Mapper.Map(movieDto, movieInDb);

            _context.SaveChanges();
        }

        //Delete Movie
        //Post
        [HttpDelete]
        public void DeleteMovie(int id)
        {
            var movieInDb = _context.Movies.SingleOrDefault(m => m.id == id);

            if (movieInDb == null)
                NotFound();

            _context.Movies.Remove(movieInDb);
            _context.SaveChanges();

        }

    }
}
