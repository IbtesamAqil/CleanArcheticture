using CleanArcheticture.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArcheticture.Application
{
    public interface IMovieTypesService
    {
        List<MovieTypes> GetAllMovieTypes();
        MovieTypes GetMovieTypeByID(int ID);
        void AddMovieType(MovieTypes oMovie);
        void UpdateMovieType(MovieTypes oMovie);
        void DeleteMovieType(MovieTypes oMovie);
    }
}
