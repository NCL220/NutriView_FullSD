using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NutriView.Server.Migrations
{
    /// <inheritdoc />
    public partial class changeAll : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1507dbd1-1c83-4ad2-9b0e-4d298c7b4521",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9bafc4ff-63f1-4c45-b15c-2dc4193fd4e6", "AQAAAAIAAYagAAAAENuMYw6Ko6qhjPbrU6D/fxFQbpdT6xIjwH7CmxqSVECK1DOXIhNIalUSblaJ85tmWA==", "d26bad31-1378-4959-ad63-9bd25ce13cba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41624b27-7496-447c-b299-4892483d6b47",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dcf50210-ce9b-4f04-8c76-bc0e3de7e807", "AQAAAAIAAYagAAAAEGeiAjTGGvxqA1qt1tTMk7tlf2HBleFNwBxbwENYwOrODtPMIzpXlFow5SzyZns8pQ==", "b6f98d03-c840-4d54-a4dc-bf23c82211d4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d3dfcba-a0af-4b10-989d-d63dcfec5e97",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "173be61d-073a-4204-91b5-b09760b28fc8", "AQAAAAIAAYagAAAAED6AymG6SQhprlFiY0UuqQDxI59X5zfa6IGYPxvUJ36nvmNBnXkJt5eQxTuv80JNCw==", "3303e168-a0d2-4cdb-a002-7670cec18f00" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8aa738a7-6c07-4e5a-8a7f-5637388c41b4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff451e04-aa39-4724-93f6-5fa86f727cae", "AQAAAAIAAYagAAAAEMObfcbHnxJU45l4vvN2/bez8/OX27ao3YeOJCtbS/rao9J419gy8WTJIjvjrFBe9g==", "bd22405a-8fe0-44f1-8880-ee791c2879fa" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 12, 35, 3, 568, DateTimeKind.Local).AddTicks(4641), new DateTime(2024, 2, 1, 12, 35, 3, 568, DateTimeKind.Local).AddTicks(4642) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 12, 35, 3, 568, DateTimeKind.Local).AddTicks(4644), new DateTime(2024, 2, 1, 12, 35, 3, 568, DateTimeKind.Local).AddTicks(4644) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 12, 35, 3, 832, DateTimeKind.Local).AddTicks(6314), new DateTime(2024, 2, 1, 12, 35, 3, 832, DateTimeKind.Local).AddTicks(6327) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 12, 35, 3, 832, DateTimeKind.Local).AddTicks(6332), new DateTime(2024, 2, 1, 12, 35, 3, 832, DateTimeKind.Local).AddTicks(6332) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 2, 1, 12, 35, 3, 832, DateTimeKind.Local).AddTicks(6867), new DateTime(2024, 2, 1, 12, 35, 3, 832, DateTimeKind.Local).AddTicks(6868), new DateTime(2024, 2, 1, 12, 35, 3, 832, DateTimeKind.Local).AddTicks(6866) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 2, 1, 12, 35, 3, 832, DateTimeKind.Local).AddTicks(6870), new DateTime(2024, 2, 1, 12, 35, 3, 832, DateTimeKind.Local).AddTicks(6871), new DateTime(2024, 2, 1, 12, 35, 3, 832, DateTimeKind.Local).AddTicks(6870) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 12, 35, 3, 568, DateTimeKind.Local).AddTicks(5088), new DateTime(2024, 2, 1, 12, 35, 3, 568, DateTimeKind.Local).AddTicks(5088) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 12, 35, 3, 568, DateTimeKind.Local).AddTicks(5091), new DateTime(2024, 2, 1, 12, 35, 3, 568, DateTimeKind.Local).AddTicks(5091) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 4, 35, 3, 832, DateTimeKind.Utc).AddTicks(7192), new DateTime(2024, 2, 1, 4, 35, 3, 832, DateTimeKind.Utc).AddTicks(7193) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 4, 35, 3, 832, DateTimeKind.Utc).AddTicks(7195), new DateTime(2024, 2, 1, 4, 35, 3, 832, DateTimeKind.Utc).AddTicks(7195) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 12, 35, 3, 568, DateTimeKind.Local).AddTicks(4882), new DateTime(2024, 2, 1, 12, 35, 3, 568, DateTimeKind.Local).AddTicks(4882) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 12, 35, 3, 568, DateTimeKind.Local).AddTicks(4884), new DateTime(2024, 2, 1, 12, 35, 3, 568, DateTimeKind.Local).AddTicks(4884) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 12, 35, 3, 832, DateTimeKind.Local).AddTicks(7476), new DateTime(2024, 2, 1, 12, 35, 3, 832, DateTimeKind.Local).AddTicks(7478) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 12, 35, 3, 832, DateTimeKind.Local).AddTicks(7480), new DateTime(2024, 2, 1, 12, 35, 3, 832, DateTimeKind.Local).AddTicks(7480) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 12, 35, 3, 568, DateTimeKind.Local).AddTicks(5606), new DateTime(2024, 2, 1, 12, 35, 3, 568, DateTimeKind.Local).AddTicks(5607) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 12, 35, 3, 568, DateTimeKind.Local).AddTicks(5610), new DateTime(2024, 2, 1, 12, 35, 3, 568, DateTimeKind.Local).AddTicks(5611) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 12, 35, 3, 568, DateTimeKind.Local).AddTicks(4097), new DateTime(2024, 2, 1, 12, 35, 3, 568, DateTimeKind.Local).AddTicks(4107) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 12, 35, 3, 568, DateTimeKind.Local).AddTicks(4111), new DateTime(2024, 2, 1, 12, 35, 3, 568, DateTimeKind.Local).AddTicks(4111) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 12, 35, 3, 832, DateTimeKind.Local).AddTicks(6631), new DateTime(2024, 2, 1, 12, 35, 3, 832, DateTimeKind.Local).AddTicks(6630), new DateTime(2024, 2, 1, 12, 35, 3, 832, DateTimeKind.Local).AddTicks(6628), new DateTime(2024, 2, 1, 12, 35, 3, 832, DateTimeKind.Local).AddTicks(6632) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 12, 35, 3, 832, DateTimeKind.Local).AddTicks(6635), new DateTime(2024, 2, 1, 12, 35, 3, 832, DateTimeKind.Local).AddTicks(6634), new DateTime(2024, 2, 1, 12, 35, 3, 832, DateTimeKind.Local).AddTicks(6634), new DateTime(2024, 2, 1, 12, 35, 3, 832, DateTimeKind.Local).AddTicks(6635) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
