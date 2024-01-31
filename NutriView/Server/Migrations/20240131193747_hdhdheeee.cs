using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NutriView.Server.Migrations
{
    /// <inheritdoc />
    public partial class hdhdheeee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NutritionName",
                table: "NutritionInfos",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NutritionDescription",
                table: "NutritionInfos",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1507dbd1-1c83-4ad2-9b0e-4d298c7b4521",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "44954aca-eb5f-454e-8046-0cd6a22bb33a", "AQAAAAIAAYagAAAAEOAdwXl2/SGXkRq0B/J480TKspoHNyRlzQ8bTUeC4+veOyr3joX4vnurABvlY/7vBg==", "6a1a335b-573b-4fcc-a3c7-d27e729dbc58" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41624b27-7496-447c-b299-4892483d6b47",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c36d2f2c-3a0e-4af4-9303-44cbfeee87bb", "AQAAAAIAAYagAAAAELp36CzNCjnBmg1FumLAseeuHhJQrdWtUjxAld4T68B6HMCyl7QqLEkM47pIso6MEA==", "ed386590-e9b4-42ba-bfbe-f1ccc7a8694a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d3dfcba-a0af-4b10-989d-d63dcfec5e97",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "20ffdd47-9369-45ee-b1e1-18b9b02f4802", "AQAAAAIAAYagAAAAEKBAtC8fV5xNHlr6aTRWlOydsTJ1GxfxetqO/rK7c4Ybilon/2JAJyLSAc4O5ppzBw==", "4c2feefe-e81c-4086-9ff1-16f0c3a1905f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8aa738a7-6c07-4e5a-8a7f-5637388c41b4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b9d87b0-891a-4496-9419-05ef937afe8d", "AQAAAAIAAYagAAAAEHzhCCp1D7u77m6s8zrdc5H9qoo+IvbuQwAKKx+3LDqw5ugKlJ6k+9HsSvdlnqs+3A==", "a3d87bab-d770-4321-8265-91db4cd7869f" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 37, 46, 546, DateTimeKind.Local).AddTicks(1438), new DateTime(2024, 2, 1, 3, 37, 46, 546, DateTimeKind.Local).AddTicks(1438) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 37, 46, 546, DateTimeKind.Local).AddTicks(1442), new DateTime(2024, 2, 1, 3, 37, 46, 546, DateTimeKind.Local).AddTicks(1442) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 37, 46, 753, DateTimeKind.Local).AddTicks(579), new DateTime(2024, 2, 1, 3, 37, 46, 753, DateTimeKind.Local).AddTicks(599) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 37, 46, 753, DateTimeKind.Local).AddTicks(603), new DateTime(2024, 2, 1, 3, 37, 46, 753, DateTimeKind.Local).AddTicks(604) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 37, 46, 753, DateTimeKind.Local).AddTicks(1100), new DateTime(2024, 2, 1, 3, 37, 46, 753, DateTimeKind.Local).AddTicks(1100), new DateTime(2024, 2, 1, 3, 37, 46, 753, DateTimeKind.Local).AddTicks(1099) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 37, 46, 753, DateTimeKind.Local).AddTicks(1103), new DateTime(2024, 2, 1, 3, 37, 46, 753, DateTimeKind.Local).AddTicks(1104), new DateTime(2024, 2, 1, 3, 37, 46, 753, DateTimeKind.Local).AddTicks(1103) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 37, 46, 546, DateTimeKind.Local).AddTicks(1935), new DateTime(2024, 2, 1, 3, 37, 46, 546, DateTimeKind.Local).AddTicks(1935) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 37, 46, 546, DateTimeKind.Local).AddTicks(1938), new DateTime(2024, 2, 1, 3, 37, 46, 546, DateTimeKind.Local).AddTicks(1939) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 19, 37, 46, 753, DateTimeKind.Utc).AddTicks(1544), new DateTime(2024, 1, 31, 19, 37, 46, 753, DateTimeKind.Utc).AddTicks(1545) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 19, 37, 46, 753, DateTimeKind.Utc).AddTicks(1547), new DateTime(2024, 1, 31, 19, 37, 46, 753, DateTimeKind.Utc).AddTicks(1547) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 37, 46, 546, DateTimeKind.Local).AddTicks(1711), new DateTime(2024, 2, 1, 3, 37, 46, 546, DateTimeKind.Local).AddTicks(1712) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 37, 46, 546, DateTimeKind.Local).AddTicks(1714), new DateTime(2024, 2, 1, 3, 37, 46, 546, DateTimeKind.Local).AddTicks(1714) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 37, 46, 753, DateTimeKind.Local).AddTicks(1856), new DateTime(2024, 2, 1, 3, 37, 46, 753, DateTimeKind.Local).AddTicks(1858) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 37, 46, 753, DateTimeKind.Local).AddTicks(1860), new DateTime(2024, 2, 1, 3, 37, 46, 753, DateTimeKind.Local).AddTicks(1861) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 37, 46, 546, DateTimeKind.Local).AddTicks(3041), new DateTime(2024, 2, 1, 3, 37, 46, 546, DateTimeKind.Local).AddTicks(3044) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 37, 46, 546, DateTimeKind.Local).AddTicks(3048), new DateTime(2024, 2, 1, 3, 37, 46, 546, DateTimeKind.Local).AddTicks(3048) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 37, 46, 546, DateTimeKind.Local).AddTicks(573), new DateTime(2024, 2, 1, 3, 37, 46, 546, DateTimeKind.Local).AddTicks(589) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 37, 46, 546, DateTimeKind.Local).AddTicks(599), new DateTime(2024, 2, 1, 3, 37, 46, 546, DateTimeKind.Local).AddTicks(599) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 37, 46, 753, DateTimeKind.Local).AddTicks(871), new DateTime(2024, 2, 1, 3, 37, 46, 753, DateTimeKind.Local).AddTicks(869), new DateTime(2024, 2, 1, 3, 37, 46, 753, DateTimeKind.Local).AddTicks(867), new DateTime(2024, 2, 1, 3, 37, 46, 753, DateTimeKind.Local).AddTicks(871) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 37, 46, 753, DateTimeKind.Local).AddTicks(874), new DateTime(2024, 2, 1, 3, 37, 46, 753, DateTimeKind.Local).AddTicks(874), new DateTime(2024, 2, 1, 3, 37, 46, 753, DateTimeKind.Local).AddTicks(873), new DateTime(2024, 2, 1, 3, 37, 46, 753, DateTimeKind.Local).AddTicks(875) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NutritionName",
                table: "NutritionInfos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "NutritionDescription",
                table: "NutritionInfos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1507dbd1-1c83-4ad2-9b0e-4d298c7b4521",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "552b4abe-11eb-433d-a467-c3ccfc2758fd", "AQAAAAIAAYagAAAAEBP6lWUN+RoOVb2Kfl8GsIT1rWF4MyrZKoM4G7hrg0utGKOE1DsTXWKTviFulXhftA==", "e035537a-e2b4-4f4d-8f69-f512c8798991" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41624b27-7496-447c-b299-4892483d6b47",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "18f57eac-8e35-484b-9218-c49cad6e0642", "AQAAAAIAAYagAAAAEEhqd6IFsK5zLSA1gi6vAd8AFyacu99OlMxibqC7RZk68+YFI4pNsHhHHAuhjCNvoA==", "1a3fcd54-b8ac-474a-b00b-4a574bde8cb2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d3dfcba-a0af-4b10-989d-d63dcfec5e97",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "828e3e18-b2b0-4a51-8878-6f5f1036417a", "AQAAAAIAAYagAAAAEDf4IPo3nZIPb/AOgniidoy+t/7xDvwXRDJ2rVhf3tPiCyUsZU8hWdkGY3ysokcpFw==", "d429a2c2-386c-4e35-a874-0e5d3d46ee9a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8aa738a7-6c07-4e5a-8a7f-5637388c41b4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "103a74f1-c708-4b75-a187-3c9b42e17905", "AQAAAAIAAYagAAAAEBuO6D1+mXoLub0190OsWBcWSB5EcW34i9GxCsnXLt6q9UXbwGvBL1gGzLMT8P70Ug==", "28901d36-599b-445c-ab9d-02c197300dc0" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 6, 40, 227, DateTimeKind.Local).AddTicks(8318), new DateTime(2024, 2, 1, 3, 6, 40, 227, DateTimeKind.Local).AddTicks(8321) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 6, 40, 227, DateTimeKind.Local).AddTicks(8323), new DateTime(2024, 2, 1, 3, 6, 40, 227, DateTimeKind.Local).AddTicks(8324) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 6, 40, 428, DateTimeKind.Local).AddTicks(8538), new DateTime(2024, 2, 1, 3, 6, 40, 428, DateTimeKind.Local).AddTicks(8563) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 6, 40, 428, DateTimeKind.Local).AddTicks(8568), new DateTime(2024, 2, 1, 3, 6, 40, 428, DateTimeKind.Local).AddTicks(8569) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 6, 40, 429, DateTimeKind.Local).AddTicks(240), new DateTime(2024, 2, 1, 3, 6, 40, 429, DateTimeKind.Local).AddTicks(241), new DateTime(2024, 2, 1, 3, 6, 40, 429, DateTimeKind.Local).AddTicks(238) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 6, 40, 429, DateTimeKind.Local).AddTicks(243), new DateTime(2024, 2, 1, 3, 6, 40, 429, DateTimeKind.Local).AddTicks(244), new DateTime(2024, 2, 1, 3, 6, 40, 429, DateTimeKind.Local).AddTicks(243) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 6, 40, 227, DateTimeKind.Local).AddTicks(9317), new DateTime(2024, 2, 1, 3, 6, 40, 227, DateTimeKind.Local).AddTicks(9318) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 6, 40, 227, DateTimeKind.Local).AddTicks(9321), new DateTime(2024, 2, 1, 3, 6, 40, 227, DateTimeKind.Local).AddTicks(9321) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 19, 6, 40, 429, DateTimeKind.Utc).AddTicks(3882), new DateTime(2024, 1, 31, 19, 6, 40, 429, DateTimeKind.Utc).AddTicks(3884) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 19, 6, 40, 429, DateTimeKind.Utc).AddTicks(3887), new DateTime(2024, 1, 31, 19, 6, 40, 429, DateTimeKind.Utc).AddTicks(3887) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 6, 40, 227, DateTimeKind.Local).AddTicks(9113), new DateTime(2024, 2, 1, 3, 6, 40, 227, DateTimeKind.Local).AddTicks(9115) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 6, 40, 227, DateTimeKind.Local).AddTicks(9117), new DateTime(2024, 2, 1, 3, 6, 40, 227, DateTimeKind.Local).AddTicks(9117) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 6, 40, 429, DateTimeKind.Local).AddTicks(4285), new DateTime(2024, 2, 1, 3, 6, 40, 429, DateTimeKind.Local).AddTicks(4290) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 6, 40, 429, DateTimeKind.Local).AddTicks(4293), new DateTime(2024, 2, 1, 3, 6, 40, 429, DateTimeKind.Local).AddTicks(4294) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 6, 40, 228, DateTimeKind.Local).AddTicks(63), new DateTime(2024, 2, 1, 3, 6, 40, 228, DateTimeKind.Local).AddTicks(66) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 6, 40, 228, DateTimeKind.Local).AddTicks(69), new DateTime(2024, 2, 1, 3, 6, 40, 228, DateTimeKind.Local).AddTicks(69) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 6, 40, 227, DateTimeKind.Local).AddTicks(6412), new DateTime(2024, 2, 1, 3, 6, 40, 227, DateTimeKind.Local).AddTicks(6430) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 6, 40, 227, DateTimeKind.Local).AddTicks(6433), new DateTime(2024, 2, 1, 3, 6, 40, 227, DateTimeKind.Local).AddTicks(6433) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 6, 40, 428, DateTimeKind.Local).AddTicks(8949), new DateTime(2024, 2, 1, 3, 6, 40, 428, DateTimeKind.Local).AddTicks(8947), new DateTime(2024, 2, 1, 3, 6, 40, 428, DateTimeKind.Local).AddTicks(8945), new DateTime(2024, 2, 1, 3, 6, 40, 428, DateTimeKind.Local).AddTicks(8949) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 6, 40, 428, DateTimeKind.Local).AddTicks(8953), new DateTime(2024, 2, 1, 3, 6, 40, 428, DateTimeKind.Local).AddTicks(8952), new DateTime(2024, 2, 1, 3, 6, 40, 428, DateTimeKind.Local).AddTicks(8952), new DateTime(2024, 2, 1, 3, 6, 40, 428, DateTimeKind.Local).AddTicks(8953) });
        }
    }
}
