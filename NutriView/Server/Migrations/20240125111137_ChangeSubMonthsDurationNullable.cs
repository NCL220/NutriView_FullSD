using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NutriView.Server.Migrations
{
    /// <inheritdoc />
    public partial class ChangeSubMonthsDurationNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "SubMonthsDuration",
                table: "SubscriptionInfos",
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
                values: new object[] { "d9788f14-c5c1-4bdc-918b-4703e88948cc", "AQAAAAIAAYagAAAAEIZWeSj+JgrwlfPnMFNY19dzV8RqnGLJQ4lTKvo6XiZEA33WyZErViqk/AgYzPV8kA==", "20ccee4e-6d8b-402c-b1b6-6ed6d7c14e42" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41624b27-7496-447c-b299-4892483d6b47",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ef1af165-758f-44dd-905d-7053824ac1c6", "AQAAAAIAAYagAAAAEMuxUarsSY1H0nleNQFqAe5eFNGZolF+Z8TmAfRQC6XsTf1FsjwHZhrGx+PekCAGHQ==", "a948557e-68e6-455c-9e3c-1e1aa2c3edc9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d3dfcba-a0af-4b10-989d-d63dcfec5e97",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "21df32e2-76d9-496d-9e89-ab0e95d42105", "AQAAAAIAAYagAAAAEE3AOqXyyv9DtZYLcmqga58jaA2um5XRuPXKT0eQiSRzyOzFhoxJ6HCqqqs6WouooA==", "1df98566-8d42-4875-8930-33f09cde5e0c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8aa738a7-6c07-4e5a-8a7f-5637388c41b4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b4137c0a-9804-4b6c-ace9-ffa7bb12d14d", "AQAAAAIAAYagAAAAEIb9JeHY3yCvMhIUyxnlfPeE1LuAp9Qm7SZgi3ppA8N9ZM3I85TlgavLK9KXZ6Q0ng==", "a4d3b11a-96c7-49c8-8e93-e2d55b1052d0" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 19, 11, 37, 294, DateTimeKind.Local).AddTicks(9069), new DateTime(2024, 1, 25, 19, 11, 37, 294, DateTimeKind.Local).AddTicks(9070) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 19, 11, 37, 294, DateTimeKind.Local).AddTicks(9072), new DateTime(2024, 1, 25, 19, 11, 37, 294, DateTimeKind.Local).AddTicks(9075) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 19, 11, 37, 484, DateTimeKind.Local).AddTicks(8404), new DateTime(2024, 1, 25, 19, 11, 37, 484, DateTimeKind.Local).AddTicks(8419) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 19, 11, 37, 484, DateTimeKind.Local).AddTicks(8422), new DateTime(2024, 1, 25, 19, 11, 37, 484, DateTimeKind.Local).AddTicks(8423) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 1, 25, 19, 11, 37, 484, DateTimeKind.Local).AddTicks(9014), new DateTime(2024, 1, 25, 19, 11, 37, 484, DateTimeKind.Local).AddTicks(9015), new DateTime(2024, 1, 25, 19, 11, 37, 484, DateTimeKind.Local).AddTicks(9014) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 1, 25, 19, 11, 37, 484, DateTimeKind.Local).AddTicks(9017), new DateTime(2024, 1, 25, 19, 11, 37, 484, DateTimeKind.Local).AddTicks(9017), new DateTime(2024, 1, 25, 19, 11, 37, 484, DateTimeKind.Local).AddTicks(9016) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 19, 11, 37, 294, DateTimeKind.Local).AddTicks(9409), new DateTime(2024, 1, 25, 19, 11, 37, 294, DateTimeKind.Local).AddTicks(9410) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 19, 11, 37, 294, DateTimeKind.Local).AddTicks(9412), new DateTime(2024, 1, 25, 19, 11, 37, 294, DateTimeKind.Local).AddTicks(9413) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 11, 11, 37, 484, DateTimeKind.Utc).AddTicks(9253), new DateTime(2024, 1, 25, 11, 11, 37, 484, DateTimeKind.Utc).AddTicks(9253) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 11, 11, 37, 484, DateTimeKind.Utc).AddTicks(9255), new DateTime(2024, 1, 25, 11, 11, 37, 484, DateTimeKind.Utc).AddTicks(9255) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 19, 11, 37, 294, DateTimeKind.Local).AddTicks(9242), new DateTime(2024, 1, 25, 19, 11, 37, 294, DateTimeKind.Local).AddTicks(9243) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 19, 11, 37, 294, DateTimeKind.Local).AddTicks(9245), new DateTime(2024, 1, 25, 19, 11, 37, 294, DateTimeKind.Local).AddTicks(9245) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 19, 11, 37, 484, DateTimeKind.Local).AddTicks(9534), new DateTime(2024, 1, 25, 19, 11, 37, 484, DateTimeKind.Local).AddTicks(9535) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 19, 11, 37, 484, DateTimeKind.Local).AddTicks(9536), new DateTime(2024, 1, 25, 19, 11, 37, 484, DateTimeKind.Local).AddTicks(9537) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 19, 11, 37, 294, DateTimeKind.Local).AddTicks(9774), new DateTime(2024, 1, 25, 19, 11, 37, 294, DateTimeKind.Local).AddTicks(9775) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 19, 11, 37, 294, DateTimeKind.Local).AddTicks(9777), new DateTime(2024, 1, 25, 19, 11, 37, 294, DateTimeKind.Local).AddTicks(9777) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "SubMonthsDuration" },
                values: new object[] { new DateTime(2024, 1, 25, 19, 11, 37, 294, DateTimeKind.Local).AddTicks(8887), new DateTime(2024, 1, 25, 19, 11, 37, 294, DateTimeKind.Local).AddTicks(8899), 0 });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "SubMonthsDuration" },
                values: new object[] { new DateTime(2024, 1, 25, 19, 11, 37, 294, DateTimeKind.Local).AddTicks(8901), new DateTime(2024, 1, 25, 19, 11, 37, 294, DateTimeKind.Local).AddTicks(8902), 0 });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 19, 11, 37, 484, DateTimeKind.Local).AddTicks(8693), new DateTime(2024, 1, 25, 19, 11, 37, 484, DateTimeKind.Local).AddTicks(8693), new DateTime(2024, 1, 25, 19, 11, 37, 484, DateTimeKind.Local).AddTicks(8691), new DateTime(2024, 1, 25, 19, 11, 37, 484, DateTimeKind.Local).AddTicks(8694) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 19, 11, 37, 484, DateTimeKind.Local).AddTicks(8696), new DateTime(2024, 1, 25, 19, 11, 37, 484, DateTimeKind.Local).AddTicks(8696), new DateTime(2024, 1, 25, 19, 11, 37, 484, DateTimeKind.Local).AddTicks(8696), new DateTime(2024, 1, 25, 19, 11, 37, 484, DateTimeKind.Local).AddTicks(8697) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "SubMonthsDuration",
                table: "SubscriptionInfos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1507dbd1-1c83-4ad2-9b0e-4d298c7b4521",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "53d95532-4367-4c18-9b12-f66bc397e939", "AQAAAAIAAYagAAAAEO+dMjTFIAPKJpwZKX77upJl+C+lh3dJCWdBen6916Oi61p2E/2s8Ft/qgP1sFx6Hw==", "f62d0d9b-951a-4b39-a43b-f1cc279b6fa7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41624b27-7496-447c-b299-4892483d6b47",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4876e931-b367-440b-90a8-e0a1a7a32e5c", "AQAAAAIAAYagAAAAEJfQ6cpobuh0SnoawMCvZGCRz8yjSeWP4feUKGpcYSwGsGTigzfiBvi7ApiK0OA8UQ==", "5e77dea6-78a6-4600-a3c2-f9c74ea85283" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d3dfcba-a0af-4b10-989d-d63dcfec5e97",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fbc3a976-1abe-4612-922a-71f7b6b12bac", "AQAAAAIAAYagAAAAEDG99bnjoFE+/1VQVWjXBh+Y2y2kgsnm5oedntNZpcgCc3x5RI6MG+KMhUIPbpymdg==", "f726781d-2116-4b9d-84c2-35e01ae93fd1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8aa738a7-6c07-4e5a-8a7f-5637388c41b4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "13c1fce5-d38e-4ef1-84f5-7bed902d4299", "AQAAAAIAAYagAAAAEHMheWgzbK8Fy8zFOFzWV7+FPuE0/ALbGWW7d/0eQruHIL+B1ogPbLplv3QcrzeDwQ==", "27b0fa47-ed4b-43c1-90e6-61e1798f7523" });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 16, 1, 12, 503, DateTimeKind.Local).AddTicks(3197), new DateTime(2024, 1, 24, 16, 1, 12, 503, DateTimeKind.Local).AddTicks(3197) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 16, 1, 12, 503, DateTimeKind.Local).AddTicks(3200), new DateTime(2024, 1, 24, 16, 1, 12, 503, DateTimeKind.Local).AddTicks(3200) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 16, 1, 12, 692, DateTimeKind.Local).AddTicks(3723), new DateTime(2024, 1, 24, 16, 1, 12, 692, DateTimeKind.Local).AddTicks(3740) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 16, 1, 12, 692, DateTimeKind.Local).AddTicks(3743), new DateTime(2024, 1, 24, 16, 1, 12, 692, DateTimeKind.Local).AddTicks(3744) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 1, 24, 16, 1, 12, 692, DateTimeKind.Local).AddTicks(4207), new DateTime(2024, 1, 24, 16, 1, 12, 692, DateTimeKind.Local).AddTicks(4208), new DateTime(2024, 1, 24, 16, 1, 12, 692, DateTimeKind.Local).AddTicks(4207) });

            migrationBuilder.UpdateData(
                table: "FoodEntries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "Time_Stamp" },
                values: new object[] { new DateTime(2024, 1, 24, 16, 1, 12, 692, DateTimeKind.Local).AddTicks(4211), new DateTime(2024, 1, 24, 16, 1, 12, 692, DateTimeKind.Local).AddTicks(4211), new DateTime(2024, 1, 24, 16, 1, 12, 692, DateTimeKind.Local).AddTicks(4210) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 16, 1, 12, 503, DateTimeKind.Local).AddTicks(3523), new DateTime(2024, 1, 24, 16, 1, 12, 503, DateTimeKind.Local).AddTicks(3523) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 16, 1, 12, 503, DateTimeKind.Local).AddTicks(3526), new DateTime(2024, 1, 24, 16, 1, 12, 503, DateTimeKind.Local).AddTicks(3526) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 8, 1, 12, 692, DateTimeKind.Utc).AddTicks(4566), new DateTime(2024, 1, 24, 8, 1, 12, 692, DateTimeKind.Utc).AddTicks(4566) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 8, 1, 12, 692, DateTimeKind.Utc).AddTicks(4568), new DateTime(2024, 1, 24, 8, 1, 12, 692, DateTimeKind.Utc).AddTicks(4568) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 16, 1, 12, 503, DateTimeKind.Local).AddTicks(3358), new DateTime(2024, 1, 24, 16, 1, 12, 503, DateTimeKind.Local).AddTicks(3359) });

            migrationBuilder.UpdateData(
                table: "NutritionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 16, 1, 12, 503, DateTimeKind.Local).AddTicks(3360), new DateTime(2024, 1, 24, 16, 1, 12, 503, DateTimeKind.Local).AddTicks(3361) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 16, 1, 12, 692, DateTimeKind.Local).AddTicks(4814), new DateTime(2024, 1, 24, 16, 1, 12, 692, DateTimeKind.Local).AddTicks(4815) });

            migrationBuilder.UpdateData(
                table: "NutritionalQuotas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 16, 1, 12, 692, DateTimeKind.Local).AddTicks(4817), new DateTime(2024, 1, 24, 16, 1, 12, 692, DateTimeKind.Local).AddTicks(4817) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 16, 1, 12, 503, DateTimeKind.Local).AddTicks(3912), new DateTime(2024, 1, 24, 16, 1, 12, 503, DateTimeKind.Local).AddTicks(3913) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 16, 1, 12, 503, DateTimeKind.Local).AddTicks(3915), new DateTime(2024, 1, 24, 16, 1, 12, 503, DateTimeKind.Local).AddTicks(3916) });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "SubMonthsDuration" },
                values: new object[] { new DateTime(2024, 1, 24, 16, 1, 12, 503, DateTimeKind.Local).AddTicks(3012), new DateTime(2024, 1, 24, 16, 1, 12, 503, DateTimeKind.Local).AddTicks(3023), null });

            migrationBuilder.UpdateData(
                table: "SubscriptionInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "SubMonthsDuration" },
                values: new object[] { new DateTime(2024, 1, 24, 16, 1, 12, 503, DateTimeKind.Local).AddTicks(3025), new DateTime(2024, 1, 24, 16, 1, 12, 503, DateTimeKind.Local).AddTicks(3026), null });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 16, 1, 12, 692, DateTimeKind.Local).AddTicks(3967), new DateTime(2024, 1, 24, 16, 1, 12, 692, DateTimeKind.Local).AddTicks(3966), new DateTime(2024, 1, 24, 16, 1, 12, 692, DateTimeKind.Local).AddTicks(3965), new DateTime(2024, 1, 24, 16, 1, 12, 692, DateTimeKind.Local).AddTicks(3968) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateEnd", "DateStart", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 16, 1, 12, 692, DateTimeKind.Local).AddTicks(3970), new DateTime(2024, 1, 24, 16, 1, 12, 692, DateTimeKind.Local).AddTicks(3970), new DateTime(2024, 1, 24, 16, 1, 12, 692, DateTimeKind.Local).AddTicks(3969), new DateTime(2024, 1, 24, 16, 1, 12, 692, DateTimeKind.Local).AddTicks(3970) });
        }
    }
}
