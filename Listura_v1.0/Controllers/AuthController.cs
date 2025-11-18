using Listura_v1._0.Models.DTOs;
using Listura_v1._0.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Listura_v1._0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        IAuthService authService;
        public AuthController(IAuthService authService)
        {
            this.authService = authService;
        }
        [HttpPost("Register")]
        public async Task<IActionResult> Register(RegisterDto dto)
        {
            var result = await authService.Register(dto);
            if (result != "Registered")
            {
                return BadRequest(result);
            }
            return Ok("User registered successfully!");
        }
        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginDto dto)
        {
            var result = await authService.Login(dto);

            if (result != "LoggedIn")
                return Unauthorized("Invalid email or password");

            return Ok("Login successful");
        }
    }
}
