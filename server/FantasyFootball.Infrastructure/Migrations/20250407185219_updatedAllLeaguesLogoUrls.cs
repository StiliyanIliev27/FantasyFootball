using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FantasyFootball.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updatedAllLeaguesLogoUrls : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: "1e0d80fc-6ad2-4610-bb32-92aafbddda9c");

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: "1f964a4a-23d5-42b3-bc11-ab61642996c9");

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: "3adb9f29-a43d-476c-9b53-64b16a116ceb");

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: "5a67c678-6505-406c-8728-c0fd89f29aa6");

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: "69a125c4-4a47-4052-ae68-93c7da2cdd6b");

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: "87b64ca9-9e47-4e78-9385-d7c5412dd920");

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: "b3f7425a-f99c-4426-9529-721651370ebe");

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: "b6d74029-fee0-425c-84f1-57316c92ee3f");

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: "c9d6e61b-c920-45f8-8a8e-c801eff0e602");

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: "cad82805-34ec-4209-bd3d-64170ad0c12b");

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: "e42bb921-4e24-4f3c-84fa-fd5130172668");

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: "f130ad60-d896-46de-9988-d5098ee9e6fb");

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: "f276537d-d472-4d5a-bade-77d182d5954e");

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: "f35ef5ee-ee6d-472c-b47c-7c9a3a623bf7");

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: "0j0f0f00-jjjj-jjjj-jjjj-000000000000",
                column: "LogoUrl",
                value: "https://upload.wikimedia.org/wikipedia/commons/thumb/9/92/Logo_de_la_Liga_Profesional_de_F%C3%BAtbol_de_Argentina.svg/1200px-Logo_de_la_Liga_Profesional_de_F%C3%BAtbol_de_Argentina.svg.png");

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: "2b2f2f00-bbbb-bbbb-bbbb-222222222222",
                column: "LogoUrl",
                value: "https://pngdownload.io/wp-content/uploads/2023/12/LaLiga-Logo-PNG-Official-Symbol-for-Football-League-Transparent-jpg.webp");

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: "5e5f5f00-eeee-eeee-eeee-555555555555",
                column: "LogoUrl",
                value: "https://static.cdnlogo.com/logos/l/37/ligue-1.png");

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: "6f6f6f00-ffff-ffff-ffff-666666666666",
                column: "LogoUrl",
                value: "https://upload.wikimedia.org/wikipedia/commons/4/46/Eredivisie_nuovo_logo.png");

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: "7g7f7f00-gggg-gggg-gggg-777777777777",
                column: "LogoUrl",
                value: "https://upload.wikimedia.org/wikipedia/commons/5/5a/S%C3%ADmbolo_da_Liga_Portuguesa_de_Futebol_Profissional.png");

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: "9i9f9f00-iiii-iiii-iiii-999999999999",
                column: "LogoUrl",
                value: "https://e7.pngegg.com/pngimages/985/30/png-clipart-2018-campeonato-brasileiro-serie-a-campeonato-brasileiro-serie-b-campeonato-brasileiro-serie-c-brazil-1959-campeonato-brasileiro-serie-a-football-text-logo-thumbnail.png");

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "FirstName", "LastName", "MarketValue", "Nationality", "Position", "TeamId" },
                values: new object[,]
                {
                    { "08453d7f-2b2f-48ef-89f3-8c55781b5ba7", "Luka", "Modrić", 20000000m, "Croatia", 7, "506eb3fc-7511-4af8-86de-11b55623deca" },
                    { "171445e2-5d99-403a-acf6-d47fd2a07260", "Federico", "Valverde", 85000000m, "Uruguay", 10, "506eb3fc-7511-4af8-86de-11b55623deca" },
                    { "1d4c086b-eeae-49f8-a633-c204ef2f7585", "Thibaut", "Courtois", 55000000m, "Belgium", 0, "506eb3fc-7511-4af8-86de-11b55623deca" },
                    { "2b95f465-4bee-4d57-b08a-6cc31e803126", "Lionel", "Messi", 40000000m, "Argentina", 15, "aefd72fb-edfe-4239-bdec-21fea1ad49cb" },
                    { "5d0b04f7-ac12-415c-9c0d-c43cf0b592e9", "Harry", "Kane", 100000000m, "England", 12, "0b9e12ef-bc06-4ba8-a660-fcd52285258c" },
                    { "82f97032-eb68-4d6a-897c-932d25381361", "Virgil", "van Dijk", 70000000m, "Netherlands", 1, "b3241106-0d85-4c91-aaa9-5c1a37dc2553" },
                    { "b04eb71d-c461-44fc-ba2b-14064a086b4a", "Rúben", "Dias", 75000000m, "Portugal", 1, "4eb0819d-5550-4399-8752-edba2fc7ab42" },
                    { "bd2f0065-3ecf-40e7-aace-2a7f94ee2a57", "Alisson", "Becker", 60000000m, "Brazil", 0, "b3241106-0d85-4c91-aaa9-5c1a37dc2553" },
                    { "c0127da1-a89a-4eab-a8bf-e5678bf4ca3c", "Rodri", "Hernandez", 70000000m, "Spain", 6, "4eb0819d-5550-4399-8752-edba2fc7ab42" },
                    { "c94c5663-c1ab-434a-9583-98e0c578e5a4", "Erling", "Haaland", 200000000m, "Norway", 11, "4eb0819d-5550-4399-8752-edba2fc7ab42" },
                    { "e0fdd787-847f-4920-a9d1-3493162aa176", "João", "Cancelo", 65000000m, "Portugal", 3, "74c1fcab-b9d6-4b6f-aeef-6ece83923c32" },
                    { "eeedb98a-cde1-4701-90a2-6915d4763c7f", "Kylian", "Mbappé", 180000000m, "France", 14, "c23f5056-0bf2-4cbe-92b3-7dfdcc226ece" },
                    { "f47634ad-9709-44c9-a85e-8576555f82fb", "Kevin", "De Bruyne", 80000000m, "Belgium", 8, "4eb0819d-5550-4399-8752-edba2fc7ab42" },
                    { "fe9c0c29-eed4-448c-82b0-f55d74180989", "Theo", "Hernández", 60000000m, "France", 2, "1811b66c-462b-46a9-9c4a-344d310c329e" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: "08453d7f-2b2f-48ef-89f3-8c55781b5ba7");

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: "171445e2-5d99-403a-acf6-d47fd2a07260");

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: "1d4c086b-eeae-49f8-a633-c204ef2f7585");

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: "2b95f465-4bee-4d57-b08a-6cc31e803126");

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: "5d0b04f7-ac12-415c-9c0d-c43cf0b592e9");

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: "82f97032-eb68-4d6a-897c-932d25381361");

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: "b04eb71d-c461-44fc-ba2b-14064a086b4a");

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: "bd2f0065-3ecf-40e7-aace-2a7f94ee2a57");

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: "c0127da1-a89a-4eab-a8bf-e5678bf4ca3c");

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: "c94c5663-c1ab-434a-9583-98e0c578e5a4");

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: "e0fdd787-847f-4920-a9d1-3493162aa176");

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: "eeedb98a-cde1-4701-90a2-6915d4763c7f");

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: "f47634ad-9709-44c9-a85e-8576555f82fb");

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: "fe9c0c29-eed4-448c-82b0-f55d74180989");

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: "0j0f0f00-jjjj-jjjj-jjjj-000000000000",
                column: "LogoUrl",
                value: "https://upload.wikimedia.org/wikipedia/en/2/27/Liga_Profesional_de_Fútbol_%28Argentina%29_logo.svg");

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: "2b2f2f00-bbbb-bbbb-bbbb-222222222222",
                column: "LogoUrl",
                value: "https://upload.wikimedia.org/wikipedia/en/9/92/La_Liga_Santander.svg");

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: "5e5f5f00-eeee-eeee-eeee-555555555555",
                column: "LogoUrl",
                value: "https://upload.wikimedia.org/wikipedia/en/c/c7/Ligue1.svg");

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: "6f6f6f00-ffff-ffff-ffff-666666666666",
                column: "LogoUrl",
                value: "https://upload.wikimedia.org/wikipedia/en/5/5e/Eredivisie_logo_%282017%29.svg");

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: "7g7f7f00-gggg-gggg-gggg-777777777777",
                column: "LogoUrl",
                value: "https://upload.wikimedia.org/wikipedia/en/2/2d/Liga_Portugal_logo.svg");

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: "9i9f9f00-iiii-iiii-iiii-999999999999",
                column: "LogoUrl",
                value: "https://upload.wikimedia.org/wikipedia/commons/b/be/Campeonato_Brasileiro_Série_A_logo.png");

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "FirstName", "LastName", "MarketValue", "Nationality", "Position", "TeamId" },
                values: new object[,]
                {
                    { "1e0d80fc-6ad2-4610-bb32-92aafbddda9c", "Rúben", "Dias", 75000000m, "Portugal", 1, "4eb0819d-5550-4399-8752-edba2fc7ab42" },
                    { "1f964a4a-23d5-42b3-bc11-ab61642996c9", "Virgil", "van Dijk", 70000000m, "Netherlands", 1, "b3241106-0d85-4c91-aaa9-5c1a37dc2553" },
                    { "3adb9f29-a43d-476c-9b53-64b16a116ceb", "Thibaut", "Courtois", 55000000m, "Belgium", 0, "506eb3fc-7511-4af8-86de-11b55623deca" },
                    { "5a67c678-6505-406c-8728-c0fd89f29aa6", "Erling", "Haaland", 200000000m, "Norway", 11, "4eb0819d-5550-4399-8752-edba2fc7ab42" },
                    { "69a125c4-4a47-4052-ae68-93c7da2cdd6b", "Kevin", "De Bruyne", 80000000m, "Belgium", 8, "4eb0819d-5550-4399-8752-edba2fc7ab42" },
                    { "87b64ca9-9e47-4e78-9385-d7c5412dd920", "Alisson", "Becker", 60000000m, "Brazil", 0, "b3241106-0d85-4c91-aaa9-5c1a37dc2553" },
                    { "b3f7425a-f99c-4426-9529-721651370ebe", "Luka", "Modrić", 20000000m, "Croatia", 7, "506eb3fc-7511-4af8-86de-11b55623deca" },
                    { "b6d74029-fee0-425c-84f1-57316c92ee3f", "Harry", "Kane", 100000000m, "England", 12, "0b9e12ef-bc06-4ba8-a660-fcd52285258c" },
                    { "c9d6e61b-c920-45f8-8a8e-c801eff0e602", "Lionel", "Messi", 40000000m, "Argentina", 15, "aefd72fb-edfe-4239-bdec-21fea1ad49cb" },
                    { "cad82805-34ec-4209-bd3d-64170ad0c12b", "Theo", "Hernández", 60000000m, "France", 2, "1811b66c-462b-46a9-9c4a-344d310c329e" },
                    { "e42bb921-4e24-4f3c-84fa-fd5130172668", "Federico", "Valverde", 85000000m, "Uruguay", 10, "506eb3fc-7511-4af8-86de-11b55623deca" },
                    { "f130ad60-d896-46de-9988-d5098ee9e6fb", "João", "Cancelo", 65000000m, "Portugal", 3, "74c1fcab-b9d6-4b6f-aeef-6ece83923c32" },
                    { "f276537d-d472-4d5a-bade-77d182d5954e", "Rodri", "Hernandez", 70000000m, "Spain", 6, "4eb0819d-5550-4399-8752-edba2fc7ab42" },
                    { "f35ef5ee-ee6d-472c-b47c-7c9a3a623bf7", "Kylian", "Mbappé", 180000000m, "France", 14, "c23f5056-0bf2-4cbe-92b3-7dfdcc226ece" }
                });
        }
    }
}
