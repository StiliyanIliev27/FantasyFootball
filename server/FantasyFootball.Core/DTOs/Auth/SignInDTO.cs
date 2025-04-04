using System.ComponentModel.DataAnnotations;

namespace FantasyFootball.Core.DTOs.Auth
{
    public class SignInDTO
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } = null!;

        [Required]
        public string Password { get; set; } = null!;
    }
}
