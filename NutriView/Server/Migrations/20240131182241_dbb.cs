using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NutriView.Server.Migrations
{
    /// <inheritdoc />
    public partial class dbb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "283a416f-6fe2-40d8-8f32-e2d78fa6f365", "AQAAAAIAAYagAAAAEEnq81hGKVIOs56UUGMHpFQ+BAnvlR6vSLPk8fkJg5NWTjjSfNjENhqWXtIiXoFetA==", "2ecd5e2c-59a2-4e4d-a63c-d59e70d47049" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41624b27-7496-447c-b299-4892483d6b47",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d963a321-9aea-4c63-9828-572d09379c01", "AQAAAAIAAYagAAAAELsNJVQs8UohMzpkpGdIsr0fpVGc2PzFJEojtoAdd9NXrAxnYMwXyq2qmye1Y217Mg==", "989e6e16-6b41-46a7-9a66-09a1e029a963" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d3dfcba-a0af-4b10-989d-d63dcfec5e97",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bd3497b3-e89f-4e53-82ab-632d9dd8194d", "AQAAAAIAAYagAAAAENI6JS1XyiV8I9AmK4lsGYeAadG+0ghHD/xcCFJEJsNf+ni1eBxa79T7Iaa5t8Uogw==", "4554f24c-5e6b-45ad-b6e7-2c79857612bd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8aa738a7-6c07-4e5a-8a7f-5637388c41b4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "195aa3f0-225b-4938-a299-20d611f91ae8", "AQAAAAIAAYagAAAAEGyWj0JDzzKNDWK/mMvOqdSJ5CyP3b5HJ1QGKsJ4bx/3BLVLudnlypncBdMW8qOGwQ==", "9831f096-29b7-4b33-bc0b-bd4e82828d3f" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 9, 19, 20, 850, DateTimeKind.Local).AddTicks(7506), new DateTime(2024, 1, 31, 9, 19, 20, 850, DateTimeKind.Local).AddTicks(7507) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 9, 19, 20, 850, DateTimeKind.Local).AddTicks(7513), new DateTime(2024, 1, 31, 9, 19, 20, 850, DateTimeKind.Local).AddTicks(7514) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 9, 19, 21, 66, DateTimeKind.Local).AddTicks(3348), new DateTime(2024, 1, 31, 9, 19, 21, 66, DateTimeKind.Local).AddTicks(3375) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 9, 19, 21, 66, DateTimeKind.Local).AddTicks(3381), new DateTime(2024, 1, 31, 9, 19, 21, 66, DateTimeKind.Local).AddTicks(3382) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 1, 31, 9, 19, 21, 66, DateTimeKind.Local).AddTicks(4042), new DateTime(2024, 1, 31, 9, 19, 21, 66, DateTimeKind.Local).AddTicks(4045), new DateTime(2024, 1, 31, 9, 19, 21, 66, DateTimeKind.Local).AddTicks(4041) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 1, 31, 9, 19, 21, 66, DateTimeKind.Local).AddTicks(4049), new DateTime(2024, 1, 31, 9, 19, 21, 66, DateTimeKind.Local).AddTicks(4050), new DateTime(2024, 1, 31, 9, 19, 21, 66, DateTimeKind.Local).AddTicks(4048) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 9, 19, 20, 850, DateTimeKind.Local).AddTicks(8592), new DateTime(2024, 1, 31, 9, 19, 20, 850, DateTimeKind.Local).AddTicks(8593) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 9, 19, 20, 850, DateTimeKind.Local).AddTicks(8596), new DateTime(2024, 1, 31, 9, 19, 20, 850, DateTimeKind.Local).AddTicks(8597) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 1, 19, 21, 66, DateTimeKind.Utc).AddTicks(4585), new DateTime(2024, 1, 31, 1, 19, 21, 66, DateTimeKind.Utc).AddTicks(4586) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 1, 19, 21, 66, DateTimeKind.Utc).AddTicks(4591), new DateTime(2024, 1, 31, 1, 19, 21, 66, DateTimeKind.Utc).AddTicks(4592) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 9, 19, 20, 850, DateTimeKind.Local).AddTicks(7792), new DateTime(2024, 1, 31, 9, 19, 20, 850, DateTimeKind.Local).AddTicks(7794) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 9, 19, 20, 850, DateTimeKind.Local).AddTicks(7796), new DateTime(2024, 1, 31, 9, 19, 20, 850, DateTimeKind.Local).AddTicks(7796) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 9, 19, 21, 66, DateTimeKind.Local).AddTicks(4907), new DateTime(2024, 1, 31, 9, 19, 21, 66, DateTimeKind.Local).AddTicks(4908) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 9, 19, 21, 66, DateTimeKind.Local).AddTicks(4912), new DateTime(2024, 1, 31, 9, 19, 21, 66, DateTimeKind.Local).AddTicks(4912) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 9, 19, 20, 850, DateTimeKind.Local).AddTicks(9201), new DateTime(2024, 1, 31, 9, 19, 20, 850, DateTimeKind.Local).AddTicks(9202) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 9, 19, 20, 850, DateTimeKind.Local).AddTicks(9206), new DateTime(2024, 1, 31, 9, 19, 20, 850, DateTimeKind.Local).AddTicks(9206) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 9, 19, 20, 850, DateTimeKind.Local).AddTicks(7276), new DateTime(2024, 1, 31, 9, 19, 20, 850, DateTimeKind.Local).AddTicks(7291) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 9, 19, 20, 850, DateTimeKind.Local).AddTicks(7294), new DateTime(2024, 1, 31, 9, 19, 20, 850, DateTimeKind.Local).AddTicks(7294) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 9, 19, 21, 66, DateTimeKind.Local).AddTicks(3656), new DateTime(2024, 1, 31, 9, 19, 21, 66, DateTimeKind.Local).AddTicks(3655), new DateTime(2024, 1, 31, 9, 19, 21, 66, DateTimeKind.Local).AddTicks(3653), new DateTime(2024, 1, 31, 9, 19, 21, 66, DateTimeKind.Local).AddTicks(3658) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 9, 19, 21, 66, DateTimeKind.Local).AddTicks(3660), new DateTime(2024, 1, 31, 9, 19, 21, 66, DateTimeKind.Local).AddTicks(3660), new DateTime(2024, 1, 31, 9, 19, 21, 66, DateTimeKind.Local).AddTicks(3659), new DateTime(2024, 1, 31, 9, 19, 21, 66, DateTimeKind.Local).AddTicks(3661) });
        }
    }
}
