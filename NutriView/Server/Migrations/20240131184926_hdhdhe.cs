using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NutriView.Server.Migrations
{
    /// <inheritdoc />
    public partial class hdhdhe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Foods",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FoodDesc",
                table: "Foods",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Foods",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "FoodDesc",
                table: "Foods",
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
                values: new object[] { "caf1ccae-6b40-457d-9928-8a7512d1a94c", "AQAAAAIAAYagAAAAEPnhrCvFTe7i3v2Z7ySaLkw/XPqkGF0OSngnroqtnQkW0iJeReQFZ/1pYEJGwbQSpA==", "bbcdfb80-3b59-4920-9f56-0c3656724cf4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41624b27-7496-447c-b299-4892483d6b47",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f16e501f-2046-45de-b4ce-99b2406f8b20", "AQAAAAIAAYagAAAAEKnMJBUQZtbSX8maYuAe5jX6uSQejuWH+lBiKcqd/vk6iYq/SwFKf8CvP6AXj2n7dw==", "d143ece2-5a62-4d0a-93f3-07739c5f2050" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d3dfcba-a0af-4b10-989d-d63dcfec5e97",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "73ff413a-dd5f-46c2-9cf4-a1edafe01131", "AQAAAAIAAYagAAAAEObcQ9eNquNhkDPwopgaKQFPCd9BXkrB8GXcs+l1x3r9SezDb0ALaWQZl9nO7QbZZA==", "7996c743-2ab0-4245-92fe-aa1e92e36db7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8aa738a7-6c07-4e5a-8a7f-5637388c41b4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1077e746-96b0-4f00-bb79-726e6f3c5b4d", "AQAAAAIAAYagAAAAEByShVWfYrLdLmn4K26zhFUflNbMXw8rifn2keOiXb+x35JjEqZ8rOkVPKejWNbn7g==", "2f9052fb-7983-4a34-ab7a-3b03a95fdb21" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 43, 53, 808, DateTimeKind.Local).AddTicks(2198), new DateTime(2024, 2, 1, 2, 43, 53, 808, DateTimeKind.Local).AddTicks(2199) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 43, 53, 808, DateTimeKind.Local).AddTicks(2201), new DateTime(2024, 2, 1, 2, 43, 53, 808, DateTimeKind.Local).AddTicks(2202) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 43, 54, 20, DateTimeKind.Local).AddTicks(240), new DateTime(2024, 2, 1, 2, 43, 54, 20, DateTimeKind.Local).AddTicks(261) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 43, 54, 20, DateTimeKind.Local).AddTicks(265), new DateTime(2024, 2, 1, 2, 43, 54, 20, DateTimeKind.Local).AddTicks(265) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 43, 54, 20, DateTimeKind.Local).AddTicks(719), new DateTime(2024, 2, 1, 2, 43, 54, 20, DateTimeKind.Local).AddTicks(720), new DateTime(2024, 2, 1, 2, 43, 54, 20, DateTimeKind.Local).AddTicks(717) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 43, 54, 20, DateTimeKind.Local).AddTicks(722), new DateTime(2024, 2, 1, 2, 43, 54, 20, DateTimeKind.Local).AddTicks(722), new DateTime(2024, 2, 1, 2, 43, 54, 20, DateTimeKind.Local).AddTicks(721) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 43, 53, 808, DateTimeKind.Local).AddTicks(2592), new DateTime(2024, 2, 1, 2, 43, 53, 808, DateTimeKind.Local).AddTicks(2593) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 43, 53, 808, DateTimeKind.Local).AddTicks(2596), new DateTime(2024, 2, 1, 2, 43, 53, 808, DateTimeKind.Local).AddTicks(2596) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 18, 43, 54, 20, DateTimeKind.Utc).AddTicks(3835), new DateTime(2024, 1, 31, 18, 43, 54, 20, DateTimeKind.Utc).AddTicks(3836) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 18, 43, 54, 20, DateTimeKind.Utc).AddTicks(3839), new DateTime(2024, 1, 31, 18, 43, 54, 20, DateTimeKind.Utc).AddTicks(3840) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 43, 53, 808, DateTimeKind.Local).AddTicks(2395), new DateTime(2024, 2, 1, 2, 43, 53, 808, DateTimeKind.Local).AddTicks(2396) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 43, 53, 808, DateTimeKind.Local).AddTicks(2398), new DateTime(2024, 2, 1, 2, 43, 53, 808, DateTimeKind.Local).AddTicks(2399) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 43, 54, 20, DateTimeKind.Local).AddTicks(4297), new DateTime(2024, 2, 1, 2, 43, 54, 20, DateTimeKind.Local).AddTicks(4303) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 43, 54, 20, DateTimeKind.Local).AddTicks(4305), new DateTime(2024, 2, 1, 2, 43, 54, 20, DateTimeKind.Local).AddTicks(4306) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 43, 53, 808, DateTimeKind.Local).AddTicks(3133), new DateTime(2024, 2, 1, 2, 43, 53, 808, DateTimeKind.Local).AddTicks(3134) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 43, 53, 808, DateTimeKind.Local).AddTicks(3137), new DateTime(2024, 2, 1, 2, 43, 53, 808, DateTimeKind.Local).AddTicks(3137) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 43, 53, 808, DateTimeKind.Local).AddTicks(1428), new DateTime(2024, 2, 1, 2, 43, 53, 808, DateTimeKind.Local).AddTicks(1440) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 43, 53, 808, DateTimeKind.Local).AddTicks(1443), new DateTime(2024, 2, 1, 2, 43, 53, 808, DateTimeKind.Local).AddTicks(1444) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 43, 54, 20, DateTimeKind.Local).AddTicks(515), new DateTime(2024, 2, 1, 2, 43, 54, 20, DateTimeKind.Local).AddTicks(513), new DateTime(2024, 2, 1, 2, 43, 54, 20, DateTimeKind.Local).AddTicks(512), new DateTime(2024, 2, 1, 2, 43, 54, 20, DateTimeKind.Local).AddTicks(515) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 2, 43, 54, 20, DateTimeKind.Local).AddTicks(518), new DateTime(2024, 2, 1, 2, 43, 54, 20, DateTimeKind.Local).AddTicks(518), new DateTime(2024, 2, 1, 2, 43, 54, 20, DateTimeKind.Local).AddTicks(517), new DateTime(2024, 2, 1, 2, 43, 54, 20, DateTimeKind.Local).AddTicks(519) });
        }
    }
}
