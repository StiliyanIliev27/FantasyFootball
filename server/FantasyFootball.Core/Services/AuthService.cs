using FantasyFootball.API.Utilities;
using FantasyFootball.Core.Contracts;
using FantasyFootball.Core.DTOs;
using FantasyFootball.Core.DTOs.Auth;
using FantasyFootball.Infrastructure.Common;
using FantasyFootball.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace FantasyFootball.Core.Services
{
    public class AuthService : IAuthService
    {
        private readonly IRepository repository;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly JwtSettings jwtSettings;

        public AuthService(IRepository repository, UserManager<ApplicationUser> userManager, IOptions<JwtSettings> jwtSettings)
        {
            this.repository = repository;
            this.userManager = userManager;
            this.jwtSettings = jwtSettings.Value;
        }

        private async Task<string> GenerateTokenAsync(string userId)
        {
            var user = await userManager.FindByIdAsync(userId);
            if (user == null)
                throw new ArgumentException("User was not found!");

            var userRoles = await userManager.GetRolesAsync(user);

            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, userId),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            claims.AddRange(userRoles.Select(role => new Claim(ClaimTypes.Role, role)));

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings.Key));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: jwtSettings.Issuer,
                audience: jwtSettings.Audience,
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(jwtSettings.ExpiryMinutes),
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public async Task<ApiResponse> SignInAsync(SignInDTO signInDtoModel)
        {
            var apiResponse = new ApiResponse();

            if (signInDtoModel == null)
            {
                apiResponse.StatusCode = 400;
                apiResponse.ErrorMessage = "Sign in form is empty!";
                return apiResponse;
            }

            var user = await userManager.FindByEmailAsync(signInDtoModel.Email);
            var isPasswordValid = user != null && await userManager.CheckPasswordAsync(user, signInDtoModel.Password);

            if (!isPasswordValid)
            {
                apiResponse.StatusCode = 400;
                apiResponse.ErrorMessage = "Email or password is incorrect!";
                return apiResponse;
            }

            var token = await GenerateTokenAsync(user!.Id);

            apiResponse.Result = new
            {
                user.Nickname,
                user.Email,
                user.ProfilePicture,
                Token = token
            };
            apiResponse.SuccessfulMessage = "User signed in successfully!";
            apiResponse.StatusCode = 200;
            return apiResponse;
        }

        public async Task<ApiResponse> SignUpAsync(SignUpDTO signUpDtoModel)
        {
            var apiResponse = new ApiResponse();

            if(signUpDtoModel == null)
            {
                apiResponse.StatusCode = 400;
                apiResponse.ErrorMessage = "Sign up form is empty!";
                return apiResponse;
            }

            var existingUser = await userManager.FindByEmailAsync(signUpDtoModel.Email);
            if (existingUser != null)
            {
                apiResponse.StatusCode = 400;
                apiResponse.ErrorMessage = "The user with the this email address already exists!";
                return apiResponse;
            }

            if (!signUpDtoModel.Password.Equals(signUpDtoModel.ConfirmPassword))
            {
                apiResponse.StatusCode = 400;
                apiResponse.ErrorMessage = "The passwords do not match!";
                return apiResponse;
            }


            var newUser = new ApplicationUser()
            {
                Nickname = signUpDtoModel.Nickname,
                Email = signUpDtoModel.Email,
                ProfilePicture = signUpDtoModel.ProfilePicture,
                UserName = signUpDtoModel.Email
            };


            var result = await userManager.CreateAsync(newUser, signUpDtoModel.Password);

            
            if (result.Succeeded)
            {
                apiResponse.StatusCode = 200;
                apiResponse.SuccessfulMessage = "User registered successfully!";
                return apiResponse;
            }


            apiResponse.StatusCode = 400;
            apiResponse.ErrorMessage = string.Join(", ", result.Errors.Select(e => e.Description));
            return apiResponse;
        }
    }
}
