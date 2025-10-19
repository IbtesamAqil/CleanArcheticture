using CleanArcheticture.Application;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;

namespace CleanArcheticture.API.Controllers
    {
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
        {
        private readonly ITokenService _tokens;

        public AuthController(ITokenService tokens) => _tokens = tokens;

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest request)
            {
            // TODO: replace with real user validation (DB/Identity)
            if (request.Username == "nour" && request.Password == "P@ssw0rd")
                {
                var roles = new[] { "User" }; // or load from DB
                var token = _tokens.CreateToken("42", request.Username, roles);
                return Ok(new { accessToken = token });
                }
            return Unauthorized();
            }
        }
    }
public record LoginRequest(string Username, string Password);

