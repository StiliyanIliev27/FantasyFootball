using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FantasyFootball.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedLeagueEntityAndLeagueIdColumnToTeamsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: "2aff1ec4-706a-45d4-87de-d4a2f476a4cb");

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: "2b01eecc-2875-40c3-a75c-b433be72d805");

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: "34ebb98a-6208-4f8c-a775-f37814981825");

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: "40fa0d95-6b2c-4ed1-bcfc-5753a5d3e89b");

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: "571d21cd-431b-4077-8768-021273506b5a");

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: "62bc10b0-af3e-4da3-9437-bab5863d8baf");

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: "6fd6535a-158d-474a-90f5-966f8d5e10fa");

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: "826f7528-0817-4a04-8d70-d8d701e48c49");

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: "8704944f-63ac-44e7-81a0-f7888f948030");

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: "a7ea93ed-d79e-46c2-8b16-818a192c3c22");

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: "b01088ae-a53a-4852-8878-4edf32e48d01");

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: "b409424b-07ad-4964-92f8-458ac19d97c8");

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: "f7a59c84-0d95-4ccb-92aa-90c747a3757a");

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: "fd74593a-2792-4372-9a16-0fcdfb0ac709");

            migrationBuilder.AddColumn<string>(
                name: "LeagueId",
                table: "Teams",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Leagues",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leagues", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Leagues",
                columns: new[] { "Id", "Country", "LogoUrl", "Name" },
                values: new object[,]
                {
                    { "0j0f0f00-jjjj-jjjj-jjjj-000000000000", "Argentina", "https://upload.wikimedia.org/wikipedia/en/2/27/Liga_Profesional_de_Fútbol_%28Argentina%29_logo.svg", "Argentine Primera División" },
                    { "1a1f1f00-aaaa-aaaa-aaaa-111111111111", "England", "https://upload.wikimedia.org/wikipedia/en/f/f2/Premier_League_Logo.svg", "Premier League" },
                    { "2b2f2f00-bbbb-bbbb-bbbb-222222222222", "Spain", "https://upload.wikimedia.org/wikipedia/en/9/92/La_Liga_Santander.svg", "La Liga" },
                    { "3c3f3f00-cccc-cccc-cccc-333333333333", "Germany", "https://upload.wikimedia.org/wikipedia/en/d/df/Bundesliga_logo_%282017%29.svg", "Bundesliga" },
                    { "4d4f4f00-dddd-dddd-dddd-444444444444", "Italy", "https://upload.wikimedia.org/wikipedia/en/e/e1/Serie_A_logo_%282019%29.svg", "Serie A" },
                    { "5e5f5f00-eeee-eeee-eeee-555555555555", "France", "https://upload.wikimedia.org/wikipedia/en/c/c7/Ligue1.svg", "Ligue 1" },
                    { "6f6f6f00-ffff-ffff-ffff-666666666666", "Netherlands", "https://upload.wikimedia.org/wikipedia/en/5/5e/Eredivisie_logo_%282017%29.svg", "Eredivisie" },
                    { "7g7f7f00-gggg-gggg-gggg-777777777777", "Portugal", "https://upload.wikimedia.org/wikipedia/en/2/2d/Liga_Portugal_logo.svg", "Primeira Liga" },
                    { "8h8f8f00-hhhh-hhhh-hhhh-888888888888", "USA", "https://upload.wikimedia.org/wikipedia/commons/7/76/MLS_crest_logo_RGB_gradient.svg", "Major League Soccer" },
                    { "9i9f9f00-iiii-iiii-iiii-999999999999", "Brazil", "https://upload.wikimedia.org/wikipedia/commons/b/be/Campeonato_Brasileiro_Série_A_logo.png", "Brasileirão" }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "FirstName", "LastName", "MarketValue", "Nationality", "Position", "TeamId" },
                values: new object[,]
                {
                    { "06aa4fb4-3f94-450a-a838-398dc6bd8677", "João", "Cancelo", 65000000m, "Portugal", 3, "74c1fcab-b9d6-4b6f-aeef-6ece83923c32" },
                    { "1eca6925-c9e5-4dd0-8864-22d54e872dfc", "Alisson", "Becker", 60000000m, "Brazil", 0, "b3241106-0d85-4c91-aaa9-5c1a37dc2553" },
                    { "2e9c383b-dba1-483d-a3ab-f82d306d2916", "Thibaut", "Courtois", 55000000m, "Belgium", 0, "506eb3fc-7511-4af8-86de-11b55623deca" },
                    { "4126356f-b068-4831-bea0-9bb5ee74af91", "Luka", "Modrić", 20000000m, "Croatia", 7, "506eb3fc-7511-4af8-86de-11b55623deca" },
                    { "48890162-187e-4191-adf9-f04fc1a8af87", "Harry", "Kane", 100000000m, "England", 12, "0b9e12ef-bc06-4ba8-a660-fcd52285258c" },
                    { "5612fa2c-7547-49c2-8b25-3161799c4606", "Rúben", "Dias", 75000000m, "Portugal", 1, "4eb0819d-5550-4399-8752-edba2fc7ab42" },
                    { "5ccd5bf4-0b6d-4dc0-96e8-630211b29849", "Virgil", "van Dijk", 70000000m, "Netherlands", 1, "b3241106-0d85-4c91-aaa9-5c1a37dc2553" },
                    { "6a73e040-a993-41b8-b987-5238fa997ef1", "Kevin", "De Bruyne", 80000000m, "Belgium", 8, "4eb0819d-5550-4399-8752-edba2fc7ab42" },
                    { "6fed43a7-e4d5-4f24-b901-ae168a4a800f", "Rodri", "Hernandez", 70000000m, "Spain", 6, "4eb0819d-5550-4399-8752-edba2fc7ab42" },
                    { "70faad43-e99b-4de4-a766-f7c4365cb356", "Kylian", "Mbappé", 180000000m, "France", 14, "c23f5056-0bf2-4cbe-92b3-7dfdcc226ece" },
                    { "7f1a4af5-03bc-439a-95e6-5d009af80e0a", "Theo", "Hernández", 60000000m, "France", 2, "1811b66c-462b-46a9-9c4a-344d310c329e" },
                    { "8a5e73ce-798e-42e8-beeb-cdd2517a959a", "Federico", "Valverde", 85000000m, "Uruguay", 10, "506eb3fc-7511-4af8-86de-11b55623deca" },
                    { "a0455607-184a-43f2-8a29-462c7c7a3cd1", "Erling", "Haaland", 200000000m, "Norway", 11, "4eb0819d-5550-4399-8752-edba2fc7ab42" },
                    { "f10d8a15-ebf2-4ffa-8e61-8c63debf9944", "Lionel", "Messi", 40000000m, "Argentina", 15, "aefd72fb-edfe-4239-bdec-21fea1ad49cb" }
                });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "0b9e12ef-bc06-4ba8-a660-fcd52285258c",
                column: "LeagueId",
                value: "3c3f3f00-cccc-cccc-cccc-333333333333");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "1811b66c-462b-46a9-9c4a-344d310c329e",
                column: "LeagueId",
                value: "4d4f4f00-dddd-dddd-dddd-444444444444");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "4eb0819d-5550-4399-8752-edba2fc7ab42",
                column: "LeagueId",
                value: "1a1f1f00-aaaa-aaaa-aaaa-111111111111");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "506eb3fc-7511-4af8-86de-11b55623deca",
                column: "LeagueId",
                value: "2b2f2f00-bbbb-bbbb-bbbb-222222222222");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "74c1fcab-b9d6-4b6f-aeef-6ece83923c32",
                column: "LeagueId",
                value: "2b2f2f00-bbbb-bbbb-bbbb-222222222222");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "aefd72fb-edfe-4239-bdec-21fea1ad49cb",
                column: "LeagueId",
                value: "8h8f8f00-hhhh-hhhh-hhhh-888888888888");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "b3241106-0d85-4c91-aaa9-5c1a37dc2553",
                column: "LeagueId",
                value: "1a1f1f00-aaaa-aaaa-aaaa-111111111111");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: "c23f5056-0bf2-4cbe-92b3-7dfdcc226ece",
                column: "LeagueId",
                value: "5e5f5f00-eeee-eeee-eeee-555555555555");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_LeagueId",
                table: "Teams",
                column: "LeagueId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Leagues_LeagueId",
                table: "Teams",
                column: "LeagueId",
                principalTable: "Leagues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Leagues_LeagueId",
                table: "Teams");

            migrationBuilder.DropTable(
                name: "Leagues");

            migrationBuilder.DropIndex(
                name: "IX_Teams_LeagueId",
                table: "Teams");

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: "06aa4fb4-3f94-450a-a838-398dc6bd8677");

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: "1eca6925-c9e5-4dd0-8864-22d54e872dfc");

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: "2e9c383b-dba1-483d-a3ab-f82d306d2916");

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: "4126356f-b068-4831-bea0-9bb5ee74af91");

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: "48890162-187e-4191-adf9-f04fc1a8af87");

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: "5612fa2c-7547-49c2-8b25-3161799c4606");

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: "5ccd5bf4-0b6d-4dc0-96e8-630211b29849");

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: "6a73e040-a993-41b8-b987-5238fa997ef1");

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: "6fed43a7-e4d5-4f24-b901-ae168a4a800f");

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: "70faad43-e99b-4de4-a766-f7c4365cb356");

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: "7f1a4af5-03bc-439a-95e6-5d009af80e0a");

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: "8a5e73ce-798e-42e8-beeb-cdd2517a959a");

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: "a0455607-184a-43f2-8a29-462c7c7a3cd1");

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: "f10d8a15-ebf2-4ffa-8e61-8c63debf9944");

            migrationBuilder.DropColumn(
                name: "LeagueId",
                table: "Teams");

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "FirstName", "LastName", "MarketValue", "Nationality", "Position", "TeamId" },
                values: new object[,]
                {
                    { "2aff1ec4-706a-45d4-87de-d4a2f476a4cb", "Thibaut", "Courtois", 55000000m, "Belgium", 0, "506eb3fc-7511-4af8-86de-11b55623deca" },
                    { "2b01eecc-2875-40c3-a75c-b433be72d805", "Alisson", "Becker", 60000000m, "Brazil", 0, "b3241106-0d85-4c91-aaa9-5c1a37dc2553" },
                    { "34ebb98a-6208-4f8c-a775-f37814981825", "Rúben", "Dias", 75000000m, "Portugal", 1, "4eb0819d-5550-4399-8752-edba2fc7ab42" },
                    { "40fa0d95-6b2c-4ed1-bcfc-5753a5d3e89b", "Theo", "Hernández", 60000000m, "France", 2, "1811b66c-462b-46a9-9c4a-344d310c329e" },
                    { "571d21cd-431b-4077-8768-021273506b5a", "Kevin", "De Bruyne", 80000000m, "Belgium", 8, "4eb0819d-5550-4399-8752-edba2fc7ab42" },
                    { "62bc10b0-af3e-4da3-9437-bab5863d8baf", "Kylian", "Mbappé", 180000000m, "France", 14, "c23f5056-0bf2-4cbe-92b3-7dfdcc226ece" },
                    { "6fd6535a-158d-474a-90f5-966f8d5e10fa", "Luka", "Modrić", 20000000m, "Croatia", 7, "506eb3fc-7511-4af8-86de-11b55623deca" },
                    { "826f7528-0817-4a04-8d70-d8d701e48c49", "Lionel", "Messi", 40000000m, "Argentina", 15, "aefd72fb-edfe-4239-bdec-21fea1ad49cb" },
                    { "8704944f-63ac-44e7-81a0-f7888f948030", "Federico", "Valverde", 85000000m, "Uruguay", 10, "506eb3fc-7511-4af8-86de-11b55623deca" },
                    { "a7ea93ed-d79e-46c2-8b16-818a192c3c22", "Harry", "Kane", 100000000m, "England", 12, "0b9e12ef-bc06-4ba8-a660-fcd52285258c" },
                    { "b01088ae-a53a-4852-8878-4edf32e48d01", "Erling", "Haaland", 200000000m, "Norway", 11, "4eb0819d-5550-4399-8752-edba2fc7ab42" },
                    { "b409424b-07ad-4964-92f8-458ac19d97c8", "Virgil", "van Dijk", 70000000m, "Netherlands", 1, "b3241106-0d85-4c91-aaa9-5c1a37dc2553" },
                    { "f7a59c84-0d95-4ccb-92aa-90c747a3757a", "João", "Cancelo", 65000000m, "Portugal", 3, "74c1fcab-b9d6-4b6f-aeef-6ece83923c32" },
                    { "fd74593a-2792-4372-9a16-0fcdfb0ac709", "Rodri", "Hernandez", 70000000m, "Spain", 6, "4eb0819d-5550-4399-8752-edba2fc7ab42" }
                });
        }
    }
}
