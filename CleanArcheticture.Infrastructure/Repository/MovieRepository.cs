using CleanArcheticture.Domain;
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
            new Movie() { Cost=100,Name="M1",MovieId=1},
            new Movie() { Cost=200,Name="M2",MovieId=2},
            new Movie() { Cost=150,Name="M3",MovieId=3},

        };

        public bool AddMovie(Movie oMovie)
        {

            movies.Add(oMovie);
            return true;
        }

        public bool DeleteMovie(int ID)
        {
            Movie oMovie = movies.FirstOrDefault(e => e.MovieId == ID);
            movies.Remove(oMovie);
            return true;
        }

        public List<Movie> GetAllMovies()
        {
            return movies;
        }

        public Movie GetMoviesByID(int ID)
        {
            return (movies != null) ? movies.FirstOrDefault(e => e.MovieId == ID) : new Movie();
        }

        public bool UpdateMovie(Movie oMovie)
        {
            Movie objMovie = movies.FirstOrDefault(e => e.MovieId == oMovie.MovieId);
            if (objMovie != null)
            {
                objMovie.Name = oMovie.Name;
                objMovie.Cost = oMovie.Cost;
            }
            return true;
        }
    }
}
