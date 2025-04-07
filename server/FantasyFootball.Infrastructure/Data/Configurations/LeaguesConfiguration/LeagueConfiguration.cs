using FantasyFootball.Infrastructure.Data.Models;
using FantasyFootball.Infrastructure.Data.Seed;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FantasyFootball.Infrastructure.Data.Configurations.LeaguesConfiguration
{
    internal class LeagueConfiguration : IEntityTypeConfiguration<League>
    {
        public void Configure(EntityTypeBuilder<League> builder)
        {
            var seeder = new Seeder();

            builder.HasData(seeder.Leagues);
        }
    }
}
