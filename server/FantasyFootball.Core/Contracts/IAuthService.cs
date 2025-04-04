using FantasyFootball.Core.DTOs;
using FantasyFootball.Core.DTOs.Auth;

namespace FantasyFootball.Core.Contracts
{
    public interface IAuthService
    {
        Task<ApiResponse> SignUpAsync(SignUpDTO signUpDtoModel);
        Task<ApiResponse> SignInAsync(SignInDTO signInDtoModel);
    }
}
