using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FantasyFootball.Infrastructure.Data.Models
{
    public class FantasyTeam
    {
        public FantasyTeam()
        {
            Id = Guid.NewGuid().ToString();
        }

        [Required]
        public string Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        [ForeignKey(nameof(UserId))]
        public string UserId { get; set; } = null!;
        public ApplicationUser? User { get; set; }

        [Required]
        public int TotalPoints { get; set; } = 0;  // Updated weekly based on player performance.
    }
}
