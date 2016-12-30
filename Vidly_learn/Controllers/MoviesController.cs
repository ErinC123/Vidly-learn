﻿
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly_learn.Models;
using Vidly_learn.ViewModels;

namespace Vidly_learn.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Movies
        public ActionResult Index()
        {
            var movies = _context.Movies.Include(c => c.Genre).ToList();
            return View(movies);
        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(c => c.Genre).SingleOrDefault(c => c.Id == id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            
            return View(movie);
        }

        public ActionResult Random()
        {
            var movie = new Movie() {Name = "Shrek!"};
            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1"},
                new Customer { Name = "Customer 2"},

            };
            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);              //just pass the movie object here. Do not use viewdata either viewbag.
            //return Content("Hello World"); //return the string "Hello World"
            //return HttpNotFound();         // return 404
            //return new EmptyResult();      // return empty page

        }

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")] //attributing routing constraints
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year+"/"+ month);
        }


    }
}