using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NutriView.Server.Migrations
{
    /// <inheritdoc />
    public partial class @new : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1507dbd1-1c83-4ad2-9b0e-4d298c7b4521",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ebdf3b3f-cd28-46d2-919e-471872c1125d", "AQAAAAIAAYagAAAAEETVFykDAwPA8XIseylBnoVmujNQx8CK4/RC8M5YLTBmJwhsM/0Yeexr2gY6IWx9+g==", "7313f14e-4da0-4017-8ef0-5532cf7e2aa8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41624b27-7496-447c-b299-4892483d6b47",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f0d3dd4c-500e-4d2d-992f-4e42dc74ff78", "AQAAAAIAAYagAAAAEKj9ZMBNbvjNjPNUf/WmRegQcPf9AWG+ikopSZZYpjtAvKvzfjsAjGbMYH5W5LA4Bw==", "c193f557-f156-4733-a7d3-990c7f41a078" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d3dfcba-a0af-4b10-989d-d63dcfec5e97",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fe7abc33-7827-4d2d-ad08-3ac607e531d8", "AQAAAAIAAYagAAAAEMoDX6h55Nk/gKDEDb+W3lXZ7ea//ajWLqMUuiyWQlCoHgPuf88IidI98QnYVx8VAQ==", "85738dcf-906c-42d9-a358-1570d23beb8a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8aa738a7-6c07-4e5a-8a7f-5637388c41b4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a5613b9a-14ab-4214-b0d3-e20659bcf896", "AQAAAAIAAYagAAAAEHvvlZCoZEulDcZnmsXsFy+WEALtxjHy/mA+X77DzH3l4aafgJnV1rwdSBYkaWr7hQ==", "6f2ae1db-f41b-4dcd-9917-031b7938265a" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 16, 19, 6, 801, DateTimeKind.Local).AddTicks(9469), new DateTime(2024, 1, 30, 16, 19, 6, 801, DateTimeKind.Local).AddTicks(9470) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 16, 19, 6, 801, DateTimeKind.Local).AddTicks(9473), new DateTime(2024, 1, 30, 16, 19, 6, 801, DateTimeKind.Local).AddTicks(9474) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 16, 19, 7, 60, DateTimeKind.Local).AddTicks(5220), new DateTime(2024, 1, 30, 16, 19, 7, 60, DateTimeKind.Local).AddTicks(5237) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 16, 19, 7, 60, DateTimeKind.Local).AddTicks(5241), new DateTime(2024, 1, 30, 16, 19, 7, 60, DateTimeKind.Local).AddTicks(5241) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 1, 30, 16, 19, 7, 60, DateTimeKind.Local).AddTicks(5876), new DateTime(2024, 1, 30, 16, 19, 7, 60, DateTimeKind.Local).AddTicks(5877), new DateTime(2024, 1, 30, 16, 19, 7, 60, DateTimeKind.Local).AddTicks(5874) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 1, 30, 16, 19, 7, 60, DateTimeKind.Local).AddTicks(5879), new DateTime(2024, 1, 30, 16, 19, 7, 60, DateTimeKind.Local).AddTicks(5880), new DateTime(2024, 1, 30, 16, 19, 7, 60, DateTimeKind.Local).AddTicks(5879) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 16, 19, 6, 802, DateTimeKind.Local).AddTicks(39), new DateTime(2024, 1, 30, 16, 19, 6, 802, DateTimeKind.Local).AddTicks(43) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 16, 19, 6, 802, DateTimeKind.Local).AddTicks(47), new DateTime(2024, 1, 30, 16, 19, 6, 802, DateTimeKind.Local).AddTicks(48) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 8, 19, 7, 60, DateTimeKind.Utc).AddTicks(6293), new DateTime(2024, 1, 30, 8, 19, 7, 60, DateTimeKind.Utc).AddTicks(6294) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 8, 19, 7, 60, DateTimeKind.Utc).AddTicks(6297), new DateTime(2024, 1, 30, 8, 19, 7, 60, DateTimeKind.Utc).AddTicks(6298) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 16, 19, 6, 801, DateTimeKind.Local).AddTicks(9737), new DateTime(2024, 1, 30, 16, 19, 6, 801, DateTimeKind.Local).AddTicks(9738) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 16, 19, 6, 801, DateTimeKind.Local).AddTicks(9740), new DateTime(2024, 1, 30, 16, 19, 6, 801, DateTimeKind.Local).AddTicks(9741) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 16, 19, 7, 60, DateTimeKind.Local).AddTicks(6796), new DateTime(2024, 1, 30, 16, 19, 7, 60, DateTimeKind.Local).AddTicks(6798) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 16, 19, 7, 60, DateTimeKind.Local).AddTicks(6800), new DateTime(2024, 1, 30, 16, 19, 7, 60, DateTimeKind.Local).AddTicks(6801) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 16, 19, 6, 802, DateTimeKind.Local).AddTicks(1667), new DateTime(2024, 1, 30, 16, 19, 6, 802, DateTimeKind.Local).AddTicks(1672) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 16, 19, 6, 802, DateTimeKind.Local).AddTicks(1675), new DateTime(2024, 1, 30, 16, 19, 6, 802, DateTimeKind.Local).AddTicks(1675) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 16, 19, 6, 801, DateTimeKind.Local).AddTicks(9164), new DateTime(2024, 1, 30, 16, 19, 6, 801, DateTimeKind.Local).AddTicks(9187) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 16, 19, 6, 801, DateTimeKind.Local).AddTicks(9190), new DateTime(2024, 1, 30, 16, 19, 6, 801, DateTimeKind.Local).AddTicks(9190) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 16, 19, 7, 60, DateTimeKind.Local).AddTicks(5587), new DateTime(2024, 1, 30, 16, 19, 7, 60, DateTimeKind.Local).AddTicks(5586), new DateTime(2024, 1, 30, 16, 19, 7, 60, DateTimeKind.Local).AddTicks(5584), new DateTime(2024, 1, 30, 16, 19, 7, 60, DateTimeKind.Local).AddTicks(5588) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 16, 19, 7, 60, DateTimeKind.Local).AddTicks(5591), new DateTime(2024, 1, 30, 16, 19, 7, 60, DateTimeKind.Local).AddTicks(5591), new DateTime(2024, 1, 30, 16, 19, 7, 60, DateTimeKind.Local).AddTicks(5591), new DateTime(2024, 1, 30, 16, 19, 7, 60, DateTimeKind.Local).AddTicks(5592) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1507dbd1-1c83-4ad2-9b0e-4d298c7b4521",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee93c114-50d0-4e82-8916-8c180dc6bef2", "AQAAAAIAAYagAAAAEGXVvwDhbfuvHMnEikp6jEKCk7X29mOiq+/ww8pmFzw3NNlirDK1x9G/jzbDcn+0Sw==", "96aab539-42c6-41d1-8818-2f29ca2353da" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41624b27-7496-447c-b299-4892483d6b47",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1a4d6e79-f316-43bf-b536-7ca3c6687cba", "AQAAAAIAAYagAAAAEPa/mzrGnkfJdE3Uym1tKyjbh1zzJnXIPRSFLFf6srwrTT/N6ngYTbAzphgQqESLUw==", "41b70ff7-f905-4efa-a70d-7d065d17e875" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d3dfcba-a0af-4b10-989d-d63dcfec5e97",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8b5287ef-76dc-458c-b1aa-8a6b7e926b21", "AQAAAAIAAYagAAAAEDyIUNegFfa3AgI3pcoEocAtT0X9GXAfCDkk89vh5Qf/ofdyD16lKSWymjogxbQUdA==", "4a45baea-97d8-4cb6-a05c-d9f38a8064da" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8aa738a7-6c07-4e5a-8a7f-5637388c41b4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "40388f2e-e20f-4b1c-9932-530b12e617f8", "AQAAAAIAAYagAAAAEGGg91sk3oHZP9irLd1QQi4+zYDtFwJgAYK1T/eBIPi42yCamThpwFXeCCZmOTeYew==", "d205d81d-036e-4735-ae73-353d7fc61971" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 11, 22, 416, DateTimeKind.Local).AddTicks(2032), new DateTime(2024, 1, 30, 15, 11, 22, 416, DateTimeKind.Local).AddTicks(2033) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 11, 22, 416, DateTimeKind.Local).AddTicks(2035), new DateTime(2024, 1, 30, 15, 11, 22, 416, DateTimeKind.Local).AddTicks(2035) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 11, 22, 679, DateTimeKind.Local).AddTicks(2220), new DateTime(2024, 1, 30, 15, 11, 22, 679, DateTimeKind.Local).AddTicks(2234) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 11, 22, 679, DateTimeKind.Local).AddTicks(2238), new DateTime(2024, 1, 30, 15, 11, 22, 679, DateTimeKind.Local).AddTicks(2238) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 11, 22, 679, DateTimeKind.Local).AddTicks(2756), new DateTime(2024, 1, 30, 15, 11, 22, 679, DateTimeKind.Local).AddTicks(2757), new DateTime(2024, 1, 30, 15, 11, 22, 679, DateTimeKind.Local).AddTicks(2755) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 11, 22, 679, DateTimeKind.Local).AddTicks(2759), new DateTime(2024, 1, 30, 15, 11, 22, 679, DateTimeKind.Local).AddTicks(2760), new DateTime(2024, 1, 30, 15, 11, 22, 679, DateTimeKind.Local).AddTicks(2759) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 11, 22, 416, DateTimeKind.Local).AddTicks(2416), new DateTime(2024, 1, 30, 15, 11, 22, 416, DateTimeKind.Local).AddTicks(2418) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 11, 22, 416, DateTimeKind.Local).AddTicks(2420), new DateTime(2024, 1, 30, 15, 11, 22, 416, DateTimeKind.Local).AddTicks(2420) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 7, 11, 22, 679, DateTimeKind.Utc).AddTicks(3041), new DateTime(2024, 1, 30, 7, 11, 22, 679, DateTimeKind.Utc).AddTicks(3041) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 7, 11, 22, 679, DateTimeKind.Utc).AddTicks(3043), new DateTime(2024, 1, 30, 7, 11, 22, 679, DateTimeKind.Utc).AddTicks(3044) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 11, 22, 416, DateTimeKind.Local).AddTicks(2224), new DateTime(2024, 1, 30, 15, 11, 22, 416, DateTimeKind.Local).AddTicks(2225) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 11, 22, 416, DateTimeKind.Local).AddTicks(2227), new DateTime(2024, 1, 30, 15, 11, 22, 416, DateTimeKind.Local).AddTicks(2227) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 11, 22, 679, DateTimeKind.Local).AddTicks(3440), new DateTime(2024, 1, 30, 15, 11, 22, 679, DateTimeKind.Local).AddTicks(3442) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 11, 22, 679, DateTimeKind.Local).AddTicks(3445), new DateTime(2024, 1, 30, 15, 11, 22, 679, DateTimeKind.Local).AddTicks(3445) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 11, 22, 416, DateTimeKind.Local).AddTicks(3273), new DateTime(2024, 1, 30, 15, 11, 22, 416, DateTimeKind.Local).AddTicks(3275) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 11, 22, 416, DateTimeKind.Local).AddTicks(3277), new DateTime(2024, 1, 30, 15, 11, 22, 416, DateTimeKind.Local).AddTicks(3278) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 11, 22, 416, DateTimeKind.Local).AddTicks(1818), new DateTime(2024, 1, 30, 15, 11, 22, 416, DateTimeKind.Local).AddTicks(1827) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 11, 22, 416, DateTimeKind.Local).AddTicks(1829), new DateTime(2024, 1, 30, 15, 11, 22, 416, DateTimeKind.Local).AddTicks(1829) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 11, 22, 679, DateTimeKind.Local).AddTicks(2515), new DateTime(2024, 1, 30, 15, 11, 22, 679, DateTimeKind.Local).AddTicks(2514), new DateTime(2024, 1, 30, 15, 11, 22, 679, DateTimeKind.Local).AddTicks(2513), new DateTime(2024, 1, 30, 15, 11, 22, 679, DateTimeKind.Local).AddTicks(2515) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 15, 11, 22, 679, DateTimeKind.Local).AddTicks(2518), new DateTime(2024, 1, 30, 15, 11, 22, 679, DateTimeKind.Local).AddTicks(2518), new DateTime(2024, 1, 30, 15, 11, 22, 679, DateTimeKind.Local).AddTicks(2517), new DateTime(2024, 1, 30, 15, 11, 22, 679, DateTimeKind.Local).AddTicks(2519) });
        }
    }
}
