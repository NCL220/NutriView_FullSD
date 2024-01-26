using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NutriView.Server.Migrations
{
    /// <inheritdoc />
    public partial class changedb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePathStaff",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "CompanyImagePath",
                table: "Companies");

            migrationBuilder.AddColumn<byte[]>(
                name: "CompanyImageByte",
                table: "Companies",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1507dbd1-1c83-4ad2-9b0e-4d298c7b4521",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d5fe8286-8547-4a04-a176-8d523a914368", "AQAAAAIAAYagAAAAEBC99lilHfqK3UnWqaXOZEb6I3EPMBzqTfAYLxmD6mNh/VUKwOOW17FpXqlur0vEzQ==", "3fc78ffc-5628-486c-b537-dcf48b4936e2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41624b27-7496-447c-b299-4892483d6b47",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "68015bea-f102-4444-b7c2-a2bfc9ff6e45", "AQAAAAIAAYagAAAAENm0+jMDdRqtufuGvrweiD/j/EqTZnN7eUCVCfjyEGtY4fPsk6o6+lS3mp5xuniKig==", "0441c518-4ee1-463d-a623-290a90026fd2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d3dfcba-a0af-4b10-989d-d63dcfec5e97",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "92ae5a89-04a5-4458-a940-28ba54639a7a", "AQAAAAIAAYagAAAAEKh4F7E84FoVIg7zkorqUWZym3k7xm0NgnQgxEzoyJXhdjQ8CyEwumm+SADpwkNPfg==", "d5ee5cd7-f3ab-4459-b552-406b436f8447" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8aa738a7-6c07-4e5a-8a7f-5637388c41b4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b77bc01-7e08-467b-9994-06bf96b4438c", "AQAAAAIAAYagAAAAEE1Xxf1Zd4npOMPeXMfZLDwkP5RePFLb5W3Ufbg1p8sL8A4PCWO1vObjpkdBhqv8Nw==", "2616a31c-086b-4359-84b0-0f5727675ac8" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CompanyImageByte", "DateCreated", "DateUpdated" },
                values: new object[] { null, new DateTime(2024, 1, 26, 23, 35, 40, 219, DateTimeKind.Local).AddTicks(3373), new DateTime(2024, 1, 26, 23, 35, 40, 219, DateTimeKind.Local).AddTicks(3374) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CompanyImageByte", "DateCreated", "DateUpdated" },
                values: new object[] { null, new DateTime(2024, 1, 26, 23, 35, 40, 219, DateTimeKind.Local).AddTicks(3377), new DateTime(2024, 1, 26, 23, 35, 40, 219, DateTimeKind.Local).AddTicks(3377) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 23, 35, 40, 407, DateTimeKind.Local).AddTicks(7292), new DateTime(2024, 1, 26, 23, 35, 40, 407, DateTimeKind.Local).AddTicks(7303) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 23, 35, 40, 407, DateTimeKind.Local).AddTicks(7306), new DateTime(2024, 1, 26, 23, 35, 40, 407, DateTimeKind.Local).AddTicks(7306) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 1, 26, 23, 35, 40, 407, DateTimeKind.Local).AddTicks(7725), new DateTime(2024, 1, 26, 23, 35, 40, 407, DateTimeKind.Local).AddTicks(7726), new DateTime(2024, 1, 26, 23, 35, 40, 407, DateTimeKind.Local).AddTicks(7724) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 1, 26, 23, 35, 40, 407, DateTimeKind.Local).AddTicks(7728), new DateTime(2024, 1, 26, 23, 35, 40, 407, DateTimeKind.Local).AddTicks(7728), new DateTime(2024, 1, 26, 23, 35, 40, 407, DateTimeKind.Local).AddTicks(7727) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 23, 35, 40, 219, DateTimeKind.Local).AddTicks(3711), new DateTime(2024, 1, 26, 23, 35, 40, 219, DateTimeKind.Local).AddTicks(3711) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 23, 35, 40, 219, DateTimeKind.Local).AddTicks(3713), new DateTime(2024, 1, 26, 23, 35, 40, 219, DateTimeKind.Local).AddTicks(3714) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 15, 35, 40, 407, DateTimeKind.Utc).AddTicks(8053), new DateTime(2024, 1, 26, 15, 35, 40, 407, DateTimeKind.Utc).AddTicks(8054) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 15, 35, 40, 407, DateTimeKind.Utc).AddTicks(8056), new DateTime(2024, 1, 26, 15, 35, 40, 407, DateTimeKind.Utc).AddTicks(8056) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 23, 35, 40, 219, DateTimeKind.Local).AddTicks(3546), new DateTime(2024, 1, 26, 23, 35, 40, 219, DateTimeKind.Local).AddTicks(3547) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 23, 35, 40, 219, DateTimeKind.Local).AddTicks(3548), new DateTime(2024, 1, 26, 23, 35, 40, 219, DateTimeKind.Local).AddTicks(3549) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 23, 35, 40, 407, DateTimeKind.Local).AddTicks(8280), new DateTime(2024, 1, 26, 23, 35, 40, 407, DateTimeKind.Local).AddTicks(8281) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 23, 35, 40, 407, DateTimeKind.Local).AddTicks(8282), new DateTime(2024, 1, 26, 23, 35, 40, 407, DateTimeKind.Local).AddTicks(8283) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 23, 35, 40, 219, DateTimeKind.Local).AddTicks(4464), new DateTime(2024, 1, 26, 23, 35, 40, 219, DateTimeKind.Local).AddTicks(4465) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 23, 35, 40, 219, DateTimeKind.Local).AddTicks(4467), new DateTime(2024, 1, 26, 23, 35, 40, 219, DateTimeKind.Local).AddTicks(4467) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 23, 35, 40, 219, DateTimeKind.Local).AddTicks(3157), new DateTime(2024, 1, 26, 23, 35, 40, 219, DateTimeKind.Local).AddTicks(3166) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 23, 35, 40, 219, DateTimeKind.Local).AddTicks(3168), new DateTime(2024, 1, 26, 23, 35, 40, 219, DateTimeKind.Local).AddTicks(3169) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 23, 35, 40, 407, DateTimeKind.Local).AddTicks(7539), new DateTime(2024, 1, 26, 23, 35, 40, 407, DateTimeKind.Local).AddTicks(7538), new DateTime(2024, 1, 26, 23, 35, 40, 407, DateTimeKind.Local).AddTicks(7537), new DateTime(2024, 1, 26, 23, 35, 40, 407, DateTimeKind.Local).AddTicks(7540) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 23, 35, 40, 407, DateTimeKind.Local).AddTicks(7542), new DateTime(2024, 1, 26, 23, 35, 40, 407, DateTimeKind.Local).AddTicks(7542), new DateTime(2024, 1, 26, 23, 35, 40, 407, DateTimeKind.Local).AddTicks(7541), new DateTime(2024, 1, 26, 23, 35, 40, 407, DateTimeKind.Local).AddTicks(7543) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyImageByte",
                table: "Companies");

            migrationBuilder.AddColumn<string>(
                name: "ImagePathStaff",
                table: "Staffs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompanyImagePath",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: true);

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
                columns: new[] { "CompanyImagePath", "DateCreated", "DateUpdated" },
                values: new object[] { "Not Yet Available", new DateTime(2024, 1, 26, 18, 11, 7, 50, DateTimeKind.Local).AddTicks(5576), new DateTime(2024, 1, 26, 18, 11, 7, 50, DateTimeKind.Local).AddTicks(5578) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CompanyImagePath", "DateCreated", "DateUpdated" },
                values: new object[] { "Not Yet Available", new DateTime(2024, 1, 26, 18, 11, 7, 50, DateTimeKind.Local).AddTicks(5579), new DateTime(2024, 1, 26, 18, 11, 7, 50, DateTimeKind.Local).AddTicks(5580) });

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
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 10, 11, 7, 237, DateTimeKind.Utc).AddTicks(4176), new DateTime(2024, 1, 26, 10, 11, 7, 237, DateTimeKind.Utc).AddTicks(4177) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 10, 11, 7, 237, DateTimeKind.Utc).AddTicks(4178), new DateTime(2024, 1, 26, 10, 11, 7, 237, DateTimeKind.Utc).AddTicks(4179) });

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
                columns: new[] { "DateCreated", "DateUpdated", "ImagePathStaff" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 7, 50, DateTimeKind.Local).AddTicks(6553), new DateTime(2024, 1, 26, 18, 11, 7, 50, DateTimeKind.Local).AddTicks(6554), "-" });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "ImagePathStaff" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 7, 50, DateTimeKind.Local).AddTicks(6556), new DateTime(2024, 1, 26, 18, 11, 7, 50, DateTimeKind.Local).AddTicks(6557), "-" });

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
    }
}
