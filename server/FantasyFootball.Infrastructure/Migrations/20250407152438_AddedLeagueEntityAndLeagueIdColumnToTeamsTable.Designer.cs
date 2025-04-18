﻿// <auto-generated />
using System;
using FantasyFootball.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FantasyFootball.Infrastructure.Migrations
{
    [DbContext(typeof(FantasyFootballDbContext))]
    [Migration("20250407152438_AddedLeagueEntityAndLeagueIdColumnToTeamsTable")]
    partial class AddedLeagueEntityAndLeagueIdColumnToTeamsTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FantasyFootball.Infrastructure.Data.Models.FantasyTeam", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalPoints")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("FantasyTeams");
                });

            modelBuilder.Entity("FantasyFootball.Infrastructure.Data.Models.League", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LogoUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Leagues");

                    b.HasData(
                        new
                        {
                            Id = "1a1f1f00-aaaa-aaaa-aaaa-111111111111",
                            Country = "England",
                            LogoUrl = "https://upload.wikimedia.org/wikipedia/en/f/f2/Premier_League_Logo.svg",
                            Name = "Premier League"
                        },
                        new
                        {
                            Id = "2b2f2f00-bbbb-bbbb-bbbb-222222222222",
                            Country = "Spain",
                            LogoUrl = "https://upload.wikimedia.org/wikipedia/en/9/92/La_Liga_Santander.svg",
                            Name = "La Liga"
                        },
                        new
                        {
                            Id = "3c3f3f00-cccc-cccc-cccc-333333333333",
                            Country = "Germany",
                            LogoUrl = "https://upload.wikimedia.org/wikipedia/en/d/df/Bundesliga_logo_%282017%29.svg",
                            Name = "Bundesliga"
                        },
                        new
                        {
                            Id = "4d4f4f00-dddd-dddd-dddd-444444444444",
                            Country = "Italy",
                            LogoUrl = "https://upload.wikimedia.org/wikipedia/en/e/e1/Serie_A_logo_%282019%29.svg",
                            Name = "Serie A"
                        },
                        new
                        {
                            Id = "5e5f5f00-eeee-eeee-eeee-555555555555",
                            Country = "France",
                            LogoUrl = "https://upload.wikimedia.org/wikipedia/en/c/c7/Ligue1.svg",
                            Name = "Ligue 1"
                        },
                        new
                        {
                            Id = "6f6f6f00-ffff-ffff-ffff-666666666666",
                            Country = "Netherlands",
                            LogoUrl = "https://upload.wikimedia.org/wikipedia/en/5/5e/Eredivisie_logo_%282017%29.svg",
                            Name = "Eredivisie"
                        },
                        new
                        {
                            Id = "7g7f7f00-gggg-gggg-gggg-777777777777",
                            Country = "Portugal",
                            LogoUrl = "https://upload.wikimedia.org/wikipedia/en/2/2d/Liga_Portugal_logo.svg",
                            Name = "Primeira Liga"
                        },
                        new
                        {
                            Id = "8h8f8f00-hhhh-hhhh-hhhh-888888888888",
                            Country = "USA",
                            LogoUrl = "https://upload.wikimedia.org/wikipedia/commons/7/76/MLS_crest_logo_RGB_gradient.svg",
                            Name = "Major League Soccer"
                        },
                        new
                        {
                            Id = "9i9f9f00-iiii-iiii-iiii-999999999999",
                            Country = "Brazil",
                            LogoUrl = "https://upload.wikimedia.org/wikipedia/commons/b/be/Campeonato_Brasileiro_Série_A_logo.png",
                            Name = "Brasileirão"
                        },
                        new
                        {
                            Id = "0j0f0f00-jjjj-jjjj-jjjj-000000000000",
                            Country = "Argentina",
                            LogoUrl = "https://upload.wikimedia.org/wikipedia/en/2/27/Liga_Profesional_de_Fútbol_%28Argentina%29_logo.svg",
                            Name = "Argentine Primera División"
                        });
                });

            modelBuilder.Entity("FantasyFootball.Infrastructure.Data.Models.Player", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("MarketValue")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Nationality")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Position")
                        .HasColumnType("int");

                    b.Property<string>("TeamId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("Players");

                    b.HasData(
                        new
                        {
                            Id = "1eca6925-c9e5-4dd0-8864-22d54e872dfc",
                            FirstName = "Alisson",
                            LastName = "Becker",
                            MarketValue = 60000000m,
                            Nationality = "Brazil",
                            Position = 0,
                            TeamId = "b3241106-0d85-4c91-aaa9-5c1a37dc2553"
                        },
                        new
                        {
                            Id = "2e9c383b-dba1-483d-a3ab-f82d306d2916",
                            FirstName = "Thibaut",
                            LastName = "Courtois",
                            MarketValue = 55000000m,
                            Nationality = "Belgium",
                            Position = 0,
                            TeamId = "506eb3fc-7511-4af8-86de-11b55623deca"
                        },
                        new
                        {
                            Id = "5ccd5bf4-0b6d-4dc0-96e8-630211b29849",
                            FirstName = "Virgil",
                            LastName = "van Dijk",
                            MarketValue = 70000000m,
                            Nationality = "Netherlands",
                            Position = 1,
                            TeamId = "b3241106-0d85-4c91-aaa9-5c1a37dc2553"
                        },
                        new
                        {
                            Id = "5612fa2c-7547-49c2-8b25-3161799c4606",
                            FirstName = "Rúben",
                            LastName = "Dias",
                            MarketValue = 75000000m,
                            Nationality = "Portugal",
                            Position = 1,
                            TeamId = "4eb0819d-5550-4399-8752-edba2fc7ab42"
                        },
                        new
                        {
                            Id = "06aa4fb4-3f94-450a-a838-398dc6bd8677",
                            FirstName = "João",
                            LastName = "Cancelo",
                            MarketValue = 65000000m,
                            Nationality = "Portugal",
                            Position = 3,
                            TeamId = "74c1fcab-b9d6-4b6f-aeef-6ece83923c32"
                        },
                        new
                        {
                            Id = "7f1a4af5-03bc-439a-95e6-5d009af80e0a",
                            FirstName = "Theo",
                            LastName = "Hernández",
                            MarketValue = 60000000m,
                            Nationality = "France",
                            Position = 2,
                            TeamId = "1811b66c-462b-46a9-9c4a-344d310c329e"
                        },
                        new
                        {
                            Id = "6a73e040-a993-41b8-b987-5238fa997ef1",
                            FirstName = "Kevin",
                            LastName = "De Bruyne",
                            MarketValue = 80000000m,
                            Nationality = "Belgium",
                            Position = 8,
                            TeamId = "4eb0819d-5550-4399-8752-edba2fc7ab42"
                        },
                        new
                        {
                            Id = "4126356f-b068-4831-bea0-9bb5ee74af91",
                            FirstName = "Luka",
                            LastName = "Modrić",
                            MarketValue = 20000000m,
                            Nationality = "Croatia",
                            Position = 7,
                            TeamId = "506eb3fc-7511-4af8-86de-11b55623deca"
                        },
                        new
                        {
                            Id = "6fed43a7-e4d5-4f24-b901-ae168a4a800f",
                            FirstName = "Rodri",
                            LastName = "Hernandez",
                            MarketValue = 70000000m,
                            Nationality = "Spain",
                            Position = 6,
                            TeamId = "4eb0819d-5550-4399-8752-edba2fc7ab42"
                        },
                        new
                        {
                            Id = "8a5e73ce-798e-42e8-beeb-cdd2517a959a",
                            FirstName = "Federico",
                            LastName = "Valverde",
                            MarketValue = 85000000m,
                            Nationality = "Uruguay",
                            Position = 10,
                            TeamId = "506eb3fc-7511-4af8-86de-11b55623deca"
                        },
                        new
                        {
                            Id = "70faad43-e99b-4de4-a766-f7c4365cb356",
                            FirstName = "Kylian",
                            LastName = "Mbappé",
                            MarketValue = 180000000m,
                            Nationality = "France",
                            Position = 14,
                            TeamId = "c23f5056-0bf2-4cbe-92b3-7dfdcc226ece"
                        },
                        new
                        {
                            Id = "a0455607-184a-43f2-8a29-462c7c7a3cd1",
                            FirstName = "Erling",
                            LastName = "Haaland",
                            MarketValue = 200000000m,
                            Nationality = "Norway",
                            Position = 11,
                            TeamId = "4eb0819d-5550-4399-8752-edba2fc7ab42"
                        },
                        new
                        {
                            Id = "f10d8a15-ebf2-4ffa-8e61-8c63debf9944",
                            FirstName = "Lionel",
                            LastName = "Messi",
                            MarketValue = 40000000m,
                            Nationality = "Argentina",
                            Position = 15,
                            TeamId = "aefd72fb-edfe-4239-bdec-21fea1ad49cb"
                        },
                        new
                        {
                            Id = "48890162-187e-4191-adf9-f04fc1a8af87",
                            FirstName = "Harry",
                            LastName = "Kane",
                            MarketValue = 100000000m,
                            Nationality = "England",
                            Position = 12,
                            TeamId = "0b9e12ef-bc06-4ba8-a660-fcd52285258c"
                        });
                });

            modelBuilder.Entity("FantasyFootball.Infrastructure.Data.Models.PlayerFantasyTeam", b =>
                {
                    b.Property<string>("PlayerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FantasyTeamId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PlayerId", "FantasyTeamId");

                    b.HasIndex("FantasyTeamId");

                    b.ToTable("PlayersFantasyTeams");
                });

            modelBuilder.Entity("FantasyFootball.Infrastructure.Data.Models.Team", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("HomeCountry")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomeTown")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LeagueId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeamIconUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LeagueId");

                    b.ToTable("Teams");

                    b.HasData(
                        new
                        {
                            Id = "b3241106-0d85-4c91-aaa9-5c1a37dc2553",
                            HomeCountry = "England",
                            HomeTown = "Liverpool",
                            LeagueId = "1a1f1f00-aaaa-aaaa-aaaa-111111111111",
                            Name = "Liverpool",
                            TeamIconUrl = "https://upload.wikimedia.org/wikipedia/en/0/0c/Liverpool_FC.svg"
                        },
                        new
                        {
                            Id = "506eb3fc-7511-4af8-86de-11b55623deca",
                            HomeCountry = "Spain",
                            HomeTown = "Madrid",
                            LeagueId = "2b2f2f00-bbbb-bbbb-bbbb-222222222222",
                            Name = "Real Madrid",
                            TeamIconUrl = "https://upload.wikimedia.org/wikipedia/en/5/56/Real_Madrid_CF.svg"
                        },
                        new
                        {
                            Id = "4eb0819d-5550-4399-8752-edba2fc7ab42",
                            HomeCountry = "England",
                            HomeTown = "Manchester",
                            LeagueId = "1a1f1f00-aaaa-aaaa-aaaa-111111111111",
                            Name = "Manchester City",
                            TeamIconUrl = "https://upload.wikimedia.org/wikipedia/en/e/eb/Manchester_City_FC_badge.svg"
                        },
                        new
                        {
                            Id = "74c1fcab-b9d6-4b6f-aeef-6ece83923c32",
                            HomeCountry = "Spain",
                            HomeTown = "Barcelona",
                            LeagueId = "2b2f2f00-bbbb-bbbb-bbbb-222222222222",
                            Name = "Barcelona",
                            TeamIconUrl = "https://upload.wikimedia.org/wikipedia/en/4/47/FC_Barcelona_%28crest%29.svg"
                        },
                        new
                        {
                            Id = "1811b66c-462b-46a9-9c4a-344d310c329e",
                            HomeCountry = "Italy",
                            HomeTown = "Milan",
                            LeagueId = "4d4f4f00-dddd-dddd-dddd-444444444444",
                            Name = "AC Milan",
                            TeamIconUrl = "https://upload.wikimedia.org/wikipedia/en/d/d0/AC_Milan_logo.svg"
                        },
                        new
                        {
                            Id = "c23f5056-0bf2-4cbe-92b3-7dfdcc226ece",
                            HomeCountry = "France",
                            HomeTown = "Paris",
                            LeagueId = "5e5f5f00-eeee-eeee-eeee-555555555555",
                            Name = "Paris Saint-Germain",
                            TeamIconUrl = "https://upload.wikimedia.org/wikipedia/en/a/a7/Paris_Saint-Germain_F.C..svg"
                        },
                        new
                        {
                            Id = "aefd72fb-edfe-4239-bdec-21fea1ad49cb",
                            HomeCountry = "USA",
                            HomeTown = "Miami",
                            LeagueId = "8h8f8f00-hhhh-hhhh-hhhh-888888888888",
                            Name = "Inter Miami",
                            TeamIconUrl = "https://upload.wikimedia.org/wikipedia/en/4/4a/Inter_Miami_CF_logo.svg"
                        },
                        new
                        {
                            Id = "0b9e12ef-bc06-4ba8-a660-fcd52285258c",
                            HomeCountry = "Germany",
                            HomeTown = "Munich",
                            LeagueId = "3c3f3f00-cccc-cccc-cccc-333333333333",
                            Name = "Bayern Munich",
                            TeamIconUrl = "https://upload.wikimedia.org/wikipedia/commons/1/1c/FC_Bayern_München_logo_%282017%29.svg"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(21)
                        .HasColumnType("nvarchar(21)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator().HasValue("IdentityUser");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("FantasyFootball.Infrastructure.Data.Models.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("Nickname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilePicture")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("ApplicationUser");
                });

            modelBuilder.Entity("FantasyFootball.Infrastructure.Data.Models.FantasyTeam", b =>
                {
                    b.HasOne("FantasyFootball.Infrastructure.Data.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("FantasyFootball.Infrastructure.Data.Models.Player", b =>
                {
                    b.HasOne("FantasyFootball.Infrastructure.Data.Models.Team", "Team")
                        .WithMany()
                        .HasForeignKey("TeamId");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("FantasyFootball.Infrastructure.Data.Models.PlayerFantasyTeam", b =>
                {
                    b.HasOne("FantasyFootball.Infrastructure.Data.Models.FantasyTeam", "FantasyTeam")
                        .WithMany()
                        .HasForeignKey("FantasyTeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FantasyFootball.Infrastructure.Data.Models.Player", "Player")
                        .WithMany()
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FantasyTeam");

                    b.Navigation("Player");
                });

            modelBuilder.Entity("FantasyFootball.Infrastructure.Data.Models.Team", b =>
                {
                    b.HasOne("FantasyFootball.Infrastructure.Data.Models.League", "League")
                        .WithMany()
                        .HasForeignKey("LeagueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("League");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
