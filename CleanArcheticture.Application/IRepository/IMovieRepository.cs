using CleanArcheticture.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.IRepository
{
    public interface IMovieRepository
    {
        List<Movie> GetAllMovies();
        Movie GetMoviesByID(int ID);
        bool AddMovie(Movie oMovie);
        bool UpdateMovie(Movie oMovie);
        bool DeleteMovie(int ID);

    }
}