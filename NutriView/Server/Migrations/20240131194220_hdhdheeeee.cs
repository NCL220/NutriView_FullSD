using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NutriView.Server.Migrations
{
    /// <inheritdoc />
    public partial class hdhdheeeee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SubType",
                table: "SubscriptionInfos",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SubTierName",
                table: "SubscriptionInfos",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SubDescription",
                table: "SubscriptionInfos",
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
                values: new object[] { "1296450c-696d-4028-a34a-8e23a54a5a23", "AQAAAAIAAYagAAAAELsvbXfvzc6bl9JHWA+zxKuI/FcCL2Bys+lZXRDD+/gVX0WU6YvC3KvuKBt1Zjm6yw==", "42ed8153-90cc-49d4-baca-0089bac1b379" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41624b27-7496-447c-b299-4892483d6b47",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9620c07-bd95-45b2-9ebb-5c0410a5cd3d", "AQAAAAIAAYagAAAAEJeI+K8njNgjIqyhUv3HQPW/N93KDKAcuzRxnDOjcQjFAEbvscav2wwSWc3eKPKGEA==", "079571ba-cf2f-4b63-ac9e-ff59ffd2fde2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d3dfcba-a0af-4b10-989d-d63dcfec5e97",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "51639ed4-75ec-48ec-84c6-18cf04946e34", "AQAAAAIAAYagAAAAEOutYEMb+ur6Hkka3XNvvug1wu3MjSj3wGOc8m+7phjnWuCmSMXXqlw+by7m1sKg8w==", "345f9626-9417-4ae5-9232-efc8ceb0dbce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8aa738a7-6c07-4e5a-8a7f-5637388c41b4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "79ddd123-16b5-44fa-ba9c-36966959328c", "AQAAAAIAAYagAAAAEAJhQ8ITBIaSl1j35HdGUxLv3QMtKKv3GfKZXqstSJuts5ZYL4c1VrFgyz196k28Eg==", "e4e0c83d-80c7-4e3f-b20e-5ad5b875c1a0" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 42, 20, 353, DateTimeKind.Local).AddTicks(9280), new DateTime(2024, 2, 1, 3, 42, 20, 353, DateTimeKind.Local).AddTicks(9281) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 42, 20, 353, DateTimeKind.Local).AddTicks(9283), new DateTime(2024, 2, 1, 3, 42, 20, 353, DateTimeKind.Local).AddTicks(9283) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 42, 20, 567, DateTimeKind.Local).AddTicks(715), new DateTime(2024, 2, 1, 3, 42, 20, 567, DateTimeKind.Local).AddTicks(732) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 42, 20, 567, DateTimeKind.Local).AddTicks(736), new DateTime(2024, 2, 1, 3, 42, 20, 567, DateTimeKind.Local).AddTicks(737) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 42, 20, 567, DateTimeKind.Local).AddTicks(1246), new DateTime(2024, 2, 1, 3, 42, 20, 567, DateTimeKind.Local).AddTicks(1247), new DateTime(2024, 2, 1, 3, 42, 20, 567, DateTimeKind.Local).AddTicks(1244) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 42, 20, 567, DateTimeKind.Local).AddTicks(1249), new DateTime(2024, 2, 1, 3, 42, 20, 567, DateTimeKind.Local).AddTicks(1249), new DateTime(2024, 2, 1, 3, 42, 20, 567, DateTimeKind.Local).AddTicks(1248) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 42, 20, 353, DateTimeKind.Local).AddTicks(9736), new DateTime(2024, 2, 1, 3, 42, 20, 353, DateTimeKind.Local).AddTicks(9737) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 42, 20, 353, DateTimeKind.Local).AddTicks(9739), new DateTime(2024, 2, 1, 3, 42, 20, 353, DateTimeKind.Local).AddTicks(9740) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 19, 42, 20, 567, DateTimeKind.Utc).AddTicks(4608), new DateTime(2024, 1, 31, 19, 42, 20, 567, DateTimeKind.Utc).AddTicks(4609) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 19, 42, 20, 567, DateTimeKind.Utc).AddTicks(4611), new DateTime(2024, 1, 31, 19, 42, 20, 567, DateTimeKind.Utc).AddTicks(4612) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 42, 20, 353, DateTimeKind.Local).AddTicks(9556), new DateTime(2024, 2, 1, 3, 42, 20, 353, DateTimeKind.Local).AddTicks(9557) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 42, 20, 353, DateTimeKind.Local).AddTicks(9559), new DateTime(2024, 2, 1, 3, 42, 20, 353, DateTimeKind.Local).AddTicks(9559) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 42, 20, 567, DateTimeKind.Local).AddTicks(4982), new DateTime(2024, 2, 1, 3, 42, 20, 567, DateTimeKind.Local).AddTicks(4985) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 42, 20, 567, DateTimeKind.Local).AddTicks(4987), new DateTime(2024, 2, 1, 3, 42, 20, 567, DateTimeKind.Local).AddTicks(4987) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 42, 20, 354, DateTimeKind.Local).AddTicks(258), new DateTime(2024, 2, 1, 3, 42, 20, 354, DateTimeKind.Local).AddTicks(260) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 42, 20, 354, DateTimeKind.Local).AddTicks(262), new DateTime(2024, 2, 1, 3, 42, 20, 354, DateTimeKind.Local).AddTicks(262) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 42, 20, 353, DateTimeKind.Local).AddTicks(8562), new DateTime(2024, 2, 1, 3, 42, 20, 353, DateTimeKind.Local).AddTicks(8575) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 42, 20, 353, DateTimeKind.Local).AddTicks(8578), new DateTime(2024, 2, 1, 3, 42, 20, 353, DateTimeKind.Local).AddTicks(8579) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 42, 20, 567, DateTimeKind.Local).AddTicks(1004), new DateTime(2024, 2, 1, 3, 42, 20, 567, DateTimeKind.Local).AddTicks(1003), new DateTime(2024, 2, 1, 3, 42, 20, 567, DateTimeKind.Local).AddTicks(1000), new DateTime(2024, 2, 1, 3, 42, 20, 567, DateTimeKind.Local).AddTicks(1005) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 42, 20, 567, DateTimeKind.Local).AddTicks(1013), new DateTime(2024, 2, 1, 3, 42, 20, 567, DateTimeKind.Local).AddTicks(1012), new DateTime(2024, 2, 1, 3, 42, 20, 567, DateTimeKind.Local).AddTicks(1012), new DateTime(2024, 2, 1, 3, 42, 20, 567, DateTimeKind.Local).AddTicks(1013) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SubType",
                table: "SubscriptionInfos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SubTierName",
                table: "SubscriptionInfos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SubDescription",
                table: "SubscriptionInfos",
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
    }
}
