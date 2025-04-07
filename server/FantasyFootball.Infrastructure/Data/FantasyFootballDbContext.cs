using FantasyFootball.Infrastructure.Data.Configurations.FantasyTeamsConfiguration;
using FantasyFootball.Infrastructure.Data.Configurations.LeaguesConfiguration;
using FantasyFootball.Infrastructure.Data.Configurations.PlayersConfiguration;
using FantasyFootball.Infrastructure.Data.Configurations.TeamsConfiguration;
using FantasyFootball.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FantasyFootball.Infrastructure.Data
{
    public class FantasyFootballDbContext : IdentityDbContext
    {
        public FantasyFootballDbContext(DbContextOptions<FantasyFootballDbContext> options) : base(options)
        {

        }

        public DbSet<Player> Players { get; set; } = null!;
        public DbSet<League> Leagues { get; set; } = null!;
        public DbSet<Team> Teams { get; set; } = null!;
        public DbSet<FantasyTeam> FantasyTeams { get; set; } = null!;
        public DbSet<PlayerFantasyTeam> PlayersFantasyTeams { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new LeagueConfiguration());
            builder.ApplyConfiguration(new TeamConfiguration());
            builder.ApplyConfiguration(new PlayerConfiguration());
            builder.ApplyConfiguration(new PlayerFantasyTeamsConfiguration());


            base.OnModelCreating(builder);
        }
    }
}
