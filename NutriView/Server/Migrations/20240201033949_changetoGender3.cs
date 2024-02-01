using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NutriView.Server.Migrations
{
    /// <inheritdoc />
    public partial class changetoGender3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1507dbd1-1c83-4ad2-9b0e-4d298c7b4521",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cbf18cce-f6c9-452f-9996-c355c338ec24", "AQAAAAIAAYagAAAAEBVT8RcApSbLU4lStAznnSjJAQo9NuiY6DncSwurhM1Ymz0W76qIHJ0iIiAPveEXZQ==", "098c0f29-759e-417f-9f6f-8b57e2969f09" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41624b27-7496-447c-b299-4892483d6b47",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b7ee3c35-6482-4222-9fff-af8150919874", "AQAAAAIAAYagAAAAEJ3wGhNmncifzES8VW5u+izEqtHsWOKnlLK23rkKsTpiC61mpaHOCA8h/9HAHMLDLA==", "c11beef7-35f7-428b-ac8b-14acbddfc07f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d3dfcba-a0af-4b10-989d-d63dcfec5e97",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4db7448-8d3f-4a48-8981-b98914e326f3", "AQAAAAIAAYagAAAAEPZgQ/ZZ5vJp0vyq1cSA2FE0E+BZXmWWUfED8edaL63w/7ZzNIu3YpmAASMS2aDN1g==", "23372b4d-ea27-4b0c-84f6-ff20dc41c2a7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8aa738a7-6c07-4e5a-8a7f-5637388c41b4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a1e87e77-2388-44a8-8b56-a6b2cef93f3e", "AQAAAAIAAYagAAAAEAmrdxQ0I1+l9eZ5jev3S4+N51vDBQ5JhkXiv0I/oNEdpprGMGFcwCKgJiR1KaBEqg==", "c2e9f72d-2596-4323-81a6-40290762151f" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 31, 14, 641, DateTimeKind.Local).AddTicks(3660), new DateTime(2024, 2, 1, 11, 31, 14, 641, DateTimeKind.Local).AddTicks(3661) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 31, 14, 641, DateTimeKind.Local).AddTicks(3663), new DateTime(2024, 2, 1, 11, 31, 14, 641, DateTimeKind.Local).AddTicks(3663) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 31, 14, 907, DateTimeKind.Local).AddTicks(6651), new DateTime(2024, 2, 1, 11, 31, 14, 907, DateTimeKind.Local).AddTicks(6664) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 31, 14, 907, DateTimeKind.Local).AddTicks(6667), new DateTime(2024, 2, 1, 11, 31, 14, 907, DateTimeKind.Local).AddTicks(6667) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 31, 14, 907, DateTimeKind.Local).AddTicks(7190), new DateTime(2024, 2, 1, 11, 31, 14, 907, DateTimeKind.Local).AddTicks(7191), new DateTime(2024, 2, 1, 11, 31, 14, 907, DateTimeKind.Local).AddTicks(7189) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 31, 14, 907, DateTimeKind.Local).AddTicks(7193), new DateTime(2024, 2, 1, 11, 31, 14, 907, DateTimeKind.Local).AddTicks(7194), new DateTime(2024, 2, 1, 11, 31, 14, 907, DateTimeKind.Local).AddTicks(7193) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 31, 14, 641, DateTimeKind.Local).AddTicks(4068), new DateTime(2024, 2, 1, 11, 31, 14, 641, DateTimeKind.Local).AddTicks(4068) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 31, 14, 641, DateTimeKind.Local).AddTicks(4071), new DateTime(2024, 2, 1, 11, 31, 14, 641, DateTimeKind.Local).AddTicks(4071) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 31, 14, 907, DateTimeKind.Utc).AddTicks(7516), new DateTime(2024, 2, 1, 3, 31, 14, 907, DateTimeKind.Utc).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 3, 31, 14, 907, DateTimeKind.Utc).AddTicks(7518), new DateTime(2024, 2, 1, 3, 31, 14, 907, DateTimeKind.Utc).AddTicks(7519) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 31, 14, 641, DateTimeKind.Local).AddTicks(3866), new DateTime(2024, 2, 1, 11, 31, 14, 641, DateTimeKind.Local).AddTicks(3867) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 31, 14, 641, DateTimeKind.Local).AddTicks(3869), new DateTime(2024, 2, 1, 11, 31, 14, 641, DateTimeKind.Local).AddTicks(3869) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 31, 14, 907, DateTimeKind.Local).AddTicks(7831), new DateTime(2024, 2, 1, 11, 31, 14, 907, DateTimeKind.Local).AddTicks(7833) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 31, 14, 907, DateTimeKind.Local).AddTicks(7835), new DateTime(2024, 2, 1, 11, 31, 14, 907, DateTimeKind.Local).AddTicks(7835) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 31, 14, 641, DateTimeKind.Local).AddTicks(4554), new DateTime(2024, 2, 1, 11, 31, 14, 641, DateTimeKind.Local).AddTicks(4555) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 31, 14, 641, DateTimeKind.Local).AddTicks(4558), new DateTime(2024, 2, 1, 11, 31, 14, 641, DateTimeKind.Local).AddTicks(4559) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 31, 14, 641, DateTimeKind.Local).AddTicks(3165), new DateTime(2024, 2, 1, 11, 31, 14, 641, DateTimeKind.Local).AddTicks(3174) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 31, 14, 641, DateTimeKind.Local).AddTicks(3177), new DateTime(2024, 2, 1, 11, 31, 14, 641, DateTimeKind.Local).AddTicks(3177) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 31, 14, 907, DateTimeKind.Local).AddTicks(6942), new DateTime(2024, 2, 1, 11, 31, 14, 907, DateTimeKind.Local).AddTicks(6942), new DateTime(2024, 2, 1, 11, 31, 14, 907, DateTimeKind.Local).AddTicks(6941), new DateTime(2024, 2, 1, 11, 31, 14, 907, DateTimeKind.Local).AddTicks(6943) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 1, 11, 31, 14, 907, DateTimeKind.Local).AddTicks(6946), new DateTime(2024, 2, 1, 11, 31, 14, 907, DateTimeKind.Local).AddTicks(6945), new DateTime(2024, 2, 1, 11, 31, 14, 907, DateTimeKind.Local).AddTicks(6945), new DateTime(2024, 2, 1, 11, 31, 14, 907, DateTimeKind.Local).AddTicks(6946) });
        }
    }
}
