using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NutriView.Server.Migrations
{
    /// <inheritdoc />
    public partial class hdhdh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1507dbd1-1c83-4ad2-9b0e-4d298c7b4521",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "caf1ccae-6b40-457d-9928-8a7512d1a94c", "AQAAAAIAAYagAAAAEPnhrCvFTe7i3v2Z7ySaLkw/XPqkGF0OSngnroqtnQkW0iJeReQFZ/1pYEJGwbQSpA==", "bbcdfb80-3b59-4920-9f56-0c3656724cf4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41624b27-7496-447c-b299-4892483d6b47",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f16e501f-2046-45de-b4ce-99b2406f8b20", "AQAAAAIAAYagAAAAEKnMJBUQZtbSX8maYuAe5jX6uSQejuWH+lBiKcqd/vk6iYq/SwFKf8CvP6AXj2n7dw==", "d143ece2-5a62-4d0a-93f3-07739c5f2050" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d3dfcba-a0af-4b10-989d-d63dcfec5e97",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "73ff413a-dd5f-46c2-9cf4-a1edafe01131", "AQAAAAIAAYagAAAAEObcQ9eNquNhkDPwopgaKQFPCd9BXkrB8GXcs+l1x3r9SezDb0ALaWQZl9nO7QbZZA==", "7996c743-2ab0-4245-92fe-aa1e92e36db7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8aa738a7-6c07-4e5a-8a7f-5637388c41b4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1077e746-96b0-4f00-bb79-726e6f3c5b4d", "AQAAAAIAAYagAAAAEByShVWfYrLdLmn4K26zhFUflNbMXw8rifn2keOiXb+x35JjEqZ8rOkVPKejWNbn7g==", "2f9052fb-7983-4a34-ab7a-3b03a95fdb21" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 43, 53, 808, DateTimeKind.Local).AddTicks(2198), new DateTime(2024, 2, 1, 2, 43, 53, 808, DateTimeKind.Local).AddTicks(2199) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 43, 53, 808, DateTimeKind.Local).AddTicks(2201), new DateTime(2024, 2, 1, 2, 43, 53, 808, DateTimeKind.Local).AddTicks(2202) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 43, 54, 20, DateTimeKind.Local).AddTicks(240), new DateTime(2024, 2, 1, 2, 43, 54, 20, DateTimeKind.Local).AddTicks(261) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 43, 54, 20, DateTimeKind.Local).AddTicks(265), new DateTime(2024, 2, 1, 2, 43, 54, 20, DateTimeKind.Local).AddTicks(265) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 43, 54, 20, DateTimeKind.Local).AddTicks(719), new DateTime(2024, 2, 1, 2, 43, 54, 20, DateTimeKind.Local).AddTicks(720), new DateTime(2024, 2, 1, 2, 43, 54, 20, DateTimeKind.Local).AddTicks(717) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 43, 54, 20, DateTimeKind.Local).AddTicks(722), new DateTime(2024, 2, 1, 2, 43, 54, 20, DateTimeKind.Local).AddTicks(722), new DateTime(2024, 2, 1, 2, 43, 54, 20, DateTimeKind.Local).AddTicks(721) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 43, 53, 808, DateTimeKind.Local).AddTicks(2592), new DateTime(2024, 2, 1, 2, 43, 53, 808, DateTimeKind.Local).AddTicks(2593) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 43, 53, 808, DateTimeKind.Local).AddTicks(2596), new DateTime(2024, 2, 1, 2, 43, 53, 808, DateTimeKind.Local).AddTicks(2596) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 18, 43, 54, 20, DateTimeKind.Utc).AddTicks(3835), new DateTime(2024, 1, 31, 18, 43, 54, 20, DateTimeKind.Utc).AddTicks(3836) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 18, 43, 54, 20, DateTimeKind.Utc).AddTicks(3839), new DateTime(2024, 1, 31, 18, 43, 54, 20, DateTimeKind.Utc).AddTicks(3840) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 43, 53, 808, DateTimeKind.Local).AddTicks(2395), new DateTime(2024, 2, 1, 2, 43, 53, 808, DateTimeKind.Local).AddTicks(2396) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 43, 53, 808, DateTimeKind.Local).AddTicks(2398), new DateTime(2024, 2, 1, 2, 43, 53, 808, DateTimeKind.Local).AddTicks(2399) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 43, 54, 20, DateTimeKind.Local).AddTicks(4297), new DateTime(2024, 2, 1, 2, 43, 54, 20, DateTimeKind.Local).AddTicks(4303) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 43, 54, 20, DateTimeKind.Local).AddTicks(4305), new DateTime(2024, 2, 1, 2, 43, 54, 20, DateTimeKind.Local).AddTicks(4306) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 43, 53, 808, DateTimeKind.Local).AddTicks(3133), new DateTime(2024, 2, 1, 2, 43, 53, 808, DateTimeKind.Local).AddTicks(3134) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 43, 53, 808, DateTimeKind.Local).AddTicks(3137), new DateTime(2024, 2, 1, 2, 43, 53, 808, DateTimeKind.Local).AddTicks(3137) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 43, 53, 808, DateTimeKind.Local).AddTicks(1428), new DateTime(2024, 2, 1, 2, 43, 53, 808, DateTimeKind.Local).AddTicks(1440) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 43, 53, 808, DateTimeKind.Local).AddTicks(1443), new DateTime(2024, 2, 1, 2, 43, 53, 808, DateTimeKind.Local).AddTicks(1444) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 43, 54, 20, DateTimeKind.Local).AddTicks(515), new DateTime(2024, 2, 1, 2, 43, 54, 20, DateTimeKind.Local).AddTicks(513), new DateTime(2024, 2, 1, 2, 43, 54, 20, DateTimeKind.Local).AddTicks(512), new DateTime(2024, 2, 1, 2, 43, 54, 20, DateTimeKind.Local).AddTicks(515) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 43, 54, 20, DateTimeKind.Local).AddTicks(518), new DateTime(2024, 2, 1, 2, 43, 54, 20, DateTimeKind.Local).AddTicks(518), new DateTime(2024, 2, 1, 2, 43, 54, 20, DateTimeKind.Local).AddTicks(517), new DateTime(2024, 2, 1, 2, 43, 54, 20, DateTimeKind.Local).AddTicks(519) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1507dbd1-1c83-4ad2-9b0e-4d298c7b4521",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "19dc049b-3f9e-4541-a4ee-c5ce0be9e46a", "AQAAAAIAAYagAAAAEEluJOe0mm2/Z6sePQpTmp3FnMgD6Zk1l96E5L0JoKC3DA2LAT9kkINl2aqm+PV4EA==", "b46008f3-68e7-4506-99e2-9b50a9cd2bff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41624b27-7496-447c-b299-4892483d6b47",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "211b6120-1dd2-4783-93a9-b7a7e19646de", "AQAAAAIAAYagAAAAEHhyK24wWOV0NOplEaqCcfMqhWrLvDVQC9hMrG+vsh8dxLjFLJq+Svore3IN/mX0Jw==", "9065f8a6-8603-4ad0-b952-ff2eef954753" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d3dfcba-a0af-4b10-989d-d63dcfec5e97",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "291671d9-b7f0-48c3-a337-36608ed444ff", "AQAAAAIAAYagAAAAEODdvVxqJI5XBWtzo7tRPk0rSrBao+LiNqyRtlTTlKr2QHVLqFIsrfgyJ7X1RFCFFg==", "05b9cdcd-994c-4202-8cd8-7bf83696df08" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8aa738a7-6c07-4e5a-8a7f-5637388c41b4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "42d8f57d-711c-4fc7-9769-568f1041c15e", "AQAAAAIAAYagAAAAEGJ1YIq/JKKuczSzMd7IVeKC0mBNcyqZstaH6dVu9z2nGcP+NnM7ZQUEVtLlz1t5zQ==", "f27db541-f0b8-4418-81a2-69e0336db9ae" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 32, 26, 825, DateTimeKind.Local).AddTicks(2397), new DateTime(2024, 2, 1, 2, 32, 26, 825, DateTimeKind.Local).AddTicks(2399) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 32, 26, 825, DateTimeKind.Local).AddTicks(2401), new DateTime(2024, 2, 1, 2, 32, 26, 825, DateTimeKind.Local).AddTicks(2401) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 32, 27, 27, DateTimeKind.Local).AddTicks(7235), new DateTime(2024, 2, 1, 2, 32, 27, 27, DateTimeKind.Local).AddTicks(7254) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 32, 27, 27, DateTimeKind.Local).AddTicks(7260), new DateTime(2024, 2, 1, 2, 32, 27, 27, DateTimeKind.Local).AddTicks(7260) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 32, 27, 27, DateTimeKind.Local).AddTicks(7734), new DateTime(2024, 2, 1, 2, 32, 27, 27, DateTimeKind.Local).AddTicks(7734), new DateTime(2024, 2, 1, 2, 32, 27, 27, DateTimeKind.Local).AddTicks(7733) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 32, 27, 27, DateTimeKind.Local).AddTicks(7736), new DateTime(2024, 2, 1, 2, 32, 27, 27, DateTimeKind.Local).AddTicks(7737), new DateTime(2024, 2, 1, 2, 32, 27, 27, DateTimeKind.Local).AddTicks(7736) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 32, 26, 825, DateTimeKind.Local).AddTicks(3028), new DateTime(2024, 2, 1, 2, 32, 26, 825, DateTimeKind.Local).AddTicks(3030) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 32, 26, 825, DateTimeKind.Local).AddTicks(3032), new DateTime(2024, 2, 1, 2, 32, 26, 825, DateTimeKind.Local).AddTicks(3033) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 18, 32, 27, 27, DateTimeKind.Utc).AddTicks(8218), new DateTime(2024, 1, 31, 18, 32, 27, 27, DateTimeKind.Utc).AddTicks(8219) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 18, 32, 27, 27, DateTimeKind.Utc).AddTicks(8221), new DateTime(2024, 1, 31, 18, 32, 27, 27, DateTimeKind.Utc).AddTicks(8222) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 32, 26, 825, DateTimeKind.Local).AddTicks(2646), new DateTime(2024, 2, 1, 2, 32, 26, 825, DateTimeKind.Local).AddTicks(2647) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 32, 26, 825, DateTimeKind.Local).AddTicks(2649), new DateTime(2024, 2, 1, 2, 32, 26, 825, DateTimeKind.Local).AddTicks(2650) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 32, 27, 27, DateTimeKind.Local).AddTicks(8494), new DateTime(2024, 2, 1, 2, 32, 27, 27, DateTimeKind.Local).AddTicks(8496) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 32, 27, 27, DateTimeKind.Local).AddTicks(8498), new DateTime(2024, 2, 1, 2, 32, 27, 27, DateTimeKind.Local).AddTicks(8498) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 32, 26, 825, DateTimeKind.Local).AddTicks(4142), new DateTime(2024, 2, 1, 2, 32, 26, 825, DateTimeKind.Local).AddTicks(4143) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 32, 26, 825, DateTimeKind.Local).AddTicks(4148), new DateTime(2024, 2, 1, 2, 32, 26, 825, DateTimeKind.Local).AddTicks(4148) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 32, 26, 825, DateTimeKind.Local).AddTicks(1578), new DateTime(2024, 2, 1, 2, 32, 26, 825, DateTimeKind.Local).AddTicks(1596) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 32, 26, 825, DateTimeKind.Local).AddTicks(1599), new DateTime(2024, 2, 1, 2, 32, 26, 825, DateTimeKind.Local).AddTicks(1600) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 32, 27, 27, DateTimeKind.Local).AddTicks(7520), new DateTime(2024, 2, 1, 2, 32, 27, 27, DateTimeKind.Local).AddTicks(7519), new DateTime(2024, 2, 1, 2, 32, 27, 27, DateTimeKind.Local).AddTicks(7517), new DateTime(2024, 2, 1, 2, 32, 27, 27, DateTimeKind.Local).AddTicks(7521) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 32, 27, 27, DateTimeKind.Local).AddTicks(7524), new DateTime(2024, 2, 1, 2, 32, 27, 27, DateTimeKind.Local).AddTicks(7524), new DateTime(2024, 2, 1, 2, 32, 27, 27, DateTimeKind.Local).AddTicks(7523), new DateTime(2024, 2, 1, 2, 32, 27, 27, DateTimeKind.Local).AddTicks(7525) });
        }
    }
}
