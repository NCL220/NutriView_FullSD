using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NutriView.Server.Migrations
{
    /// <inheritdoc />
    public partial class yes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GenderId",
                table: "Customers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Genders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1507dbd1-1c83-4ad2-9b0e-4d298c7b4521",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0f5131ec-794e-44d0-be00-6d126ffef1c4", "AQAAAAIAAYagAAAAEJ5KhXwRjL2QjoEBAX2CLK3FXdHOMAkPOoxA7j6q/lVms37uM2uzLftVbyMT2QQoWg==", "814b84ff-9d37-462e-a1d8-ab0a1b482c69" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41624b27-7496-447c-b299-4892483d6b47",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d97c19b-2961-469b-a6b1-f40d9b5aa8b8", "AQAAAAIAAYagAAAAEK3BS1fVN7p/DJolpyzqCLEc3/K740SqBwkIWXi760wfE/1csUKw2QDHmxI1KHBFSg==", "44227144-01e0-4c41-ad24-797f9620af12" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d3dfcba-a0af-4b10-989d-d63dcfec5e97",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a342e264-495b-4505-9420-33f5b7f93761", "AQAAAAIAAYagAAAAEJY3pv2OV8b8hYfZdc6Nr4oqmlg2TsH8g6cgkFKpXM1GcE68JWNjMJpZIK5gHMXypA==", "979011e4-8ea7-4f4e-90b9-e43b0ef93787" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8aa738a7-6c07-4e5a-8a7f-5637388c41b4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6fbc4f33-4083-426f-94cf-ee20eb380bf5", "AQAAAAIAAYagAAAAEOQnKZFszZEdEC/+3iDgyy2ux8kgvhFIOggBCMIpyvT0iPEZu2CeQXq+4rZG4yaa0A==", "f90caa84-2a47-4eac-86a7-8357981c5de3" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 16, 23, 19, 797, DateTimeKind.Local).AddTicks(1404), new DateTime(2024, 1, 30, 16, 23, 19, 797, DateTimeKind.Local).AddTicks(1404) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 16, 23, 19, 797, DateTimeKind.Local).AddTicks(1406), new DateTime(2024, 1, 30, 16, 23, 19, 797, DateTimeKind.Local).AddTicks(1407) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "GenderId" },
                values: new object[] { new DateTime(2024, 1, 30, 16, 23, 19, 998, DateTimeKind.Local).AddTicks(8388), new DateTime(2024, 1, 30, 16, 23, 19, 998, DateTimeKind.Local).AddTicks(8403), null });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "GenderId" },
                values: new object[] { new DateTime(2024, 1, 30, 16, 23, 19, 998, DateTimeKind.Local).AddTicks(8408), new DateTime(2024, 1, 30, 16, 23, 19, 998, DateTimeKind.Local).AddTicks(8409), null });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 1, 30, 16, 23, 19, 998, DateTimeKind.Local).AddTicks(8947), new DateTime(2024, 1, 30, 16, 23, 19, 998, DateTimeKind.Local).AddTicks(8948), new DateTime(2024, 1, 30, 16, 23, 19, 998, DateTimeKind.Local).AddTicks(8947) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 1, 30, 16, 23, 19, 998, DateTimeKind.Local).AddTicks(8950), new DateTime(2024, 1, 30, 16, 23, 19, 998, DateTimeKind.Local).AddTicks(8951), new DateTime(2024, 1, 30, 16, 23, 19, 998, DateTimeKind.Local).AddTicks(8949) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 16, 23, 19, 797, DateTimeKind.Local).AddTicks(2295), new DateTime(2024, 1, 30, 16, 23, 19, 797, DateTimeKind.Local).AddTicks(2296) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 16, 23, 19, 797, DateTimeKind.Local).AddTicks(2299), new DateTime(2024, 1, 30, 16, 23, 19, 797, DateTimeKind.Local).AddTicks(2300) });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "CreatedBy", "CustomerId", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Male", null },
                    { 2, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Female", null },
                    { 3, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Others", null }
                });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 8, 23, 19, 998, DateTimeKind.Utc).AddTicks(9396), new DateTime(2024, 1, 30, 8, 23, 19, 998, DateTimeKind.Utc).AddTicks(9397) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 8, 23, 19, 998, DateTimeKind.Utc).AddTicks(9400), new DateTime(2024, 1, 30, 8, 23, 19, 998, DateTimeKind.Utc).AddTicks(9400) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 16, 23, 19, 797, DateTimeKind.Local).AddTicks(1597), new DateTime(2024, 1, 30, 16, 23, 19, 797, DateTimeKind.Local).AddTicks(1598) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 16, 23, 19, 797, DateTimeKind.Local).AddTicks(1600), new DateTime(2024, 1, 30, 16, 23, 19, 797, DateTimeKind.Local).AddTicks(1600) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 16, 23, 19, 998, DateTimeKind.Local).AddTicks(9694), new DateTime(2024, 1, 30, 16, 23, 19, 998, DateTimeKind.Local).AddTicks(9696) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 16, 23, 19, 998, DateTimeKind.Local).AddTicks(9698), new DateTime(2024, 1, 30, 16, 23, 19, 998, DateTimeKind.Local).AddTicks(9699) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 16, 23, 19, 797, DateTimeKind.Local).AddTicks(2719), new DateTime(2024, 1, 30, 16, 23, 19, 797, DateTimeKind.Local).AddTicks(2721) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 16, 23, 19, 797, DateTimeKind.Local).AddTicks(2724), new DateTime(2024, 1, 30, 16, 23, 19, 797, DateTimeKind.Local).AddTicks(2724) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 16, 23, 19, 797, DateTimeKind.Local).AddTicks(1180), new DateTime(2024, 1, 30, 16, 23, 19, 797, DateTimeKind.Local).AddTicks(1201) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 16, 23, 19, 797, DateTimeKind.Local).AddTicks(1204), new DateTime(2024, 1, 30, 16, 23, 19, 797, DateTimeKind.Local).AddTicks(1205) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 16, 23, 19, 998, DateTimeKind.Local).AddTicks(8636), new DateTime(2024, 1, 30, 16, 23, 19, 998, DateTimeKind.Local).AddTicks(8634), new DateTime(2024, 1, 30, 16, 23, 19, 998, DateTimeKind.Local).AddTicks(8632), new DateTime(2024, 1, 30, 16, 23, 19, 998, DateTimeKind.Local).AddTicks(8636) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 16, 23, 19, 998, DateTimeKind.Local).AddTicks(8640), new DateTime(2024, 1, 30, 16, 23, 19, 998, DateTimeKind.Local).AddTicks(8639), new DateTime(2024, 1, 30, 16, 23, 19, 998, DateTimeKind.Local).AddTicks(8639), new DateTime(2024, 1, 30, 16, 23, 19, 998, DateTimeKind.Local).AddTicks(8640) });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_GenderId",
                table: "Customers",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Genders_CustomerId",
                table: "Genders",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Genders_GenderId",
                table: "Customers",
                column: "GenderId",
                principalTable: "Genders",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Genders_GenderId",
                table: "Customers");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropIndex(
                name: "IX_Customers_GenderId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "GenderId",
                table: "Customers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1507dbd1-1c83-4ad2-9b0e-4d298c7b4521",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ebdf3b3f-cd28-46d2-919e-471872c1125d", "AQAAAAIAAYagAAAAEETVFykDAwPA8XIseylBnoVmujNQx8CK4/RC8M5YLTBmJwhsM/0Yeexr2gY6IWx9+g==", "7313f14e-4da0-4017-8ef0-5532cf7e2aa8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41624b27-7496-447c-b299-4892483d6b47",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f0d3dd4c-500e-4d2d-992f-4e42dc74ff78", "AQAAAAIAAYagAAAAEKj9ZMBNbvjNjPNUf/WmRegQcPf9AWG+ikopSZZYpjtAvKvzfjsAjGbMYH5W5LA4Bw==", "c193f557-f156-4733-a7d3-990c7f41a078" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d3dfcba-a0af-4b10-989d-d63dcfec5e97",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fe7abc33-7827-4d2d-ad08-3ac607e531d8", "AQAAAAIAAYagAAAAEMoDX6h55Nk/gKDEDb+W3lXZ7ea//ajWLqMUuiyWQlCoHgPuf88IidI98QnYVx8VAQ==", "85738dcf-906c-42d9-a358-1570d23beb8a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8aa738a7-6c07-4e5a-8a7f-5637388c41b4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a5613b9a-14ab-4214-b0d3-e20659bcf896", "AQAAAAIAAYagAAAAEHvvlZCoZEulDcZnmsXsFy+WEALtxjHy/mA+X77DzH3l4aafgJnV1rwdSBYkaWr7hQ==", "6f2ae1db-f41b-4dcd-9917-031b7938265a" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 16, 19, 6, 801, DateTimeKind.Local).AddTicks(9469), new DateTime(2024, 1, 30, 16, 19, 6, 801, DateTimeKind.Local).AddTicks(9470) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 16, 19, 6, 801, DateTimeKind.Local).AddTicks(9473), new DateTime(2024, 1, 30, 16, 19, 6, 801, DateTimeKind.Local).AddTicks(9474) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 16, 19, 7, 60, DateTimeKind.Local).AddTicks(5220), new DateTime(2024, 1, 30, 16, 19, 7, 60, DateTimeKind.Local).AddTicks(5237) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 16, 19, 7, 60, DateTimeKind.Local).AddTicks(5241), new DateTime(2024, 1, 30, 16, 19, 7, 60, DateTimeKind.Local).AddTicks(5241) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 1, 30, 16, 19, 7, 60, DateTimeKind.Local).AddTicks(5876), new DateTime(2024, 1, 30, 16, 19, 7, 60, DateTimeKind.Local).AddTicks(5877), new DateTime(2024, 1, 30, 16, 19, 7, 60, DateTimeKind.Local).AddTicks(5874) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 1, 30, 16, 19, 7, 60, DateTimeKind.Local).AddTicks(5879), new DateTime(2024, 1, 30, 16, 19, 7, 60, DateTimeKind.Local).AddTicks(5880), new DateTime(2024, 1, 30, 16, 19, 7, 60, DateTimeKind.Local).AddTicks(5879) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 16, 19, 6, 802, DateTimeKind.Local).AddTicks(39), new DateTime(2024, 1, 30, 16, 19, 6, 802, DateTimeKind.Local).AddTicks(43) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 16, 19, 6, 802, DateTimeKind.Local).AddTicks(47), new DateTime(2024, 1, 30, 16, 19, 6, 802, DateTimeKind.Local).AddTicks(48) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 8, 19, 7, 60, DateTimeKind.Utc).AddTicks(6293), new DateTime(2024, 1, 30, 8, 19, 7, 60, DateTimeKind.Utc).AddTicks(6294) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 8, 19, 7, 60, DateTimeKind.Utc).AddTicks(6297), new DateTime(2024, 1, 30, 8, 19, 7, 60, DateTimeKind.Utc).AddTicks(6298) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 16, 19, 6, 801, DateTimeKind.Local).AddTicks(9737), new DateTime(2024, 1, 30, 16, 19, 6, 801, DateTimeKind.Local).AddTicks(9738) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 16, 19, 6, 801, DateTimeKind.Local).AddTicks(9740), new DateTime(2024, 1, 30, 16, 19, 6, 801, DateTimeKind.Local).AddTicks(9741) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 16, 19, 7, 60, DateTimeKind.Local).AddTicks(6796), new DateTime(2024, 1, 30, 16, 19, 7, 60, DateTimeKind.Local).AddTicks(6798) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 16, 19, 7, 60, DateTimeKind.Local).AddTicks(6800), new DateTime(2024, 1, 30, 16, 19, 7, 60, DateTimeKind.Local).AddTicks(6801) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 16, 19, 6, 802, DateTimeKind.Local).AddTicks(1667), new DateTime(2024, 1, 30, 16, 19, 6, 802, DateTimeKind.Local).AddTicks(1672) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 16, 19, 6, 802, DateTimeKind.Local).AddTicks(1675), new DateTime(2024, 1, 30, 16, 19, 6, 802, DateTimeKind.Local).AddTicks(1675) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 16, 19, 6, 801, DateTimeKind.Local).AddTicks(9164), new DateTime(2024, 1, 30, 16, 19, 6, 801, DateTimeKind.Local).AddTicks(9187) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 16, 19, 6, 801, DateTimeKind.Local).AddTicks(9190), new DateTime(2024, 1, 30, 16, 19, 6, 801, DateTimeKind.Local).AddTicks(9190) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 16, 19, 7, 60, DateTimeKind.Local).AddTicks(5587), new DateTime(2024, 1, 30, 16, 19, 7, 60, DateTimeKind.Local).AddTicks(5586), new DateTime(2024, 1, 30, 16, 19, 7, 60, DateTimeKind.Local).AddTicks(5584), new DateTime(2024, 1, 30, 16, 19, 7, 60, DateTimeKind.Local).AddTicks(5588) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 16, 19, 7, 60, DateTimeKind.Local).AddTicks(5591), new DateTime(2024, 1, 30, 16, 19, 7, 60, DateTimeKind.Local).AddTicks(5591), new DateTime(2024, 1, 30, 16, 19, 7, 60, DateTimeKind.Local).AddTicks(5591), new DateTime(2024, 1, 30, 16, 19, 7, 60, DateTimeKind.Local).AddTicks(5592) });
        }
    }
}
