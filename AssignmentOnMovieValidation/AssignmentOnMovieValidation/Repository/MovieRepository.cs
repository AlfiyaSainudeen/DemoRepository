using AssignmentOnMovieValidation.Models;
using System.IO;
using static System.Reflection.Metadata.BlobBuilder;

namespace AssignmentOnMovieValidation.Repository
{
    public class MovieRepository : IMovieRepository
    {
        public  List<Movie> movies = new List<Movie>();
      

        public void AddMovie(Movie movie)
        {
            try
            {
                movies.Add(movie);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

      

        public List<Movie> GetAllMovies()
        {
            try
            {
                return movies;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public List<Movie> GetMovieByActor(string Actor)
        {
            List<Movie> mov = new List<Movie>();
            try
            {
                foreach (var movie in movies)
                {
                    if (movie.Actor == Actor)
                    {
                        mov.Add(movie);
                    }
                }
                return mov;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public List<Movie> GetMovieByDirector(string Director)
        {

            List<Movie> mov = new List<Movie>();
            try
            {
                foreach (var movie in movies)
                {
                    if (movie.Director == Director)
                    {
                        mov.Add(movie);
                    }
                }
                return mov;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public List<Movie> GetMovieByName(string MovieName)
        {
            List<Movie> mov = new List<Movie>();
            try
            {
                foreach (var movie in movies)
                {
                    if (movie.MovieName == MovieName)
                    {
                        mov.Add(movie);
                    }
                }
                return mov;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public List<Movie> GetMovieByReleaseYear(int ReleaseYear)
        {
            List<Movie> mov = new List<Movie>();
            try
            {
                foreach (var movie in movies)
                {
                    if (movie.ReleaseYear == ReleaseYear)
                    {
                        mov.Add(movie);
                    }
                }
                return mov;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }

      
    
}
