using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly_learn.Models;

namespace Vidly_learn.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        [Required]
        public int? Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }
        [Required]
        [Display(Name = "Added Date")]
        public DateTime? AddedDate { get; set; }

        [Range(1, 20)]
        [Required(ErrorMessage = "The number must between 1 to 20.")]
        [Display(Name = "Number in Stock")]
        public int? NumInStock { get; set; }


        [Required]
        [Display(Name = "Genre")]
        public byte? GenreId { get; set; }

        public string Title
        {
            get { return Id != 0 ? "Edit Movie" : "New Movie"; }

        }

        public MovieFormViewModel()
        {
            Id = 0;
        }

        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            AddedDate = movie.AddedDate;
            NumInStock = movie.NumInStock;
            GenreId = movie.GenreId;
        }
    }
}