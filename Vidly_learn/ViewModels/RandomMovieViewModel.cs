using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly_learn.Models;

namespace Vidly_learn.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}