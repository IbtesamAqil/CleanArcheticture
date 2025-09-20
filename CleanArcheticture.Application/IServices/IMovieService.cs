using CleanArcheticture.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.IService
{
    public interface IMovieService
    {
        List<Movie> GetAllMovies();
    }
}