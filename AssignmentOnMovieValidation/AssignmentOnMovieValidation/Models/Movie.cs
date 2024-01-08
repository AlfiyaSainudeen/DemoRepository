using System.ComponentModel.DataAnnotations;

namespace AssignmentOnMovieValidation.Models
{
    public class Movie
    { public Movie()
        {
            MovieId = new Random().Next(100, 999);
        }
        public int MovieId { get;  }
        [Required(ErrorMessage ="enter movie name")]
        public string MovieName { get; set; }
        [Required(ErrorMessage = "enter movie language")]
        public string Lang { get; set; }
        [Required(ErrorMessage = "enter movie Release Year")]
       
        public int ReleaseYear { get; set; }
        [Required(ErrorMessage = "enter movie Actor")]
      
        public string Actor { get; set; }
        [Required(ErrorMessage = "enter movie Director")]
        public string Director { get; set; }
    }
}
