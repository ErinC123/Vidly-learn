using System;
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
        [Display (Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }
        [Required]
        [Display (Name = "Added Date")]
        public DateTime AddedDate { get; set; }
        [Required]
        [Display (Name = "Number in Stock")]
        public int NumInStock { get; set; }

        public Genre Genre { get; set; }
        [Required]
        [Display (Name = "Genre")]
        public byte GenreId { get; set; }

    }

    // /movies/random
}