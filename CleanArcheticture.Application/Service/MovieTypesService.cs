using CleanArcheticture.Domain.Entites;
using CleanArcheticture.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArcheticture.Application
{
    public class MovieTypesService : IMovieTypesService
    {
        private readonly IUnitOfWork _iUnitOfWork;
        public MovieTypesService(IUnitOfWork unitofwork)
        {
            _iUnitOfWork = unitofwork;
        }

        public void AddMovieType(MovieTypes oMovie)
        {
            _iUnitOfWork.Repository<MovieTypes>().Add(oMovie);
            _iUnitOfWork.Commit();
        }

        public void DeleteMovieType(MovieTypes oMovie)
        {
            _iUnitOfWork.Repository<MovieTypes>().Delete(oMovie);
            _iUnitOfWork.Commit();
        }

        public List<MovieTypes> GetAllMovieTypes()
        {
            return _iUnitOfWork.Repository<MovieTypes>().GetAll().ToList();
        }

        public MovieTypes GetMovieTypeByID(int Id)
        {
            return _iUnitOfWork.Repository<MovieTypes>().GetById(Id);
        }

        public void UpdateMovieType(MovieTypes oMovie)
        {
            _iUnitOfWork.Repository<MovieTypes>().Update(oMovie);
            _iUnitOfWork.Commit();
        }
    }
}
