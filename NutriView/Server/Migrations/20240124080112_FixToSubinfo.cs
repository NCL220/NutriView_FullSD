using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NutriView.Server.Migrations
{
    /// <inheritdoc />
    public partial class FixToSubinfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "SubMonthsDuration",
                table: "SubscriptionInfos",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1507dbd1-1c83-4ad2-9b0e-4d298c7b4521",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "53d95532-4367-4c18-9b12-f66bc397e939", "AQAAAAIAAYagAAAAEO+dMjTFIAPKJpwZKX77upJl+C+lh3dJCWdBen6916Oi61p2E/2s8Ft/qgP1sFx6Hw==", "f62d0d9b-951a-4b39-a43b-f1cc279b6fa7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41624b27-7496-447c-b299-4892483d6b47",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4876e931-b367-440b-90a8-e0a1a7a32e5c", "AQAAAAIAAYagAAAAEJfQ6cpobuh0SnoawMCvZGCRz8yjSeWP4feUKGpcYSwGsGTigzfiBvi7ApiK0OA8UQ==", "5e77dea6-78a6-4600-a3c2-f9c74ea85283" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d3dfcba-a0af-4b10-989d-d63dcfec5e97",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fbc3a976-1abe-4612-922a-71f7b6b12bac", "AQAAAAIAAYagAAAAEDG99bnjoFE+/1VQVWjXBh+Y2y2kgsnm5oedntNZpcgCc3x5RI6MG+KMhUIPbpymdg==", "f726781d-2116-4b9d-84c2-35e01ae93fd1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8aa738a7-6c07-4e5a-8a7f-5637388c41b4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "13c1fce5-d38e-4ef1-84f5-7bed902d4299", "AQAAAAIAAYagAAAAEHMheWgzbK8Fy8zFOFzWV7+FPuE0/ALbGWW7d/0eQruHIL+B1ogPbLplv3QcrzeDwQ==", "27b0fa47-ed4b-43c1-90e6-61e1798f7523" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 16, 1, 12, 503, DateTimeKind.Local).AddTicks(3197), new DateTime(2024, 1, 24, 16, 1, 12, 503, DateTimeKind.Local).AddTicks(3197) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 16, 1, 12, 503, DateTimeKind.Local).AddTicks(3200), new DateTime(2024, 1, 24, 16, 1, 12, 503, DateTimeKind.Local).AddTicks(3200) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 16, 1, 12, 692, DateTimeKind.Local).AddTicks(3723), new DateTime(2024, 1, 24, 16, 1, 12, 692, DateTimeKind.Local).AddTicks(3740) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 16, 1, 12, 692, DateTimeKind.Local).AddTicks(3743), new DateTime(2024, 1, 24, 16, 1, 12, 692, DateTimeKind.Local).AddTicks(3744) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 1, 24, 16, 1, 12, 692, DateTimeKind.Local).AddTicks(4207), new DateTime(2024, 1, 24, 16, 1, 12, 692, DateTimeKind.Local).AddTicks(4208), new DateTime(2024, 1, 24, 16, 1, 12, 692, DateTimeKind.Local).AddTicks(4207) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 1, 24, 16, 1, 12, 692, DateTimeKind.Local).AddTicks(4211), new DateTime(2024, 1, 24, 16, 1, 12, 692, DateTimeKind.Local).AddTicks(4211), new DateTime(2024, 1, 24, 16, 1, 12, 692, DateTimeKind.Local).AddTicks(4210) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 16, 1, 12, 503, DateTimeKind.Local).AddTicks(3523), new DateTime(2024, 1, 24, 16, 1, 12, 503, DateTimeKind.Local).AddTicks(3523) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 16, 1, 12, 503, DateTimeKind.Local).AddTicks(3526), new DateTime(2024, 1, 24, 16, 1, 12, 503, DateTimeKind.Local).AddTicks(3526) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 8, 1, 12, 692, DateTimeKind.Utc).AddTicks(4566), new DateTime(2024, 1, 24, 8, 1, 12, 692, DateTimeKind.Utc).AddTicks(4566) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 8, 1, 12, 692, DateTimeKind.Utc).AddTicks(4568), new DateTime(2024, 1, 24, 8, 1, 12, 692, DateTimeKind.Utc).AddTicks(4568) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 16, 1, 12, 503, DateTimeKind.Local).AddTicks(3358), new DateTime(2024, 1, 24, 16, 1, 12, 503, DateTimeKind.Local).AddTicks(3359) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 16, 1, 12, 503, DateTimeKind.Local).AddTicks(3360), new DateTime(2024, 1, 24, 16, 1, 12, 503, DateTimeKind.Local).AddTicks(3361) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 16, 1, 12, 692, DateTimeKind.Local).AddTicks(4814), new DateTime(2024, 1, 24, 16, 1, 12, 692, DateTimeKind.Local).AddTicks(4815) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 16, 1, 12, 692, DateTimeKind.Local).AddTicks(4817), new DateTime(2024, 1, 24, 16, 1, 12, 692, DateTimeKind.Local).AddTicks(4817) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 16, 1, 12, 503, DateTimeKind.Local).AddTicks(3912), new DateTime(2024, 1, 24, 16, 1, 12, 503, DateTimeKind.Local).AddTicks(3913) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 16, 1, 12, 503, DateTimeKind.Local).AddTicks(3915), new DateTime(2024, 1, 24, 16, 1, 12, 503, DateTimeKind.Local).AddTicks(3916) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "SubMonthsDuration" },
                values: new object[] { new DateTime(2024, 1, 24, 16, 1, 12, 503, DateTimeKind.Local).AddTicks(3012), new DateTime(2024, 1, 24, 16, 1, 12, 503, DateTimeKind.Local).AddTicks(3023), null });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "SubMonthsDuration" },
                values: new object[] { new DateTime(2024, 1, 24, 16, 1, 12, 503, DateTimeKind.Local).AddTicks(3025), new DateTime(2024, 1, 24, 16, 1, 12, 503, DateTimeKind.Local).AddTicks(3026), null });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 16, 1, 12, 692, DateTimeKind.Local).AddTicks(3967), new DateTime(2024, 1, 24, 16, 1, 12, 692, DateTimeKind.Local).AddTicks(3966), new DateTime(2024, 1, 24, 16, 1, 12, 692, DateTimeKind.Local).AddTicks(3965), new DateTime(2024, 1, 24, 16, 1, 12, 692, DateTimeKind.Local).AddTicks(3968) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 16, 1, 12, 692, DateTimeKind.Local).AddTicks(3970), new DateTime(2024, 1, 24, 16, 1, 12, 692, DateTimeKind.Local).AddTicks(3970), new DateTime(2024, 1, 24, 16, 1, 12, 692, DateTimeKind.Local).AddTicks(3969), new DateTime(2024, 1, 24, 16, 1, 12, 692, DateTimeKind.Local).AddTicks(3970) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SubMonthsDuration",
                table: "SubscriptionInfos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
    }
}
