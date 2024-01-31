using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NutriView.Server.Migrations
{
    /// <inheritdoc />
    public partial class db : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Genders_GenderId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Genders_Customers_CustomerId",
                table: "Genders");

            migrationBuilder.DropIndex(
                name: "IX_Genders_CustomerId",
                table: "Genders");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Genders");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "GenderId",
                table: "Customers",
                newName: "GenderID");

            migrationBuilder.RenameIndex(
                name: "IX_Customers_GenderId",
                table: "Customers",
                newName: "IX_Customers_GenderID");

            migrationBuilder.AlterColumn<int>(
                name: "GenderID",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1507dbd1-1c83-4ad2-9b0e-4d298c7b4521",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "283a416f-6fe2-40d8-8f32-e2d78fa6f365", "AQAAAAIAAYagAAAAEEnq81hGKVIOs56UUGMHpFQ+BAnvlR6vSLPk8fkJg5NWTjjSfNjENhqWXtIiXoFetA==", "2ecd5e2c-59a2-4e4d-a63c-d59e70d47049" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41624b27-7496-447c-b299-4892483d6b47",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d963a321-9aea-4c63-9828-572d09379c01", "AQAAAAIAAYagAAAAELsNJVQs8UohMzpkpGdIsr0fpVGc2PzFJEojtoAdd9NXrAxnYMwXyq2qmye1Y217Mg==", "989e6e16-6b41-46a7-9a66-09a1e029a963" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d3dfcba-a0af-4b10-989d-d63dcfec5e97",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bd3497b3-e89f-4e53-82ab-632d9dd8194d", "AQAAAAIAAYagAAAAENI6JS1XyiV8I9AmK4lsGYeAadG+0ghHD/xcCFJEJsNf+ni1eBxa79T7Iaa5t8Uogw==", "4554f24c-5e6b-45ad-b6e7-2c79857612bd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8aa738a7-6c07-4e5a-8a7f-5637388c41b4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "195aa3f0-225b-4938-a299-20d611f91ae8", "AQAAAAIAAYagAAAAEGyWj0JDzzKNDWK/mMvOqdSJ5CyP3b5HJ1QGKsJ4bx/3BLVLudnlypncBdMW8qOGwQ==", "9831f096-29b7-4b33-bc0b-bd4e82828d3f" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 9, 19, 20, 850, DateTimeKind.Local).AddTicks(7506), new DateTime(2024, 1, 31, 9, 19, 20, 850, DateTimeKind.Local).AddTicks(7507) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 9, 19, 20, 850, DateTimeKind.Local).AddTicks(7513), new DateTime(2024, 1, 31, 9, 19, 20, 850, DateTimeKind.Local).AddTicks(7514) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "GenderID" },
                values: new object[] { new DateTime(2024, 1, 31, 9, 19, 21, 66, DateTimeKind.Local).AddTicks(3348), new DateTime(2024, 1, 31, 9, 19, 21, 66, DateTimeKind.Local).AddTicks(3375), 1 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "GenderID" },
                values: new object[] { new DateTime(2024, 1, 31, 9, 19, 21, 66, DateTimeKind.Local).AddTicks(3381), new DateTime(2024, 1, 31, 9, 19, 21, 66, DateTimeKind.Local).AddTicks(3382), 2 });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 1, 31, 9, 19, 21, 66, DateTimeKind.Local).AddTicks(4042), new DateTime(2024, 1, 31, 9, 19, 21, 66, DateTimeKind.Local).AddTicks(4045), new DateTime(2024, 1, 31, 9, 19, 21, 66, DateTimeKind.Local).AddTicks(4041) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 1, 31, 9, 19, 21, 66, DateTimeKind.Local).AddTicks(4049), new DateTime(2024, 1, 31, 9, 19, 21, 66, DateTimeKind.Local).AddTicks(4050), new DateTime(2024, 1, 31, 9, 19, 21, 66, DateTimeKind.Local).AddTicks(4048) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 9, 19, 20, 850, DateTimeKind.Local).AddTicks(8592), new DateTime(2024, 1, 31, 9, 19, 20, 850, DateTimeKind.Local).AddTicks(8593) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 9, 19, 20, 850, DateTimeKind.Local).AddTicks(8596), new DateTime(2024, 1, 31, 9, 19, 20, 850, DateTimeKind.Local).AddTicks(8597) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 1, 19, 21, 66, DateTimeKind.Utc).AddTicks(4585), new DateTime(2024, 1, 31, 1, 19, 21, 66, DateTimeKind.Utc).AddTicks(4586) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 1, 19, 21, 66, DateTimeKind.Utc).AddTicks(4591), new DateTime(2024, 1, 31, 1, 19, 21, 66, DateTimeKind.Utc).AddTicks(4592) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 9, 19, 20, 850, DateTimeKind.Local).AddTicks(7792), new DateTime(2024, 1, 31, 9, 19, 20, 850, DateTimeKind.Local).AddTicks(7794) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 9, 19, 20, 850, DateTimeKind.Local).AddTicks(7796), new DateTime(2024, 1, 31, 9, 19, 20, 850, DateTimeKind.Local).AddTicks(7796) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 9, 19, 21, 66, DateTimeKind.Local).AddTicks(4907), new DateTime(2024, 1, 31, 9, 19, 21, 66, DateTimeKind.Local).AddTicks(4908) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 9, 19, 21, 66, DateTimeKind.Local).AddTicks(4912), new DateTime(2024, 1, 31, 9, 19, 21, 66, DateTimeKind.Local).AddTicks(4912) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 9, 19, 20, 850, DateTimeKind.Local).AddTicks(9201), new DateTime(2024, 1, 31, 9, 19, 20, 850, DateTimeKind.Local).AddTicks(9202) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 9, 19, 20, 850, DateTimeKind.Local).AddTicks(9206), new DateTime(2024, 1, 31, 9, 19, 20, 850, DateTimeKind.Local).AddTicks(9206) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 9, 19, 20, 850, DateTimeKind.Local).AddTicks(7276), new DateTime(2024, 1, 31, 9, 19, 20, 850, DateTimeKind.Local).AddTicks(7291) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 9, 19, 20, 850, DateTimeKind.Local).AddTicks(7294), new DateTime(2024, 1, 31, 9, 19, 20, 850, DateTimeKind.Local).AddTicks(7294) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 9, 19, 21, 66, DateTimeKind.Local).AddTicks(3656), new DateTime(2024, 1, 31, 9, 19, 21, 66, DateTimeKind.Local).AddTicks(3655), new DateTime(2024, 1, 31, 9, 19, 21, 66, DateTimeKind.Local).AddTicks(3653), new DateTime(2024, 1, 31, 9, 19, 21, 66, DateTimeKind.Local).AddTicks(3658) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 31, 9, 19, 21, 66, DateTimeKind.Local).AddTicks(3660), new DateTime(2024, 1, 31, 9, 19, 21, 66, DateTimeKind.Local).AddTicks(3660), new DateTime(2024, 1, 31, 9, 19, 21, 66, DateTimeKind.Local).AddTicks(3659), new DateTime(2024, 1, 31, 9, 19, 21, 66, DateTimeKind.Local).AddTicks(3661) });

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Genders_GenderID",
                table: "Customers",
                column: "GenderID",
                principalTable: "Genders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Genders_GenderID",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "GenderID",
                table: "Customers",
                newName: "GenderId");

            migrationBuilder.RenameIndex(
                name: "IX_Customers_GenderID",
                table: "Customers",
                newName: "IX_Customers_GenderId");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Genders",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GenderId",
                table: "Customers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

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
                columns: new[] { "DateCreated", "DateUpdated", "Gender", "GenderId" },
                values: new object[] { new DateTime(2024, 1, 30, 16, 23, 19, 998, DateTimeKind.Local).AddTicks(8388), new DateTime(2024, 1, 30, 16, 23, 19, 998, DateTimeKind.Local).AddTicks(8403), "Male", null });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "Gender", "GenderId" },
                values: new object[] { new DateTime(2024, 1, 30, 16, 23, 19, 998, DateTimeKind.Local).AddTicks(8408), new DateTime(2024, 1, 30, 16, 23, 19, 998, DateTimeKind.Local).AddTicks(8409), "Female", null });

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

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CustomerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CustomerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CustomerId",
                value: null);

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
                name: "IX_Genders_CustomerId",
                table: "Genders",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Genders_GenderId",
                table: "Customers",
                column: "GenderId",
                principalTable: "Genders",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Genders_Customers_CustomerId",
                table: "Genders",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id");
        }
    }
}
