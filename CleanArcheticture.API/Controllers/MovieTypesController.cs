using CleanArcheticture.Domain.Entites;
using CleanArcheticture.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CleanArcheticture.API.Controllers
{
    [Route("api/MovieTypes")]
    public class MovieTypesController : Controller
    {
        private readonly IUnitOfWork _iUnitOfWork;
        public MovieTypesController(IUnitOfWork oIUnitOfWork)
        {
            _iUnitOfWork = oIUnitOfWork;
        }
        [HttpGet("Get")]
        public IActionResult GetMovies()
        {
            List<MovieTypes> movieTypesList = _iUnitOfWork.MovieTypes.GetAll().ToList();
            return Ok(movieTypesList);
        }
        [HttpGet("GetById")]
        public IActionResult GetAllMovies(int Id)
        {
            MovieTypes movieTypeObject = _iUnitOfWork.MovieTypes.GetById(Id);
            return Ok(movieTypeObject);
        }
        [HttpPost("Add")]
        public IActionResult Add(MovieTypes oMovieTypes)
        {
            _iUnitOfWork.MovieTypes.Add(oMovieTypes);
            return Ok();
        }
        [HttpPost("Update")]
        public IActionResult Update(MovieTypes oMovieTypes)
        {
            MovieTypes oMovieTypes1 = _iUnitOfWork.MovieTypes.GetById(oMovieTypes.Id);
            oMovieTypes1.Name = oMovieTypes.Name;
            _iUnitOfWork.MovieTypes.Update(oMovieTypes1);
            return Ok();
        }
        [HttpPost("Delete")]
        public IActionResult Delete(MovieTypes oMovieTypes)
        {
            _iUnitOfWork.MovieTypes.Delete(oMovieTypes);
            return Ok();
        }
    }
}
