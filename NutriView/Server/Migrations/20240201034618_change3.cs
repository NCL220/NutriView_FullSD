using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NutriView.Server.Migrations
{
    /// <inheritdoc />
    public partial class change3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1507dbd1-1c83-4ad2-9b0e-4d298c7b4521",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ef79c4eb-f25a-4267-8652-e54ccc369f81", "AQAAAAIAAYagAAAAEKqXLJNd4O6/glGRPN4j1lMCmraVVPuaf2FMaF7bNKFZyPaUjztZS023aInGFYegww==", "eec68b65-0dfb-46f6-ab75-b7715f9b48c0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41624b27-7496-447c-b299-4892483d6b47",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1a62a5b1-9a02-484f-98c9-05919b6fa495", "AQAAAAIAAYagAAAAEB1rXQ0s5WqCXLB7E3CIf9CZ/7spUV2ka5Oxj2qNPgj3X0fGKMbjKCe3EMKhpIv0ig==", "1a526a09-0a6c-42de-bcc3-e1c63b0007de" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d3dfcba-a0af-4b10-989d-d63dcfec5e97",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6763546e-18f7-479e-b59d-163e6f1a7056", "AQAAAAIAAYagAAAAEHoM1c3SRkCL5MiEd8Cb1SDfS0r9vE9jItrDGbIyLOFOmEPdXhFzoFmLii1w4DMDxA==", "5fa8d42b-eb33-4c79-b734-6184e57543b5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8aa738a7-6c07-4e5a-8a7f-5637388c41b4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa6aba72-8876-4b38-8cef-82b4c88c6e87", "AQAAAAIAAYagAAAAEE7hbVfiSMyshdwvmvyFblKr1po3fHsrpk3H1h1xTi6LIabYZOECbwiw8igpANwFpg==", "ac37316e-6d80-49ed-aebc-183e7baade1c" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 46, 18, 76, DateTimeKind.Local).AddTicks(9979), new DateTime(2024, 2, 1, 11, 46, 18, 76, DateTimeKind.Local).AddTicks(9980) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 46, 18, 76, DateTimeKind.Local).AddTicks(9982), new DateTime(2024, 2, 1, 11, 46, 18, 76, DateTimeKind.Local).AddTicks(9982) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 46, 18, 348, DateTimeKind.Local).AddTicks(9298), new DateTime(2024, 2, 1, 11, 46, 18, 348, DateTimeKind.Local).AddTicks(9315) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 46, 18, 348, DateTimeKind.Local).AddTicks(9318), new DateTime(2024, 2, 1, 11, 46, 18, 348, DateTimeKind.Local).AddTicks(9319) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 46, 18, 348, DateTimeKind.Local).AddTicks(9829), new DateTime(2024, 2, 1, 11, 46, 18, 348, DateTimeKind.Local).AddTicks(9830), new DateTime(2024, 2, 1, 11, 46, 18, 348, DateTimeKind.Local).AddTicks(9828) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 46, 18, 348, DateTimeKind.Local).AddTicks(9832), new DateTime(2024, 2, 1, 11, 46, 18, 348, DateTimeKind.Local).AddTicks(9833), new DateTime(2024, 2, 1, 11, 46, 18, 348, DateTimeKind.Local).AddTicks(9832) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 46, 18, 77, DateTimeKind.Local).AddTicks(388), new DateTime(2024, 2, 1, 11, 46, 18, 77, DateTimeKind.Local).AddTicks(389) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 46, 18, 77, DateTimeKind.Local).AddTicks(392), new DateTime(2024, 2, 1, 11, 46, 18, 77, DateTimeKind.Local).AddTicks(392) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 46, 18, 349, DateTimeKind.Utc).AddTicks(157), new DateTime(2024, 2, 1, 3, 46, 18, 349, DateTimeKind.Utc).AddTicks(158) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 46, 18, 349, DateTimeKind.Utc).AddTicks(160), new DateTime(2024, 2, 1, 3, 46, 18, 349, DateTimeKind.Utc).AddTicks(160) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 46, 18, 77, DateTimeKind.Local).AddTicks(190), new DateTime(2024, 2, 1, 11, 46, 18, 77, DateTimeKind.Local).AddTicks(191) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 46, 18, 77, DateTimeKind.Local).AddTicks(193), new DateTime(2024, 2, 1, 11, 46, 18, 77, DateTimeKind.Local).AddTicks(194) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 46, 18, 349, DateTimeKind.Local).AddTicks(453), new DateTime(2024, 2, 1, 11, 46, 18, 349, DateTimeKind.Local).AddTicks(455) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 46, 18, 349, DateTimeKind.Local).AddTicks(457), new DateTime(2024, 2, 1, 11, 46, 18, 349, DateTimeKind.Local).AddTicks(458) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 46, 18, 77, DateTimeKind.Local).AddTicks(922), new DateTime(2024, 2, 1, 11, 46, 18, 77, DateTimeKind.Local).AddTicks(924) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 46, 18, 77, DateTimeKind.Local).AddTicks(926), new DateTime(2024, 2, 1, 11, 46, 18, 77, DateTimeKind.Local).AddTicks(927) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 46, 18, 76, DateTimeKind.Local).AddTicks(9392), new DateTime(2024, 2, 1, 11, 46, 18, 76, DateTimeKind.Local).AddTicks(9401) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 46, 18, 76, DateTimeKind.Local).AddTicks(9404), new DateTime(2024, 2, 1, 11, 46, 18, 76, DateTimeKind.Local).AddTicks(9405) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 46, 18, 348, DateTimeKind.Local).AddTicks(9593), new DateTime(2024, 2, 1, 11, 46, 18, 348, DateTimeKind.Local).AddTicks(9592), new DateTime(2024, 2, 1, 11, 46, 18, 348, DateTimeKind.Local).AddTicks(9590), new DateTime(2024, 2, 1, 11, 46, 18, 348, DateTimeKind.Local).AddTicks(9593) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 46, 18, 348, DateTimeKind.Local).AddTicks(9596), new DateTime(2024, 2, 1, 11, 46, 18, 348, DateTimeKind.Local).AddTicks(9596), new DateTime(2024, 2, 1, 11, 46, 18, 348, DateTimeKind.Local).AddTicks(9595), new DateTime(2024, 2, 1, 11, 46, 18, 348, DateTimeKind.Local).AddTicks(9596) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1507dbd1-1c83-4ad2-9b0e-4d298c7b4521",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cdc2d4e5-b100-4201-8362-81c29f7317b5", "AQAAAAIAAYagAAAAEK4QS9oyQRSOH73z+UQd+S28NjwPYwy7L1U5zZ4hWD8FawELce4ufCvrGtF6XRxiIg==", "dbfda61b-7157-419d-ba9b-d84468f3dc1e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41624b27-7496-447c-b299-4892483d6b47",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a178db3-a6dd-4b2e-98e6-48501a4db840", "AQAAAAIAAYagAAAAENkFSW1NLNe3nFyk7Tw48XnoC0hsJ3sjs12b1B2fNG+N1S+4lRPAYHhUFoZnrkqZgw==", "9c76b052-e43f-4a88-9aa0-dc101e586396" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d3dfcba-a0af-4b10-989d-d63dcfec5e97",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b4c693c-9b0e-49fa-bdcb-cc14d50e9be0", "AQAAAAIAAYagAAAAECkvKGEEfnrrTLVwHeV7NKOjNzhNUmXJNjpCiwIJnq4feuJYVm+1q+uCMq9l8ajc6Q==", "9483636b-b24b-4369-83aa-713f1c270080" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8aa738a7-6c07-4e5a-8a7f-5637388c41b4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ed25f74-f3e1-41be-98d4-d1e6842904de", "AQAAAAIAAYagAAAAECJEGeWf2E2AbzAo/TtfUoa9KeaLqDkIqKowsQu92ioFesQbRXcPqBwOyKWVwXEYeQ==", "4737c80b-5f08-4137-8abc-4598a57411c4" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 39, 49, 392, DateTimeKind.Local).AddTicks(3110), new DateTime(2024, 2, 1, 11, 39, 49, 392, DateTimeKind.Local).AddTicks(3111) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 39, 49, 392, DateTimeKind.Local).AddTicks(3113), new DateTime(2024, 2, 1, 11, 39, 49, 392, DateTimeKind.Local).AddTicks(3113) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 39, 49, 654, DateTimeKind.Local).AddTicks(4614), new DateTime(2024, 2, 1, 11, 39, 49, 654, DateTimeKind.Local).AddTicks(4631) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 39, 49, 654, DateTimeKind.Local).AddTicks(4636), new DateTime(2024, 2, 1, 11, 39, 49, 654, DateTimeKind.Local).AddTicks(4636) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 39, 49, 654, DateTimeKind.Local).AddTicks(5206), new DateTime(2024, 2, 1, 11, 39, 49, 654, DateTimeKind.Local).AddTicks(5207), new DateTime(2024, 2, 1, 11, 39, 49, 654, DateTimeKind.Local).AddTicks(5205) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 39, 49, 654, DateTimeKind.Local).AddTicks(5210), new DateTime(2024, 2, 1, 11, 39, 49, 654, DateTimeKind.Local).AddTicks(5210), new DateTime(2024, 2, 1, 11, 39, 49, 654, DateTimeKind.Local).AddTicks(5209) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 39, 49, 392, DateTimeKind.Local).AddTicks(3548), new DateTime(2024, 2, 1, 11, 39, 49, 392, DateTimeKind.Local).AddTicks(3549) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 39, 49, 392, DateTimeKind.Local).AddTicks(3551), new DateTime(2024, 2, 1, 11, 39, 49, 392, DateTimeKind.Local).AddTicks(3551) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 39, 49, 654, DateTimeKind.Utc).AddTicks(5966), new DateTime(2024, 2, 1, 3, 39, 49, 654, DateTimeKind.Utc).AddTicks(5967) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 39, 49, 654, DateTimeKind.Utc).AddTicks(5969), new DateTime(2024, 2, 1, 3, 39, 49, 654, DateTimeKind.Utc).AddTicks(5970) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 39, 49, 392, DateTimeKind.Local).AddTicks(3323), new DateTime(2024, 2, 1, 11, 39, 49, 392, DateTimeKind.Local).AddTicks(3324) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 39, 49, 392, DateTimeKind.Local).AddTicks(3329), new DateTime(2024, 2, 1, 11, 39, 49, 392, DateTimeKind.Local).AddTicks(3330) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 39, 49, 654, DateTimeKind.Local).AddTicks(6302), new DateTime(2024, 2, 1, 11, 39, 49, 654, DateTimeKind.Local).AddTicks(6305) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 39, 49, 654, DateTimeKind.Local).AddTicks(6307), new DateTime(2024, 2, 1, 11, 39, 49, 654, DateTimeKind.Local).AddTicks(6308) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 39, 49, 392, DateTimeKind.Local).AddTicks(4063), new DateTime(2024, 2, 1, 11, 39, 49, 392, DateTimeKind.Local).AddTicks(4065) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 39, 49, 392, DateTimeKind.Local).AddTicks(4067), new DateTime(2024, 2, 1, 11, 39, 49, 392, DateTimeKind.Local).AddTicks(4067) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 39, 49, 392, DateTimeKind.Local).AddTicks(2632), new DateTime(2024, 2, 1, 11, 39, 49, 392, DateTimeKind.Local).AddTicks(2641) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 39, 49, 392, DateTimeKind.Local).AddTicks(2645), new DateTime(2024, 2, 1, 11, 39, 49, 392, DateTimeKind.Local).AddTicks(2645) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 39, 49, 654, DateTimeKind.Local).AddTicks(4951), new DateTime(2024, 2, 1, 11, 39, 49, 654, DateTimeKind.Local).AddTicks(4951), new DateTime(2024, 2, 1, 11, 39, 49, 654, DateTimeKind.Local).AddTicks(4949), new DateTime(2024, 2, 1, 11, 39, 49, 654, DateTimeKind.Local).AddTicks(4952) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 39, 49, 654, DateTimeKind.Local).AddTicks(4955), new DateTime(2024, 2, 1, 11, 39, 49, 654, DateTimeKind.Local).AddTicks(4955), new DateTime(2024, 2, 1, 11, 39, 49, 654, DateTimeKind.Local).AddTicks(4954), new DateTime(2024, 2, 1, 11, 39, 49, 654, DateTimeKind.Local).AddTicks(4956) });
        }
    }
}
