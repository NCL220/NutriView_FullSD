using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NutriView.Server.Migrations
{
    /// <inheritdoc />
    public partial class yay : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1507dbd1-1c83-4ad2-9b0e-4d298c7b4521",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa8a1e1d-66ef-4ab2-a9dd-295ca0fed32e", "AQAAAAIAAYagAAAAEAtfv7YcCJLLQ9C3xi6EXUzdbH0D7soZF/MhvFoP5sJHwaVeRQADvopiReYWzUCwXA==", "03ce4e8b-50ea-4abf-b674-9ecf7e4e398d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41624b27-7496-447c-b299-4892483d6b47",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1de93588-0e3a-4e83-ac7d-b65871657479", "AQAAAAIAAYagAAAAELCYHJxYpZHltanPMkshxomE79OFH2GekPmauDzd1kbGYnf/usb76ZeqNm4Kv3qDKA==", "ff31e164-81b3-4b19-b071-81ed16741b31" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d3dfcba-a0af-4b10-989d-d63dcfec5e97",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39cb22f4-fc98-4fb7-8e55-caa035360d75", "AQAAAAIAAYagAAAAELKq0CMYgYE6rghbvbY7B8RMiQyy00Mn88o2ZnrCG6kdbc0trD2Q/G1DvCPkJ86bGA==", "0ab60422-2e5d-4bba-bbe9-14c086576594" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8aa738a7-6c07-4e5a-8a7f-5637388c41b4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a644ebd-90b5-4853-b020-d8e0ffb96c5f", "AQAAAAIAAYagAAAAEEQB/uFEW81nVD2YkQc1lrXJE1fByTIYdACOnKL7p2AWD+DWnfLBZ7Pfm/3PvIOCjA==", "bd9dc198-0a08-4e96-bdbd-d3eb38b0e72d" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 17, 46, 15, 202, DateTimeKind.Local).AddTicks(8990), new DateTime(2024, 1, 27, 17, 46, 15, 202, DateTimeKind.Local).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 17, 46, 15, 202, DateTimeKind.Local).AddTicks(8991), new DateTime(2024, 1, 27, 17, 46, 15, 202, DateTimeKind.Local).AddTicks(8992) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 17, 46, 15, 389, DateTimeKind.Local).AddTicks(8250), new DateTime(2024, 1, 27, 17, 46, 15, 389, DateTimeKind.Local).AddTicks(8263) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 17, 46, 15, 389, DateTimeKind.Local).AddTicks(8265), new DateTime(2024, 1, 27, 17, 46, 15, 389, DateTimeKind.Local).AddTicks(8266) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 1, 27, 17, 46, 15, 389, DateTimeKind.Local).AddTicks(8668), new DateTime(2024, 1, 27, 17, 46, 15, 389, DateTimeKind.Local).AddTicks(8669), new DateTime(2024, 1, 27, 17, 46, 15, 389, DateTimeKind.Local).AddTicks(8667) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 1, 27, 17, 46, 15, 389, DateTimeKind.Local).AddTicks(8671), new DateTime(2024, 1, 27, 17, 46, 15, 389, DateTimeKind.Local).AddTicks(8672), new DateTime(2024, 1, 27, 17, 46, 15, 389, DateTimeKind.Local).AddTicks(8671) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 17, 46, 15, 202, DateTimeKind.Local).AddTicks(9305), new DateTime(2024, 1, 27, 17, 46, 15, 202, DateTimeKind.Local).AddTicks(9306) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 17, 46, 15, 202, DateTimeKind.Local).AddTicks(9307), new DateTime(2024, 1, 27, 17, 46, 15, 202, DateTimeKind.Local).AddTicks(9308) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 9, 46, 15, 389, DateTimeKind.Utc).AddTicks(9061), new DateTime(2024, 1, 27, 9, 46, 15, 389, DateTimeKind.Utc).AddTicks(9063) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 9, 46, 15, 389, DateTimeKind.Utc).AddTicks(9065), new DateTime(2024, 1, 27, 9, 46, 15, 389, DateTimeKind.Utc).AddTicks(9065) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 17, 46, 15, 202, DateTimeKind.Local).AddTicks(9145), new DateTime(2024, 1, 27, 17, 46, 15, 202, DateTimeKind.Local).AddTicks(9146) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 17, 46, 15, 202, DateTimeKind.Local).AddTicks(9147), new DateTime(2024, 1, 27, 17, 46, 15, 202, DateTimeKind.Local).AddTicks(9148) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 17, 46, 15, 389, DateTimeKind.Local).AddTicks(9400), new DateTime(2024, 1, 27, 17, 46, 15, 389, DateTimeKind.Local).AddTicks(9402) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 17, 46, 15, 389, DateTimeKind.Local).AddTicks(9437), new DateTime(2024, 1, 27, 17, 46, 15, 389, DateTimeKind.Local).AddTicks(9437) });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "ServiceDescription", "ServiceName", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test", "Test", null },
                    { 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test2", "Test2", null }
                });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 17, 46, 15, 202, DateTimeKind.Local).AddTicks(9988), new DateTime(2024, 1, 27, 17, 46, 15, 202, DateTimeKind.Local).AddTicks(9989) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 17, 46, 15, 202, DateTimeKind.Local).AddTicks(9991), new DateTime(2024, 1, 27, 17, 46, 15, 202, DateTimeKind.Local).AddTicks(9991) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 17, 46, 15, 202, DateTimeKind.Local).AddTicks(8823), new DateTime(2024, 1, 27, 17, 46, 15, 202, DateTimeKind.Local).AddTicks(8833) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 17, 46, 15, 202, DateTimeKind.Local).AddTicks(8835), new DateTime(2024, 1, 27, 17, 46, 15, 202, DateTimeKind.Local).AddTicks(8835) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 17, 46, 15, 389, DateTimeKind.Local).AddTicks(8481), new DateTime(2024, 1, 27, 17, 46, 15, 389, DateTimeKind.Local).AddTicks(8481), new DateTime(2024, 1, 27, 17, 46, 15, 389, DateTimeKind.Local).AddTicks(8479), new DateTime(2024, 1, 27, 17, 46, 15, 389, DateTimeKind.Local).AddTicks(8482) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 17, 46, 15, 389, DateTimeKind.Local).AddTicks(8484), new DateTime(2024, 1, 27, 17, 46, 15, 389, DateTimeKind.Local).AddTicks(8484), new DateTime(2024, 1, 27, 17, 46, 15, 389, DateTimeKind.Local).AddTicks(8484), new DateTime(2024, 1, 27, 17, 46, 15, 389, DateTimeKind.Local).AddTicks(8485) });

            migrationBuilder.InsertData(
                table: "ServiceLinkSubInfos",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "ServiceID", "SubscriptionInfoID", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, null },
                    { 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ServiceLinkSubInfos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ServiceLinkSubInfos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1507dbd1-1c83-4ad2-9b0e-4d298c7b4521",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2de6dea3-569b-4b52-a638-ec00fb619757", "AQAAAAIAAYagAAAAEGl4gikFaafkTvg/gJ8PfqsUxpbbVe/TivadpyByYadwmWnzqTjBbG/m6uwyifnd7g==", "a2cfacb2-23c9-45fc-b318-ed20ce073939" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41624b27-7496-447c-b299-4892483d6b47",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "70b3aeb4-5da0-4735-9079-68cda60da44c", "AQAAAAIAAYagAAAAEMOgyhuM2pYLKwFrZ3XCGtF7AxMV2YvnKi3TN4f60L4u6gPJH0uVNG1z8A1zifJJSA==", "5ca05c3f-8b83-41ad-bd14-687ff0738665" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d3dfcba-a0af-4b10-989d-d63dcfec5e97",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b087dfb9-01fc-4b59-bbf5-62ceeba8d79c", "AQAAAAIAAYagAAAAEOs0Lig2vjEu/5oXR8hTqCZE8jJsuBqLbosFIxmHTo2WtJe/c++SeaNX5zMJ/T3Ezw==", "94debd9f-4e58-4145-9434-3280c15ee8e7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8aa738a7-6c07-4e5a-8a7f-5637388c41b4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fba0a97d-b998-4a11-9e5f-d844e8320289", "AQAAAAIAAYagAAAAEMdI00F4Cg4jCXtUOLHeM5UHmlkDxH85NAp44IiORKwuz2E7d7Y33xdoY+c3zN3a5g==", "902f4b5e-4482-4131-bd41-2ec7133989fe" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 17, 39, 35, 841, DateTimeKind.Local).AddTicks(4413), new DateTime(2024, 1, 27, 17, 39, 35, 841, DateTimeKind.Local).AddTicks(4414) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 17, 39, 35, 841, DateTimeKind.Local).AddTicks(4416), new DateTime(2024, 1, 27, 17, 39, 35, 841, DateTimeKind.Local).AddTicks(4416) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 17, 39, 36, 28, DateTimeKind.Local).AddTicks(8129), new DateTime(2024, 1, 27, 17, 39, 36, 28, DateTimeKind.Local).AddTicks(8143) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 17, 39, 36, 28, DateTimeKind.Local).AddTicks(8146), new DateTime(2024, 1, 27, 17, 39, 36, 28, DateTimeKind.Local).AddTicks(8146) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 1, 27, 17, 39, 36, 28, DateTimeKind.Local).AddTicks(8563), new DateTime(2024, 1, 27, 17, 39, 36, 28, DateTimeKind.Local).AddTicks(8564), new DateTime(2024, 1, 27, 17, 39, 36, 28, DateTimeKind.Local).AddTicks(8562) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 1, 27, 17, 39, 36, 28, DateTimeKind.Local).AddTicks(8566), new DateTime(2024, 1, 27, 17, 39, 36, 28, DateTimeKind.Local).AddTicks(8567), new DateTime(2024, 1, 27, 17, 39, 36, 28, DateTimeKind.Local).AddTicks(8566) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 17, 39, 35, 841, DateTimeKind.Local).AddTicks(4747), new DateTime(2024, 1, 27, 17, 39, 35, 841, DateTimeKind.Local).AddTicks(4747) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 17, 39, 35, 841, DateTimeKind.Local).AddTicks(4749), new DateTime(2024, 1, 27, 17, 39, 35, 841, DateTimeKind.Local).AddTicks(4750) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 9, 39, 36, 28, DateTimeKind.Utc).AddTicks(8947), new DateTime(2024, 1, 27, 9, 39, 36, 28, DateTimeKind.Utc).AddTicks(8948) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 9, 39, 36, 28, DateTimeKind.Utc).AddTicks(8950), new DateTime(2024, 1, 27, 9, 39, 36, 28, DateTimeKind.Utc).AddTicks(8950) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 17, 39, 35, 841, DateTimeKind.Local).AddTicks(4586), new DateTime(2024, 1, 27, 17, 39, 35, 841, DateTimeKind.Local).AddTicks(4587) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 17, 39, 35, 841, DateTimeKind.Local).AddTicks(4588), new DateTime(2024, 1, 27, 17, 39, 35, 841, DateTimeKind.Local).AddTicks(4589) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 17, 39, 36, 28, DateTimeKind.Local).AddTicks(9199), new DateTime(2024, 1, 27, 17, 39, 36, 28, DateTimeKind.Local).AddTicks(9200) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 17, 39, 36, 28, DateTimeKind.Local).AddTicks(9202), new DateTime(2024, 1, 27, 17, 39, 36, 28, DateTimeKind.Local).AddTicks(9203) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 17, 39, 35, 841, DateTimeKind.Local).AddTicks(5472), new DateTime(2024, 1, 27, 17, 39, 35, 841, DateTimeKind.Local).AddTicks(5473) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 17, 39, 35, 841, DateTimeKind.Local).AddTicks(5475), new DateTime(2024, 1, 27, 17, 39, 35, 841, DateTimeKind.Local).AddTicks(5475) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 17, 39, 35, 841, DateTimeKind.Local).AddTicks(4236), new DateTime(2024, 1, 27, 17, 39, 35, 841, DateTimeKind.Local).AddTicks(4247) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 17, 39, 35, 841, DateTimeKind.Local).AddTicks(4249), new DateTime(2024, 1, 27, 17, 39, 35, 841, DateTimeKind.Local).AddTicks(4249) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 17, 39, 36, 28, DateTimeKind.Local).AddTicks(8367), new DateTime(2024, 1, 27, 17, 39, 36, 28, DateTimeKind.Local).AddTicks(8366), new DateTime(2024, 1, 27, 17, 39, 36, 28, DateTimeKind.Local).AddTicks(8365), new DateTime(2024, 1, 27, 17, 39, 36, 28, DateTimeKind.Local).AddTicks(8368) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 17, 39, 36, 28, DateTimeKind.Local).AddTicks(8370), new DateTime(2024, 1, 27, 17, 39, 36, 28, DateTimeKind.Local).AddTicks(8370), new DateTime(2024, 1, 27, 17, 39, 36, 28, DateTimeKind.Local).AddTicks(8370), new DateTime(2024, 1, 27, 17, 39, 36, 28, DateTimeKind.Local).AddTicks(8371) });
        }
    }
}
