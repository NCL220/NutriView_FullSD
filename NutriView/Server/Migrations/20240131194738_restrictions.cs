using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NutriView.Server.Migrations
{
    /// <inheritdoc />
    public partial class restrictions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Staffs",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Role",
                table: "Staffs",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PhoneNumber",
                table: "Staffs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Staffs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Staffs",
                type: "nvarchar(max)",
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
                values: new object[] { "af77bbb6-9ffe-4ed1-bf4a-906b540d7b36", "AQAAAAIAAYagAAAAEAn1L+xks8GiNBP0jg11Eoj1kKa8kStEr/kn+OLUTa1TEH/9nQdpTTU5z2ZvZWhblQ==", "69cbbfbe-99f8-465a-b353-e66a374c9875" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41624b27-7496-447c-b299-4892483d6b47",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a08b202-4d31-4e92-ad59-7391f0270d55", "AQAAAAIAAYagAAAAEPrsg1St57W9t2lJckd/EAVZiVjovVCfQkCsOrGeC/Ko6enwvdsXbwWJt6w8+tWvuQ==", "3d61321e-2895-483b-aca1-af06771e49c0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d3dfcba-a0af-4b10-989d-d63dcfec5e97",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cad40869-786e-40b6-aea5-c4c15248874c", "AQAAAAIAAYagAAAAEP+bArPcmcMi2WsZRJui/l06xK7v3xRGY/t6dxnRO0aNmJjCB5jYqNQR66HxjYhaBw==", "2dd6ccaf-f6ae-422f-b370-adb541f71996" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8aa738a7-6c07-4e5a-8a7f-5637388c41b4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9d0a9c4-60db-439a-bb38-a56b44b02205", "AQAAAAIAAYagAAAAEH7TS/Mww7W9oHHBKcFrhM3aN2wdF+kpDlQVWe0poQkKh59t4UyqyUObNfkmlBOiqg==", "9085a765-d3fb-4a75-b075-ab9d684f62d4" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 47, 38, 216, DateTimeKind.Local).AddTicks(3172), new DateTime(2024, 2, 1, 3, 47, 38, 216, DateTimeKind.Local).AddTicks(3173) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 47, 38, 216, DateTimeKind.Local).AddTicks(3175), new DateTime(2024, 2, 1, 3, 47, 38, 216, DateTimeKind.Local).AddTicks(3190) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 47, 38, 416, DateTimeKind.Local).AddTicks(3521), new DateTime(2024, 2, 1, 3, 47, 38, 416, DateTimeKind.Local).AddTicks(3565) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 47, 38, 416, DateTimeKind.Local).AddTicks(3580), new DateTime(2024, 2, 1, 3, 47, 38, 416, DateTimeKind.Local).AddTicks(3580) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 47, 38, 416, DateTimeKind.Local).AddTicks(4373), new DateTime(2024, 2, 1, 3, 47, 38, 416, DateTimeKind.Local).AddTicks(4374), new DateTime(2024, 2, 1, 3, 47, 38, 416, DateTimeKind.Local).AddTicks(4372) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 47, 38, 416, DateTimeKind.Local).AddTicks(4381), new DateTime(2024, 2, 1, 3, 47, 38, 416, DateTimeKind.Local).AddTicks(4381), new DateTime(2024, 2, 1, 3, 47, 38, 416, DateTimeKind.Local).AddTicks(4380) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 47, 38, 216, DateTimeKind.Local).AddTicks(3676), new DateTime(2024, 2, 1, 3, 47, 38, 216, DateTimeKind.Local).AddTicks(3677) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 47, 38, 216, DateTimeKind.Local).AddTicks(3679), new DateTime(2024, 2, 1, 3, 47, 38, 216, DateTimeKind.Local).AddTicks(3680) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 19, 47, 38, 416, DateTimeKind.Utc).AddTicks(4654), new DateTime(2024, 1, 31, 19, 47, 38, 416, DateTimeKind.Utc).AddTicks(4654) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 19, 47, 38, 416, DateTimeKind.Utc).AddTicks(4656), new DateTime(2024, 1, 31, 19, 47, 38, 416, DateTimeKind.Utc).AddTicks(4657) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 47, 38, 216, DateTimeKind.Local).AddTicks(3460), new DateTime(2024, 2, 1, 3, 47, 38, 216, DateTimeKind.Local).AddTicks(3461) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 47, 38, 216, DateTimeKind.Local).AddTicks(3463), new DateTime(2024, 2, 1, 3, 47, 38, 216, DateTimeKind.Local).AddTicks(3463) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 47, 38, 416, DateTimeKind.Local).AddTicks(4902), new DateTime(2024, 2, 1, 3, 47, 38, 416, DateTimeKind.Local).AddTicks(4903) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 47, 38, 416, DateTimeKind.Local).AddTicks(4905), new DateTime(2024, 2, 1, 3, 47, 38, 416, DateTimeKind.Local).AddTicks(4905) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 47, 38, 216, DateTimeKind.Local).AddTicks(4245), new DateTime(2024, 2, 1, 3, 47, 38, 216, DateTimeKind.Local).AddTicks(4247) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 47, 38, 216, DateTimeKind.Local).AddTicks(4249), new DateTime(2024, 2, 1, 3, 47, 38, 216, DateTimeKind.Local).AddTicks(4250) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 47, 38, 216, DateTimeKind.Local).AddTicks(2341), new DateTime(2024, 2, 1, 3, 47, 38, 216, DateTimeKind.Local).AddTicks(2354) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 47, 38, 216, DateTimeKind.Local).AddTicks(2361), new DateTime(2024, 2, 1, 3, 47, 38, 216, DateTimeKind.Local).AddTicks(2362) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 47, 38, 416, DateTimeKind.Local).AddTicks(4026), new DateTime(2024, 2, 1, 3, 47, 38, 416, DateTimeKind.Local).AddTicks(4024), new DateTime(2024, 2, 1, 3, 47, 38, 416, DateTimeKind.Local).AddTicks(4023), new DateTime(2024, 2, 1, 3, 47, 38, 416, DateTimeKind.Local).AddTicks(4026) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 47, 38, 416, DateTimeKind.Local).AddTicks(4032), new DateTime(2024, 2, 1, 3, 47, 38, 416, DateTimeKind.Local).AddTicks(4031), new DateTime(2024, 2, 1, 3, 47, 38, 416, DateTimeKind.Local).AddTicks(4031), new DateTime(2024, 2, 1, 3, 47, 38, 416, DateTimeKind.Local).AddTicks(4032) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Staffs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Role",
                table: "Staffs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PhoneNumber",
                table: "Staffs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Staffs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Staffs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
    }
}
