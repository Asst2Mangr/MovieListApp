using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using MovieListApp.Models;

namespace MovieListApp.Models
{
    public class Movie
    {
        //EF Core will configure the database to generate this value
        public int MovieID { get; set; }
        [Required(ErrorMessage = "Please enter a name.")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Please enter a year.")]
        [Range(1889, 2999, ErrorMessage ="Year must be after 1889.")]
        public int? Year { get; set; }
        [Required(ErrorMessage ="Please eater a rating.")]
        [Range(1, 5, ErrorMessage ="Rating must be between 1 and 5.")]
        public int? Rating { get; set; }
    }
}
