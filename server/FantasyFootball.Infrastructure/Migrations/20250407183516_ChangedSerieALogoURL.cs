using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FantasyFootball.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ChangedSerieALogoURL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Leagues",
                keyColumn: "Id",
                keyValue: "4d4f4f00-dddd-dddd-dddd-444444444444",
                column: "LogoUrl",
                value: "https://logolook.net/wp-content/uploads/2023/11/Italian-Serie-A-Logo.png");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                keyValue: "4d4f4f00-dddd-dddd-dddd-444444444444",
                column: "LogoUrl",
                value: "https://upload.wikimedia.org/wikipedia/en/e/e1/Serie_A_logo_%282019%29.svg");

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
        }
    }
}
