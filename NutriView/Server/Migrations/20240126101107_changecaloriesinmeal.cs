using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NutriView.Server.Migrations
{
    /// <inheritdoc />
    public partial class changecaloriesinmeal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Calories",
                table: "Meals",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1507dbd1-1c83-4ad2-9b0e-4d298c7b4521",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "72e06e4d-7a7c-4c3f-8d1b-c5196ca23d72", "AQAAAAIAAYagAAAAEEd4xcK+9yWQWfpfAWVdCreqxua+uCiPvxvAd5V9+nr3rm4XN0yhLKgldp60mDGofg==", "54cb44d5-3852-4015-be28-f8dcd89594c8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41624b27-7496-447c-b299-4892483d6b47",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "971ee8ba-eb87-471c-8c6d-841dd58ab8fc", "AQAAAAIAAYagAAAAEMAime59uSAZYyv8DZsPZEdH5vsWZx+2AcNx0MipFb7lnG2fEK4gBJIl3018gPyMYw==", "c0c8529a-a94b-4a85-a1ca-71df6bc2f56d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d3dfcba-a0af-4b10-989d-d63dcfec5e97",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d5b06c43-4284-4278-8872-767092679bd8", "AQAAAAIAAYagAAAAEBN7U6xCfKp94l24mhmnDvxBJpuPC2bn2dSBfk+i3Ts0LZ+VG4s0Qr9K7exnGsItNg==", "5e245b99-d6b7-499a-950a-4a30988224d3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8aa738a7-6c07-4e5a-8a7f-5637388c41b4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "afeefeb7-b6c9-45e7-a4f0-087aa6f732c6", "AQAAAAIAAYagAAAAED7gHJNBNnBMUx8j9d9zaYTQdC2VuHtZSNw2eYbBVZ0PDsnklri671+uYnLWily7Eg==", "3712e70a-d21a-4596-b5ef-164cf90dfcb1" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 7, 50, DateTimeKind.Local).AddTicks(5576), new DateTime(2024, 1, 26, 18, 11, 7, 50, DateTimeKind.Local).AddTicks(5578) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 7, 50, DateTimeKind.Local).AddTicks(5579), new DateTime(2024, 1, 26, 18, 11, 7, 50, DateTimeKind.Local).AddTicks(5580) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 7, 237, DateTimeKind.Local).AddTicks(3386), new DateTime(2024, 1, 26, 18, 11, 7, 237, DateTimeKind.Local).AddTicks(3400) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 7, 237, DateTimeKind.Local).AddTicks(3405), new DateTime(2024, 1, 26, 18, 11, 7, 237, DateTimeKind.Local).AddTicks(3406) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 7, 237, DateTimeKind.Local).AddTicks(3811), new DateTime(2024, 1, 26, 18, 11, 7, 237, DateTimeKind.Local).AddTicks(3811), new DateTime(2024, 1, 26, 18, 11, 7, 237, DateTimeKind.Local).AddTicks(3810) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 7, 237, DateTimeKind.Local).AddTicks(3813), new DateTime(2024, 1, 26, 18, 11, 7, 237, DateTimeKind.Local).AddTicks(3814), new DateTime(2024, 1, 26, 18, 11, 7, 237, DateTimeKind.Local).AddTicks(3813) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 7, 50, DateTimeKind.Local).AddTicks(5891), new DateTime(2024, 1, 26, 18, 11, 7, 50, DateTimeKind.Local).AddTicks(5892) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 7, 50, DateTimeKind.Local).AddTicks(5895), new DateTime(2024, 1, 26, 18, 11, 7, 50, DateTimeKind.Local).AddTicks(5895) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Calories", "DateCreated", "DateUpdated" },
                values: new object[] { 0.0, new DateTime(2024, 1, 26, 10, 11, 7, 237, DateTimeKind.Utc).AddTicks(4176), new DateTime(2024, 1, 26, 10, 11, 7, 237, DateTimeKind.Utc).AddTicks(4177) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Calories", "DateCreated", "DateUpdated" },
                values: new object[] { 0.0, new DateTime(2024, 1, 26, 10, 11, 7, 237, DateTimeKind.Utc).AddTicks(4178), new DateTime(2024, 1, 26, 10, 11, 7, 237, DateTimeKind.Utc).AddTicks(4179) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 7, 50, DateTimeKind.Local).AddTicks(5732), new DateTime(2024, 1, 26, 18, 11, 7, 50, DateTimeKind.Local).AddTicks(5733) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 7, 50, DateTimeKind.Local).AddTicks(5735), new DateTime(2024, 1, 26, 18, 11, 7, 50, DateTimeKind.Local).AddTicks(5735) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 7, 237, DateTimeKind.Local).AddTicks(4430), new DateTime(2024, 1, 26, 18, 11, 7, 237, DateTimeKind.Local).AddTicks(4431) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 7, 237, DateTimeKind.Local).AddTicks(4432), new DateTime(2024, 1, 26, 18, 11, 7, 237, DateTimeKind.Local).AddTicks(4433) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 7, 50, DateTimeKind.Local).AddTicks(6553), new DateTime(2024, 1, 26, 18, 11, 7, 50, DateTimeKind.Local).AddTicks(6554) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 7, 50, DateTimeKind.Local).AddTicks(6556), new DateTime(2024, 1, 26, 18, 11, 7, 50, DateTimeKind.Local).AddTicks(6557) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 7, 50, DateTimeKind.Local).AddTicks(5391), new DateTime(2024, 1, 26, 18, 11, 7, 50, DateTimeKind.Local).AddTicks(5402) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 7, 50, DateTimeKind.Local).AddTicks(5404), new DateTime(2024, 1, 26, 18, 11, 7, 50, DateTimeKind.Local).AddTicks(5404) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 7, 237, DateTimeKind.Local).AddTicks(3625), new DateTime(2024, 1, 26, 18, 11, 7, 237, DateTimeKind.Local).AddTicks(3624), new DateTime(2024, 1, 26, 18, 11, 7, 237, DateTimeKind.Local).AddTicks(3623), new DateTime(2024, 1, 26, 18, 11, 7, 237, DateTimeKind.Local).AddTicks(3625) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 7, 237, DateTimeKind.Local).AddTicks(3627), new DateTime(2024, 1, 26, 18, 11, 7, 237, DateTimeKind.Local).AddTicks(3627), new DateTime(2024, 1, 26, 18, 11, 7, 237, DateTimeKind.Local).AddTicks(3627), new DateTime(2024, 1, 26, 18, 11, 7, 237, DateTimeKind.Local).AddTicks(3628) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Calories",
                table: "Meals",
                type: "int",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

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
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 13, 44, 5, 392, DateTimeKind.Local).AddTicks(6755), new DateTime(2024, 1, 26, 13, 44, 5, 392, DateTimeKind.Local).AddTicks(6766) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 13, 44, 5, 392, DateTimeKind.Local).AddTicks(6770), new DateTime(2024, 1, 26, 13, 44, 5, 392, DateTimeKind.Local).AddTicks(6770) });

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
                columns: new[] { "Calories", "DateCreated", "DateUpdated" },
                values: new object[] { null, new DateTime(2024, 1, 26, 5, 44, 5, 392, DateTimeKind.Utc).AddTicks(7487), new DateTime(2024, 1, 26, 5, 44, 5, 392, DateTimeKind.Utc).AddTicks(7488) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Calories", "DateCreated", "DateUpdated" },
                values: new object[] { null, new DateTime(2024, 1, 26, 5, 44, 5, 392, DateTimeKind.Utc).AddTicks(7489), new DateTime(2024, 1, 26, 5, 44, 5, 392, DateTimeKind.Utc).AddTicks(7490) });

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
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 13, 44, 5, 205, DateTimeKind.Local).AddTicks(2889), new DateTime(2024, 1, 26, 13, 44, 5, 205, DateTimeKind.Local).AddTicks(2890) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 13, 44, 5, 205, DateTimeKind.Local).AddTicks(2892), new DateTime(2024, 1, 26, 13, 44, 5, 205, DateTimeKind.Local).AddTicks(2892) });

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
    }
}
