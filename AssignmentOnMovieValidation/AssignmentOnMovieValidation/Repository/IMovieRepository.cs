using AssignmentOnMovieValidation.Models;

namespace AssignmentOnMovieValidation.Repository
{
    public interface IMovieRepository
    {
        void AddMovie(Movie movie);
        List<Movie> GetAllMovies();
        List<Movie> GetMovieByName(string MovieName);
        List<Movie> GetMovieByActor(string Actor);
        List<Movie> GetMovieByReleaseYear(int ReleaseYear);
        List<Movie> GetMovieByDirector(string Director);
    }
}
