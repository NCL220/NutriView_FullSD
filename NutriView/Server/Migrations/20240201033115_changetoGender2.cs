using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NutriView.Server.Migrations
{
    /// <inheritdoc />
    public partial class changetoGender2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Genders",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1507dbd1-1c83-4ad2-9b0e-4d298c7b4521",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cbf18cce-f6c9-452f-9996-c355c338ec24", "AQAAAAIAAYagAAAAEBVT8RcApSbLU4lStAznnSjJAQo9NuiY6DncSwurhM1Ymz0W76qIHJ0iIiAPveEXZQ==", "098c0f29-759e-417f-9f6f-8b57e2969f09" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41624b27-7496-447c-b299-4892483d6b47",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b7ee3c35-6482-4222-9fff-af8150919874", "AQAAAAIAAYagAAAAEJ3wGhNmncifzES8VW5u+izEqtHsWOKnlLK23rkKsTpiC61mpaHOCA8h/9HAHMLDLA==", "c11beef7-35f7-428b-ac8b-14acbddfc07f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d3dfcba-a0af-4b10-989d-d63dcfec5e97",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4db7448-8d3f-4a48-8981-b98914e326f3", "AQAAAAIAAYagAAAAEPZgQ/ZZ5vJp0vyq1cSA2FE0E+BZXmWWUfED8edaL63w/7ZzNIu3YpmAASMS2aDN1g==", "23372b4d-ea27-4b0c-84f6-ff20dc41c2a7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8aa738a7-6c07-4e5a-8a7f-5637388c41b4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a1e87e77-2388-44a8-8b56-a6b2cef93f3e", "AQAAAAIAAYagAAAAEAmrdxQ0I1+l9eZ5jev3S4+N51vDBQ5JhkXiv0I/oNEdpprGMGFcwCKgJiR1KaBEqg==", "c2e9f72d-2596-4323-81a6-40290762151f" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 31, 14, 641, DateTimeKind.Local).AddTicks(3660), new DateTime(2024, 2, 1, 11, 31, 14, 641, DateTimeKind.Local).AddTicks(3661) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 31, 14, 641, DateTimeKind.Local).AddTicks(3663), new DateTime(2024, 2, 1, 11, 31, 14, 641, DateTimeKind.Local).AddTicks(3663) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 31, 14, 907, DateTimeKind.Local).AddTicks(6651), new DateTime(2024, 2, 1, 11, 31, 14, 907, DateTimeKind.Local).AddTicks(6664) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 31, 14, 907, DateTimeKind.Local).AddTicks(6667), new DateTime(2024, 2, 1, 11, 31, 14, 907, DateTimeKind.Local).AddTicks(6667) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 31, 14, 907, DateTimeKind.Local).AddTicks(7190), new DateTime(2024, 2, 1, 11, 31, 14, 907, DateTimeKind.Local).AddTicks(7191), new DateTime(2024, 2, 1, 11, 31, 14, 907, DateTimeKind.Local).AddTicks(7189) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 31, 14, 907, DateTimeKind.Local).AddTicks(7193), new DateTime(2024, 2, 1, 11, 31, 14, 907, DateTimeKind.Local).AddTicks(7194), new DateTime(2024, 2, 1, 11, 31, 14, 907, DateTimeKind.Local).AddTicks(7193) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 31, 14, 641, DateTimeKind.Local).AddTicks(4068), new DateTime(2024, 2, 1, 11, 31, 14, 641, DateTimeKind.Local).AddTicks(4068) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 31, 14, 641, DateTimeKind.Local).AddTicks(4071), new DateTime(2024, 2, 1, 11, 31, 14, 641, DateTimeKind.Local).AddTicks(4071) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 31, 14, 907, DateTimeKind.Utc).AddTicks(7516), new DateTime(2024, 2, 1, 3, 31, 14, 907, DateTimeKind.Utc).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 31, 14, 907, DateTimeKind.Utc).AddTicks(7518), new DateTime(2024, 2, 1, 3, 31, 14, 907, DateTimeKind.Utc).AddTicks(7519) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 31, 14, 641, DateTimeKind.Local).AddTicks(3866), new DateTime(2024, 2, 1, 11, 31, 14, 641, DateTimeKind.Local).AddTicks(3867) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 31, 14, 641, DateTimeKind.Local).AddTicks(3869), new DateTime(2024, 2, 1, 11, 31, 14, 641, DateTimeKind.Local).AddTicks(3869) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 31, 14, 907, DateTimeKind.Local).AddTicks(7831), new DateTime(2024, 2, 1, 11, 31, 14, 907, DateTimeKind.Local).AddTicks(7833) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 31, 14, 907, DateTimeKind.Local).AddTicks(7835), new DateTime(2024, 2, 1, 11, 31, 14, 907, DateTimeKind.Local).AddTicks(7835) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 31, 14, 641, DateTimeKind.Local).AddTicks(4554), new DateTime(2024, 2, 1, 11, 31, 14, 641, DateTimeKind.Local).AddTicks(4555) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 31, 14, 641, DateTimeKind.Local).AddTicks(4558), new DateTime(2024, 2, 1, 11, 31, 14, 641, DateTimeKind.Local).AddTicks(4559) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 31, 14, 641, DateTimeKind.Local).AddTicks(3165), new DateTime(2024, 2, 1, 11, 31, 14, 641, DateTimeKind.Local).AddTicks(3174) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 31, 14, 641, DateTimeKind.Local).AddTicks(3177), new DateTime(2024, 2, 1, 11, 31, 14, 641, DateTimeKind.Local).AddTicks(3177) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 31, 14, 907, DateTimeKind.Local).AddTicks(6942), new DateTime(2024, 2, 1, 11, 31, 14, 907, DateTimeKind.Local).AddTicks(6942), new DateTime(2024, 2, 1, 11, 31, 14, 907, DateTimeKind.Local).AddTicks(6941), new DateTime(2024, 2, 1, 11, 31, 14, 907, DateTimeKind.Local).AddTicks(6943) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 31, 14, 907, DateTimeKind.Local).AddTicks(6946), new DateTime(2024, 2, 1, 11, 31, 14, 907, DateTimeKind.Local).AddTicks(6945), new DateTime(2024, 2, 1, 11, 31, 14, 907, DateTimeKind.Local).AddTicks(6945), new DateTime(2024, 2, 1, 11, 31, 14, 907, DateTimeKind.Local).AddTicks(6946) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Genders",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1507dbd1-1c83-4ad2-9b0e-4d298c7b4521",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "427f3973-22a6-434b-8bb8-9b863dcb1dbc", "AQAAAAIAAYagAAAAEGgguJPsUJz9ca4g5ELzq0qk9yt3GIj6xqDXpWESaQYIkHOXK1z1t3UoVhF4kjuhJg==", "058b39e2-4b75-4845-b6b8-06164835061f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41624b27-7496-447c-b299-4892483d6b47",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9309a9d0-d18e-45e8-9778-5bdaa0502a72", "AQAAAAIAAYagAAAAEBo21y9GevRxs/DilDV+1820ESdpjU7IDVLuqr64Dl6SQrGGC3fXkunwGpINEXyEhQ==", "6259e29d-30de-413f-943e-ddf1543da571" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d3dfcba-a0af-4b10-989d-d63dcfec5e97",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7585b99a-2cc1-4359-a971-f704e6f3c7a8", "AQAAAAIAAYagAAAAEGEu1hXaBCcuc8nRFNVPriM75ydQQIbz5shWYOwzc/cNvO77Io3Bg2wZMcWodPQQ+Q==", "95eb00ff-3264-426c-acba-fd7857c25307" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8aa738a7-6c07-4e5a-8a7f-5637388c41b4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "efde9674-380f-4ef1-aae1-5209796d26d4", "AQAAAAIAAYagAAAAEFOJ90N/ceAjxOXcM5t65Rw95a9RYrvLwEY2uK4WC0Aq8Kh2O+0uTm7i8drbyH3LVQ==", "9e02ea94-846b-40b5-b70a-39fa6c958729" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 29, 58, 719, DateTimeKind.Local).AddTicks(3253), new DateTime(2024, 2, 1, 11, 29, 58, 719, DateTimeKind.Local).AddTicks(3254) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 29, 58, 719, DateTimeKind.Local).AddTicks(3256), new DateTime(2024, 2, 1, 11, 29, 58, 719, DateTimeKind.Local).AddTicks(3256) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 29, 58, 990, DateTimeKind.Local).AddTicks(4528), new DateTime(2024, 2, 1, 11, 29, 58, 990, DateTimeKind.Local).AddTicks(4541) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 29, 58, 990, DateTimeKind.Local).AddTicks(4544), new DateTime(2024, 2, 1, 11, 29, 58, 990, DateTimeKind.Local).AddTicks(4545) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 29, 58, 990, DateTimeKind.Local).AddTicks(5110), new DateTime(2024, 2, 1, 11, 29, 58, 990, DateTimeKind.Local).AddTicks(5111), new DateTime(2024, 2, 1, 11, 29, 58, 990, DateTimeKind.Local).AddTicks(5109) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 29, 58, 990, DateTimeKind.Local).AddTicks(5113), new DateTime(2024, 2, 1, 11, 29, 58, 990, DateTimeKind.Local).AddTicks(5113), new DateTime(2024, 2, 1, 11, 29, 58, 990, DateTimeKind.Local).AddTicks(5112) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 29, 58, 719, DateTimeKind.Local).AddTicks(3729), new DateTime(2024, 2, 1, 11, 29, 58, 719, DateTimeKind.Local).AddTicks(3730) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 29, 58, 719, DateTimeKind.Local).AddTicks(3732), new DateTime(2024, 2, 1, 11, 29, 58, 719, DateTimeKind.Local).AddTicks(3733) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 29, 58, 990, DateTimeKind.Utc).AddTicks(5464), new DateTime(2024, 2, 1, 3, 29, 58, 990, DateTimeKind.Utc).AddTicks(5465) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 29, 58, 990, DateTimeKind.Utc).AddTicks(5467), new DateTime(2024, 2, 1, 3, 29, 58, 990, DateTimeKind.Utc).AddTicks(5467) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 29, 58, 719, DateTimeKind.Local).AddTicks(3493), new DateTime(2024, 2, 1, 11, 29, 58, 719, DateTimeKind.Local).AddTicks(3494) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 29, 58, 719, DateTimeKind.Local).AddTicks(3496), new DateTime(2024, 2, 1, 11, 29, 58, 719, DateTimeKind.Local).AddTicks(3497) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 29, 58, 990, DateTimeKind.Local).AddTicks(5836), new DateTime(2024, 2, 1, 11, 29, 58, 990, DateTimeKind.Local).AddTicks(5839) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 29, 58, 990, DateTimeKind.Local).AddTicks(5841), new DateTime(2024, 2, 1, 11, 29, 58, 990, DateTimeKind.Local).AddTicks(5842) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 29, 58, 719, DateTimeKind.Local).AddTicks(4293), new DateTime(2024, 2, 1, 11, 29, 58, 719, DateTimeKind.Local).AddTicks(4295) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 29, 58, 719, DateTimeKind.Local).AddTicks(4298), new DateTime(2024, 2, 1, 11, 29, 58, 719, DateTimeKind.Local).AddTicks(4298) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 29, 58, 719, DateTimeKind.Local).AddTicks(2743), new DateTime(2024, 2, 1, 11, 29, 58, 719, DateTimeKind.Local).AddTicks(2752) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 29, 58, 719, DateTimeKind.Local).AddTicks(2754), new DateTime(2024, 2, 1, 11, 29, 58, 719, DateTimeKind.Local).AddTicks(2754) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 29, 58, 990, DateTimeKind.Local).AddTicks(4858), new DateTime(2024, 2, 1, 11, 29, 58, 990, DateTimeKind.Local).AddTicks(4858), new DateTime(2024, 2, 1, 11, 29, 58, 990, DateTimeKind.Local).AddTicks(4856), new DateTime(2024, 2, 1, 11, 29, 58, 990, DateTimeKind.Local).AddTicks(4859) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 29, 58, 990, DateTimeKind.Local).AddTicks(4862), new DateTime(2024, 2, 1, 11, 29, 58, 990, DateTimeKind.Local).AddTicks(4861), new DateTime(2024, 2, 1, 11, 29, 58, 990, DateTimeKind.Local).AddTicks(4861), new DateTime(2024, 2, 1, 11, 29, 58, 990, DateTimeKind.Local).AddTicks(4862) });
        }
    }
}
