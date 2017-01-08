using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly_learn.Models;

namespace Vidly_learn.Dtos
{
    public class MovieDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime ReleaseDate { get; set; }
        [Required]
        public DateTime AddedDate { get; set; }

        [Range(1, 20)]
        [Required(ErrorMessage = "The number must between 1 to 20.")]
        public int NumInStock { get; set; }

        public GenreDto genre { get; set; }

        [Required]
        public byte GenreId { get; set; }
    }
}