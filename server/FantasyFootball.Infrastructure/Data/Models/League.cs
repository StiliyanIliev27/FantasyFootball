using System.ComponentModel.DataAnnotations;
using static FantasyFootball.Common.DatabaseModelsConstants.DataConstants.League;

namespace FantasyFootball.Infrastructure.Data.Models
{
    public class League
    {
        public League()
        {
            Id = Guid.NewGuid().ToString();
        }
        public string Id { get; set; }

        [Required]
        [StringLength(LeagueNameMaxLength, MinimumLength = LeagueNameMinLength,
            ErrorMessage = LeagueNameLengthErrorMessage)]
        public string Name { get; set; } = null!;

        [Required]
        public string Country { get; set; } = null!;

        public string? LogoUrl { get; set; }
    }
}
