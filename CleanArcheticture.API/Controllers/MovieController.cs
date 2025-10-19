using CleanArcheticture.Domain.Entites;
using CleanArchitecture.Application;
using Microsoft.AspNetCore.Mvc;

namespace CleanArcheticture.API.Controllers
{
    [Route("api/Movie")]
    public class MovieController : Controller
    {
        private readonly IMovieService _movieService;
        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }
        [HttpGet("Get")]
        public IActionResult GetMovies()
        {
            var movieList = _movieService.GetAllMovies();
            return Ok(movieList);
        }
        [HttpGet("GetById")]
        public IActionResult GetAllMovies(int Id)
        {
            var movieList = _movieService.GetMoviesByID(Id);
            return Ok(movieList);
        }
        [HttpPost("Add")]
        public IActionResult Add(Movie oMovie)
        {
            _movieService.AddMovie(oMovie);
            return Ok();
        }
        [HttpPost("Update")]
        public IActionResult Update(Movie oMovie)
        {
            _movieService.UpdateMovie(oMovie);
            return Ok();
        }
        [HttpPost("Delete")]
        public IActionResult Delete(Movie oMovie)
        {
            _movieService.DeleteMovie(oMovie);
            return Ok();
        }
    }
}
