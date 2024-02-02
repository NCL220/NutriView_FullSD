using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NutriView.Server.Migrations
{
    /// <inheritdoc />
    public partial class change : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1507dbd1-1c83-4ad2-9b0e-4d298c7b4521",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb4de6b3-3ccc-4ff0-9caf-9741638a4fca", "AQAAAAIAAYagAAAAEPi7pTtNZum6uCxYDg2jzupkijv0BWUmZmk8IhkbpnzeZOYIMFDoywXLGmXy6xi9zw==", "8f89a9cc-65a0-40f7-961d-45f808c89b21" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41624b27-7496-447c-b299-4892483d6b47",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad72ce55-689b-43ec-a033-80f26f5186de", "AQAAAAIAAYagAAAAEAXy4dflu0K3qjxXy/axDPwMIC8Gu8irHdd3nGX4xndrzMEbp6BHsfKVfqQFifkk3g==", "d222d80b-fc4c-48b8-ac73-3700f7bdc8eb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d3dfcba-a0af-4b10-989d-d63dcfec5e97",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b74d8b5-f1d9-44c0-86bb-98e466a479ea", "AQAAAAIAAYagAAAAEBSw/CuVQsD9lHpy8uqNTXOCuD6V/ZJl+7QYWMtGI9QeHrY3agWwJdDlH2lTjoUFvA==", "805668c9-058d-47ec-a14b-b6d307c51ac4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8aa738a7-6c07-4e5a-8a7f-5637388c41b4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a3072a75-80ad-4fed-9abf-ac39b844fcd0", "AQAAAAIAAYagAAAAEJd1saYKdD1RFE4DwpbF5gCPvuR7cTdEPHvG5QC9zYs/O9F8E3te0xRhm6YJ9g+BAA==", "daccb8f9-0513-425c-aa00-099d75bba382" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 20, 21, 44, 362, DateTimeKind.Local).AddTicks(5042), new DateTime(2024, 2, 2, 20, 21, 44, 362, DateTimeKind.Local).AddTicks(5043) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 20, 21, 44, 362, DateTimeKind.Local).AddTicks(5045), new DateTime(2024, 2, 2, 20, 21, 44, 362, DateTimeKind.Local).AddTicks(5045) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 20, 21, 44, 650, DateTimeKind.Local).AddTicks(1667), new DateTime(2024, 2, 2, 20, 21, 44, 650, DateTimeKind.Local).AddTicks(1681) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 20, 21, 44, 650, DateTimeKind.Local).AddTicks(1685), new DateTime(2024, 2, 2, 20, 21, 44, 650, DateTimeKind.Local).AddTicks(1686) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 20, 21, 44, 650, DateTimeKind.Local).AddTicks(1688), new DateTime(2024, 2, 2, 20, 21, 44, 650, DateTimeKind.Local).AddTicks(1689) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 2, 2, 20, 21, 44, 650, DateTimeKind.Local).AddTicks(2297), new DateTime(2024, 2, 2, 20, 21, 44, 650, DateTimeKind.Local).AddTicks(2298), new DateTime(2024, 2, 2, 20, 21, 44, 650, DateTimeKind.Local).AddTicks(2296) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 2, 2, 20, 21, 44, 650, DateTimeKind.Local).AddTicks(2300), new DateTime(2024, 2, 2, 20, 21, 44, 650, DateTimeKind.Local).AddTicks(2300), new DateTime(2024, 2, 2, 20, 21, 44, 650, DateTimeKind.Local).AddTicks(2299) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 20, 21, 44, 362, DateTimeKind.Local).AddTicks(5463), new DateTime(2024, 2, 2, 20, 21, 44, 362, DateTimeKind.Local).AddTicks(5464) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 20, 21, 44, 362, DateTimeKind.Local).AddTicks(5468), new DateTime(2024, 2, 2, 20, 21, 44, 362, DateTimeKind.Local).AddTicks(5468) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 12, 21, 44, 650, DateTimeKind.Utc).AddTicks(2703), new DateTime(2024, 2, 2, 12, 21, 44, 650, DateTimeKind.Utc).AddTicks(2704) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 12, 21, 44, 650, DateTimeKind.Utc).AddTicks(2706), new DateTime(2024, 2, 2, 12, 21, 44, 650, DateTimeKind.Utc).AddTicks(2706) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 20, 21, 44, 362, DateTimeKind.Local).AddTicks(5260), new DateTime(2024, 2, 2, 20, 21, 44, 362, DateTimeKind.Local).AddTicks(5261) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 20, 21, 44, 362, DateTimeKind.Local).AddTicks(5263), new DateTime(2024, 2, 2, 20, 21, 44, 362, DateTimeKind.Local).AddTicks(5263) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 20, 21, 44, 650, DateTimeKind.Local).AddTicks(3009), new DateTime(2024, 2, 2, 20, 21, 44, 650, DateTimeKind.Local).AddTicks(3015) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 20, 21, 44, 362, DateTimeKind.Local).AddTicks(6049), new DateTime(2024, 2, 2, 20, 21, 44, 362, DateTimeKind.Local).AddTicks(6050) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 20, 21, 44, 362, DateTimeKind.Local).AddTicks(6052), new DateTime(2024, 2, 2, 20, 21, 44, 362, DateTimeKind.Local).AddTicks(6053) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 20, 21, 44, 362, DateTimeKind.Local).AddTicks(4509), new DateTime(2024, 2, 2, 20, 21, 44, 362, DateTimeKind.Local).AddTicks(4517) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 20, 21, 44, 362, DateTimeKind.Local).AddTicks(4520), new DateTime(2024, 2, 2, 20, 21, 44, 362, DateTimeKind.Local).AddTicks(4520) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 20, 21, 44, 362, DateTimeKind.Local).AddTicks(4522), new DateTime(2024, 2, 2, 20, 21, 44, 362, DateTimeKind.Local).AddTicks(4523) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 20, 21, 44, 650, DateTimeKind.Local).AddTicks(2029), new DateTime(2024, 2, 2, 20, 21, 44, 650, DateTimeKind.Local).AddTicks(2029), new DateTime(2024, 2, 2, 20, 21, 44, 650, DateTimeKind.Local).AddTicks(2028), new DateTime(2024, 2, 2, 20, 21, 44, 650, DateTimeKind.Local).AddTicks(2029) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 20, 21, 44, 650, DateTimeKind.Local).AddTicks(2032), new DateTime(2024, 2, 2, 20, 21, 44, 650, DateTimeKind.Local).AddTicks(2032), new DateTime(2024, 2, 2, 20, 21, 44, 650, DateTimeKind.Local).AddTicks(2031), new DateTime(2024, 2, 2, 20, 21, 44, 650, DateTimeKind.Local).AddTicks(2033) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 20, 21, 44, 650, DateTimeKind.Local).AddTicks(2035), new DateTime(2024, 2, 2, 20, 21, 44, 650, DateTimeKind.Local).AddTicks(2034), new DateTime(2024, 2, 2, 20, 21, 44, 650, DateTimeKind.Local).AddTicks(2034), new DateTime(2024, 2, 2, 20, 21, 44, 650, DateTimeKind.Local).AddTicks(2035) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1507dbd1-1c83-4ad2-9b0e-4d298c7b4521",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f1620968-12dc-470b-9d49-86c4dec07f02", "AQAAAAIAAYagAAAAEFVsc4egl3PXQx4vpPMV+LGWXysYP2mpct2qNJez74+lCabS8CrseF3IZLrQN7vcxw==", "45aa4dd0-d88b-4fc8-822d-4757bc2bb98f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41624b27-7496-447c-b299-4892483d6b47",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "762cf705-a33d-4306-8162-d4edb92d6e21", "AQAAAAIAAYagAAAAEFFPH2ZWXaj1ECp9NHEpf09u8px4HUg/CbnjLwzlpMw01e4UyUka++bTiokc8Tqqdw==", "ad3a42c6-a9b0-4b4f-b003-a656f7e02caa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d3dfcba-a0af-4b10-989d-d63dcfec5e97",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dcb501f0-9ba8-49ca-b759-37ed23e5f189", "AQAAAAIAAYagAAAAEOPcotK94Dv6tfb5lwvjJTrXG3mcwieMvvbJLOmMekWBWz4E4xUyl7XBVWPun4lVaA==", "0ea34c99-9e8a-4667-be41-1629477c0f78" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8aa738a7-6c07-4e5a-8a7f-5637388c41b4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "53ee04ce-fe09-4ec5-976c-e33da7aeff44", "AQAAAAIAAYagAAAAEEFukKMO7ZHH2oJgLUV93itUQHtpK+v1NSNPkyZ/9a7YSTmlFASY7IMJ2AMn+UiOgg==", "f2a444d4-0507-4234-8559-cbc174b6e05c" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 19, 35, 47, 723, DateTimeKind.Local).AddTicks(1643), new DateTime(2024, 2, 2, 19, 35, 47, 723, DateTimeKind.Local).AddTicks(1645) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 19, 35, 47, 723, DateTimeKind.Local).AddTicks(1647), new DateTime(2024, 2, 2, 19, 35, 47, 723, DateTimeKind.Local).AddTicks(1647) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 19, 35, 47, 991, DateTimeKind.Local).AddTicks(9755), new DateTime(2024, 2, 2, 19, 35, 47, 991, DateTimeKind.Local).AddTicks(9769) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 19, 35, 47, 991, DateTimeKind.Local).AddTicks(9773), new DateTime(2024, 2, 2, 19, 35, 47, 991, DateTimeKind.Local).AddTicks(9774) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 19, 35, 47, 991, DateTimeKind.Local).AddTicks(9776), new DateTime(2024, 2, 2, 19, 35, 47, 991, DateTimeKind.Local).AddTicks(9777) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 2, 2, 19, 35, 47, 992, DateTimeKind.Local).AddTicks(417), new DateTime(2024, 2, 2, 19, 35, 47, 992, DateTimeKind.Local).AddTicks(418), new DateTime(2024, 2, 2, 19, 35, 47, 992, DateTimeKind.Local).AddTicks(416) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 2, 2, 19, 35, 47, 992, DateTimeKind.Local).AddTicks(421), new DateTime(2024, 2, 2, 19, 35, 47, 992, DateTimeKind.Local).AddTicks(422), new DateTime(2024, 2, 2, 19, 35, 47, 992, DateTimeKind.Local).AddTicks(420) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 19, 35, 47, 723, DateTimeKind.Local).AddTicks(2091), new DateTime(2024, 2, 2, 19, 35, 47, 723, DateTimeKind.Local).AddTicks(2092) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 19, 35, 47, 723, DateTimeKind.Local).AddTicks(2095), new DateTime(2024, 2, 2, 19, 35, 47, 723, DateTimeKind.Local).AddTicks(2096) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 11, 35, 47, 992, DateTimeKind.Utc).AddTicks(887), new DateTime(2024, 2, 2, 11, 35, 47, 992, DateTimeKind.Utc).AddTicks(888) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 11, 35, 47, 992, DateTimeKind.Utc).AddTicks(891), new DateTime(2024, 2, 2, 11, 35, 47, 992, DateTimeKind.Utc).AddTicks(891) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 19, 35, 47, 723, DateTimeKind.Local).AddTicks(1887), new DateTime(2024, 2, 2, 19, 35, 47, 723, DateTimeKind.Local).AddTicks(1888) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 19, 35, 47, 723, DateTimeKind.Local).AddTicks(1890), new DateTime(2024, 2, 2, 19, 35, 47, 723, DateTimeKind.Local).AddTicks(1890) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 19, 35, 47, 992, DateTimeKind.Local).AddTicks(1225), new DateTime(2024, 2, 2, 19, 35, 47, 992, DateTimeKind.Local).AddTicks(1237) });

            migrationBuilder.InsertData(
                table: "NutritionalQuotas",
                columns: new[] { "Id", "CreatedBy", "CustomerID", "DateCreated", "DateUpdated", "TargetBMI", "TargetCalorieDaily", "TargetCarbDaily", "UpdatedBy" },
                values: new object[] { 2, "System", 2, new DateTime(2024, 2, 2, 19, 35, 47, 992, DateTimeKind.Local).AddTicks(1243), new DateTime(2024, 2, 2, 19, 35, 47, 992, DateTimeKind.Local).AddTicks(1243), 21.0, 2000.0, 290.0, "System" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 19, 35, 47, 723, DateTimeKind.Local).AddTicks(2620), new DateTime(2024, 2, 2, 19, 35, 47, 723, DateTimeKind.Local).AddTicks(2621) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 19, 35, 47, 723, DateTimeKind.Local).AddTicks(2624), new DateTime(2024, 2, 2, 19, 35, 47, 723, DateTimeKind.Local).AddTicks(2624) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 19, 35, 47, 723, DateTimeKind.Local).AddTicks(1102), new DateTime(2024, 2, 2, 19, 35, 47, 723, DateTimeKind.Local).AddTicks(1113) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 19, 35, 47, 723, DateTimeKind.Local).AddTicks(1115), new DateTime(2024, 2, 2, 19, 35, 47, 723, DateTimeKind.Local).AddTicks(1116) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 19, 35, 47, 723, DateTimeKind.Local).AddTicks(1117), new DateTime(2024, 2, 2, 19, 35, 47, 723, DateTimeKind.Local).AddTicks(1117) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 19, 35, 47, 992, DateTimeKind.Local).AddTicks(130), new DateTime(2024, 2, 2, 19, 35, 47, 992, DateTimeKind.Local).AddTicks(130), new DateTime(2024, 2, 2, 19, 35, 47, 992, DateTimeKind.Local).AddTicks(127), new DateTime(2024, 2, 2, 19, 35, 47, 992, DateTimeKind.Local).AddTicks(131) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 19, 35, 47, 992, DateTimeKind.Local).AddTicks(134), new DateTime(2024, 2, 2, 19, 35, 47, 992, DateTimeKind.Local).AddTicks(134), new DateTime(2024, 2, 2, 19, 35, 47, 992, DateTimeKind.Local).AddTicks(133), new DateTime(2024, 2, 2, 19, 35, 47, 992, DateTimeKind.Local).AddTicks(135) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 19, 35, 47, 992, DateTimeKind.Local).AddTicks(138), new DateTime(2024, 2, 2, 19, 35, 47, 992, DateTimeKind.Local).AddTicks(137), new DateTime(2024, 2, 2, 19, 35, 47, 992, DateTimeKind.Local).AddTicks(137), new DateTime(2024, 2, 2, 19, 35, 47, 992, DateTimeKind.Local).AddTicks(138) });
        }
    }
}
