using FantasyFootball.Infrastructure.Data.Models;
using FantasyFootball.Infrastructure.Data.Seed;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FantasyFootball.Infrastructure.Data.Configurations.TeamsConfiguration
{
    internal class TeamConfiguration : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            var data = new Seeder();

            builder.HasData(data.Teams);
        }
    }
}
