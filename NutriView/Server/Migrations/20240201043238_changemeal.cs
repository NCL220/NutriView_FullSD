using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NutriView.Server.Migrations
{
    /// <inheritdoc />
    public partial class changemeal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1507dbd1-1c83-4ad2-9b0e-4d298c7b4521",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2772c5f1-c89d-4e0a-88a6-36c747bd624d", "AQAAAAIAAYagAAAAEOXcYaXvMLhTZYjVV3vWxhAK/QtB/EYx0yPyp50mQR07SYQWcO3Sd2W3gauzNo6LRw==", "c4a2ccc8-c3c9-42ef-b869-f09096570ec3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41624b27-7496-447c-b299-4892483d6b47",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2043da99-45fa-41c4-b021-cb7ff0ee956a", "AQAAAAIAAYagAAAAEEyw0MPMsewud/4K3E9ln4Q6nM1tjMrDGiqXjI5wAqw3j7XpGPMz7JhBzZ0HOdRdng==", "40103bb9-479e-485b-b7d0-6060624ba9d5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d3dfcba-a0af-4b10-989d-d63dcfec5e97",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "04e99567-96af-4847-8030-39c640617495", "AQAAAAIAAYagAAAAEGf/uxPQR7mPd0OXo+6n98VEJwKBQ7hHvkfvOlMpwP+miBAbVIfumy0MktWP544ewA==", "bc67244a-9cc7-4e73-98d2-d88fc328b9b4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8aa738a7-6c07-4e5a-8a7f-5637388c41b4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "98becccc-cc05-4275-988d-49f663157bf9", "AQAAAAIAAYagAAAAEPwNzF6MB05gyYicJEhlEt8nxobSnziK/4ZCc+sx/2LpoiYrQ3IaxQYKI7hvCOs7Hw==", "5e895b34-7a47-46c4-ac51-cb87c9880450" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 12, 32, 38, 195, DateTimeKind.Local).AddTicks(1776), new DateTime(2024, 2, 1, 12, 32, 38, 195, DateTimeKind.Local).AddTicks(1777) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 12, 32, 38, 195, DateTimeKind.Local).AddTicks(1779), new DateTime(2024, 2, 1, 12, 32, 38, 195, DateTimeKind.Local).AddTicks(1779) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 12, 32, 38, 469, DateTimeKind.Local).AddTicks(384), new DateTime(2024, 2, 1, 12, 32, 38, 469, DateTimeKind.Local).AddTicks(397) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 12, 32, 38, 469, DateTimeKind.Local).AddTicks(401), new DateTime(2024, 2, 1, 12, 32, 38, 469, DateTimeKind.Local).AddTicks(401) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 2, 1, 12, 32, 38, 469, DateTimeKind.Local).AddTicks(1023), new DateTime(2024, 2, 1, 12, 32, 38, 469, DateTimeKind.Local).AddTicks(1024), new DateTime(2024, 2, 1, 12, 32, 38, 469, DateTimeKind.Local).AddTicks(1022) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 2, 1, 12, 32, 38, 469, DateTimeKind.Local).AddTicks(1027), new DateTime(2024, 2, 1, 12, 32, 38, 469, DateTimeKind.Local).AddTicks(1027), new DateTime(2024, 2, 1, 12, 32, 38, 469, DateTimeKind.Local).AddTicks(1026) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 12, 32, 38, 195, DateTimeKind.Local).AddTicks(2248), new DateTime(2024, 2, 1, 12, 32, 38, 195, DateTimeKind.Local).AddTicks(2249) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 12, 32, 38, 195, DateTimeKind.Local).AddTicks(2252), new DateTime(2024, 2, 1, 12, 32, 38, 195, DateTimeKind.Local).AddTicks(2252) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 4, 32, 38, 469, DateTimeKind.Utc).AddTicks(1747), new DateTime(2024, 2, 1, 4, 32, 38, 469, DateTimeKind.Utc).AddTicks(1748) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 4, 32, 38, 469, DateTimeKind.Utc).AddTicks(1751), new DateTime(2024, 2, 1, 4, 32, 38, 469, DateTimeKind.Utc).AddTicks(1751) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 12, 32, 38, 195, DateTimeKind.Local).AddTicks(2018), new DateTime(2024, 2, 1, 12, 32, 38, 195, DateTimeKind.Local).AddTicks(2018) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 12, 32, 38, 195, DateTimeKind.Local).AddTicks(2021), new DateTime(2024, 2, 1, 12, 32, 38, 195, DateTimeKind.Local).AddTicks(2021) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 12, 32, 38, 469, DateTimeKind.Local).AddTicks(2112), new DateTime(2024, 2, 1, 12, 32, 38, 469, DateTimeKind.Local).AddTicks(2115) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 12, 32, 38, 469, DateTimeKind.Local).AddTicks(2117), new DateTime(2024, 2, 1, 12, 32, 38, 469, DateTimeKind.Local).AddTicks(2118) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 12, 32, 38, 195, DateTimeKind.Local).AddTicks(2833), new DateTime(2024, 2, 1, 12, 32, 38, 195, DateTimeKind.Local).AddTicks(2835) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 12, 32, 38, 195, DateTimeKind.Local).AddTicks(2837), new DateTime(2024, 2, 1, 12, 32, 38, 195, DateTimeKind.Local).AddTicks(2837) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 12, 32, 38, 195, DateTimeKind.Local).AddTicks(1261), new DateTime(2024, 2, 1, 12, 32, 38, 195, DateTimeKind.Local).AddTicks(1270) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 12, 32, 38, 195, DateTimeKind.Local).AddTicks(1273), new DateTime(2024, 2, 1, 12, 32, 38, 195, DateTimeKind.Local).AddTicks(1273) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 12, 32, 38, 469, DateTimeKind.Local).AddTicks(743), new DateTime(2024, 2, 1, 12, 32, 38, 469, DateTimeKind.Local).AddTicks(742), new DateTime(2024, 2, 1, 12, 32, 38, 469, DateTimeKind.Local).AddTicks(739), new DateTime(2024, 2, 1, 12, 32, 38, 469, DateTimeKind.Local).AddTicks(743) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 12, 32, 38, 469, DateTimeKind.Local).AddTicks(746), new DateTime(2024, 2, 1, 12, 32, 38, 469, DateTimeKind.Local).AddTicks(746), new DateTime(2024, 2, 1, 12, 32, 38, 469, DateTimeKind.Local).AddTicks(745), new DateTime(2024, 2, 1, 12, 32, 38, 469, DateTimeKind.Local).AddTicks(747) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1507dbd1-1c83-4ad2-9b0e-4d298c7b4521",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ef79c4eb-f25a-4267-8652-e54ccc369f81", "AQAAAAIAAYagAAAAEKqXLJNd4O6/glGRPN4j1lMCmraVVPuaf2FMaF7bNKFZyPaUjztZS023aInGFYegww==", "eec68b65-0dfb-46f6-ab75-b7715f9b48c0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41624b27-7496-447c-b299-4892483d6b47",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1a62a5b1-9a02-484f-98c9-05919b6fa495", "AQAAAAIAAYagAAAAEB1rXQ0s5WqCXLB7E3CIf9CZ/7spUV2ka5Oxj2qNPgj3X0fGKMbjKCe3EMKhpIv0ig==", "1a526a09-0a6c-42de-bcc3-e1c63b0007de" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d3dfcba-a0af-4b10-989d-d63dcfec5e97",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6763546e-18f7-479e-b59d-163e6f1a7056", "AQAAAAIAAYagAAAAEHoM1c3SRkCL5MiEd8Cb1SDfS0r9vE9jItrDGbIyLOFOmEPdXhFzoFmLii1w4DMDxA==", "5fa8d42b-eb33-4c79-b734-6184e57543b5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8aa738a7-6c07-4e5a-8a7f-5637388c41b4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa6aba72-8876-4b38-8cef-82b4c88c6e87", "AQAAAAIAAYagAAAAEE7hbVfiSMyshdwvmvyFblKr1po3fHsrpk3H1h1xTi6LIabYZOECbwiw8igpANwFpg==", "ac37316e-6d80-49ed-aebc-183e7baade1c" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 46, 18, 76, DateTimeKind.Local).AddTicks(9979), new DateTime(2024, 2, 1, 11, 46, 18, 76, DateTimeKind.Local).AddTicks(9980) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 46, 18, 76, DateTimeKind.Local).AddTicks(9982), new DateTime(2024, 2, 1, 11, 46, 18, 76, DateTimeKind.Local).AddTicks(9982) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 46, 18, 348, DateTimeKind.Local).AddTicks(9298), new DateTime(2024, 2, 1, 11, 46, 18, 348, DateTimeKind.Local).AddTicks(9315) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 46, 18, 348, DateTimeKind.Local).AddTicks(9318), new DateTime(2024, 2, 1, 11, 46, 18, 348, DateTimeKind.Local).AddTicks(9319) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 46, 18, 348, DateTimeKind.Local).AddTicks(9829), new DateTime(2024, 2, 1, 11, 46, 18, 348, DateTimeKind.Local).AddTicks(9830), new DateTime(2024, 2, 1, 11, 46, 18, 348, DateTimeKind.Local).AddTicks(9828) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 46, 18, 348, DateTimeKind.Local).AddTicks(9832), new DateTime(2024, 2, 1, 11, 46, 18, 348, DateTimeKind.Local).AddTicks(9833), new DateTime(2024, 2, 1, 11, 46, 18, 348, DateTimeKind.Local).AddTicks(9832) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 46, 18, 77, DateTimeKind.Local).AddTicks(388), new DateTime(2024, 2, 1, 11, 46, 18, 77, DateTimeKind.Local).AddTicks(389) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 46, 18, 77, DateTimeKind.Local).AddTicks(392), new DateTime(2024, 2, 1, 11, 46, 18, 77, DateTimeKind.Local).AddTicks(392) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 46, 18, 349, DateTimeKind.Utc).AddTicks(157), new DateTime(2024, 2, 1, 3, 46, 18, 349, DateTimeKind.Utc).AddTicks(158) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 46, 18, 349, DateTimeKind.Utc).AddTicks(160), new DateTime(2024, 2, 1, 3, 46, 18, 349, DateTimeKind.Utc).AddTicks(160) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 46, 18, 77, DateTimeKind.Local).AddTicks(190), new DateTime(2024, 2, 1, 11, 46, 18, 77, DateTimeKind.Local).AddTicks(191) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 46, 18, 77, DateTimeKind.Local).AddTicks(193), new DateTime(2024, 2, 1, 11, 46, 18, 77, DateTimeKind.Local).AddTicks(194) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 46, 18, 349, DateTimeKind.Local).AddTicks(453), new DateTime(2024, 2, 1, 11, 46, 18, 349, DateTimeKind.Local).AddTicks(455) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 46, 18, 349, DateTimeKind.Local).AddTicks(457), new DateTime(2024, 2, 1, 11, 46, 18, 349, DateTimeKind.Local).AddTicks(458) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 46, 18, 77, DateTimeKind.Local).AddTicks(922), new DateTime(2024, 2, 1, 11, 46, 18, 77, DateTimeKind.Local).AddTicks(924) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 46, 18, 77, DateTimeKind.Local).AddTicks(926), new DateTime(2024, 2, 1, 11, 46, 18, 77, DateTimeKind.Local).AddTicks(927) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 46, 18, 76, DateTimeKind.Local).AddTicks(9392), new DateTime(2024, 2, 1, 11, 46, 18, 76, DateTimeKind.Local).AddTicks(9401) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 46, 18, 76, DateTimeKind.Local).AddTicks(9404), new DateTime(2024, 2, 1, 11, 46, 18, 76, DateTimeKind.Local).AddTicks(9405) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 46, 18, 348, DateTimeKind.Local).AddTicks(9593), new DateTime(2024, 2, 1, 11, 46, 18, 348, DateTimeKind.Local).AddTicks(9592), new DateTime(2024, 2, 1, 11, 46, 18, 348, DateTimeKind.Local).AddTicks(9590), new DateTime(2024, 2, 1, 11, 46, 18, 348, DateTimeKind.Local).AddTicks(9593) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 46, 18, 348, DateTimeKind.Local).AddTicks(9596), new DateTime(2024, 2, 1, 11, 46, 18, 348, DateTimeKind.Local).AddTicks(9596), new DateTime(2024, 2, 1, 11, 46, 18, 348, DateTimeKind.Local).AddTicks(9595), new DateTime(2024, 2, 1, 11, 46, 18, 348, DateTimeKind.Local).AddTicks(9596) });
        }
    }
}
