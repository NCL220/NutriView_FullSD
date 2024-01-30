using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NutriView.Server.Migrations
{
    /// <inheritdoc />
    public partial class addcodeinService : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ServiceCode",
                table: "Services",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1507dbd1-1c83-4ad2-9b0e-4d298c7b4521",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b763985a-11cc-4314-bc0a-253b9cfd9726", "AQAAAAIAAYagAAAAECKzGGyidI0kJWMpemD5qOZaJaZ4fGaGI/h1R8JuRAtBO5SXWdbiaDkB8+sJBpLN6Q==", "2bea1210-c438-434b-983c-28b0a4716e7e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41624b27-7496-447c-b299-4892483d6b47",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "941fd336-b390-4edd-bc1d-c728f99f5979", "AQAAAAIAAYagAAAAEIMqps7mjJOAxrMGnPZ3x4PJP5C8QCK6C4p29ZmKkj/Jl8b4iokJ4R68UtPiyggL/Q==", "cd86a8f9-3535-4b77-83b9-a7b3ef473f87" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d3dfcba-a0af-4b10-989d-d63dcfec5e97",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6cd8435c-068c-43ba-8514-67be85599469", "AQAAAAIAAYagAAAAEEkXd0MKYXVE9kx9VdAru0vqxVXgt9+kkkU0ezQeymArwd9lSND7gnSPcmIuaRGvOA==", "b522e857-5ffc-4bfe-beee-69b28117e9c2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8aa738a7-6c07-4e5a-8a7f-5637388c41b4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5c84d074-5681-427b-b57a-b3a17f94ab72", "AQAAAAIAAYagAAAAEDYmNqqYaAR2n47TyNXfPSc17pnGucKrXXbqQop2cSI0Ob6cLXD/V7tPeZaFSVKBVQ==", "9ad3b94e-cb7e-4d0e-a9b7-7a12ac5ddb14" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 14, 59, 42, 160, DateTimeKind.Local).AddTicks(8771), new DateTime(2024, 1, 30, 14, 59, 42, 160, DateTimeKind.Local).AddTicks(8772) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 14, 59, 42, 160, DateTimeKind.Local).AddTicks(8774), new DateTime(2024, 1, 30, 14, 59, 42, 160, DateTimeKind.Local).AddTicks(8775) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 14, 59, 42, 419, DateTimeKind.Local).AddTicks(3937), new DateTime(2024, 1, 30, 14, 59, 42, 419, DateTimeKind.Local).AddTicks(3951) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 14, 59, 42, 419, DateTimeKind.Local).AddTicks(3954), new DateTime(2024, 1, 30, 14, 59, 42, 419, DateTimeKind.Local).AddTicks(3954) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 1, 30, 14, 59, 42, 419, DateTimeKind.Local).AddTicks(4432), new DateTime(2024, 1, 30, 14, 59, 42, 419, DateTimeKind.Local).AddTicks(4433), new DateTime(2024, 1, 30, 14, 59, 42, 419, DateTimeKind.Local).AddTicks(4431) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 1, 30, 14, 59, 42, 419, DateTimeKind.Local).AddTicks(4435), new DateTime(2024, 1, 30, 14, 59, 42, 419, DateTimeKind.Local).AddTicks(4435), new DateTime(2024, 1, 30, 14, 59, 42, 419, DateTimeKind.Local).AddTicks(4434) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 14, 59, 42, 160, DateTimeKind.Local).AddTicks(9200), new DateTime(2024, 1, 30, 14, 59, 42, 160, DateTimeKind.Local).AddTicks(9201) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 14, 59, 42, 160, DateTimeKind.Local).AddTicks(9204), new DateTime(2024, 1, 30, 14, 59, 42, 160, DateTimeKind.Local).AddTicks(9205) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 6, 59, 42, 419, DateTimeKind.Utc).AddTicks(4700), new DateTime(2024, 1, 30, 6, 59, 42, 419, DateTimeKind.Utc).AddTicks(4701) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 6, 59, 42, 419, DateTimeKind.Utc).AddTicks(4703), new DateTime(2024, 1, 30, 6, 59, 42, 419, DateTimeKind.Utc).AddTicks(4703) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 14, 59, 42, 160, DateTimeKind.Local).AddTicks(8971), new DateTime(2024, 1, 30, 14, 59, 42, 160, DateTimeKind.Local).AddTicks(8971) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 14, 59, 42, 160, DateTimeKind.Local).AddTicks(8973), new DateTime(2024, 1, 30, 14, 59, 42, 160, DateTimeKind.Local).AddTicks(8974) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 14, 59, 42, 419, DateTimeKind.Local).AddTicks(5087), new DateTime(2024, 1, 30, 14, 59, 42, 419, DateTimeKind.Local).AddTicks(5089) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 14, 59, 42, 419, DateTimeKind.Local).AddTicks(5091), new DateTime(2024, 1, 30, 14, 59, 42, 419, DateTimeKind.Local).AddTicks(5092) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                column: "ServiceCode",
                value: null);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                column: "ServiceCode",
                value: null);

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 14, 59, 42, 161, DateTimeKind.Local).AddTicks(23), new DateTime(2024, 1, 30, 14, 59, 42, 161, DateTimeKind.Local).AddTicks(24) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 14, 59, 42, 161, DateTimeKind.Local).AddTicks(27), new DateTime(2024, 1, 30, 14, 59, 42, 161, DateTimeKind.Local).AddTicks(27) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 14, 59, 42, 160, DateTimeKind.Local).AddTicks(8550), new DateTime(2024, 1, 30, 14, 59, 42, 160, DateTimeKind.Local).AddTicks(8561) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 14, 59, 42, 160, DateTimeKind.Local).AddTicks(8563), new DateTime(2024, 1, 30, 14, 59, 42, 160, DateTimeKind.Local).AddTicks(8564) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 14, 59, 42, 419, DateTimeKind.Local).AddTicks(4219), new DateTime(2024, 1, 30, 14, 59, 42, 419, DateTimeKind.Local).AddTicks(4218), new DateTime(2024, 1, 30, 14, 59, 42, 419, DateTimeKind.Local).AddTicks(4217), new DateTime(2024, 1, 30, 14, 59, 42, 419, DateTimeKind.Local).AddTicks(4219) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 14, 59, 42, 419, DateTimeKind.Local).AddTicks(4222), new DateTime(2024, 1, 30, 14, 59, 42, 419, DateTimeKind.Local).AddTicks(4221), new DateTime(2024, 1, 30, 14, 59, 42, 419, DateTimeKind.Local).AddTicks(4221), new DateTime(2024, 1, 30, 14, 59, 42, 419, DateTimeKind.Local).AddTicks(4222) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ServiceCode",
                table: "Services");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1507dbd1-1c83-4ad2-9b0e-4d298c7b4521",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d9793bb-3059-48f1-a60a-09f6a6fd8749", "AQAAAAIAAYagAAAAEK0ou3s8i1+whRdtjCSfKPsGakyx42uTafXs1x6PHsbL7ZosbQxysNsZJxWxWCn/TA==", "bada9a06-7085-4fa7-97b1-0291d0cc7462" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41624b27-7496-447c-b299-4892483d6b47",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e0760882-12a2-4ef6-ade1-e1823ebba417", "AQAAAAIAAYagAAAAEDVrQxcI0O32+28u8w3uZjQ0r8sCbSbcolKD9Fn0q7J8bT/lGUhzI8c5ZSEoZsnwIA==", "70ae94c0-2771-4d99-9602-81ec979881fa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d3dfcba-a0af-4b10-989d-d63dcfec5e97",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c912c84b-c4e4-46ff-9037-6ce400e59786", "AQAAAAIAAYagAAAAEDCBml8W2JVyyXUaoBGcJTjNwKyLt5YdYNx8RyEtyIpOSGufadqrZ2E8Td6EMLnyMw==", "c91395df-e3c3-408e-bf00-7df96f1b8e89" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8aa738a7-6c07-4e5a-8a7f-5637388c41b4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "112d5453-1a1a-48bd-b264-60c10a576b5a", "AQAAAAIAAYagAAAAEENOuuED5oNDj7/LOSocUHRE/nY1UZ46euMKnYFz/X5B4tLRiXPkJvKMQMFGaQ6tXg==", "fbd422ea-7223-4c96-8f74-91ebb2594455" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 0, 10, 32, 857, DateTimeKind.Local).AddTicks(6758), new DateTime(2024, 1, 30, 0, 10, 32, 857, DateTimeKind.Local).AddTicks(6759) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 0, 10, 32, 857, DateTimeKind.Local).AddTicks(6761), new DateTime(2024, 1, 30, 0, 10, 32, 857, DateTimeKind.Local).AddTicks(6761) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 0, 10, 33, 153, DateTimeKind.Local).AddTicks(9241), new DateTime(2024, 1, 30, 0, 10, 33, 153, DateTimeKind.Local).AddTicks(9254) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 0, 10, 33, 153, DateTimeKind.Local).AddTicks(9258), new DateTime(2024, 1, 30, 0, 10, 33, 153, DateTimeKind.Local).AddTicks(9259) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 1, 30, 0, 10, 33, 153, DateTimeKind.Local).AddTicks(9852), new DateTime(2024, 1, 30, 0, 10, 33, 153, DateTimeKind.Local).AddTicks(9852), new DateTime(2024, 1, 30, 0, 10, 33, 153, DateTimeKind.Local).AddTicks(9850) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 1, 30, 0, 10, 33, 153, DateTimeKind.Local).AddTicks(9855), new DateTime(2024, 1, 30, 0, 10, 33, 153, DateTimeKind.Local).AddTicks(9855), new DateTime(2024, 1, 30, 0, 10, 33, 153, DateTimeKind.Local).AddTicks(9854) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 0, 10, 32, 857, DateTimeKind.Local).AddTicks(7218), new DateTime(2024, 1, 30, 0, 10, 32, 857, DateTimeKind.Local).AddTicks(7220) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 0, 10, 32, 857, DateTimeKind.Local).AddTicks(7223), new DateTime(2024, 1, 30, 0, 10, 32, 857, DateTimeKind.Local).AddTicks(7224) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 16, 10, 33, 154, DateTimeKind.Utc).AddTicks(174), new DateTime(2024, 1, 29, 16, 10, 33, 154, DateTimeKind.Utc).AddTicks(174) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 16, 10, 33, 154, DateTimeKind.Utc).AddTicks(176), new DateTime(2024, 1, 29, 16, 10, 33, 154, DateTimeKind.Utc).AddTicks(177) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 0, 10, 32, 857, DateTimeKind.Local).AddTicks(6990), new DateTime(2024, 1, 30, 0, 10, 32, 857, DateTimeKind.Local).AddTicks(6991) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 0, 10, 32, 857, DateTimeKind.Local).AddTicks(6993), new DateTime(2024, 1, 30, 0, 10, 32, 857, DateTimeKind.Local).AddTicks(6993) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 0, 10, 33, 154, DateTimeKind.Local).AddTicks(636), new DateTime(2024, 1, 30, 0, 10, 33, 154, DateTimeKind.Local).AddTicks(637) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 0, 10, 33, 154, DateTimeKind.Local).AddTicks(640), new DateTime(2024, 1, 30, 0, 10, 33, 154, DateTimeKind.Local).AddTicks(640) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 0, 10, 32, 857, DateTimeKind.Local).AddTicks(8088), new DateTime(2024, 1, 30, 0, 10, 32, 857, DateTimeKind.Local).AddTicks(8090) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 0, 10, 32, 857, DateTimeKind.Local).AddTicks(8093), new DateTime(2024, 1, 30, 0, 10, 32, 857, DateTimeKind.Local).AddTicks(8093) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 0, 10, 32, 857, DateTimeKind.Local).AddTicks(6517), new DateTime(2024, 1, 30, 0, 10, 32, 857, DateTimeKind.Local).AddTicks(6527) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 0, 10, 32, 857, DateTimeKind.Local).AddTicks(6529), new DateTime(2024, 1, 30, 0, 10, 32, 857, DateTimeKind.Local).AddTicks(6530) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 0, 10, 33, 153, DateTimeKind.Local).AddTicks(9581), new DateTime(2024, 1, 30, 0, 10, 33, 153, DateTimeKind.Local).AddTicks(9580), new DateTime(2024, 1, 30, 0, 10, 33, 153, DateTimeKind.Local).AddTicks(9579), new DateTime(2024, 1, 30, 0, 10, 33, 153, DateTimeKind.Local).AddTicks(9582) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 30, 0, 10, 33, 153, DateTimeKind.Local).AddTicks(9585), new DateTime(2024, 1, 30, 0, 10, 33, 153, DateTimeKind.Local).AddTicks(9584), new DateTime(2024, 1, 30, 0, 10, 33, 153, DateTimeKind.Local).AddTicks(9584), new DateTime(2024, 1, 30, 0, 10, 33, 153, DateTimeKind.Local).AddTicks(9585) });
        }
    }
}
