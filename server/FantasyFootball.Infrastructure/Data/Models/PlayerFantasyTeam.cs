using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FantasyFootball.Infrastructure.Data.Models
{
    public class PlayerFantasyTeam
    {
        public PlayerFantasyTeam()
        {
            Id = Guid.NewGuid().ToString();
        }

        [Required]
        public string Id { get; set; }

        [Required]
        [ForeignKey(nameof(PlayerId))]
        public string PlayerId { get; set; } = null!;
        public Player? Player { get; set; }

        [Required]
        [ForeignKey(nameof(FantasyTeamId))]
        public string FantasyTeamId { get; set; } = null!;
        public FantasyTeam? FantasyTeam { get; set; }
    }
}
