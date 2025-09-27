using CleanArcheticture.Domain.Entites;
using CleanArchitecture.Application.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArcheticture.Infrastructure.Repository
{
    public class MovieRepository : IMovieRepository
    {
        private static List<Movie> movies = new List<Movie>()
        {
            new Movie() { Cost=100,Name="M1",Id=1},
            new Movie() { Cost=200,Name="M2",Id=2},
            new Movie() { Cost=150,Name="M3",Id=3},

        };

        public bool AddMovie(Movie oMovie)
        {

            movies.Add(oMovie);
            return true;
        }

        public bool DeleteMovie(int ID)
        {
            Movie oMovie = movies.FirstOrDefault(e => e.Id == ID);
            movies.Remove(oMovie);
            return true;
        }

        public List<Movie> GetAllMovies()
        {
            return movies;
        }

        public Movie GetMoviesByID(int ID)
        {
            return (movies != null) ? movies.FirstOrDefault(e => e.Id == ID) : new Movie();
        }

        public bool UpdateMovie(Movie oMovie)
        {
            Movie objMovie = movies.FirstOrDefault(e => e.Id == oMovie.Id);
            if (objMovie != null)
            {
                objMovie.Name = oMovie.Name;
                objMovie.Cost = oMovie.Cost;
            }
            return true;
        }
    }
}
