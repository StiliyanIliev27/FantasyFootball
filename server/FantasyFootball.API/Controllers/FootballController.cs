using FantasyFootball.Core.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace FantasyFootball.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FootballController : ControllerBase
    {
        private readonly IFootballService footballService;

        public FootballController(IFootballService footballService)
        {
            this.footballService = footballService;
        }

        [HttpGet("leagues")]
        public async Task<IActionResult> GetLeagues()
        {
            var response = await footballService.GetLeagues();

            return Ok(response);
        }
    }
}
