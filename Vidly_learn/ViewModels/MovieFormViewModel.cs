﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly_learn.Models;

namespace Vidly_learn.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        public Movie Movie { get; set; }
    }
}