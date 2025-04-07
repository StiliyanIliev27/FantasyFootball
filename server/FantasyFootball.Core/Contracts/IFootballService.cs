using FantasyFootball.Core.DTOs;

namespace FantasyFootball.Core.Contracts
{
    public interface IFootballService
    {
        Task<ApiResponse> GetLeagues();
    }
}
