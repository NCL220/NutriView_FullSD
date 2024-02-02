using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NutriView.Server.Migrations
{
    /// <inheritdoc />
    public partial class slightchange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Staffs",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1507dbd1-1c83-4ad2-9b0e-4d298c7b4521",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39dc9af5-597f-457b-9ea7-8757482a6cb1", "AQAAAAIAAYagAAAAEDD4QwVkINAI7//iM8tJSqiiYC8fLit8Z/g8xApXOxVLHPZmfMd9IsrezKYJAEixtQ==", "d0f640f8-75fd-40c5-9510-710b7666e5d6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41624b27-7496-447c-b299-4892483d6b47",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ac05958-2230-4719-b9df-738316fb8e0d", "AQAAAAIAAYagAAAAEFOoE6acGzDoadFE9cZWRzlt2EsGF7bWwq4DDEd1rMKax4P8/j3YErJ/wtKRZxUyog==", "7d881da7-d5f3-4766-a2bb-2a2a39ec3ee7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d3dfcba-a0af-4b10-989d-d63dcfec5e97",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3965d666-ff0e-4882-8a87-3cbad89a247a", "AQAAAAIAAYagAAAAECzZkqBDU/Rl5ik3UZydAxp+MQ6k2Wm9xFXLj28h6EbR4H+Ay8bU8mL9HayAcFpMVg==", "eb355d7a-7c96-4dc8-90a4-113ed077d4dc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8aa738a7-6c07-4e5a-8a7f-5637388c41b4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2c8bbaf2-56a8-477d-aedd-4b20aa9ef7b0", "AQAAAAIAAYagAAAAEBYfXSrtpg1O6usUCE5LWxGm3f2UAwxuI4lEIyA9SeMIZfCSuBTk5nWhH6rzyQXo+w==", "de68ac8b-99db-45dc-95e9-4aba9fb6edeb" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 20, 28, 52, 562, DateTimeKind.Local).AddTicks(7309), new DateTime(2024, 2, 2, 20, 28, 52, 562, DateTimeKind.Local).AddTicks(7310) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 20, 28, 52, 562, DateTimeKind.Local).AddTicks(7315), new DateTime(2024, 2, 2, 20, 28, 52, 562, DateTimeKind.Local).AddTicks(7315) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 20, 28, 52, 842, DateTimeKind.Local).AddTicks(5895), new DateTime(2024, 2, 2, 20, 28, 52, 842, DateTimeKind.Local).AddTicks(5910) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 20, 28, 52, 842, DateTimeKind.Local).AddTicks(5914), new DateTime(2024, 2, 2, 20, 28, 52, 842, DateTimeKind.Local).AddTicks(5914) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 20, 28, 52, 842, DateTimeKind.Local).AddTicks(5916), new DateTime(2024, 2, 2, 20, 28, 52, 842, DateTimeKind.Local).AddTicks(5917) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 2, 2, 20, 28, 52, 842, DateTimeKind.Local).AddTicks(6469), new DateTime(2024, 2, 2, 20, 28, 52, 842, DateTimeKind.Local).AddTicks(6470), new DateTime(2024, 2, 2, 20, 28, 52, 842, DateTimeKind.Local).AddTicks(6468) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 2, 2, 20, 28, 52, 842, DateTimeKind.Local).AddTicks(6473), new DateTime(2024, 2, 2, 20, 28, 52, 842, DateTimeKind.Local).AddTicks(6473), new DateTime(2024, 2, 2, 20, 28, 52, 842, DateTimeKind.Local).AddTicks(6472) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 20, 28, 52, 562, DateTimeKind.Local).AddTicks(7914), new DateTime(2024, 2, 2, 20, 28, 52, 562, DateTimeKind.Local).AddTicks(7914) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 20, 28, 52, 562, DateTimeKind.Local).AddTicks(7917), new DateTime(2024, 2, 2, 20, 28, 52, 562, DateTimeKind.Local).AddTicks(7917) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 12, 28, 52, 842, DateTimeKind.Utc).AddTicks(6775), new DateTime(2024, 2, 2, 12, 28, 52, 842, DateTimeKind.Utc).AddTicks(6775) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 12, 28, 52, 842, DateTimeKind.Utc).AddTicks(6778), new DateTime(2024, 2, 2, 12, 28, 52, 842, DateTimeKind.Utc).AddTicks(6778) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 20, 28, 52, 562, DateTimeKind.Local).AddTicks(7716), new DateTime(2024, 2, 2, 20, 28, 52, 562, DateTimeKind.Local).AddTicks(7716) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 20, 28, 52, 562, DateTimeKind.Local).AddTicks(7718), new DateTime(2024, 2, 2, 20, 28, 52, 562, DateTimeKind.Local).AddTicks(7719) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 20, 28, 52, 842, DateTimeKind.Local).AddTicks(7127), new DateTime(2024, 2, 2, 20, 28, 52, 842, DateTimeKind.Local).AddTicks(7139) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 2, 2, 20, 28, 52, 562, DateTimeKind.Local).AddTicks(8585), new DateTime(2024, 2, 2, 20, 28, 52, 562, DateTimeKind.Local).AddTicks(8586), "87993192" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 2, 2, 20, 28, 52, 562, DateTimeKind.Local).AddTicks(8588), new DateTime(2024, 2, 2, 20, 28, 52, 562, DateTimeKind.Local).AddTicks(8589), "12345678" });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 20, 28, 52, 562, DateTimeKind.Local).AddTicks(6800), new DateTime(2024, 2, 2, 20, 28, 52, 562, DateTimeKind.Local).AddTicks(6810) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 20, 28, 52, 562, DateTimeKind.Local).AddTicks(6812), new DateTime(2024, 2, 2, 20, 28, 52, 562, DateTimeKind.Local).AddTicks(6812) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 20, 28, 52, 562, DateTimeKind.Local).AddTicks(6813), new DateTime(2024, 2, 2, 20, 28, 52, 562, DateTimeKind.Local).AddTicks(6814) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 20, 28, 52, 842, DateTimeKind.Local).AddTicks(6219), new DateTime(2024, 2, 2, 20, 28, 52, 842, DateTimeKind.Local).AddTicks(6219), new DateTime(2024, 2, 2, 20, 28, 52, 842, DateTimeKind.Local).AddTicks(6217), new DateTime(2024, 2, 2, 20, 28, 52, 842, DateTimeKind.Local).AddTicks(6220) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 20, 28, 52, 842, DateTimeKind.Local).AddTicks(6223), new DateTime(2024, 2, 2, 20, 28, 52, 842, DateTimeKind.Local).AddTicks(6223), new DateTime(2024, 2, 2, 20, 28, 52, 842, DateTimeKind.Local).AddTicks(6222), new DateTime(2024, 2, 2, 20, 28, 52, 842, DateTimeKind.Local).AddTicks(6224) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 20, 28, 52, 842, DateTimeKind.Local).AddTicks(6226), new DateTime(2024, 2, 2, 20, 28, 52, 842, DateTimeKind.Local).AddTicks(6225), new DateTime(2024, 2, 2, 20, 28, 52, 842, DateTimeKind.Local).AddTicks(6225), new DateTime(2024, 2, 2, 20, 28, 52, 842, DateTimeKind.Local).AddTicks(6226) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PhoneNumber",
                table: "Staffs",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
                columns: new[] { "DateCreated", "DateUpdated", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 2, 2, 20, 21, 44, 362, DateTimeKind.Local).AddTicks(6049), new DateTime(2024, 2, 2, 20, 21, 44, 362, DateTimeKind.Local).AddTicks(6050), 87993192 });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 2, 2, 20, 21, 44, 362, DateTimeKind.Local).AddTicks(6052), new DateTime(2024, 2, 2, 20, 21, 44, 362, DateTimeKind.Local).AddTicks(6053), 87993192 });

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
    }
}
