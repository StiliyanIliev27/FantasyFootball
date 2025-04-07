using FantasyFootball.Core.Contracts;
using FantasyFootball.Core.DTOs;
using FantasyFootball.Infrastructure.Common;
using FantasyFootball.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;


namespace FantasyFootball.Core.Services
{
    public class FootballService : IFootballService
    {
        private readonly IRepository repository;

        public FootballService(IRepository repository)
        {
            this.repository = repository;
        }
        public async Task<ApiResponse> GetLeagues()
        {
            var leagues = await repository.AllReadOnly<League>().ToListAsync();

            return new ApiResponse()
            {
                Result = leagues,
                StatusCode = 200,
                SuccessfulMessage = "Succesfully fetched all leagues."
            };
        }
    }
}
