using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Movie> Movies { get; set; }
        public Customer Customer { get; set; }
        public List<Customer> Customers { get; set; }
        public Genre Genre { get; set; }
        public List<Genre> Genres { get; set; }


    }
}