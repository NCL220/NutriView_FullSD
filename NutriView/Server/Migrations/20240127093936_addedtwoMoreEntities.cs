using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NutriView.Server.Migrations
{
    /// <inheritdoc />
    public partial class addedtwoMoreEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServiceDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceLinkSubInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubscriptionInfoID = table.Column<int>(type: "int", nullable: false),
                    ServiceID = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceLinkSubInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiceLinkSubInfos_Services_ServiceID",
                        column: x => x.ServiceID,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServiceLinkSubInfos_SubscriptionInfos_SubscriptionInfoID",
                        column: x => x.SubscriptionInfoID,
                        principalTable: "SubscriptionInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ServiceLinkSubInfos_ServiceID",
                table: "ServiceLinkSubInfos",
                column: "ServiceID");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceLinkSubInfos_SubscriptionInfoID",
                table: "ServiceLinkSubInfos",
                column: "SubscriptionInfoID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ServiceLinkSubInfos");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1507dbd1-1c83-4ad2-9b0e-4d298c7b4521",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d5fe8286-8547-4a04-a176-8d523a914368", "AQAAAAIAAYagAAAAEBC99lilHfqK3UnWqaXOZEb6I3EPMBzqTfAYLxmD6mNh/VUKwOOW17FpXqlur0vEzQ==", "3fc78ffc-5628-486c-b537-dcf48b4936e2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41624b27-7496-447c-b299-4892483d6b47",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "68015bea-f102-4444-b7c2-a2bfc9ff6e45", "AQAAAAIAAYagAAAAENm0+jMDdRqtufuGvrweiD/j/EqTZnN7eUCVCfjyEGtY4fPsk6o6+lS3mp5xuniKig==", "0441c518-4ee1-463d-a623-290a90026fd2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d3dfcba-a0af-4b10-989d-d63dcfec5e97",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "92ae5a89-04a5-4458-a940-28ba54639a7a", "AQAAAAIAAYagAAAAEKh4F7E84FoVIg7zkorqUWZym3k7xm0NgnQgxEzoyJXhdjQ8CyEwumm+SADpwkNPfg==", "d5ee5cd7-f3ab-4459-b552-406b436f8447" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8aa738a7-6c07-4e5a-8a7f-5637388c41b4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b77bc01-7e08-467b-9994-06bf96b4438c", "AQAAAAIAAYagAAAAEE1Xxf1Zd4npOMPeXMfZLDwkP5RePFLb5W3Ufbg1p8sL8A4PCWO1vObjpkdBhqv8Nw==", "2616a31c-086b-4359-84b0-0f5727675ac8" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 23, 35, 40, 219, DateTimeKind.Local).AddTicks(3373), new DateTime(2024, 1, 26, 23, 35, 40, 219, DateTimeKind.Local).AddTicks(3374) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 23, 35, 40, 219, DateTimeKind.Local).AddTicks(3377), new DateTime(2024, 1, 26, 23, 35, 40, 219, DateTimeKind.Local).AddTicks(3377) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 23, 35, 40, 407, DateTimeKind.Local).AddTicks(7292), new DateTime(2024, 1, 26, 23, 35, 40, 407, DateTimeKind.Local).AddTicks(7303) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 23, 35, 40, 407, DateTimeKind.Local).AddTicks(7306), new DateTime(2024, 1, 26, 23, 35, 40, 407, DateTimeKind.Local).AddTicks(7306) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 1, 26, 23, 35, 40, 407, DateTimeKind.Local).AddTicks(7725), new DateTime(2024, 1, 26, 23, 35, 40, 407, DateTimeKind.Local).AddTicks(7726), new DateTime(2024, 1, 26, 23, 35, 40, 407, DateTimeKind.Local).AddTicks(7724) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 1, 26, 23, 35, 40, 407, DateTimeKind.Local).AddTicks(7728), new DateTime(2024, 1, 26, 23, 35, 40, 407, DateTimeKind.Local).AddTicks(7728), new DateTime(2024, 1, 26, 23, 35, 40, 407, DateTimeKind.Local).AddTicks(7727) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 23, 35, 40, 219, DateTimeKind.Local).AddTicks(3711), new DateTime(2024, 1, 26, 23, 35, 40, 219, DateTimeKind.Local).AddTicks(3711) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 23, 35, 40, 219, DateTimeKind.Local).AddTicks(3713), new DateTime(2024, 1, 26, 23, 35, 40, 219, DateTimeKind.Local).AddTicks(3714) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 15, 35, 40, 407, DateTimeKind.Utc).AddTicks(8053), new DateTime(2024, 1, 26, 15, 35, 40, 407, DateTimeKind.Utc).AddTicks(8054) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 15, 35, 40, 407, DateTimeKind.Utc).AddTicks(8056), new DateTime(2024, 1, 26, 15, 35, 40, 407, DateTimeKind.Utc).AddTicks(8056) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 23, 35, 40, 219, DateTimeKind.Local).AddTicks(3546), new DateTime(2024, 1, 26, 23, 35, 40, 219, DateTimeKind.Local).AddTicks(3547) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 23, 35, 40, 219, DateTimeKind.Local).AddTicks(3548), new DateTime(2024, 1, 26, 23, 35, 40, 219, DateTimeKind.Local).AddTicks(3549) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 23, 35, 40, 407, DateTimeKind.Local).AddTicks(8280), new DateTime(2024, 1, 26, 23, 35, 40, 407, DateTimeKind.Local).AddTicks(8281) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 23, 35, 40, 407, DateTimeKind.Local).AddTicks(8282), new DateTime(2024, 1, 26, 23, 35, 40, 407, DateTimeKind.Local).AddTicks(8283) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 23, 35, 40, 219, DateTimeKind.Local).AddTicks(4464), new DateTime(2024, 1, 26, 23, 35, 40, 219, DateTimeKind.Local).AddTicks(4465) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 23, 35, 40, 219, DateTimeKind.Local).AddTicks(4467), new DateTime(2024, 1, 26, 23, 35, 40, 219, DateTimeKind.Local).AddTicks(4467) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 23, 35, 40, 219, DateTimeKind.Local).AddTicks(3157), new DateTime(2024, 1, 26, 23, 35, 40, 219, DateTimeKind.Local).AddTicks(3166) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 23, 35, 40, 219, DateTimeKind.Local).AddTicks(3168), new DateTime(2024, 1, 26, 23, 35, 40, 219, DateTimeKind.Local).AddTicks(3169) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 23, 35, 40, 407, DateTimeKind.Local).AddTicks(7539), new DateTime(2024, 1, 26, 23, 35, 40, 407, DateTimeKind.Local).AddTicks(7538), new DateTime(2024, 1, 26, 23, 35, 40, 407, DateTimeKind.Local).AddTicks(7537), new DateTime(2024, 1, 26, 23, 35, 40, 407, DateTimeKind.Local).AddTicks(7540) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 23, 35, 40, 407, DateTimeKind.Local).AddTicks(7542), new DateTime(2024, 1, 26, 23, 35, 40, 407, DateTimeKind.Local).AddTicks(7542), new DateTime(2024, 1, 26, 23, 35, 40, 407, DateTimeKind.Local).AddTicks(7541), new DateTime(2024, 1, 26, 23, 35, 40, 407, DateTimeKind.Local).AddTicks(7543) });
        }
    }
}
