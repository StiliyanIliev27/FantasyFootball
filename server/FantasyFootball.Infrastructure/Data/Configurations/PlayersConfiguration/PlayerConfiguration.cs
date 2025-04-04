using FantasyFootball.Infrastructure.Data.Models;
using FantasyFootball.Infrastructure.Data.Seed;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FantasyFootball.Infrastructure.Data.Configurations.PlayersConfiguration
{
    internal class PlayerConfiguration : IEntityTypeConfiguration<Player>
    {
        public void Configure(EntityTypeBuilder<Player> builder)
        {
            var data = new Seeder();

            builder.HasData(data.Players);
        }
    }
}
