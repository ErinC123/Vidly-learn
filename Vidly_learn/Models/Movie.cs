﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly_learn.Models
{
    public class Movie
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime ReleaseDate { get; set; }
        [Required]
        public DateTime AddedDate { get; set; }
        [Required]
        public int NumInStock { get; set; }
        [Required]
        public Genre Genre { get; set; }
        [Required]
        public byte GenreId { get; set; }

    }

    // /movies/random
}