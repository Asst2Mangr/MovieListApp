using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using MovieListApp.Models;
namespace MovieList.Models
{
    public class Genre
    {
        public string GenreId { get; set; }
        public string Name { get; set; }
    }
}
