using CleanArcheticture.Domain.Entites;
using CleanArcheticture.Domain.Interfaces;
using CleanArchitecture.Application.IService;

namespace CleanArchitecture.Application.Service
    {
    public class MovieService : IMovieService
        {
        private readonly IUnitOfWork _unitofwork;

        public MovieService(IUnitOfWork unitofwork)
            {
            _unitofwork = unitofwork;
            }
        public void AddMovie(Movie oMovie)
            {
            _unitofwork.Repository<Movie>().Add(oMovie);
            _unitofwork.Commit();
            }

        public void DeleteMovie(Movie oMovie)
            {
            _unitofwork.Repository<Movie>().Delete(oMovie);
            _unitofwork.Commit();
            }

        public List<Movie> GetAllMovies()
            {
            return (List<Movie>)_unitofwork.Repository<Movie>().GetAll();
            }

        public Movie GetMoviesByID(int ID)
            {
            return _unitofwork.Repository<Movie>().GetById(ID);
            }

        public void UpdateMovie(Movie oMovie)
            {
            _unitofwork.Repository<Movie>().Update(oMovie);
            _unitofwork.Commit();
            }
        }
    }