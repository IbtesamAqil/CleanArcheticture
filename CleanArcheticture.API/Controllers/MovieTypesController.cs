using CleanArcheticture.Application;
using CleanArcheticture.Domain.Entites;
using CleanArcheticture.Domain.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CleanArcheticture.API.Controllers
{
    [Route("api/MovieTypes")]
    public class MovieTypesController : Controller
    {
        private readonly IMovieTypesService _iMovieTypesService;
        public MovieTypesController(IMovieTypesService oIMovieTypesService)
        {
            _iMovieTypesService = oIMovieTypesService;
        }
        [Authorize]
        [HttpGet("Get")]
        public IActionResult GetMovies()
        {
            return Ok(_iMovieTypesService.GetAllMovieTypes());
        }
        [HttpGet("GetById")]
        public IActionResult GetAllMovies(int Id)
        {
            return Ok(_iMovieTypesService.GetMovieTypeByID(Id));
        }
        [HttpPost("Add")]
        public IActionResult Add(MovieTypes oMovieTypes)
        {
            _iMovieTypesService.AddMovieType(oMovieTypes);
            return Ok();
        }
        [HttpPost("Update")]
        public IActionResult Update(MovieTypes oMovieTypes)
        {
            _iMovieTypesService.UpdateMovieType(oMovieTypes);
            return Ok();
        }
        [HttpPost("Delete")]
        public IActionResult Delete(MovieTypes oMovieTypes)
        {
            _iMovieTypesService.DeleteMovieType(oMovieTypes);
            return Ok();
        }
    }
}
