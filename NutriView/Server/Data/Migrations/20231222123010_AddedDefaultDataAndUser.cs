using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NutriView.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultDataAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0afa81d9-cb31-4883-ae16-c9d0242e3440", null, "Administrator", "ADMINISTRATOR" },
                    { "428fdfc4-086b-4aba-bb98-148f31eaa143", null, "Staff", "STAFF" },
                    { "a1329842-8556-4ee7-ae1a-fd648064c54a", null, "Customer", "CUSTOMER" },
                    { "f5a29727-ea9d-41d4-9175-dd1fb6ec2755", null, "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1507dbd1-1c83-4ad2-9b0e-4d298c7b4521", 0, "f077c1e4-314c-4362-97bc-b68048e3fade", "Manager@localhost.com", false, "Manager", "User", false, null, "Manager@LOCALHOST.COM", "MANAGER@LOCALHOST.COM", "AQAAAAIAAYagAAAAECrb67lgy0IG2cC935ff4uv8pWpRQnvcs/RhZaTET127RI/TgVnPOTzG/f11bgAUOw==", null, false, "8f3501dc-3f2f-470a-9ef5-23053327133a", false, "Manager@localhost.com" },
                    { "41624b27-7496-447c-b299-4892483d6b47", 0, "99b66361-f4fe-4d0b-8243-bbe18a64591d", "Customer@localhost.com", false, "Customer", "User", false, null, "Customer@LOCALHOST.COM", "CUSTOMER@LOCALHOST.COM", "AQAAAAIAAYagAAAAECw1JQI+fvy21+CrjE8jPlGeRwpoyFHILQyh8B9y3zz1lk4eR41RaOrfubPMRMAG+w==", null, false, "aa28d977-6ec9-4a34-988a-45ba967b86a6", false, "Customer@localhost.com" },
                    { "4d3dfcba-a0af-4b10-989d-d63dcfec5e97", 0, "1c5d9f97-cd6c-4fe0-a442-8cdfab0b952a", "Staff@localhost.com", false, "Staff", "User", false, null, "Staff@LOCALHOST.COM", "STAFF@LOCALHOST.COM", "AQAAAAIAAYagAAAAEIr0QWIkIIB7tkj3neJAPGoIMpdGbPZkhb9u+059qM/v/CWlNbWIRT6f7o1Z2tH+tg==", null, false, "3ee78f7d-039f-45ea-8cc1-2c0ccd561ae9", false, "Staff@localhost.com" },
                    { "8aa738a7-6c07-4e5a-8a7f-5637388c41b4", 0, "3a55cf68-1d3a-400e-bde8-c6fe51236652", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEChMo4MO01RAvlWB1kaMyyEJ/zGabEPhU2IPGevqdWvzTMN80Zq46CS15JWHJF7tvw==", null, false, "79e09346-4de6-43fb-b157-40422170648a", false, "admin@localhost.com" }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "CompanyDescription", "CompanyImagePath", "CompanyName", "CreatedBy", "DateCreated", "DateUpdated", "Mission", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "At NuriView Corporations, we believe that a heathy lifestyle would always begins with proper nutrition.We are a dedicated team of nutritionists and dietitians comitted in providing you with the knowledge and tools to aid you in your journey to a healthier diet.", "Not Yet Available", "NutriView", "System", new DateTime(2023, 12, 22, 20, 30, 9, 788, DateTimeKind.Local).AddTicks(4624), new DateTime(2023, 12, 22, 20, 30, 9, 788, DateTimeKind.Local).AddTicks(4625), "Our mission is to empower individuals to achieve optimal health through mindful eating. We understand that nutrition is not always a one-size-fits-all.Our goal is to guide you on a personalized journey towards a balanced and nourishing lifestyle that will bring you a step closer to a healthier you.", "System" },
                    { 2, "Not Yet Available", "Not Yet Available", "NutriViewCorps", "System", new DateTime(2023, 12, 22, 20, 30, 9, 788, DateTimeKind.Local).AddTicks(4627), new DateTime(2023, 12, 22, 20, 30, 9, 788, DateTimeKind.Local).AddTicks(4628), "Our Mission is to encourage people to eat healthy and live healthy", "System" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Age", "CreatedBy", "DateCreated", "DateUpdated", "Email", "Gender", "Height", "Password", "UpdatedBy", "UserName", "Weight" },
                values: new object[,]
                {
                    { 1, 31, "System", new DateTime(2023, 12, 22, 20, 30, 9, 974, DateTimeKind.Local).AddTicks(5422), new DateTime(2023, 12, 22, 20, 30, 9, 974, DateTimeKind.Local).AddTicks(5434), "Test@Blazor.com", "Male", 160.0, "Test222", "System", "TestLim", 88.5 },
                    { 2, 32, "System", new DateTime(2023, 12, 22, 20, 30, 9, 974, DateTimeKind.Local).AddTicks(5440), new DateTime(2023, 12, 22, 20, 30, 9, 974, DateTimeKind.Local).AddTicks(5440), "Test2@Blazor.com", "Female", 178.0, "Test2212", "System", "TestRRLim", 77.0 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "428fdfc4-086b-4aba-bb98-148f31eaa143", "1507dbd1-1c83-4ad2-9b0e-4d298c7b4521" },
                    { "a1329842-8556-4ee7-ae1a-fd648064c54a", "41624b27-7496-447c-b299-4892483d6b47" },
                    { "f5a29727-ea9d-41d4-9175-dd1fb6ec2755", "4d3dfcba-a0af-4b10-989d-d63dcfec5e97" },
                    { "0afa81d9-cb31-4883-ae16-c9d0242e3440", "8aa738a7-6c07-4e5a-8a7f-5637388c41b4" }
                });

            migrationBuilder.InsertData(
                table: "FoodEntries",
                columns: new[] { "Id", "CreatedBy", "CustomerID", "DateCreated", "DateUpdated", "Time_Stamp", "TotalCalories", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", 1, new DateTime(2023, 12, 22, 20, 30, 9, 974, DateTimeKind.Local).AddTicks(6034), new DateTime(2023, 12, 22, 20, 30, 9, 974, DateTimeKind.Local).AddTicks(6035), "22 Jan 2024", 22.0, "System" },
                    { 2, "System", 2, new DateTime(2023, 12, 22, 20, 30, 9, 974, DateTimeKind.Local).AddTicks(6037), new DateTime(2023, 12, 22, 20, 30, 9, 974, DateTimeKind.Local).AddTicks(6037), "1 Jan 2024", 34.0, "System" }
                });

            migrationBuilder.InsertData(
                table: "NutritionalQuotas",
                columns: new[] { "Id", "CreatedBy", "CustomerID", "DateCreated", "DateUpdated", "TargetBMI", "TargetCalorieDaily", "TargetCarbDaily", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", 1, new DateTime(2023, 12, 22, 20, 30, 9, 974, DateTimeKind.Local).AddTicks(6564), new DateTime(2023, 12, 22, 20, 30, 9, 974, DateTimeKind.Local).AddTicks(6565), 19.0, 2000.0, 300.0, "System" },
                    { 2, "System", 2, new DateTime(2023, 12, 22, 20, 30, 9, 974, DateTimeKind.Local).AddTicks(6567), new DateTime(2023, 12, 22, 20, 30, 9, 974, DateTimeKind.Local).AddTicks(6568), 21.0, 2000.0, 290.0, "System" }
                });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "Id", "CompanyId", "CreatedBy", "DateCreated", "DateUpdated", "Email", "ImagePathStaff", "ManagerID", "Password", "PhoneNumber", "Role", "UpdatedBy", "UserName" },
                values: new object[,]
                {
                    { 1, 1, "System", new DateTime(2023, 12, 22, 20, 30, 9, 788, DateTimeKind.Local).AddTicks(5641), new DateTime(2023, 12, 22, 20, 30, 9, 788, DateTimeKind.Local).AddTicks(5642), "ngchunlim04@gmail.com", "-", 1, "Chun11", 87993192, "Manager", "System", "ChunLim" },
                    { 2, 1, "System", new DateTime(2023, 12, 22, 20, 30, 9, 788, DateTimeKind.Local).AddTicks(5645), new DateTime(2023, 12, 22, 20, 30, 9, 788, DateTimeKind.Local).AddTicks(5645), "Test04@gmail.com", "-", 2, "Lim12", 87993192, "Manager", "System", "Kenneth" }
                });

            migrationBuilder.InsertData(
                table: "Subscriptions",
                columns: new[] { "Id", "Cost", "CreatedBy", "CustomerID", "DateCreated", "DateEnd", "DateStart", "DateUpdated", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 0.0, "System", 1, new DateTime(2023, 12, 22, 20, 30, 9, 974, DateTimeKind.Local).AddTicks(5760), new DateTime(2023, 12, 22, 20, 30, 9, 974, DateTimeKind.Local).AddTicks(5759), new DateTime(2023, 12, 22, 20, 30, 9, 974, DateTimeKind.Local).AddTicks(5758), new DateTime(2023, 12, 22, 20, 30, 9, 974, DateTimeKind.Local).AddTicks(5760), "System" },
                    { 2, 0.0, "System", 2, new DateTime(2023, 12, 22, 20, 30, 9, 974, DateTimeKind.Local).AddTicks(5764), new DateTime(2023, 12, 22, 20, 30, 9, 974, DateTimeKind.Local).AddTicks(5763), new DateTime(2023, 12, 22, 20, 30, 9, 974, DateTimeKind.Local).AddTicks(5763), new DateTime(2023, 12, 22, 20, 30, 9, 974, DateTimeKind.Local).AddTicks(5764), "System" }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "Calories", "Carbohydrates", "CreatedBy", "DateCreated", "DateUpdated", "Fats", "FoodDesc", "FoodEntryID", "ImagePath", "Name", "ServingSize", "StaffId", "UpdatedBy", "Vitamins" },
                values: new object[,]
                {
                    { 1, 25.0, 6.0, "System", new DateTime(2023, 12, 22, 20, 30, 9, 788, DateTimeKind.Local).AddTicks(5191), new DateTime(2023, 12, 22, 20, 30, 9, 788, DateTimeKind.Local).AddTicks(5192), 0.10000000000000001, "Carrots Contains 25 Calories and 6g of Carbohydrates , etc", 1, "-", "Carrots", 61.0, 1, "System", "A,C,K" },
                    { 2, 165.0, 0.0, "System", new DateTime(2023, 12, 22, 20, 30, 9, 788, DateTimeKind.Local).AddTicks(5195), new DateTime(2023, 12, 22, 20, 30, 9, 788, DateTimeKind.Local).AddTicks(5195), 3.6000000000000001, "Chicken Contains 165 Calories per 100 grams and does not have any Carbohydrates , etc", 2, "-", "Chicken", 100.0, 2, "System", "A, B6, C, D, E" }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "Calories", "CreatedBy", "DateCreated", "DateUpdated", "FoodEntryID", "Name", "PortionSize", "TimePeriod", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, null, "System", new DateTime(2023, 12, 22, 12, 30, 9, 974, DateTimeKind.Utc).AddTicks(6305), new DateTime(2023, 12, 22, 12, 30, 9, 974, DateTimeKind.Utc).AddTicks(6306), 1, "Carrots", 1.0, "Morning", "System" },
                    { 2, null, "System", new DateTime(2023, 12, 22, 12, 30, 9, 974, DateTimeKind.Utc).AddTicks(6307), new DateTime(2023, 12, 22, 12, 30, 9, 974, DateTimeKind.Utc).AddTicks(6308), 2, "ChickenRice", 1.0, "Morning", "System" }
                });

            migrationBuilder.InsertData(
                table: "NutritionInfos",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "NutritionDescription", "NutritionImagePath", "NutritionName", "StaffId", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 12, 22, 20, 30, 9, 788, DateTimeKind.Local).AddTicks(4828), new DateTime(2023, 12, 22, 20, 30, 9, 788, DateTimeKind.Local).AddTicks(4833), "Essential for vision, immune function, and skin health.", "-", "Vitamin A", 1, "System" },
                    { 2, "System", new DateTime(2023, 12, 22, 20, 30, 9, 788, DateTimeKind.Local).AddTicks(4926), new DateTime(2023, 12, 22, 20, 30, 9, 788, DateTimeKind.Local).AddTicks(4926), "Supports bone health, immune system, and overall well-being.", "-", "Vitamin D", 2, "System" }
                });

            migrationBuilder.InsertData(
                table: "SubscriptionInfos",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "SubCost", "SubDescription", "SubTierName", "SubType", "SubscriptionID", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 12, 22, 20, 30, 9, 788, DateTimeKind.Local).AddTicks(4251), new DateTime(2023, 12, 22, 20, 30, 9, 788, DateTimeKind.Local).AddTicks(4264), 5.0, "Unlocks The Personal Quota Tracker", "Health Enthusiasts", "Monthly", 1, "System" },
                    { 2, "System", new DateTime(2023, 12, 22, 20, 30, 9, 788, DateTimeKind.Local).AddTicks(4272), new DateTime(2023, 12, 22, 20, 30, 9, 788, DateTimeKind.Local).AddTicks(4273), 30.0, "Unlocks The Personal Quota Tracker and other Features!!", "Health Enthusiasts", "Yearly", 2, "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "428fdfc4-086b-4aba-bb98-148f31eaa143", "1507dbd1-1c83-4ad2-9b0e-4d298c7b4521" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a1329842-8556-4ee7-ae1a-fd648064c54a", "41624b27-7496-447c-b299-4892483d6b47" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f5a29727-ea9d-41d4-9175-dd1fb6ec2755", "4d3dfcba-a0af-4b10-989d-d63dcfec5e97" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0afa81d9-cb31-4883-ae16-c9d0242e3440", "8aa738a7-6c07-4e5a-8a7f-5637388c41b4" });

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0afa81d9-cb31-4883-ae16-c9d0242e3440");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "428fdfc4-086b-4aba-bb98-148f31eaa143");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1329842-8556-4ee7-ae1a-fd648064c54a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f5a29727-ea9d-41d4-9175-dd1fb6ec2755");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1507dbd1-1c83-4ad2-9b0e-4d298c7b4521");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41624b27-7496-447c-b299-4892483d6b47");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d3dfcba-a0af-4b10-989d-d63dcfec5e97");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8aa738a7-6c07-4e5a-8a7f-5637388c41b4");

            migrationBuilder.DeleteData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
