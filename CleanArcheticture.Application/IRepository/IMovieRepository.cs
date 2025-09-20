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

    }
}