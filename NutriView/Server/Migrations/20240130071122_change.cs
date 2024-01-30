using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NutriView.Server.Migrations
{
    /// <inheritdoc />
    public partial class change : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                column: "ServiceCode",
                value: "");

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                column: "ServiceCode",
                value: "");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1507dbd1-1c83-4ad2-9b0e-4d298c7b4521",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b763985a-11cc-4314-bc0a-253b9cfd9726", "AQAAAAIAAYagAAAAECKzGGyidI0kJWMpemD5qOZaJaZ4fGaGI/h1R8JuRAtBO5SXWdbiaDkB8+sJBpLN6Q==", "2bea1210-c438-434b-983c-28b0a4716e7e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41624b27-7496-447c-b299-4892483d6b47",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "941fd336-b390-4edd-bc1d-c728f99f5979", "AQAAAAIAAYagAAAAEIMqps7mjJOAxrMGnPZ3x4PJP5C8QCK6C4p29ZmKkj/Jl8b4iokJ4R68UtPiyggL/Q==", "cd86a8f9-3535-4b77-83b9-a7b3ef473f87" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d3dfcba-a0af-4b10-989d-d63dcfec5e97",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6cd8435c-068c-43ba-8514-67be85599469", "AQAAAAIAAYagAAAAEEkXd0MKYXVE9kx9VdAru0vqxVXgt9+kkkU0ezQeymArwd9lSND7gnSPcmIuaRGvOA==", "b522e857-5ffc-4bfe-beee-69b28117e9c2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8aa738a7-6c07-4e5a-8a7f-5637388c41b4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5c84d074-5681-427b-b57a-b3a17f94ab72", "AQAAAAIAAYagAAAAEDYmNqqYaAR2n47TyNXfPSc17pnGucKrXXbqQop2cSI0Ob6cLXD/V7tPeZaFSVKBVQ==", "9ad3b94e-cb7e-4d0e-a9b7-7a12ac5ddb14" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 14, 59, 42, 160, DateTimeKind.Local).AddTicks(8771), new DateTime(2024, 1, 30, 14, 59, 42, 160, DateTimeKind.Local).AddTicks(8772) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 14, 59, 42, 160, DateTimeKind.Local).AddTicks(8774), new DateTime(2024, 1, 30, 14, 59, 42, 160, DateTimeKind.Local).AddTicks(8775) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 14, 59, 42, 419, DateTimeKind.Local).AddTicks(3937), new DateTime(2024, 1, 30, 14, 59, 42, 419, DateTimeKind.Local).AddTicks(3951) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 14, 59, 42, 419, DateTimeKind.Local).AddTicks(3954), new DateTime(2024, 1, 30, 14, 59, 42, 419, DateTimeKind.Local).AddTicks(3954) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 1, 30, 14, 59, 42, 419, DateTimeKind.Local).AddTicks(4432), new DateTime(2024, 1, 30, 14, 59, 42, 419, DateTimeKind.Local).AddTicks(4433), new DateTime(2024, 1, 30, 14, 59, 42, 419, DateTimeKind.Local).AddTicks(4431) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 1, 30, 14, 59, 42, 419, DateTimeKind.Local).AddTicks(4435), new DateTime(2024, 1, 30, 14, 59, 42, 419, DateTimeKind.Local).AddTicks(4435), new DateTime(2024, 1, 30, 14, 59, 42, 419, DateTimeKind.Local).AddTicks(4434) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 14, 59, 42, 160, DateTimeKind.Local).AddTicks(9200), new DateTime(2024, 1, 30, 14, 59, 42, 160, DateTimeKind.Local).AddTicks(9201) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 14, 59, 42, 160, DateTimeKind.Local).AddTicks(9204), new DateTime(2024, 1, 30, 14, 59, 42, 160, DateTimeKind.Local).AddTicks(9205) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 6, 59, 42, 419, DateTimeKind.Utc).AddTicks(4700), new DateTime(2024, 1, 30, 6, 59, 42, 419, DateTimeKind.Utc).AddTicks(4701) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 6, 59, 42, 419, DateTimeKind.Utc).AddTicks(4703), new DateTime(2024, 1, 30, 6, 59, 42, 419, DateTimeKind.Utc).AddTicks(4703) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 14, 59, 42, 160, DateTimeKind.Local).AddTicks(8971), new DateTime(2024, 1, 30, 14, 59, 42, 160, DateTimeKind.Local).AddTicks(8971) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 14, 59, 42, 160, DateTimeKind.Local).AddTicks(8973), new DateTime(2024, 1, 30, 14, 59, 42, 160, DateTimeKind.Local).AddTicks(8974) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 14, 59, 42, 419, DateTimeKind.Local).AddTicks(5087), new DateTime(2024, 1, 30, 14, 59, 42, 419, DateTimeKind.Local).AddTicks(5089) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 14, 59, 42, 419, DateTimeKind.Local).AddTicks(5091), new DateTime(2024, 1, 30, 14, 59, 42, 419, DateTimeKind.Local).AddTicks(5092) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                column: "ServiceCode",
                value: null);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                column: "ServiceCode",
                value: null);

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 14, 59, 42, 161, DateTimeKind.Local).AddTicks(23), new DateTime(2024, 1, 30, 14, 59, 42, 161, DateTimeKind.Local).AddTicks(24) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 14, 59, 42, 161, DateTimeKind.Local).AddTicks(27), new DateTime(2024, 1, 30, 14, 59, 42, 161, DateTimeKind.Local).AddTicks(27) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 14, 59, 42, 160, DateTimeKind.Local).AddTicks(8550), new DateTime(2024, 1, 30, 14, 59, 42, 160, DateTimeKind.Local).AddTicks(8561) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 14, 59, 42, 160, DateTimeKind.Local).AddTicks(8563), new DateTime(2024, 1, 30, 14, 59, 42, 160, DateTimeKind.Local).AddTicks(8564) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 14, 59, 42, 419, DateTimeKind.Local).AddTicks(4219), new DateTime(2024, 1, 30, 14, 59, 42, 419, DateTimeKind.Local).AddTicks(4218), new DateTime(2024, 1, 30, 14, 59, 42, 419, DateTimeKind.Local).AddTicks(4217), new DateTime(2024, 1, 30, 14, 59, 42, 419, DateTimeKind.Local).AddTicks(4219) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 14, 59, 42, 419, DateTimeKind.Local).AddTicks(4222), new DateTime(2024, 1, 30, 14, 59, 42, 419, DateTimeKind.Local).AddTicks(4221), new DateTime(2024, 1, 30, 14, 59, 42, 419, DateTimeKind.Local).AddTicks(4221), new DateTime(2024, 1, 30, 14, 59, 42, 419, DateTimeKind.Local).AddTicks(4222) });
        }
    }
}
