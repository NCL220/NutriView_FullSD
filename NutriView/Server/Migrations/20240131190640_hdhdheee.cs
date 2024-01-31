using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NutriView.Server.Migrations
{
    /// <inheritdoc />
    public partial class hdhdheee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TimePeriod",
                table: "Meals",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Meals",
                type: "nvarchar(200)",
                maxLength: 200,
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TimePeriod",
                table: "Meals",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Meals",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1507dbd1-1c83-4ad2-9b0e-4d298c7b4521",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b8ca95e-6e32-416c-baf9-39e7016956a9", "AQAAAAIAAYagAAAAEAWxzGrijsp5VprBF4mzMlVKPh/q3j0ZTsYLin1YOJhkfHnTFDk4CIYu4bMTRheMug==", "00eaf85d-0fe5-4ed9-bd77-0187e5314084" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41624b27-7496-447c-b299-4892483d6b47",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea93e2c4-9533-46c2-995f-523d562487ea", "AQAAAAIAAYagAAAAEFJar8g9UoN5y2Yh0ThOtaSxI7UjXKGIGcSwropJ9Z4Fr2Ho5IDan5tGlTrq9hxnGQ==", "9dcc775f-4166-46ae-acf8-3e17e70efd94" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d3dfcba-a0af-4b10-989d-d63dcfec5e97",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "78c790d6-7914-497a-bda0-7fa6da3aa58e", "AQAAAAIAAYagAAAAEFpRBEOkPceGqyz596tIe5EIv3W2xwnm4isI4aAnc6o+ZdSdTCzLgbi/8s3BydE+bw==", "95a3cdd4-7035-42d7-a76f-e13f5f696745" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8aa738a7-6c07-4e5a-8a7f-5637388c41b4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ced98e33-3b2b-47d8-bdd2-c25bd872bc12", "AQAAAAIAAYagAAAAEJ0MDUVNSt6oUyvysSTbkyx5MAuXuR4oJr9FvzryG6Yh6b2aeFJCZ7vL2IhSpg2XBw==", "d7423b9e-a49f-407a-9886-44a743edae65" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 53, 18, 494, DateTimeKind.Local).AddTicks(7584), new DateTime(2024, 2, 1, 2, 53, 18, 494, DateTimeKind.Local).AddTicks(7585) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 53, 18, 494, DateTimeKind.Local).AddTicks(7627), new DateTime(2024, 2, 1, 2, 53, 18, 494, DateTimeKind.Local).AddTicks(7627) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 53, 18, 717, DateTimeKind.Local).AddTicks(2920), new DateTime(2024, 2, 1, 2, 53, 18, 717, DateTimeKind.Local).AddTicks(2939) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 53, 18, 717, DateTimeKind.Local).AddTicks(2943), new DateTime(2024, 2, 1, 2, 53, 18, 717, DateTimeKind.Local).AddTicks(2944) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 53, 18, 717, DateTimeKind.Local).AddTicks(3716), new DateTime(2024, 2, 1, 2, 53, 18, 717, DateTimeKind.Local).AddTicks(3717), new DateTime(2024, 2, 1, 2, 53, 18, 717, DateTimeKind.Local).AddTicks(3713) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 53, 18, 717, DateTimeKind.Local).AddTicks(3721), new DateTime(2024, 2, 1, 2, 53, 18, 717, DateTimeKind.Local).AddTicks(3721), new DateTime(2024, 2, 1, 2, 53, 18, 717, DateTimeKind.Local).AddTicks(3720) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 53, 18, 494, DateTimeKind.Local).AddTicks(8005), new DateTime(2024, 2, 1, 2, 53, 18, 494, DateTimeKind.Local).AddTicks(8006) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 53, 18, 494, DateTimeKind.Local).AddTicks(8009), new DateTime(2024, 2, 1, 2, 53, 18, 494, DateTimeKind.Local).AddTicks(8009) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 18, 53, 18, 717, DateTimeKind.Utc).AddTicks(4250), new DateTime(2024, 1, 31, 18, 53, 18, 717, DateTimeKind.Utc).AddTicks(4252) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 18, 53, 18, 717, DateTimeKind.Utc).AddTicks(4253), new DateTime(2024, 1, 31, 18, 53, 18, 717, DateTimeKind.Utc).AddTicks(4254) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 53, 18, 494, DateTimeKind.Local).AddTicks(7818), new DateTime(2024, 2, 1, 2, 53, 18, 494, DateTimeKind.Local).AddTicks(7819) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 53, 18, 494, DateTimeKind.Local).AddTicks(7821), new DateTime(2024, 2, 1, 2, 53, 18, 494, DateTimeKind.Local).AddTicks(7821) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 53, 18, 717, DateTimeKind.Local).AddTicks(4559), new DateTime(2024, 2, 1, 2, 53, 18, 717, DateTimeKind.Local).AddTicks(4561) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 53, 18, 717, DateTimeKind.Local).AddTicks(4563), new DateTime(2024, 2, 1, 2, 53, 18, 717, DateTimeKind.Local).AddTicks(4563) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 53, 18, 494, DateTimeKind.Local).AddTicks(8499), new DateTime(2024, 2, 1, 2, 53, 18, 494, DateTimeKind.Local).AddTicks(8501) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 53, 18, 494, DateTimeKind.Local).AddTicks(8503), new DateTime(2024, 2, 1, 2, 53, 18, 494, DateTimeKind.Local).AddTicks(8504) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 53, 18, 494, DateTimeKind.Local).AddTicks(6929), new DateTime(2024, 2, 1, 2, 53, 18, 494, DateTimeKind.Local).AddTicks(6941) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 53, 18, 494, DateTimeKind.Local).AddTicks(6945), new DateTime(2024, 2, 1, 2, 53, 18, 494, DateTimeKind.Local).AddTicks(6945) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 53, 18, 717, DateTimeKind.Local).AddTicks(3346), new DateTime(2024, 2, 1, 2, 53, 18, 717, DateTimeKind.Local).AddTicks(3346), new DateTime(2024, 2, 1, 2, 53, 18, 717, DateTimeKind.Local).AddTicks(3343), new DateTime(2024, 2, 1, 2, 53, 18, 717, DateTimeKind.Local).AddTicks(3352) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 53, 18, 717, DateTimeKind.Local).AddTicks(3399), new DateTime(2024, 2, 1, 2, 53, 18, 717, DateTimeKind.Local).AddTicks(3399), new DateTime(2024, 2, 1, 2, 53, 18, 717, DateTimeKind.Local).AddTicks(3398), new DateTime(2024, 2, 1, 2, 53, 18, 717, DateTimeKind.Local).AddTicks(3400) });
        }
    }
}
