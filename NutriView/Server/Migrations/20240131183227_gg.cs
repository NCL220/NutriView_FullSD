using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NutriView.Server.Migrations
{
    /// <inheritdoc />
    public partial class gg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Mission",
                table: "Companies",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "CompanyName",
                table: "Companies",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "CompanyDescription",
                table: "Companies",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Mission",
                table: "Companies",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(300)",
                oldMaxLength: 300,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CompanyName",
                table: "Companies",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CompanyDescription",
                table: "Companies",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1507dbd1-1c83-4ad2-9b0e-4d298c7b4521",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed0db6a1-c840-4dda-9b68-6a7adcc8ae9f", "AQAAAAIAAYagAAAAEDf+7V/FKyPN7vf3K7AssRYSFjFqc2EfigzqJwG2VJJ9veJGAG4QTUfotDi6bB9KMw==", "0ea85525-00d7-4c70-b72c-9e4f60eadd70" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41624b27-7496-447c-b299-4892483d6b47",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b13f877-4c51-4e38-8597-84e838b14231", "AQAAAAIAAYagAAAAEA+aUIq9Nd/U79ZgSWeIwqDUKUkNFPrp53h8H0+ZZ2b274wj0NXfs49BlQfmCObuzw==", "a31486fd-a504-4c51-a7a0-f52c01bd418c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d3dfcba-a0af-4b10-989d-d63dcfec5e97",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b26742c1-97b4-4194-ad40-b875ecfb2c1a", "AQAAAAIAAYagAAAAEKA5+aqg4CML7jYhuvJ2YDU6Gkgl7JT0SjHqjLkwM2wlfuY9SqHDyHbyQGAo/W1yVg==", "c2ab991e-dd6a-4df9-8040-a40669a2eebf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8aa738a7-6c07-4e5a-8a7f-5637388c41b4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c42e9e1d-0d03-4095-a6a4-925037327b4c", "AQAAAAIAAYagAAAAEJVvTCOD/yLsdZlIlq0h10dghcsvNogpCAxBGW6q8OA5VpArULoMhwOLeWitTbnAzA==", "43a54486-2ba4-498b-a980-6824c1533ceb" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 28, 22, 644, DateTimeKind.Local).AddTicks(5341), new DateTime(2024, 2, 1, 2, 28, 22, 644, DateTimeKind.Local).AddTicks(5343) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 28, 22, 644, DateTimeKind.Local).AddTicks(5347), new DateTime(2024, 2, 1, 2, 28, 22, 644, DateTimeKind.Local).AddTicks(5358) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 28, 22, 846, DateTimeKind.Local).AddTicks(8471), new DateTime(2024, 2, 1, 2, 28, 22, 846, DateTimeKind.Local).AddTicks(8492) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 28, 22, 846, DateTimeKind.Local).AddTicks(8499), new DateTime(2024, 2, 1, 2, 28, 22, 846, DateTimeKind.Local).AddTicks(8500) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 28, 22, 846, DateTimeKind.Local).AddTicks(9108), new DateTime(2024, 2, 1, 2, 28, 22, 846, DateTimeKind.Local).AddTicks(9109), new DateTime(2024, 2, 1, 2, 28, 22, 846, DateTimeKind.Local).AddTicks(9107) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 28, 22, 846, DateTimeKind.Local).AddTicks(9111), new DateTime(2024, 2, 1, 2, 28, 22, 846, DateTimeKind.Local).AddTicks(9111), new DateTime(2024, 2, 1, 2, 28, 22, 846, DateTimeKind.Local).AddTicks(9110) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 28, 22, 644, DateTimeKind.Local).AddTicks(5891), new DateTime(2024, 2, 1, 2, 28, 22, 644, DateTimeKind.Local).AddTicks(5892) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 28, 22, 644, DateTimeKind.Local).AddTicks(5895), new DateTime(2024, 2, 1, 2, 28, 22, 644, DateTimeKind.Local).AddTicks(5896) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 18, 28, 22, 846, DateTimeKind.Utc).AddTicks(9414), new DateTime(2024, 1, 31, 18, 28, 22, 846, DateTimeKind.Utc).AddTicks(9414) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 18, 28, 22, 846, DateTimeKind.Utc).AddTicks(9416), new DateTime(2024, 1, 31, 18, 28, 22, 846, DateTimeKind.Utc).AddTicks(9416) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 28, 22, 644, DateTimeKind.Local).AddTicks(5636), new DateTime(2024, 2, 1, 2, 28, 22, 644, DateTimeKind.Local).AddTicks(5638) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 28, 22, 644, DateTimeKind.Local).AddTicks(5640), new DateTime(2024, 2, 1, 2, 28, 22, 644, DateTimeKind.Local).AddTicks(5641) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 28, 22, 846, DateTimeKind.Local).AddTicks(9671), new DateTime(2024, 2, 1, 2, 28, 22, 846, DateTimeKind.Local).AddTicks(9672) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 28, 22, 846, DateTimeKind.Local).AddTicks(9674), new DateTime(2024, 2, 1, 2, 28, 22, 846, DateTimeKind.Local).AddTicks(9674) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 28, 22, 644, DateTimeKind.Local).AddTicks(6614), new DateTime(2024, 2, 1, 2, 28, 22, 644, DateTimeKind.Local).AddTicks(6616) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 28, 22, 644, DateTimeKind.Local).AddTicks(6620), new DateTime(2024, 2, 1, 2, 28, 22, 644, DateTimeKind.Local).AddTicks(6620) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 28, 22, 644, DateTimeKind.Local).AddTicks(4486), new DateTime(2024, 2, 1, 2, 28, 22, 644, DateTimeKind.Local).AddTicks(4499) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 28, 22, 644, DateTimeKind.Local).AddTicks(4503), new DateTime(2024, 2, 1, 2, 28, 22, 644, DateTimeKind.Local).AddTicks(4503) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 28, 22, 846, DateTimeKind.Local).AddTicks(8828), new DateTime(2024, 2, 1, 2, 28, 22, 846, DateTimeKind.Local).AddTicks(8826), new DateTime(2024, 2, 1, 2, 28, 22, 846, DateTimeKind.Local).AddTicks(8825), new DateTime(2024, 2, 1, 2, 28, 22, 846, DateTimeKind.Local).AddTicks(8828) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 28, 22, 846, DateTimeKind.Local).AddTicks(8832), new DateTime(2024, 2, 1, 2, 28, 22, 846, DateTimeKind.Local).AddTicks(8831), new DateTime(2024, 2, 1, 2, 28, 22, 846, DateTimeKind.Local).AddTicks(8831), new DateTime(2024, 2, 1, 2, 28, 22, 846, DateTimeKind.Local).AddTicks(8832) });
        }
    }
}
