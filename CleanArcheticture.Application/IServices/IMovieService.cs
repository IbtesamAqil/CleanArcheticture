using CleanArcheticture.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application
{
    public interface IMovieService
    {
        List<Movie> GetAllMovies();
        Movie GetMoviesByID(int ID);
        void AddMovie(Movie oMovie);
        void UpdateMovie(Movie oMovie);
        void DeleteMovie(Movie oMovie);
    }
}