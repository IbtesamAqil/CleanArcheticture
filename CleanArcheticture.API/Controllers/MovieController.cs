using CleanArcheticture.Domain.Entites;
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
        [HttpGet("GetById")]
        public IActionResult GetAllMovies(int Id)
        {
            var movieList = _movieService.GetMoviesByID(4);
            return Ok(movieList);
        }
        [HttpPost("Add")]
        public IActionResult Add(int Id)
        {
            Movie oMovie = new Movie()
            {
                Cost = 900,
                Name = "NoorAndIbtesam",
                Id = 4
            };
            _movieService.AddMovie(oMovie);
            return Ok();
        }
        [HttpPost("Update")]
        public IActionResult Update(int Id)
        {
            Movie oMovie = new Movie()
            {
                Cost = 1000,
                Name = "Noor And Ibtesam",
                Id = 4
            };
            _movieService.UpdateMovie(oMovie);
            return Ok();
        }
        [HttpPost("Delete")]
        public IActionResult Delete(int Id)
        {
            _movieService.DeleteMovie(4);
            return Ok();
        }
    }
}
