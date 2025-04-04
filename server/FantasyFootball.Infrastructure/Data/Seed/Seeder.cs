using FantasyFootball.Infrastructure.Data.Enums;
using FantasyFootball.Infrastructure.Data.Models;
namespace FantasyFootball.Infrastructure.Data.Seed
{
    internal class Seeder
    {
        public ICollection<Team> Teams { get; private set; } = new HashSet<Team>();
        public ICollection<Player> Players { get; private set; } = new HashSet<Player>();
        public Seeder()
        {
            SeedTeams();
            SeedPlayers();
        }

        public void SeedTeams()
        {
            Teams = new HashSet<Team>
            {
                new Team { Id = "b3241106-0d85-4c91-aaa9-5c1a37dc2553", Name = "Liverpool", HomeTown = "Liverpool", HomeCountry = "England", TeamIconUrl = "https://upload.wikimedia.org/wikipedia/en/0/0c/Liverpool_FC.svg" },
                new Team { Id = "506eb3fc-7511-4af8-86de-11b55623deca", Name = "Real Madrid", HomeTown = "Madrid", HomeCountry = "Spain", TeamIconUrl = "https://upload.wikimedia.org/wikipedia/en/5/56/Real_Madrid_CF.svg" },
                new Team { Id = "4eb0819d-5550-4399-8752-edba2fc7ab42", Name = "Manchester City", HomeTown = "Manchester", HomeCountry = "England", TeamIconUrl = "https://upload.wikimedia.org/wikipedia/en/e/eb/Manchester_City_FC_badge.svg" },
                new Team { Id = "74c1fcab-b9d6-4b6f-aeef-6ece83923c32", Name = "Barcelona", HomeTown = "Barcelona", HomeCountry = "Spain", TeamIconUrl = "https://upload.wikimedia.org/wikipedia/en/4/47/FC_Barcelona_%28crest%29.svg" },
                new Team { Id = "1811b66c-462b-46a9-9c4a-344d310c329e", Name = "AC Milan", HomeTown = "Milan", HomeCountry = "Italy", TeamIconUrl = "https://upload.wikimedia.org/wikipedia/en/d/d0/AC_Milan_logo.svg" },
                new Team { Id = "c23f5056-0bf2-4cbe-92b3-7dfdcc226ece", Name = "Paris Saint-Germain", HomeTown = "Paris", HomeCountry = "France", TeamIconUrl = "https://upload.wikimedia.org/wikipedia/en/a/a7/Paris_Saint-Germain_F.C..svg" },
                new Team { Id = "aefd72fb-edfe-4239-bdec-21fea1ad49cb", Name = "Inter Miami", HomeTown = "Miami", HomeCountry = "USA", TeamIconUrl = "https://upload.wikimedia.org/wikipedia/en/4/4a/Inter_Miami_CF_logo.svg" },
                new Team { Id = "0b9e12ef-bc06-4ba8-a660-fcd52285258c", Name = "Bayern Munich", HomeTown = "Munich", HomeCountry = "Germany", TeamIconUrl = "https://upload.wikimedia.org/wikipedia/commons/1/1c/FC_Bayern_München_logo_%282017%29.svg" }
            };
        }

        public void SeedPlayers()
        {
            Players = new HashSet<Player>
            {
                new Player { FirstName = "Alisson", LastName = "Becker", Position = PlayerPosition.Goalkeeper, TeamId = "b3241106-0d85-4c91-aaa9-5c1a37dc2553", Nationality = "Brazil", MarketValue = 60_000_000 },
                new Player { FirstName = "Thibaut", LastName = "Courtois", Position = PlayerPosition.Goalkeeper, TeamId = "506eb3fc-7511-4af8-86de-11b55623deca", Nationality = "Belgium", MarketValue = 55_000_000 },

                new Player { FirstName = "Virgil", LastName = "van Dijk", Position = PlayerPosition.CenterBack, TeamId = "b3241106-0d85-4c91-aaa9-5c1a37dc2553", Nationality = "Netherlands", MarketValue = 70_000_000 },
                new Player { FirstName = "Rúben", LastName = "Dias", Position = PlayerPosition.CenterBack, TeamId = "4eb0819d-5550-4399-8752-edba2fc7ab42", Nationality = "Portugal", MarketValue = 75_000_000 },
                new Player { FirstName = "João", LastName = "Cancelo", Position = PlayerPosition.RightBack, TeamId = "74c1fcab-b9d6-4b6f-aeef-6ece83923c32", Nationality = "Portugal", MarketValue = 65_000_000 },
                new Player { FirstName = "Theo", LastName = "Hernández", Position = PlayerPosition.LeftBack, TeamId = "1811b66c-462b-46a9-9c4a-344d310c329e", Nationality = "France", MarketValue = 60_000_000 },

                new Player { FirstName = "Kevin", LastName = "De Bruyne", Position = PlayerPosition.AttackingMidfielder, TeamId = "4eb0819d-5550-4399-8752-edba2fc7ab42", Nationality = "Belgium", MarketValue = 80_000_000 },
                new Player { FirstName = "Luka", LastName = "Modrić", Position = PlayerPosition.CentralMidfielder, TeamId = "506eb3fc-7511-4af8-86de-11b55623deca", Nationality = "Croatia", MarketValue = 20_000_000 },
                new Player { FirstName = "Rodri", LastName = "Hernandez", Position = PlayerPosition.DefensiveMidfielder, TeamId = "4eb0819d-5550-4399-8752-edba2fc7ab42", Nationality = "Spain", MarketValue = 70_000_000 },
                new Player { FirstName = "Federico", LastName = "Valverde", Position = PlayerPosition.RightMidfielder, TeamId = "506eb3fc-7511-4af8-86de-11b55623deca", Nationality = "Uruguay", MarketValue = 85_000_000 },

                new Player { FirstName = "Kylian", LastName = "Mbappé", Position = PlayerPosition.LeftWinger, TeamId = "c23f5056-0bf2-4cbe-92b3-7dfdcc226ece", Nationality = "France", MarketValue = 180_000_000 },
                new Player { FirstName = "Erling", LastName = "Haaland", Position = PlayerPosition.Striker, TeamId = "4eb0819d-5550-4399-8752-edba2fc7ab42", Nationality = "Norway", MarketValue = 200_000_000 },
                new Player { FirstName = "Lionel", LastName = "Messi", Position = PlayerPosition.RightWinger, TeamId = "aefd72fb-edfe-4239-bdec-21fea1ad49cb", Nationality = "Argentina", MarketValue = 40_000_000 },
                new Player { FirstName = "Harry", LastName = "Kane", Position = PlayerPosition.CenterForward, TeamId = "0b9e12ef-bc06-4ba8-a660-fcd52285258c", Nationality = "England", MarketValue = 100_000_000 }
            };
        }
    }
}
