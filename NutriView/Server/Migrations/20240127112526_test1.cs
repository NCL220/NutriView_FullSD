using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NutriView.Server.Migrations
{
    /// <inheritdoc />
    public partial class test1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1507dbd1-1c83-4ad2-9b0e-4d298c7b4521",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "89bda472-4e46-4785-8143-b0c66d045b4a", "AQAAAAIAAYagAAAAEGi59zBbkbTNIlD5cHQ76KrhvubnZB30FBT4ZMbVBi+EFOrFW6pgqBj/XKQlXe24xg==", "8f78ad66-324d-4af8-a1c4-48889920d4e2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41624b27-7496-447c-b299-4892483d6b47",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f3b0df75-e571-4007-9b00-eb12c0189042", "AQAAAAIAAYagAAAAEHwar+mZeGZh592CBGk3kzFMfLS4vtA8m7rQn+YHPP6/qKW+i5cAZvmxRie0bJWIBA==", "1ee4d6c9-e7d9-4ade-bb82-c1866d67666c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d3dfcba-a0af-4b10-989d-d63dcfec5e97",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "95b64b3a-c4cf-41ec-983b-a332e729ddc5", "AQAAAAIAAYagAAAAEFSEdSPD/Zq63QcEUQA+A+L8HD5EvN9yW4Cdh3hPnJkLpu9cwIo/14bXAoZEInVEqA==", "f075a29c-ea30-463f-be93-3dc10d17ba7d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8aa738a7-6c07-4e5a-8a7f-5637388c41b4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ef9a54a3-a706-4fa1-8dc9-bd6872703a4c", "AQAAAAIAAYagAAAAEBNMHV7FYFdB55CXtRGiHBGDFqqAxDOs8ZFYWNL+AnmFhPCvF0mayPcmURjW8xqviw==", "5c83f9ad-0f63-4944-9fe7-4fcbc35f6f53" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 19, 25, 26, 410, DateTimeKind.Local).AddTicks(9287), new DateTime(2024, 1, 27, 19, 25, 26, 410, DateTimeKind.Local).AddTicks(9288) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 19, 25, 26, 410, DateTimeKind.Local).AddTicks(9289), new DateTime(2024, 1, 27, 19, 25, 26, 410, DateTimeKind.Local).AddTicks(9295) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 19, 25, 26, 621, DateTimeKind.Local).AddTicks(3123), new DateTime(2024, 1, 27, 19, 25, 26, 621, DateTimeKind.Local).AddTicks(3137) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 19, 25, 26, 621, DateTimeKind.Local).AddTicks(3141), new DateTime(2024, 1, 27, 19, 25, 26, 621, DateTimeKind.Local).AddTicks(3141) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 1, 27, 19, 25, 26, 621, DateTimeKind.Local).AddTicks(3922), new DateTime(2024, 1, 27, 19, 25, 26, 621, DateTimeKind.Local).AddTicks(3922), new DateTime(2024, 1, 27, 19, 25, 26, 621, DateTimeKind.Local).AddTicks(3919) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 1, 27, 19, 25, 26, 621, DateTimeKind.Local).AddTicks(3925), new DateTime(2024, 1, 27, 19, 25, 26, 621, DateTimeKind.Local).AddTicks(3925), new DateTime(2024, 1, 27, 19, 25, 26, 621, DateTimeKind.Local).AddTicks(3924) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 19, 25, 26, 410, DateTimeKind.Local).AddTicks(9652), new DateTime(2024, 1, 27, 19, 25, 26, 410, DateTimeKind.Local).AddTicks(9653) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 19, 25, 26, 410, DateTimeKind.Local).AddTicks(9655), new DateTime(2024, 1, 27, 19, 25, 26, 410, DateTimeKind.Local).AddTicks(9655) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 11, 25, 26, 621, DateTimeKind.Utc).AddTicks(4225), new DateTime(2024, 1, 27, 11, 25, 26, 621, DateTimeKind.Utc).AddTicks(4226) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 11, 25, 26, 621, DateTimeKind.Utc).AddTicks(4227), new DateTime(2024, 1, 27, 11, 25, 26, 621, DateTimeKind.Utc).AddTicks(4227) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 19, 25, 26, 410, DateTimeKind.Local).AddTicks(9486), new DateTime(2024, 1, 27, 19, 25, 26, 410, DateTimeKind.Local).AddTicks(9487) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 19, 25, 26, 410, DateTimeKind.Local).AddTicks(9488), new DateTime(2024, 1, 27, 19, 25, 26, 410, DateTimeKind.Local).AddTicks(9489) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 19, 25, 26, 621, DateTimeKind.Local).AddTicks(4512), new DateTime(2024, 1, 27, 19, 25, 26, 621, DateTimeKind.Local).AddTicks(4513) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 19, 25, 26, 621, DateTimeKind.Local).AddTicks(4515), new DateTime(2024, 1, 27, 19, 25, 26, 621, DateTimeKind.Local).AddTicks(4515) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 19, 25, 26, 411, DateTimeKind.Local).AddTicks(429), new DateTime(2024, 1, 27, 19, 25, 26, 411, DateTimeKind.Local).AddTicks(430) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 19, 25, 26, 411, DateTimeKind.Local).AddTicks(432), new DateTime(2024, 1, 27, 19, 25, 26, 411, DateTimeKind.Local).AddTicks(433) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 19, 25, 26, 410, DateTimeKind.Local).AddTicks(9101), new DateTime(2024, 1, 27, 19, 25, 26, 410, DateTimeKind.Local).AddTicks(9112) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 19, 25, 26, 410, DateTimeKind.Local).AddTicks(9115), new DateTime(2024, 1, 27, 19, 25, 26, 410, DateTimeKind.Local).AddTicks(9116) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 19, 25, 26, 621, DateTimeKind.Local).AddTicks(3445), new DateTime(2024, 1, 27, 19, 25, 26, 621, DateTimeKind.Local).AddTicks(3445), new DateTime(2024, 1, 27, 19, 25, 26, 621, DateTimeKind.Local).AddTicks(3443), new DateTime(2024, 1, 27, 19, 25, 26, 621, DateTimeKind.Local).AddTicks(3446) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 19, 25, 26, 621, DateTimeKind.Local).AddTicks(3448), new DateTime(2024, 1, 27, 19, 25, 26, 621, DateTimeKind.Local).AddTicks(3448), new DateTime(2024, 1, 27, 19, 25, 26, 621, DateTimeKind.Local).AddTicks(3447), new DateTime(2024, 1, 27, 19, 25, 26, 621, DateTimeKind.Local).AddTicks(3449) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
