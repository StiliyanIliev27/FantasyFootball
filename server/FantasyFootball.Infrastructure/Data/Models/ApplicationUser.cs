using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using static FantasyFootball.Common.DatabaseModelsConstants.DataConstants.ApplicationUser;

namespace FantasyFootball.Infrastructure.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [Length(NicknameMinLength, NicknameMaxLength, 
            ErrorMessage = NicknameLengthErrorMessage)]
        public string Nickname { get; set; } = null!;

        [Url]
        public string? ProfilePicture { get; set; }
       
    }
}
