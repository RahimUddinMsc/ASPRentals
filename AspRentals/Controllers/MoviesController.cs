﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspRentals.Models;
using AspRentals.ViewModel;

namespace AspRentals.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { id = 1, name = "Shrek" },
                new Movie { id = 2, name = "Wall-e" }
            };
        }

        public ActionResult Random()
        {
            var movie = new Movie() {name = "Shredder" };
            var customers = new List<Customer>
            {
                new Customer{Name = "customer1"},
                new Customer{Name = "customer2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
            //return Content("Content test");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new {page = 1, sortBy = "name" });
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
            //return RedirectToAction("Index", "Movies", new { pageIndex = 122, sortBy = "carlz" });
        }
        
       
        /*
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "name";

            return Content(String.Format("page index = {0}, sort by = {1}",pageIndex, sortBy));                            
        }
        */

        [Route("movies/release/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByRelease(int year, int month)
        {
            return Content(year + "/" + month);
        }

        [Route("movies/ByNone/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByNone(int year, int month)
        {
            return Content("got this thing" + year + "/" + month);
        }
    }
}