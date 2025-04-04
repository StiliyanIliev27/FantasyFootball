using FantasyFootball.Core.Contracts;
using FantasyFootball.Core.DTOs.Auth;
using Microsoft.AspNetCore.Mvc;

namespace FantasyFootball.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService authService;

        public AuthController(IAuthService authService)
        {
            this.authService = authService;
        }

        [HttpPost("sign-up")]
        public async Task<IActionResult> SignUp([FromForm]SignUpDTO signUpModel)
        {
            var response = await authService.SignUpAsync(signUpModel);

            if(response.StatusCode == 400)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }

        [HttpPost("sign-in")]
        public async Task<IActionResult> SignIn([FromForm] SignInDTO signInModel)
        {
            var response = await authService.SignInAsync(signInModel);

            if (response.StatusCode == 400)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }
    }
}
