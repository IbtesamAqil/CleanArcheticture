using CleanArcheticture.Domain.Entites;
using CleanArchitecture.Application.IService;

namespace CleanArchitecture.Application.Service
{
    public class MovieService : IMovieService
    {
        //private readonly IMovieRepository movieRepository;

        //public MovieService(IMovieRepository _movieRepository)
        //{
        //    movieRepository = _movieRepository;
        //}
        //public List<Movie> GetAllMovies()
        //{
        //    List<Movie> movies = movieRepository.GetAllMovies();
        //    return movies;
        //}
        //public void AddMovie(Movie oMovie)
        //{
        //    movieRepository.AddMovie(oMovie);
        //}

        //public void DeleteMovie(int ID)
        //{
        //    movieRepository.DeleteMovie(ID);
        //}

        //public Movie GetMoviesByID(int ID)
        //{
        //    return movieRepository.GetMoviesByID(ID);
        //}

        //public void UpdateMovie(Movie oMovie)
        //{
        //    movieRepository.UpdateMovie(oMovie);
        //}
        public void AddMovie(Movie oMovie)
        {
            throw new NotImplementedException();
        }

        public void DeleteMovie(int ID)
        {
            throw new NotImplementedException();
        }

        public List<Movie> GetAllMovies()
        {
            throw new NotImplementedException();
        }

        public Movie GetMoviesByID(int ID)
        {
            throw new NotImplementedException();
        }

        public void UpdateMovie(Movie oMovie)
        {
            throw new NotImplementedException();
        }
    }
}