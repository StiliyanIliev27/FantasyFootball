using FantasyFootball.Infrastructure.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static FantasyFootball.Common.DatabaseModelsConstants.DataConstants.Player;

namespace FantasyFootball.Infrastructure.Data.Models
{
    public class Player
    {
        public Player()
        {
            Id = Guid.NewGuid().ToString();
        }

        [Required]
        public string Id { get; set; } 

        [Required]
        [StringLength(PlayerNameMaxLength, MinimumLength = PlayerNameMinLength,
            ErrorMessage = PlayerNameLengthErrorMessage)]
        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(PlayerNameMaxLength, MinimumLength = PlayerNameMinLength,
            ErrorMessage = PlayerNameLengthErrorMessage)]
        public string LastName { get; set; } = null!;

        [Required]
        public PlayerPosition Position { get; set; }

        [ForeignKey(nameof(TeamId))]
        public string? TeamId { get; set; }
        public Team? Team { get; set; }

        [Required]
        public string Nationality { get; set; } = null!;

        public decimal MarketValue { get; set; }
    }
}
