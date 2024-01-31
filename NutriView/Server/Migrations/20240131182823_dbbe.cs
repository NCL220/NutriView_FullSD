using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NutriView.Server.Migrations
{
    /// <inheritdoc />
    public partial class dbbe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Mission",
                table: "Companies",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CompanyName",
                table: "Companies",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CompanyDescription",
                table: "Companies",
                type: "nvarchar(1000)",
                maxLength: 1000,
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Mission",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "CompanyName",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "CompanyDescription",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1507dbd1-1c83-4ad2-9b0e-4d298c7b4521",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c88dff57-af68-4415-8857-ed669e244cc1", "AQAAAAIAAYagAAAAEFQFo6J5h1jJGW4GCw/tiHgodmUOv452OVjVeMEdnZymV9fZRB3+YThPl+eNWCqbeQ==", "5ebd16bd-7b52-4a08-b396-8cc50b2dcd29" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41624b27-7496-447c-b299-4892483d6b47",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "25849cd3-04b2-48a3-8ec2-076c1016317a", "AQAAAAIAAYagAAAAEL7I3/r3I5P11hEEcDB1+x8vVNaCt8g0Q4C+rTNs7+xwOC7YCSJ3+NBjmlL+6QhpWw==", "abf85264-1e48-4d28-b225-e3bcd86c94fb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d3dfcba-a0af-4b10-989d-d63dcfec5e97",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a02d6dc-d5d3-448c-8a65-65b58399f6db", "AQAAAAIAAYagAAAAEIbO1zCixXK8HZ/CrkpZ0S/Cr2wcdwLBTnoCsrUdq4Hac9n0Oxwmk7fiIXpxDGpwqg==", "10750f8e-4f2e-40b9-97e7-6a9f123103b8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8aa738a7-6c07-4e5a-8a7f-5637388c41b4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b872e30a-716f-4ef6-a583-ceba590d3e61", "AQAAAAIAAYagAAAAEN32FCIpab0/u//5fYMYA2S1qzE0m2feNJ6rw8dU8iwg1F8G+aSI4Pv6c/s5+h91xw==", "39eb4553-94f4-4527-b08e-66b18754f4ee" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 22, 40, 612, DateTimeKind.Local).AddTicks(5338), new DateTime(2024, 2, 1, 2, 22, 40, 612, DateTimeKind.Local).AddTicks(5338) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 22, 40, 612, DateTimeKind.Local).AddTicks(5341), new DateTime(2024, 2, 1, 2, 22, 40, 612, DateTimeKind.Local).AddTicks(5342) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 22, 40, 813, DateTimeKind.Local).AddTicks(1127), new DateTime(2024, 2, 1, 2, 22, 40, 813, DateTimeKind.Local).AddTicks(1146) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 22, 40, 813, DateTimeKind.Local).AddTicks(1153), new DateTime(2024, 2, 1, 2, 22, 40, 813, DateTimeKind.Local).AddTicks(1154) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 22, 40, 813, DateTimeKind.Local).AddTicks(1737), new DateTime(2024, 2, 1, 2, 22, 40, 813, DateTimeKind.Local).AddTicks(1738), new DateTime(2024, 2, 1, 2, 22, 40, 813, DateTimeKind.Local).AddTicks(1736) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 22, 40, 813, DateTimeKind.Local).AddTicks(1741), new DateTime(2024, 2, 1, 2, 22, 40, 813, DateTimeKind.Local).AddTicks(1741), new DateTime(2024, 2, 1, 2, 22, 40, 813, DateTimeKind.Local).AddTicks(1740) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 22, 40, 612, DateTimeKind.Local).AddTicks(5718), new DateTime(2024, 2, 1, 2, 22, 40, 612, DateTimeKind.Local).AddTicks(5719) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 22, 40, 612, DateTimeKind.Local).AddTicks(5721), new DateTime(2024, 2, 1, 2, 22, 40, 612, DateTimeKind.Local).AddTicks(5721) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 18, 22, 40, 813, DateTimeKind.Utc).AddTicks(2234), new DateTime(2024, 1, 31, 18, 22, 40, 813, DateTimeKind.Utc).AddTicks(2235) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 18, 22, 40, 813, DateTimeKind.Utc).AddTicks(2237), new DateTime(2024, 1, 31, 18, 22, 40, 813, DateTimeKind.Utc).AddTicks(2237) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 22, 40, 612, DateTimeKind.Local).AddTicks(5539), new DateTime(2024, 2, 1, 2, 22, 40, 612, DateTimeKind.Local).AddTicks(5539) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 22, 40, 612, DateTimeKind.Local).AddTicks(5541), new DateTime(2024, 2, 1, 2, 22, 40, 612, DateTimeKind.Local).AddTicks(5541) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 22, 40, 813, DateTimeKind.Local).AddTicks(2601), new DateTime(2024, 2, 1, 2, 22, 40, 813, DateTimeKind.Local).AddTicks(2602) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 22, 40, 813, DateTimeKind.Local).AddTicks(2604), new DateTime(2024, 2, 1, 2, 22, 40, 813, DateTimeKind.Local).AddTicks(2605) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 22, 40, 612, DateTimeKind.Local).AddTicks(6235), new DateTime(2024, 2, 1, 2, 22, 40, 612, DateTimeKind.Local).AddTicks(6236) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 22, 40, 612, DateTimeKind.Local).AddTicks(6239), new DateTime(2024, 2, 1, 2, 22, 40, 612, DateTimeKind.Local).AddTicks(6239) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 22, 40, 612, DateTimeKind.Local).AddTicks(4558), new DateTime(2024, 2, 1, 2, 22, 40, 612, DateTimeKind.Local).AddTicks(4570) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 22, 40, 612, DateTimeKind.Local).AddTicks(4574), new DateTime(2024, 2, 1, 2, 22, 40, 612, DateTimeKind.Local).AddTicks(4575) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 22, 40, 813, DateTimeKind.Local).AddTicks(1477), new DateTime(2024, 2, 1, 2, 22, 40, 813, DateTimeKind.Local).AddTicks(1476), new DateTime(2024, 2, 1, 2, 22, 40, 813, DateTimeKind.Local).AddTicks(1475), new DateTime(2024, 2, 1, 2, 22, 40, 813, DateTimeKind.Local).AddTicks(1478) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 22, 40, 813, DateTimeKind.Local).AddTicks(1481), new DateTime(2024, 2, 1, 2, 22, 40, 813, DateTimeKind.Local).AddTicks(1481), new DateTime(2024, 2, 1, 2, 22, 40, 813, DateTimeKind.Local).AddTicks(1480), new DateTime(2024, 2, 1, 2, 22, 40, 813, DateTimeKind.Local).AddTicks(1482) });
        }
    }
}
