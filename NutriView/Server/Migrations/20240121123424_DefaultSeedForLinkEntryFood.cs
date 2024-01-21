using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NutriView.Server.Migrations
{
    /// <inheritdoc />
    public partial class DefaultSeedForLinkEntryFood : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1507dbd1-1c83-4ad2-9b0e-4d298c7b4521",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "13915a1e-5879-4b27-90a9-73589ef15c34", "AQAAAAIAAYagAAAAELNFqVEpYBiSL8W+7E3FXt3+fMcyfEw3r2DWNrUKUrJvjU9AsSCAsbvEtIWsQPqp/A==", "f4765405-0b67-40b0-ba18-57d861bae181" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41624b27-7496-447c-b299-4892483d6b47",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5863d42-9568-4e3a-b693-ab1b478a42ce", "AQAAAAIAAYagAAAAECqsPphiAcMKdXSxMYpR2AF7VZzUEJyCvv0GHa/iiPVfVegzFBuBcb5Atk3BPPFd6g==", "b76aa051-6ab6-410d-b761-e3f5ec61cac8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d3dfcba-a0af-4b10-989d-d63dcfec5e97",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ef9a919-eea9-4f30-ac49-12a7feede3e8", "AQAAAAIAAYagAAAAED2GHA0II53Vm7XctJOxsziajeU4VU8cYxILD4q24zKVx9YY6Rod3kS75wapE7K4Ww==", "8ca8cbb0-b0b6-454c-9ba7-65b88076ed9c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8aa738a7-6c07-4e5a-8a7f-5637388c41b4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "345eb58e-2f87-4cfa-8195-85b8d98489de", "AQAAAAIAAYagAAAAEA6mH1n81xK0PkGzq85RnDVuONOEWot5AM8cSLmb+4P9wgdD3DhUVmfkNzBQmBqLdg==", "d45ba109-f62e-4a06-afb9-41dfab6835c5" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 34, 24, 34, DateTimeKind.Local).AddTicks(4921), new DateTime(2024, 1, 21, 20, 34, 24, 34, DateTimeKind.Local).AddTicks(4922) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 34, 24, 34, DateTimeKind.Local).AddTicks(4924), new DateTime(2024, 1, 21, 20, 34, 24, 34, DateTimeKind.Local).AddTicks(4924) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 34, 24, 225, DateTimeKind.Local).AddTicks(4755), new DateTime(2024, 1, 21, 20, 34, 24, 225, DateTimeKind.Local).AddTicks(4768) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 34, 24, 225, DateTimeKind.Local).AddTicks(4772), new DateTime(2024, 1, 21, 20, 34, 24, 225, DateTimeKind.Local).AddTicks(4773) });

            migrationBuilder.InsertData(
                table: "EntryLinkFoods",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "FoodEntryID", "FoodID", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, null },
                    { 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, null }
                });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 34, 24, 225, DateTimeKind.Local).AddTicks(5221), new DateTime(2024, 1, 21, 20, 34, 24, 225, DateTimeKind.Local).AddTicks(5221), new DateTime(2024, 1, 21, 20, 34, 24, 225, DateTimeKind.Local).AddTicks(5219) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 34, 24, 225, DateTimeKind.Local).AddTicks(5224), new DateTime(2024, 1, 21, 20, 34, 24, 225, DateTimeKind.Local).AddTicks(5224), new DateTime(2024, 1, 21, 20, 34, 24, 225, DateTimeKind.Local).AddTicks(5224) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 34, 24, 34, DateTimeKind.Local).AddTicks(5233), new DateTime(2024, 1, 21, 20, 34, 24, 34, DateTimeKind.Local).AddTicks(5233) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 34, 24, 34, DateTimeKind.Local).AddTicks(5235), new DateTime(2024, 1, 21, 20, 34, 24, 34, DateTimeKind.Local).AddTicks(5236) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 12, 34, 24, 225, DateTimeKind.Utc).AddTicks(5579), new DateTime(2024, 1, 21, 12, 34, 24, 225, DateTimeKind.Utc).AddTicks(5580) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 12, 34, 24, 225, DateTimeKind.Utc).AddTicks(5584), new DateTime(2024, 1, 21, 12, 34, 24, 225, DateTimeKind.Utc).AddTicks(5584) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 34, 24, 34, DateTimeKind.Local).AddTicks(5077), new DateTime(2024, 1, 21, 20, 34, 24, 34, DateTimeKind.Local).AddTicks(5078) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 34, 24, 34, DateTimeKind.Local).AddTicks(5080), new DateTime(2024, 1, 21, 20, 34, 24, 34, DateTimeKind.Local).AddTicks(5080) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 34, 24, 225, DateTimeKind.Local).AddTicks(5824), new DateTime(2024, 1, 21, 20, 34, 24, 225, DateTimeKind.Local).AddTicks(5825) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 34, 24, 225, DateTimeKind.Local).AddTicks(5827), new DateTime(2024, 1, 21, 20, 34, 24, 225, DateTimeKind.Local).AddTicks(5827) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 34, 24, 34, DateTimeKind.Local).AddTicks(5613), new DateTime(2024, 1, 21, 20, 34, 24, 34, DateTimeKind.Local).AddTicks(5614) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 34, 24, 34, DateTimeKind.Local).AddTicks(5616), new DateTime(2024, 1, 21, 20, 34, 24, 34, DateTimeKind.Local).AddTicks(5616) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 34, 24, 34, DateTimeKind.Local).AddTicks(4740), new DateTime(2024, 1, 21, 20, 34, 24, 34, DateTimeKind.Local).AddTicks(4750) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 34, 24, 34, DateTimeKind.Local).AddTicks(4753), new DateTime(2024, 1, 21, 20, 34, 24, 34, DateTimeKind.Local).AddTicks(4754) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 34, 24, 225, DateTimeKind.Local).AddTicks(5022), new DateTime(2024, 1, 21, 20, 34, 24, 225, DateTimeKind.Local).AddTicks(5021), new DateTime(2024, 1, 21, 20, 34, 24, 225, DateTimeKind.Local).AddTicks(5020), new DateTime(2024, 1, 21, 20, 34, 24, 225, DateTimeKind.Local).AddTicks(5023) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 34, 24, 225, DateTimeKind.Local).AddTicks(5026), new DateTime(2024, 1, 21, 20, 34, 24, 225, DateTimeKind.Local).AddTicks(5025), new DateTime(2024, 1, 21, 20, 34, 24, 225, DateTimeKind.Local).AddTicks(5025), new DateTime(2024, 1, 21, 20, 34, 24, 225, DateTimeKind.Local).AddTicks(5026) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EntryLinkFoods",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EntryLinkFoods",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1507dbd1-1c83-4ad2-9b0e-4d298c7b4521",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "73edf72c-054b-43b0-bfc2-5e05322c7824", "AQAAAAIAAYagAAAAENdKB1C9J9fbfIvpkxRzVOXqnV2NJ9XjcofPeFWLycg/mhT9F9y+h8WAd4deN8vVCg==", "3bbd1f44-6af8-433d-a964-1bd8ce9a7656" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41624b27-7496-447c-b299-4892483d6b47",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "754ff025-1fd6-413d-87c1-417022fbc6a2", "AQAAAAIAAYagAAAAEHMZfn6vxWlicrDMhYYAhhmXWu0luttl4Veuvi7pb1XYzP2ppyR/dU7nZTqf6dkZCQ==", "e3342960-ea55-4ad0-860a-e00e6c3e9661" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d3dfcba-a0af-4b10-989d-d63dcfec5e97",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aeec5155-826a-4178-836d-d753fe5a00c3", "AQAAAAIAAYagAAAAEHZksxjCM0DyHuNfFfmc9+1nDWDVyk17zmJLbBbOUO6iuiXbngHaObkZMCz9IlCJAw==", "5f8f3d27-d2c3-47f3-a383-4002b0e155fe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8aa738a7-6c07-4e5a-8a7f-5637388c41b4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b96263bd-a023-42fa-81a4-21cee19aa8af", "AQAAAAIAAYagAAAAEHiMQTh0d3Nt3563p9XbOLV6pygx1ABRxMBGr0ZeICd2Nj1ItxrUJLjF99KcZiv25w==", "acba25c8-69a6-4064-8cf9-635c76c23d60" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 25, 2, 710, DateTimeKind.Local).AddTicks(1321), new DateTime(2024, 1, 21, 20, 25, 2, 710, DateTimeKind.Local).AddTicks(1322) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 25, 2, 710, DateTimeKind.Local).AddTicks(1324), new DateTime(2024, 1, 21, 20, 25, 2, 710, DateTimeKind.Local).AddTicks(1324) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 25, 2, 900, DateTimeKind.Local).AddTicks(8581), new DateTime(2024, 1, 21, 20, 25, 2, 900, DateTimeKind.Local).AddTicks(8594) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 25, 2, 900, DateTimeKind.Local).AddTicks(8598), new DateTime(2024, 1, 21, 20, 25, 2, 900, DateTimeKind.Local).AddTicks(8599) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 25, 2, 900, DateTimeKind.Local).AddTicks(9037), new DateTime(2024, 1, 21, 20, 25, 2, 900, DateTimeKind.Local).AddTicks(9037), new DateTime(2024, 1, 21, 20, 25, 2, 900, DateTimeKind.Local).AddTicks(9036) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 25, 2, 900, DateTimeKind.Local).AddTicks(9039), new DateTime(2024, 1, 21, 20, 25, 2, 900, DateTimeKind.Local).AddTicks(9040), new DateTime(2024, 1, 21, 20, 25, 2, 900, DateTimeKind.Local).AddTicks(9039) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 25, 2, 710, DateTimeKind.Local).AddTicks(1654), new DateTime(2024, 1, 21, 20, 25, 2, 710, DateTimeKind.Local).AddTicks(1654) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 25, 2, 710, DateTimeKind.Local).AddTicks(1656), new DateTime(2024, 1, 21, 20, 25, 2, 710, DateTimeKind.Local).AddTicks(1657) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 12, 25, 2, 900, DateTimeKind.Utc).AddTicks(9436), new DateTime(2024, 1, 21, 12, 25, 2, 900, DateTimeKind.Utc).AddTicks(9437) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 12, 25, 2, 900, DateTimeKind.Utc).AddTicks(9439), new DateTime(2024, 1, 21, 12, 25, 2, 900, DateTimeKind.Utc).AddTicks(9440) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 25, 2, 710, DateTimeKind.Local).AddTicks(1488), new DateTime(2024, 1, 21, 20, 25, 2, 710, DateTimeKind.Local).AddTicks(1489) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 25, 2, 710, DateTimeKind.Local).AddTicks(1491), new DateTime(2024, 1, 21, 20, 25, 2, 710, DateTimeKind.Local).AddTicks(1491) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 25, 2, 900, DateTimeKind.Local).AddTicks(9722), new DateTime(2024, 1, 21, 20, 25, 2, 900, DateTimeKind.Local).AddTicks(9722) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 25, 2, 900, DateTimeKind.Local).AddTicks(9724), new DateTime(2024, 1, 21, 20, 25, 2, 900, DateTimeKind.Local).AddTicks(9725) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 25, 2, 710, DateTimeKind.Local).AddTicks(1999), new DateTime(2024, 1, 21, 20, 25, 2, 710, DateTimeKind.Local).AddTicks(1999) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 25, 2, 710, DateTimeKind.Local).AddTicks(2001), new DateTime(2024, 1, 21, 20, 25, 2, 710, DateTimeKind.Local).AddTicks(2002) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 25, 2, 710, DateTimeKind.Local).AddTicks(1015), new DateTime(2024, 1, 21, 20, 25, 2, 710, DateTimeKind.Local).AddTicks(1024) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 25, 2, 710, DateTimeKind.Local).AddTicks(1027), new DateTime(2024, 1, 21, 20, 25, 2, 710, DateTimeKind.Local).AddTicks(1027) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 25, 2, 900, DateTimeKind.Local).AddTicks(8826), new DateTime(2024, 1, 21, 20, 25, 2, 900, DateTimeKind.Local).AddTicks(8825), new DateTime(2024, 1, 21, 20, 25, 2, 900, DateTimeKind.Local).AddTicks(8824), new DateTime(2024, 1, 21, 20, 25, 2, 900, DateTimeKind.Local).AddTicks(8826) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 25, 2, 900, DateTimeKind.Local).AddTicks(8828), new DateTime(2024, 1, 21, 20, 25, 2, 900, DateTimeKind.Local).AddTicks(8828), new DateTime(2024, 1, 21, 20, 25, 2, 900, DateTimeKind.Local).AddTicks(8828), new DateTime(2024, 1, 21, 20, 25, 2, 900, DateTimeKind.Local).AddTicks(8829) });
        }
    }
}
