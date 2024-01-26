using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NutriView.Server.Migrations
{
    /// <inheritdoc />
    public partial class ImagebytesforstaffAndCustomer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "ImageByte",
                table: "Staffs",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "ImageBytes",
                table: "Customers",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1507dbd1-1c83-4ad2-9b0e-4d298c7b4521",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b86f96a-ff19-446c-8579-9f92b419a474", "AQAAAAIAAYagAAAAEBu1/KJP1V1vElP0yD92qpRNdlJZMF1HSwbyvpbBu0jxnD/noat61xSIXH/kxt1T4Q==", "c0574c53-bd4e-4135-82e0-06495cd076c2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41624b27-7496-447c-b299-4892483d6b47",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1276729e-e9b1-40dc-8f3a-da100357641b", "AQAAAAIAAYagAAAAECnn+0C+58xW4/lwcmjLUWi7yizQ7QTqF4LuUYNV/3ycOLAoNDom0/ZiFZvNnKh84A==", "7be6cbe9-f76b-4d22-a9da-a74bf1518434" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d3dfcba-a0af-4b10-989d-d63dcfec5e97",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aad367de-e8a7-4331-a918-5d3bb985f478", "AQAAAAIAAYagAAAAEMJQ+cw9YFqVv9GAe8aCFlUvZugh9h5iaj71zNMSEUS0C2VLot3IqhTlqNzuMqrG7Q==", "524fd27d-8aab-46de-871e-c5401599cad1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8aa738a7-6c07-4e5a-8a7f-5637388c41b4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "89f72c42-b93e-4aa4-84d3-16220239e909", "AQAAAAIAAYagAAAAEM5T+96McDUu4rWPCx9cjOagzE/dBIolBFry+BvH0BZ/N6+RzuqT+uenNutkwkoGVw==", "b1d179ed-7538-4f25-a11d-68cdf48007c9" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 13, 44, 5, 205, DateTimeKind.Local).AddTicks(1813), new DateTime(2024, 1, 26, 13, 44, 5, 205, DateTimeKind.Local).AddTicks(1813) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 13, 44, 5, 205, DateTimeKind.Local).AddTicks(1815), new DateTime(2024, 1, 26, 13, 44, 5, 205, DateTimeKind.Local).AddTicks(1815) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "ImageBytes" },
                values: new object[] { new DateTime(2024, 1, 26, 13, 44, 5, 392, DateTimeKind.Local).AddTicks(6755), new DateTime(2024, 1, 26, 13, 44, 5, 392, DateTimeKind.Local).AddTicks(6766), null });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "ImageBytes" },
                values: new object[] { new DateTime(2024, 1, 26, 13, 44, 5, 392, DateTimeKind.Local).AddTicks(6770), new DateTime(2024, 1, 26, 13, 44, 5, 392, DateTimeKind.Local).AddTicks(6770), null });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 1, 26, 13, 44, 5, 392, DateTimeKind.Local).AddTicks(7161), new DateTime(2024, 1, 26, 13, 44, 5, 392, DateTimeKind.Local).AddTicks(7161), new DateTime(2024, 1, 26, 13, 44, 5, 392, DateTimeKind.Local).AddTicks(7160) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 1, 26, 13, 44, 5, 392, DateTimeKind.Local).AddTicks(7163), new DateTime(2024, 1, 26, 13, 44, 5, 392, DateTimeKind.Local).AddTicks(7164), new DateTime(2024, 1, 26, 13, 44, 5, 392, DateTimeKind.Local).AddTicks(7162) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 13, 44, 5, 205, DateTimeKind.Local).AddTicks(2137), new DateTime(2024, 1, 26, 13, 44, 5, 205, DateTimeKind.Local).AddTicks(2138) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 13, 44, 5, 205, DateTimeKind.Local).AddTicks(2140), new DateTime(2024, 1, 26, 13, 44, 5, 205, DateTimeKind.Local).AddTicks(2141) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 5, 44, 5, 392, DateTimeKind.Utc).AddTicks(7487), new DateTime(2024, 1, 26, 5, 44, 5, 392, DateTimeKind.Utc).AddTicks(7488) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 5, 44, 5, 392, DateTimeKind.Utc).AddTicks(7489), new DateTime(2024, 1, 26, 5, 44, 5, 392, DateTimeKind.Utc).AddTicks(7490) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 13, 44, 5, 205, DateTimeKind.Local).AddTicks(1987), new DateTime(2024, 1, 26, 13, 44, 5, 205, DateTimeKind.Local).AddTicks(1988) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 13, 44, 5, 205, DateTimeKind.Local).AddTicks(1989), new DateTime(2024, 1, 26, 13, 44, 5, 205, DateTimeKind.Local).AddTicks(1990) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 13, 44, 5, 392, DateTimeKind.Local).AddTicks(7728), new DateTime(2024, 1, 26, 13, 44, 5, 392, DateTimeKind.Local).AddTicks(7728) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 13, 44, 5, 392, DateTimeKind.Local).AddTicks(7730), new DateTime(2024, 1, 26, 13, 44, 5, 392, DateTimeKind.Local).AddTicks(7731) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "ImageByte" },
                values: new object[] { new DateTime(2024, 1, 26, 13, 44, 5, 205, DateTimeKind.Local).AddTicks(2889), new DateTime(2024, 1, 26, 13, 44, 5, 205, DateTimeKind.Local).AddTicks(2890), null });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "ImageByte" },
                values: new object[] { new DateTime(2024, 1, 26, 13, 44, 5, 205, DateTimeKind.Local).AddTicks(2892), new DateTime(2024, 1, 26, 13, 44, 5, 205, DateTimeKind.Local).AddTicks(2892), null });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 13, 44, 5, 205, DateTimeKind.Local).AddTicks(1635), new DateTime(2024, 1, 26, 13, 44, 5, 205, DateTimeKind.Local).AddTicks(1648) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 13, 44, 5, 205, DateTimeKind.Local).AddTicks(1650), new DateTime(2024, 1, 26, 13, 44, 5, 205, DateTimeKind.Local).AddTicks(1651) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 13, 44, 5, 392, DateTimeKind.Local).AddTicks(6981), new DateTime(2024, 1, 26, 13, 44, 5, 392, DateTimeKind.Local).AddTicks(6980), new DateTime(2024, 1, 26, 13, 44, 5, 392, DateTimeKind.Local).AddTicks(6976), new DateTime(2024, 1, 26, 13, 44, 5, 392, DateTimeKind.Local).AddTicks(6981) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 13, 44, 5, 392, DateTimeKind.Local).AddTicks(6984), new DateTime(2024, 1, 26, 13, 44, 5, 392, DateTimeKind.Local).AddTicks(6984), new DateTime(2024, 1, 26, 13, 44, 5, 392, DateTimeKind.Local).AddTicks(6983), new DateTime(2024, 1, 26, 13, 44, 5, 392, DateTimeKind.Local).AddTicks(6985) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageByte",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "ImageBytes",
                table: "Customers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1507dbd1-1c83-4ad2-9b0e-4d298c7b4521",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39433044-d854-452e-8721-8100daf27315", "AQAAAAIAAYagAAAAEMjIrKCdYfcAKi0R1/T15X4I1Fv83VUK7/09eM/wzFpIKEFIu7fmM3m7s7U87F9bgg==", "c033a70d-611e-4293-be8c-e433d8729d3a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41624b27-7496-447c-b299-4892483d6b47",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d8ac11e-914b-4ca9-8008-3324db8e964f", "AQAAAAIAAYagAAAAECwjZH67LpcX/dVfrVgruO6LkGXERYYRPQhfysWYAidU5hFI0dgLv+UmrJEusVDLkQ==", "c9e4312a-4622-4c8b-a2e5-7fdfd57532db" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d3dfcba-a0af-4b10-989d-d63dcfec5e97",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "04b57413-a098-47cf-aa90-a8f63670ea70", "AQAAAAIAAYagAAAAECGA6QB/E46DHpRIWFvTcBCe76aK9Moppwx+BrNrbXJ6yIEogN/3dVICnAzua+uNkg==", "11eefa20-9836-45e3-8d4a-3d34fcfad726" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8aa738a7-6c07-4e5a-8a7f-5637388c41b4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3bfdb4a4-d128-4569-bfc6-2852482c0a89", "AQAAAAIAAYagAAAAEOob69gOS179zoquhJWIcxxw+9iWCqzPzY9Oj6/VYxmJ6FnOCe7xb9CsOZfxA9DnkA==", "73564ec4-e7f8-405b-8f60-34f128cb04d5" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 22, 44, 35, 820, DateTimeKind.Local).AddTicks(9208), new DateTime(2024, 1, 25, 22, 44, 35, 820, DateTimeKind.Local).AddTicks(9208) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 22, 44, 35, 820, DateTimeKind.Local).AddTicks(9210), new DateTime(2024, 1, 25, 22, 44, 35, 820, DateTimeKind.Local).AddTicks(9213) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 22, 44, 36, 8, DateTimeKind.Local).AddTicks(4073), new DateTime(2024, 1, 25, 22, 44, 36, 8, DateTimeKind.Local).AddTicks(4086) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 22, 44, 36, 8, DateTimeKind.Local).AddTicks(4090), new DateTime(2024, 1, 25, 22, 44, 36, 8, DateTimeKind.Local).AddTicks(4091) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 1, 25, 22, 44, 36, 8, DateTimeKind.Local).AddTicks(4579), new DateTime(2024, 1, 25, 22, 44, 36, 8, DateTimeKind.Local).AddTicks(4580), new DateTime(2024, 1, 25, 22, 44, 36, 8, DateTimeKind.Local).AddTicks(4578) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 1, 25, 22, 44, 36, 8, DateTimeKind.Local).AddTicks(4582), new DateTime(2024, 1, 25, 22, 44, 36, 8, DateTimeKind.Local).AddTicks(4582), new DateTime(2024, 1, 25, 22, 44, 36, 8, DateTimeKind.Local).AddTicks(4581) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 22, 44, 35, 820, DateTimeKind.Local).AddTicks(9565), new DateTime(2024, 1, 25, 22, 44, 35, 820, DateTimeKind.Local).AddTicks(9566) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 22, 44, 35, 820, DateTimeKind.Local).AddTicks(9568), new DateTime(2024, 1, 25, 22, 44, 35, 820, DateTimeKind.Local).AddTicks(9569) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 14, 44, 36, 8, DateTimeKind.Utc).AddTicks(4795), new DateTime(2024, 1, 25, 14, 44, 36, 8, DateTimeKind.Utc).AddTicks(4796) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 14, 44, 36, 8, DateTimeKind.Utc).AddTicks(4797), new DateTime(2024, 1, 25, 14, 44, 36, 8, DateTimeKind.Utc).AddTicks(4797) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 22, 44, 35, 820, DateTimeKind.Local).AddTicks(9402), new DateTime(2024, 1, 25, 22, 44, 35, 820, DateTimeKind.Local).AddTicks(9403) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 22, 44, 35, 820, DateTimeKind.Local).AddTicks(9404), new DateTime(2024, 1, 25, 22, 44, 35, 820, DateTimeKind.Local).AddTicks(9405) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 22, 44, 36, 8, DateTimeKind.Local).AddTicks(5099), new DateTime(2024, 1, 25, 22, 44, 36, 8, DateTimeKind.Local).AddTicks(5100) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 22, 44, 36, 8, DateTimeKind.Local).AddTicks(5102), new DateTime(2024, 1, 25, 22, 44, 36, 8, DateTimeKind.Local).AddTicks(5102) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 22, 44, 35, 821, DateTimeKind.Local).AddTicks(454), new DateTime(2024, 1, 25, 22, 44, 35, 821, DateTimeKind.Local).AddTicks(456) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 22, 44, 35, 821, DateTimeKind.Local).AddTicks(458), new DateTime(2024, 1, 25, 22, 44, 35, 821, DateTimeKind.Local).AddTicks(459) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 22, 44, 35, 820, DateTimeKind.Local).AddTicks(9026), new DateTime(2024, 1, 25, 22, 44, 35, 820, DateTimeKind.Local).AddTicks(9037) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 22, 44, 35, 820, DateTimeKind.Local).AddTicks(9040), new DateTime(2024, 1, 25, 22, 44, 35, 820, DateTimeKind.Local).AddTicks(9041) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 22, 44, 36, 8, DateTimeKind.Local).AddTicks(4335), new DateTime(2024, 1, 25, 22, 44, 36, 8, DateTimeKind.Local).AddTicks(4334), new DateTime(2024, 1, 25, 22, 44, 36, 8, DateTimeKind.Local).AddTicks(4333), new DateTime(2024, 1, 25, 22, 44, 36, 8, DateTimeKind.Local).AddTicks(4335) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 22, 44, 36, 8, DateTimeKind.Local).AddTicks(4341), new DateTime(2024, 1, 25, 22, 44, 36, 8, DateTimeKind.Local).AddTicks(4340), new DateTime(2024, 1, 25, 22, 44, 36, 8, DateTimeKind.Local).AddTicks(4340), new DateTime(2024, 1, 25, 22, 44, 36, 8, DateTimeKind.Local).AddTicks(4341) });
        }
    }
}
