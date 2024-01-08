using AssignmentOnMovieValidation.Models;
using AssignmentOnMovieValidation.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AssignmentOnMovieValidation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        IMovieRepository movieRepository;

        public MovieController(IMovieRepository movieRepository)
        {
           this.movieRepository = movieRepository;  
        }

        [HttpPost, Route("AddMovies")]
        public IActionResult Add(Movie movie)
        {
            try
            {
              
                movieRepository.AddMovie(movie);
                return StatusCode(200, movie);
            }
            catch (Exception ex)
            {
                return StatusCode(501, ex);
            }
        }
        [HttpGet, Route("GetAllMovies")]
        public IActionResult GetAllMovies()
        {
            try
            {

                List<Movie> movies = movieRepository.GetAllMovies();
                return StatusCode(200, movies);

            }
            catch (Exception ex)
            {
                return StatusCode(501, ex);
            }
        }

        [HttpGet, Route("GetMovieByName/{MovieName}")]

        public IActionResult GetMovieByName(string MovieName)
        {
            try
            {
                return StatusCode(200, movieRepository.GetMovieByName(MovieName));
            }
            catch (Exception ex)
            {
                return StatusCode(501, ex);
            }
        }

        [HttpGet, Route("GetMovieByActor/{Actor}")]

        public IActionResult GetMovieByActor(string Actor)
        {
            try
            {
                return StatusCode(200, movieRepository.GetMovieByActor(Actor));
            }
            catch (Exception ex)
            {
                return StatusCode(501, ex);
            }
        }
        [HttpGet, Route("GetMovieByReleaseYear/{ReleaseYear}")]

        public IActionResult GetMovieByReleaseYear(int ReleaseYear)
        {
            try
            {
                return StatusCode(200, movieRepository.GetMovieByReleaseYear(ReleaseYear));
            }
            catch (Exception ex)
            {
                return StatusCode(501, ex);
            }
        }
        [HttpGet, Route("GetMovieByDirector/{Director}")]

        public IActionResult GetMovieByDirector(string Director)
        {
            try
            {
                return StatusCode(200, movieRepository.GetMovieByDirector(Director));
            }
            catch (Exception ex)
            {
                return StatusCode(501, ex);
            }
        }

    }
}
