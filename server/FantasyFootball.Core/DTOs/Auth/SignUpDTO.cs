using System.ComponentModel.DataAnnotations;
using static FantasyFootball.Common.ServicesModelConstants.DataConstants.Authentication;

namespace FantasyFootball.Core.DTOs.Auth
{
    public class SignUpDTO
    {
        [Required]
        [StringLength(UsernameMaxLength, MinimumLength = UsernameMinLength,
            ErrorMessage = UsernameLengthErrorMessage)]
        public string Nickname { get; set; } = null!;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = null!;

        [Url]
        public string? ProfilePicture { get; set; }

        [Required]
        public string Password { get; set; } = null!;

        [Required]
        public string ConfirmPassword { get; set; } = null!;
    }
}
