using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FantasyFootball.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedProfilePictureColumnToUserEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: "0523716d-1865-48fc-baec-c0e2d58b6a28");

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: "430e4d22-54f2-467f-94fc-3f86b10cb59a");

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: "6854c044-2a99-4f11-b763-062f7d21ad40");

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: "75a360e5-c538-4dfc-990d-83ff36e58835");

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: "89013681-70eb-4ac2-9828-17168a376938");

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: "9581752a-923c-4c40-a8bf-486ace0ae902");

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: "aea51c06-9d20-433e-a4e9-62977bbf6031");

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: "b048489d-d345-45a9-bd31-d39456778476");

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: "c60570c8-2ca2-4496-92de-25f577532328");

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: "c7bc52c2-a3dd-4009-9860-3d00931ea214");

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: "c850cc9a-2f54-44ae-be70-11b1fa5bb7bf");

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: "d411821b-2983-4110-85fc-d792d4f07415");

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: "d42be330-4f9e-4a84-bbee-9f0a865ed2a2");

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: "e37e6194-b1bc-4649-a9f7-5c8a803772da");

            migrationBuilder.AddColumn<string>(
                name: "ProfilePicture",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "ProfilePicture",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "FirstName", "LastName", "MarketValue", "Nationality", "Position", "TeamId" },
                values: new object[,]
                {
                    { "0523716d-1865-48fc-baec-c0e2d58b6a28", "Virgil", "van Dijk", 70000000m, "Netherlands", 1, "b3241106-0d85-4c91-aaa9-5c1a37dc2553" },
                    { "430e4d22-54f2-467f-94fc-3f86b10cb59a", "João", "Cancelo", 65000000m, "Portugal", 3, "74c1fcab-b9d6-4b6f-aeef-6ece83923c32" },
                    { "6854c044-2a99-4f11-b763-062f7d21ad40", "Rúben", "Dias", 75000000m, "Portugal", 1, "4eb0819d-5550-4399-8752-edba2fc7ab42" },
                    { "75a360e5-c538-4dfc-990d-83ff36e58835", "Kevin", "De Bruyne", 80000000m, "Belgium", 8, "4eb0819d-5550-4399-8752-edba2fc7ab42" },
                    { "89013681-70eb-4ac2-9828-17168a376938", "Federico", "Valverde", 85000000m, "Uruguay", 10, "506eb3fc-7511-4af8-86de-11b55623deca" },
                    { "9581752a-923c-4c40-a8bf-486ace0ae902", "Alisson", "Becker", 60000000m, "Brazil", 0, "b3241106-0d85-4c91-aaa9-5c1a37dc2553" },
                    { "aea51c06-9d20-433e-a4e9-62977bbf6031", "Kylian", "Mbappé", 180000000m, "France", 14, "c23f5056-0bf2-4cbe-92b3-7dfdcc226ece" },
                    { "b048489d-d345-45a9-bd31-d39456778476", "Erling", "Haaland", 200000000m, "Norway", 11, "4eb0819d-5550-4399-8752-edba2fc7ab42" },
                    { "c60570c8-2ca2-4496-92de-25f577532328", "Theo", "Hernández", 60000000m, "France", 2, "1811b66c-462b-46a9-9c4a-344d310c329e" },
                    { "c7bc52c2-a3dd-4009-9860-3d00931ea214", "Lionel", "Messi", 40000000m, "Argentina", 15, "aefd72fb-edfe-4239-bdec-21fea1ad49cb" },
                    { "c850cc9a-2f54-44ae-be70-11b1fa5bb7bf", "Luka", "Modrić", 20000000m, "Croatia", 7, "506eb3fc-7511-4af8-86de-11b55623deca" },
                    { "d411821b-2983-4110-85fc-d792d4f07415", "Rodri", "Hernandez", 70000000m, "Spain", 6, "4eb0819d-5550-4399-8752-edba2fc7ab42" },
                    { "d42be330-4f9e-4a84-bbee-9f0a865ed2a2", "Thibaut", "Courtois", 55000000m, "Belgium", 0, "506eb3fc-7511-4af8-86de-11b55623deca" },
                    { "e37e6194-b1bc-4649-a9f7-5c8a803772da", "Harry", "Kane", 100000000m, "England", 12, "0b9e12ef-bc06-4ba8-a660-fcd52285258c" }
                });
        }
    }
}
