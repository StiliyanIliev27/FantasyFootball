using FantasyFootball.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FantasyFootball.Infrastructure.Data.Configurations.FantasyTeamsConfiguration
{
    internal class PlayerFantasyTeamsConfiguration : IEntityTypeConfiguration<PlayerFantasyTeam>
    {
        public void Configure(EntityTypeBuilder<PlayerFantasyTeam> builder)
        {
            builder.HasKey(pft => new { pft.PlayerId, pft.FantasyTeamId });
        }
    }
}
