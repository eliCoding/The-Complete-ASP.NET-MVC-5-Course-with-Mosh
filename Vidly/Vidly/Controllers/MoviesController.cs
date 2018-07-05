using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
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
        // GET: Movies/Random
        public ActionResult Index()
        {
            //var movie = new Movie() { Name = "Shrek!" };
            //var movies= new List<Movie>

            //{
            //    new Movie {Name = "shrek"},
            //    new Movie {Name = "Wall-e"}
            //};

            //var viewModel = new RandomMovieViewModel
            //{
            //    Movies = movies,
            //    //Customers = customers

            //};
            //return View(viewModel);

            var movies = _context.Movies.ToList();
            return View(movies);


        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);

            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }


        //public ActionResult Edit(int id)
        //{
        //    return Content("id" + id);
        //}




        ////movies
        ////string type in C# is reference type and it is nullable

        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //    {

        //        pageIndex = 1;
        //    }

        //    if (String.IsNullOrWhiteSpace(sortBy))
        //    {
        //        sortBy = "Name";
        //    }

        //    return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));

        //}



        //[Route("movies.released/{year}/{month:regex(\\d{4}):range(1,12)}")]
        //public ActionResult ByReleaseDate(int year, int month)
        //{
        //    return Content(year + "/" + month);
        //}

    }
}