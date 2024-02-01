using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NutriView.Server.Migrations
{
    /// <inheritdoc />
    public partial class changetoGender : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1507dbd1-1c83-4ad2-9b0e-4d298c7b4521",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "28017170-a27c-4df0-ad41-7e1729821681", "AQAAAAIAAYagAAAAEMvuPDFnP6kfMbFH1VA6rieGg95JB3rA5X9Pm3OsnZVHosATIcONYtnSMrh0ldwr8w==", "33ca93a5-f2dc-4ed2-b0eb-a0d24db3a6d7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41624b27-7496-447c-b299-4892483d6b47",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d1c6b2e-5880-42af-ae01-7b89190ff75a", "AQAAAAIAAYagAAAAEPw0hhBq80+fQR+++c4VCo7eYMwBsfv2KrcXe04QDQug+B6oufdM5uC17qsroUzl9w==", "786166c3-1e15-4634-9a72-b33843e31a2d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d3dfcba-a0af-4b10-989d-d63dcfec5e97",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0c0774b6-3e3f-4ab1-92ea-d9ef442bc973", "AQAAAAIAAYagAAAAENXIZi0c9zr2uDiDSj9qx0P0CjmLcJ60RujzUMRQLRTU5cjXS5F4GG+GqZmxapWg/w==", "9c5e4686-4322-4a77-b661-4677194fdd8e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8aa738a7-6c07-4e5a-8a7f-5637388c41b4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "80d77471-e716-4bb6-acb9-f070ea700012", "AQAAAAIAAYagAAAAECnHVbtabpPJhiJJTPp/so3lCnQdy7WVeFIe8LgcM6vAETBsyBc0Ons+DzUPJUJtpw==", "230a6e08-1e51-4ec9-a8ef-27bafaafb1ad" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 13, 33, 691, DateTimeKind.Local).AddTicks(9115), new DateTime(2024, 2, 1, 11, 13, 33, 691, DateTimeKind.Local).AddTicks(9117) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 13, 33, 691, DateTimeKind.Local).AddTicks(9119), new DateTime(2024, 2, 1, 11, 13, 33, 691, DateTimeKind.Local).AddTicks(9119) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 13, 33, 951, DateTimeKind.Local).AddTicks(4117), new DateTime(2024, 2, 1, 11, 13, 33, 951, DateTimeKind.Local).AddTicks(4130) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 13, 33, 951, DateTimeKind.Local).AddTicks(4133), new DateTime(2024, 2, 1, 11, 13, 33, 951, DateTimeKind.Local).AddTicks(4134) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 13, 33, 951, DateTimeKind.Local).AddTicks(4673), new DateTime(2024, 2, 1, 11, 13, 33, 951, DateTimeKind.Local).AddTicks(4674), new DateTime(2024, 2, 1, 11, 13, 33, 951, DateTimeKind.Local).AddTicks(4672) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 13, 33, 951, DateTimeKind.Local).AddTicks(4676), new DateTime(2024, 2, 1, 11, 13, 33, 951, DateTimeKind.Local).AddTicks(4676), new DateTime(2024, 2, 1, 11, 13, 33, 951, DateTimeKind.Local).AddTicks(4675) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 13, 33, 691, DateTimeKind.Local).AddTicks(9554), new DateTime(2024, 2, 1, 11, 13, 33, 691, DateTimeKind.Local).AddTicks(9555) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 13, 33, 691, DateTimeKind.Local).AddTicks(9558), new DateTime(2024, 2, 1, 11, 13, 33, 691, DateTimeKind.Local).AddTicks(9558) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 13, 33, 951, DateTimeKind.Utc).AddTicks(4957), new DateTime(2024, 2, 1, 3, 13, 33, 951, DateTimeKind.Utc).AddTicks(4957) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 13, 33, 951, DateTimeKind.Utc).AddTicks(4959), new DateTime(2024, 2, 1, 3, 13, 33, 951, DateTimeKind.Utc).AddTicks(4960) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 13, 33, 691, DateTimeKind.Local).AddTicks(9339), new DateTime(2024, 2, 1, 11, 13, 33, 691, DateTimeKind.Local).AddTicks(9340) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 13, 33, 691, DateTimeKind.Local).AddTicks(9343), new DateTime(2024, 2, 1, 11, 13, 33, 691, DateTimeKind.Local).AddTicks(9343) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 13, 33, 951, DateTimeKind.Local).AddTicks(5278), new DateTime(2024, 2, 1, 11, 13, 33, 951, DateTimeKind.Local).AddTicks(5279) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 13, 33, 951, DateTimeKind.Local).AddTicks(5282), new DateTime(2024, 2, 1, 11, 13, 33, 951, DateTimeKind.Local).AddTicks(5282) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 13, 33, 692, DateTimeKind.Local).AddTicks(111), new DateTime(2024, 2, 1, 11, 13, 33, 692, DateTimeKind.Local).AddTicks(113) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 13, 33, 692, DateTimeKind.Local).AddTicks(118), new DateTime(2024, 2, 1, 11, 13, 33, 692, DateTimeKind.Local).AddTicks(119) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 13, 33, 691, DateTimeKind.Local).AddTicks(8583), new DateTime(2024, 2, 1, 11, 13, 33, 691, DateTimeKind.Local).AddTicks(8592) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 13, 33, 691, DateTimeKind.Local).AddTicks(8594), new DateTime(2024, 2, 1, 11, 13, 33, 691, DateTimeKind.Local).AddTicks(8595) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 13, 33, 951, DateTimeKind.Local).AddTicks(4431), new DateTime(2024, 2, 1, 11, 13, 33, 951, DateTimeKind.Local).AddTicks(4431), new DateTime(2024, 2, 1, 11, 13, 33, 951, DateTimeKind.Local).AddTicks(4429), new DateTime(2024, 2, 1, 11, 13, 33, 951, DateTimeKind.Local).AddTicks(4432) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 13, 33, 951, DateTimeKind.Local).AddTicks(4434), new DateTime(2024, 2, 1, 11, 13, 33, 951, DateTimeKind.Local).AddTicks(4434), new DateTime(2024, 2, 1, 11, 13, 33, 951, DateTimeKind.Local).AddTicks(4434), new DateTime(2024, 2, 1, 11, 13, 33, 951, DateTimeKind.Local).AddTicks(4435) });
        }
    }
}
