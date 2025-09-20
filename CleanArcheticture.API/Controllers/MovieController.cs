using CleanArchitecture.Application.IService;
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
    }
}
