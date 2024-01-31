using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NutriView.Server.Migrations
{
    /// <inheritdoc />
    public partial class hdhdhee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1507dbd1-1c83-4ad2-9b0e-4d298c7b4521",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f28d9967-dc46-4574-a130-ce20267ab610", "AQAAAAIAAYagAAAAEH9MdjEGRl3ccv7N/sPsdLZppMcU4u4wW5NXFjb7i6Zr7UglxZIfuUo0XMZ8MCdRNg==", "2282831b-851d-4c73-96d6-3dc3459b3042" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41624b27-7496-447c-b299-4892483d6b47",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "33bc6387-010c-4ded-8727-5047800c653f", "AQAAAAIAAYagAAAAEAzm3YFWZqI9+L9K9x02cnUOI6Zric6pedVgNMFUu+LukAYFNKF/4l14vWCpEUvRxg==", "6ec3a71e-135e-4c5b-8661-d5456a598bd3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d3dfcba-a0af-4b10-989d-d63dcfec5e97",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cf3f6b04-2cce-4520-8f08-204aa479f8bb", "AQAAAAIAAYagAAAAEHFrifA6YfyThe38yoRfAGRUqnTTVoDzaEKQZOsMyAyYzGSSrANJWZuL04KNJzJrWA==", "bb542d51-281e-4a67-87ea-cb5ae25c850f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8aa738a7-6c07-4e5a-8a7f-5637388c41b4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4333274b-4fc0-4e0c-a20b-5deb40eac12c", "AQAAAAIAAYagAAAAEIZ6UIhKfr+SHS5BEmmoSjDXutrKem54A/zZMcRrZ8V8PmYBAYzOalyL3Xgmnq0Gmg==", "f5b3adc9-0dfb-40d9-bb43-2c1685799746" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 49, 26, 70, DateTimeKind.Local).AddTicks(8747), new DateTime(2024, 2, 1, 2, 49, 26, 70, DateTimeKind.Local).AddTicks(8748) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 49, 26, 70, DateTimeKind.Local).AddTicks(8751), new DateTime(2024, 2, 1, 2, 49, 26, 70, DateTimeKind.Local).AddTicks(8751) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 49, 26, 274, DateTimeKind.Local).AddTicks(7048), new DateTime(2024, 2, 1, 2, 49, 26, 274, DateTimeKind.Local).AddTicks(7071) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 49, 26, 274, DateTimeKind.Local).AddTicks(7077), new DateTime(2024, 2, 1, 2, 49, 26, 274, DateTimeKind.Local).AddTicks(7078) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 49, 26, 274, DateTimeKind.Local).AddTicks(7529), new DateTime(2024, 2, 1, 2, 49, 26, 274, DateTimeKind.Local).AddTicks(7529), new DateTime(2024, 2, 1, 2, 49, 26, 274, DateTimeKind.Local).AddTicks(7527) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 49, 26, 274, DateTimeKind.Local).AddTicks(7531), new DateTime(2024, 2, 1, 2, 49, 26, 274, DateTimeKind.Local).AddTicks(7532), new DateTime(2024, 2, 1, 2, 49, 26, 274, DateTimeKind.Local).AddTicks(7531) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 49, 26, 70, DateTimeKind.Local).AddTicks(9273), new DateTime(2024, 2, 1, 2, 49, 26, 70, DateTimeKind.Local).AddTicks(9274) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 49, 26, 70, DateTimeKind.Local).AddTicks(9277), new DateTime(2024, 2, 1, 2, 49, 26, 70, DateTimeKind.Local).AddTicks(9277) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 18, 49, 26, 275, DateTimeKind.Utc).AddTicks(574), new DateTime(2024, 1, 31, 18, 49, 26, 275, DateTimeKind.Utc).AddTicks(575) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 18, 49, 26, 275, DateTimeKind.Utc).AddTicks(578), new DateTime(2024, 1, 31, 18, 49, 26, 275, DateTimeKind.Utc).AddTicks(579) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 49, 26, 70, DateTimeKind.Local).AddTicks(9086), new DateTime(2024, 2, 1, 2, 49, 26, 70, DateTimeKind.Local).AddTicks(9087) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 49, 26, 70, DateTimeKind.Local).AddTicks(9089), new DateTime(2024, 2, 1, 2, 49, 26, 70, DateTimeKind.Local).AddTicks(9090) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 49, 26, 275, DateTimeKind.Local).AddTicks(975), new DateTime(2024, 2, 1, 2, 49, 26, 275, DateTimeKind.Local).AddTicks(980) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 49, 26, 275, DateTimeKind.Local).AddTicks(988), new DateTime(2024, 2, 1, 2, 49, 26, 275, DateTimeKind.Local).AddTicks(988) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 49, 26, 70, DateTimeKind.Local).AddTicks(9810), new DateTime(2024, 2, 1, 2, 49, 26, 70, DateTimeKind.Local).AddTicks(9811) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 49, 26, 70, DateTimeKind.Local).AddTicks(9814), new DateTime(2024, 2, 1, 2, 49, 26, 70, DateTimeKind.Local).AddTicks(9814) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 49, 26, 70, DateTimeKind.Local).AddTicks(8070), new DateTime(2024, 2, 1, 2, 49, 26, 70, DateTimeKind.Local).AddTicks(8083) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 49, 26, 70, DateTimeKind.Local).AddTicks(8086), new DateTime(2024, 2, 1, 2, 49, 26, 70, DateTimeKind.Local).AddTicks(8087) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 49, 26, 274, DateTimeKind.Local).AddTicks(7324), new DateTime(2024, 2, 1, 2, 49, 26, 274, DateTimeKind.Local).AddTicks(7322), new DateTime(2024, 2, 1, 2, 49, 26, 274, DateTimeKind.Local).AddTicks(7320), new DateTime(2024, 2, 1, 2, 49, 26, 274, DateTimeKind.Local).AddTicks(7324) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 49, 26, 274, DateTimeKind.Local).AddTicks(7327), new DateTime(2024, 2, 1, 2, 49, 26, 274, DateTimeKind.Local).AddTicks(7326), new DateTime(2024, 2, 1, 2, 49, 26, 274, DateTimeKind.Local).AddTicks(7326), new DateTime(2024, 2, 1, 2, 49, 26, 274, DateTimeKind.Local).AddTicks(7327) });
        }
    }
}
