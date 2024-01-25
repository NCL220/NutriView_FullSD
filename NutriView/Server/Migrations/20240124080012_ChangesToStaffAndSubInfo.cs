using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NutriView.Server.Migrations
{
    /// <inheritdoc />
    public partial class ChangesToStaffAndSubInfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SubMonthsDuration",
                table: "SubscriptionInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ManagerID",
                table: "Staffs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1507dbd1-1c83-4ad2-9b0e-4d298c7b4521",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "adb28f3b-67b6-475e-902a-228abae81aa9", "AQAAAAIAAYagAAAAEKnGpiuTaGOQrcmSA4k5ERfmfacOlCqH51Gf8W6rU7phP/BzTnleBLa0IQgIV7U19Q==", "2be24e3e-cf40-4151-9d5a-f4770aed2309" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41624b27-7496-447c-b299-4892483d6b47",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2494b20d-aef1-4853-9a96-4d95a96e849e", "AQAAAAIAAYagAAAAEDtierCsMQqri2xaJqv9SV+bkXef/ddBxF+FZ4x1wbiBUYcB3DIWa4xfnooi8IRBcw==", "6fbc9649-925b-4884-bb85-5eb3e88bd5e3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d3dfcba-a0af-4b10-989d-d63dcfec5e97",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "76598473-c0c7-43e2-87c1-6c37a22e5fad", "AQAAAAIAAYagAAAAEHRNC+FHaHvjxqYZexD6nOUJHvlS125OQoTk9MyNYgb/6MNqV07hZKzJPhQGrb8WYA==", "35bccdeb-b115-401d-a375-7865cd91aec9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8aa738a7-6c07-4e5a-8a7f-5637388c41b4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f2983bb-82cf-4fd4-b824-493b3cb5b3f1", "AQAAAAIAAYagAAAAEGe56dv08oj2LOKuXYTgnbNhqFgnCD2wo4KvV3UWsVuN9yj79TJquqk1BHHS6mKDTA==", "33e79a65-cfa5-49b5-a235-d6d3029ab297" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 16, 0, 12, 330, DateTimeKind.Local).AddTicks(1203), new DateTime(2024, 1, 24, 16, 0, 12, 330, DateTimeKind.Local).AddTicks(1204) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 16, 0, 12, 330, DateTimeKind.Local).AddTicks(1206), new DateTime(2024, 1, 24, 16, 0, 12, 330, DateTimeKind.Local).AddTicks(1213) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 16, 0, 12, 517, DateTimeKind.Local).AddTicks(6947), new DateTime(2024, 1, 24, 16, 0, 12, 517, DateTimeKind.Local).AddTicks(6960) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 16, 0, 12, 517, DateTimeKind.Local).AddTicks(6963), new DateTime(2024, 1, 24, 16, 0, 12, 517, DateTimeKind.Local).AddTicks(6964) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 1, 24, 16, 0, 12, 517, DateTimeKind.Local).AddTicks(7520), new DateTime(2024, 1, 24, 16, 0, 12, 517, DateTimeKind.Local).AddTicks(7521), new DateTime(2024, 1, 24, 16, 0, 12, 517, DateTimeKind.Local).AddTicks(7520) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 1, 24, 16, 0, 12, 517, DateTimeKind.Local).AddTicks(7523), new DateTime(2024, 1, 24, 16, 0, 12, 517, DateTimeKind.Local).AddTicks(7524), new DateTime(2024, 1, 24, 16, 0, 12, 517, DateTimeKind.Local).AddTicks(7523) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 16, 0, 12, 330, DateTimeKind.Local).AddTicks(1568), new DateTime(2024, 1, 24, 16, 0, 12, 330, DateTimeKind.Local).AddTicks(1569) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 16, 0, 12, 330, DateTimeKind.Local).AddTicks(1571), new DateTime(2024, 1, 24, 16, 0, 12, 330, DateTimeKind.Local).AddTicks(1572) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 8, 0, 12, 517, DateTimeKind.Utc).AddTicks(7767), new DateTime(2024, 1, 24, 8, 0, 12, 517, DateTimeKind.Utc).AddTicks(7768) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 8, 0, 12, 517, DateTimeKind.Utc).AddTicks(7769), new DateTime(2024, 1, 24, 8, 0, 12, 517, DateTimeKind.Utc).AddTicks(7770) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 16, 0, 12, 330, DateTimeKind.Local).AddTicks(1399), new DateTime(2024, 1, 24, 16, 0, 12, 330, DateTimeKind.Local).AddTicks(1400) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 16, 0, 12, 330, DateTimeKind.Local).AddTicks(1402), new DateTime(2024, 1, 24, 16, 0, 12, 330, DateTimeKind.Local).AddTicks(1402) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 16, 0, 12, 517, DateTimeKind.Local).AddTicks(8005), new DateTime(2024, 1, 24, 16, 0, 12, 517, DateTimeKind.Local).AddTicks(8006) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 16, 0, 12, 517, DateTimeKind.Local).AddTicks(8007), new DateTime(2024, 1, 24, 16, 0, 12, 517, DateTimeKind.Local).AddTicks(8008) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 16, 0, 12, 330, DateTimeKind.Local).AddTicks(1984), new DateTime(2024, 1, 24, 16, 0, 12, 330, DateTimeKind.Local).AddTicks(1984) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 16, 0, 12, 330, DateTimeKind.Local).AddTicks(1987), new DateTime(2024, 1, 24, 16, 0, 12, 330, DateTimeKind.Local).AddTicks(1987) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "SubMonthsDuration" },
                values: new object[] { new DateTime(2024, 1, 24, 16, 0, 12, 330, DateTimeKind.Local).AddTicks(964), new DateTime(2024, 1, 24, 16, 0, 12, 330, DateTimeKind.Local).AddTicks(978), null });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "SubMonthsDuration" },
                values: new object[] { new DateTime(2024, 1, 24, 16, 0, 12, 330, DateTimeKind.Local).AddTicks(982), new DateTime(2024, 1, 24, 16, 0, 12, 330, DateTimeKind.Local).AddTicks(982), null });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 16, 0, 12, 517, DateTimeKind.Local).AddTicks(7300), new DateTime(2024, 1, 24, 16, 0, 12, 517, DateTimeKind.Local).AddTicks(7300), new DateTime(2024, 1, 24, 16, 0, 12, 517, DateTimeKind.Local).AddTicks(7299), new DateTime(2024, 1, 24, 16, 0, 12, 517, DateTimeKind.Local).AddTicks(7301) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 16, 0, 12, 517, DateTimeKind.Local).AddTicks(7303), new DateTime(2024, 1, 24, 16, 0, 12, 517, DateTimeKind.Local).AddTicks(7303), new DateTime(2024, 1, 24, 16, 0, 12, 517, DateTimeKind.Local).AddTicks(7302), new DateTime(2024, 1, 24, 16, 0, 12, 517, DateTimeKind.Local).AddTicks(7303) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SubMonthsDuration",
                table: "SubscriptionInfos");

            migrationBuilder.AlterColumn<int>(
                name: "ManagerID",
                table: "Staffs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1507dbd1-1c83-4ad2-9b0e-4d298c7b4521",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "13915a1e-5879-4b27-90a9-73589ef15c34", "AQAAAAIAAYagAAAAELNFqVEpYBiSL8W+7E3FXt3+fMcyfEw3r2DWNrUKUrJvjU9AsSCAsbvEtIWsQPqp/A==", "f4765405-0b67-40b0-ba18-57d861bae181" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41624b27-7496-447c-b299-4892483d6b47",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5863d42-9568-4e3a-b693-ab1b478a42ce", "AQAAAAIAAYagAAAAECqsPphiAcMKdXSxMYpR2AF7VZzUEJyCvv0GHa/iiPVfVegzFBuBcb5Atk3BPPFd6g==", "b76aa051-6ab6-410d-b761-e3f5ec61cac8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d3dfcba-a0af-4b10-989d-d63dcfec5e97",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ef9a919-eea9-4f30-ac49-12a7feede3e8", "AQAAAAIAAYagAAAAED2GHA0II53Vm7XctJOxsziajeU4VU8cYxILD4q24zKVx9YY6Rod3kS75wapE7K4Ww==", "8ca8cbb0-b0b6-454c-9ba7-65b88076ed9c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8aa738a7-6c07-4e5a-8a7f-5637388c41b4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "345eb58e-2f87-4cfa-8195-85b8d98489de", "AQAAAAIAAYagAAAAEA6mH1n81xK0PkGzq85RnDVuONOEWot5AM8cSLmb+4P9wgdD3DhUVmfkNzBQmBqLdg==", "d45ba109-f62e-4a06-afb9-41dfab6835c5" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 34, 24, 34, DateTimeKind.Local).AddTicks(4921), new DateTime(2024, 1, 21, 20, 34, 24, 34, DateTimeKind.Local).AddTicks(4922) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 34, 24, 34, DateTimeKind.Local).AddTicks(4924), new DateTime(2024, 1, 21, 20, 34, 24, 34, DateTimeKind.Local).AddTicks(4924) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 34, 24, 225, DateTimeKind.Local).AddTicks(4755), new DateTime(2024, 1, 21, 20, 34, 24, 225, DateTimeKind.Local).AddTicks(4768) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 34, 24, 225, DateTimeKind.Local).AddTicks(4772), new DateTime(2024, 1, 21, 20, 34, 24, 225, DateTimeKind.Local).AddTicks(4773) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 34, 24, 225, DateTimeKind.Local).AddTicks(5221), new DateTime(2024, 1, 21, 20, 34, 24, 225, DateTimeKind.Local).AddTicks(5221), new DateTime(2024, 1, 21, 20, 34, 24, 225, DateTimeKind.Local).AddTicks(5219) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 34, 24, 225, DateTimeKind.Local).AddTicks(5224), new DateTime(2024, 1, 21, 20, 34, 24, 225, DateTimeKind.Local).AddTicks(5224), new DateTime(2024, 1, 21, 20, 34, 24, 225, DateTimeKind.Local).AddTicks(5224) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 34, 24, 34, DateTimeKind.Local).AddTicks(5233), new DateTime(2024, 1, 21, 20, 34, 24, 34, DateTimeKind.Local).AddTicks(5233) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 34, 24, 34, DateTimeKind.Local).AddTicks(5235), new DateTime(2024, 1, 21, 20, 34, 24, 34, DateTimeKind.Local).AddTicks(5236) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 12, 34, 24, 225, DateTimeKind.Utc).AddTicks(5579), new DateTime(2024, 1, 21, 12, 34, 24, 225, DateTimeKind.Utc).AddTicks(5580) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 12, 34, 24, 225, DateTimeKind.Utc).AddTicks(5584), new DateTime(2024, 1, 21, 12, 34, 24, 225, DateTimeKind.Utc).AddTicks(5584) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 34, 24, 34, DateTimeKind.Local).AddTicks(5077), new DateTime(2024, 1, 21, 20, 34, 24, 34, DateTimeKind.Local).AddTicks(5078) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 34, 24, 34, DateTimeKind.Local).AddTicks(5080), new DateTime(2024, 1, 21, 20, 34, 24, 34, DateTimeKind.Local).AddTicks(5080) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 34, 24, 225, DateTimeKind.Local).AddTicks(5824), new DateTime(2024, 1, 21, 20, 34, 24, 225, DateTimeKind.Local).AddTicks(5825) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 34, 24, 225, DateTimeKind.Local).AddTicks(5827), new DateTime(2024, 1, 21, 20, 34, 24, 225, DateTimeKind.Local).AddTicks(5827) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 34, 24, 34, DateTimeKind.Local).AddTicks(5613), new DateTime(2024, 1, 21, 20, 34, 24, 34, DateTimeKind.Local).AddTicks(5614) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 34, 24, 34, DateTimeKind.Local).AddTicks(5616), new DateTime(2024, 1, 21, 20, 34, 24, 34, DateTimeKind.Local).AddTicks(5616) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 34, 24, 34, DateTimeKind.Local).AddTicks(4740), new DateTime(2024, 1, 21, 20, 34, 24, 34, DateTimeKind.Local).AddTicks(4750) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 34, 24, 34, DateTimeKind.Local).AddTicks(4753), new DateTime(2024, 1, 21, 20, 34, 24, 34, DateTimeKind.Local).AddTicks(4754) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 34, 24, 225, DateTimeKind.Local).AddTicks(5022), new DateTime(2024, 1, 21, 20, 34, 24, 225, DateTimeKind.Local).AddTicks(5021), new DateTime(2024, 1, 21, 20, 34, 24, 225, DateTimeKind.Local).AddTicks(5020), new DateTime(2024, 1, 21, 20, 34, 24, 225, DateTimeKind.Local).AddTicks(5023) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 34, 24, 225, DateTimeKind.Local).AddTicks(5026), new DateTime(2024, 1, 21, 20, 34, 24, 225, DateTimeKind.Local).AddTicks(5025), new DateTime(2024, 1, 21, 20, 34, 24, 225, DateTimeKind.Local).AddTicks(5025), new DateTime(2024, 1, 21, 20, 34, 24, 225, DateTimeKind.Local).AddTicks(5026) });
        }
    }
}
