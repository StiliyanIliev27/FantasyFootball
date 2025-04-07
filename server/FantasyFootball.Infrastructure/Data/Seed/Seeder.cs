using FantasyFootball.Infrastructure.Data.Enums;
using FantasyFootball.Infrastructure.Data.Models;

namespace FantasyFootball.Infrastructure.Data.Seed
{
    internal class Seeder
    {
        public ICollection<Team> Teams { get; private set; } = new HashSet<Team>();
        public ICollection<Player> Players { get; private set; } = new HashSet<Player>();
        public ICollection<League> Leagues { get; private set; } = new HashSet<League>();
        public Seeder()
        {
            SeedLeagues();
            SeedTeams();
            SeedPlayers();
        }

        public void SeedTeams()
        {
            Teams = new HashSet<Team>
            {
                new Team
                {
                    Id = "b3241106-0d85-4c91-aaa9-5c1a37dc2553",
                    Name = "Liverpool",
                    HomeTown = "Liverpool",
                    HomeCountry = "England",
                    TeamIconUrl = "https://upload.wikimedia.org/wikipedia/en/0/0c/Liverpool_FC.svg",
                    LeagueId = "1a1f1f00-aaaa-aaaa-aaaa-111111111111" // Premier League
                },
                new Team
                {
                    Id = "506eb3fc-7511-4af8-86de-11b55623deca",
                    Name = "Real Madrid",
                    HomeTown = "Madrid",
                    HomeCountry = "Spain",
                    TeamIconUrl = "https://upload.wikimedia.org/wikipedia/en/5/56/Real_Madrid_CF.svg",
                    LeagueId = "2b2f2f00-bbbb-bbbb-bbbb-222222222222" // La Liga
                },
                new Team
                {
                    Id = "4eb0819d-5550-4399-8752-edba2fc7ab42",
                    Name = "Manchester City",
                    HomeTown = "Manchester",
                    HomeCountry = "England",
                    TeamIconUrl = "https://upload.wikimedia.org/wikipedia/en/e/eb/Manchester_City_FC_badge.svg",
                    LeagueId = "1a1f1f00-aaaa-aaaa-aaaa-111111111111" // Premier League
                },
                new Team
                {
                    Id = "74c1fcab-b9d6-4b6f-aeef-6ece83923c32",
                    Name = "Barcelona",
                    HomeTown = "Barcelona",
                    HomeCountry = "Spain",
                    TeamIconUrl = "https://upload.wikimedia.org/wikipedia/en/4/47/FC_Barcelona_%28crest%29.svg",
                    LeagueId = "2b2f2f00-bbbb-bbbb-bbbb-222222222222" // La Liga
                },
                new Team
                {
                    Id = "1811b66c-462b-46a9-9c4a-344d310c329e",
                    Name = "AC Milan",
                    HomeTown = "Milan",
                    HomeCountry = "Italy",
                    TeamIconUrl = "https://upload.wikimedia.org/wikipedia/en/d/d0/AC_Milan_logo.svg",
                    LeagueId = "4d4f4f00-dddd-dddd-dddd-444444444444" // Serie A
                },
                new Team
                {
                    Id = "c23f5056-0bf2-4cbe-92b3-7dfdcc226ece",
                    Name = "Paris Saint-Germain",
                    HomeTown = "Paris",
                    HomeCountry = "France",
                    TeamIconUrl = "https://upload.wikimedia.org/wikipedia/en/a/a7/Paris_Saint-Germain_F.C..svg",
                    LeagueId = "5e5f5f00-eeee-eeee-eeee-555555555555" // Ligue 1
                },
                new Team
                {
                    Id = "aefd72fb-edfe-4239-bdec-21fea1ad49cb",
                    Name = "Inter Miami",
                    HomeTown = "Miami",
                    HomeCountry = "USA",
                    TeamIconUrl = "https://upload.wikimedia.org/wikipedia/en/4/4a/Inter_Miami_CF_logo.svg",
                    LeagueId = "8h8f8f00-hhhh-hhhh-hhhh-888888888888" // MLS
                },
                new Team
                {
                    Id = "0b9e12ef-bc06-4ba8-a660-fcd52285258c",
                    Name = "Bayern Munich",
                    HomeTown = "Munich",
                    HomeCountry = "Germany",
                    TeamIconUrl = "https://upload.wikimedia.org/wikipedia/commons/1/1c/FC_Bayern_München_logo_%282017%29.svg",
                    LeagueId = "3c3f3f00-cccc-cccc-cccc-333333333333" // Bundesliga
                }
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

        public void SeedLeagues()
        {
            Leagues = new HashSet<League>
            {
                new League
                {
                    Id = "1a1f1f00-aaaa-aaaa-aaaa-111111111111",
                    Name = "Premier League",
                    Country = "England",
                    LogoUrl = "https://upload.wikimedia.org/wikipedia/en/f/f2/Premier_League_Logo.svg"
                },
                new League
                {
                    Id = "2b2f2f00-bbbb-bbbb-bbbb-222222222222",
                    Name = "La Liga",
                    Country = "Spain",
                    LogoUrl = "https://pngdownload.io/wp-content/uploads/2023/12/LaLiga-Logo-PNG-Official-Symbol-for-Football-League-Transparent-jpg.webp"
                },
                new League
                {
                    Id = "3c3f3f00-cccc-cccc-cccc-333333333333",
                    Name = "Bundesliga",
                    Country = "Germany",
                    LogoUrl = "https://upload.wikimedia.org/wikipedia/en/d/df/Bundesliga_logo_%282017%29.svg"
                },
                new League
                {
                    Id = "4d4f4f00-dddd-dddd-dddd-444444444444",
                    Name = "Serie A",
                    Country = "Italy",
                    LogoUrl = "https://logolook.net/wp-content/uploads/2023/11/Italian-Serie-A-Logo.png"
                },
                new League
                {
                    Id = "5e5f5f00-eeee-eeee-eeee-555555555555",
                    Name = "Ligue 1",
                    Country = "France",
                    LogoUrl = "https://static.cdnlogo.com/logos/l/37/ligue-1.png"
                },
                new League
                {
                    Id = "6f6f6f00-ffff-ffff-ffff-666666666666",
                    Name = "Eredivisie",
                    Country = "Netherlands",
                    LogoUrl = "https://upload.wikimedia.org/wikipedia/commons/4/46/Eredivisie_nuovo_logo.png"
                },
                new League
                {
                    Id = "7g7f7f00-gggg-gggg-gggg-777777777777",
                    Name = "Primeira Liga",
                    Country = "Portugal",
                    LogoUrl = "https://upload.wikimedia.org/wikipedia/commons/5/5a/S%C3%ADmbolo_da_Liga_Portuguesa_de_Futebol_Profissional.png"
                },
                new League
                {
                    Id = "8h8f8f00-hhhh-hhhh-hhhh-888888888888",
                    Name = "Major League Soccer",
                    Country = "USA",
                    LogoUrl = "https://upload.wikimedia.org/wikipedia/commons/7/76/MLS_crest_logo_RGB_gradient.svg"
                },
                new League
                {
                    Id = "9i9f9f00-iiii-iiii-iiii-999999999999",
                    Name = "Brasileirão",
                    Country = "Brazil",
                    LogoUrl = "https://e7.pngegg.com/pngimages/985/30/png-clipart-2018-campeonato-brasileiro-serie-a-campeonato-brasileiro-serie-b-campeonato-brasileiro-serie-c-brazil-1959-campeonato-brasileiro-serie-a-football-text-logo-thumbnail.png"
                },
                new League
                {
                    Id = "0j0f0f00-jjjj-jjjj-jjjj-000000000000",
                    Name = "Argentine Primera División",
                    Country = "Argentina",
                    LogoUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/92/Logo_de_la_Liga_Profesional_de_F%C3%BAtbol_de_Argentina.svg/1200px-Logo_de_la_Liga_Profesional_de_F%C3%BAtbol_de_Argentina.svg.png"
                }
            };
        }

    }
}
