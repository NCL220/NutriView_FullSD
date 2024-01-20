using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NutriView.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mission = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Height = table.Column<double>(type: "float", nullable: true),
                    Weight = table.Column<double>(type: "float", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeviceCodes",
                columns: table => new
                {
                    UserCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DeviceCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    SubjectId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SessionId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClientId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Expiration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", maxLength: 50000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceCodes", x => x.UserCode);
                });

            migrationBuilder.CreateTable(
                name: "Keys",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Use = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Algorithm = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsX509Certificate = table.Column<bool>(type: "bit", nullable: false),
                    DataProtected = table.Column<bool>(type: "bit", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Keys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersistedGrants",
                columns: table => new
                {
                    Key = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SubjectId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SessionId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClientId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Expiration = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ConsumedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Data = table.Column<string>(type: "nvarchar(max)", maxLength: 50000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersistedGrants", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "SubscriptionInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubCost = table.Column<double>(type: "float", nullable: false),
                    SubTierName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscriptionInfos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Staffs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<int>(type: "int", nullable: true),
                    ImagePathStaff = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManagerID = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Staffs_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FoodEntries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalCalories = table.Column<double>(type: "float", nullable: false),
                    Time_Stamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodEntries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FoodEntries_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NutritionalQuotas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TargetCalorieDaily = table.Column<double>(type: "float", nullable: false),
                    TargetCarbDaily = table.Column<double>(type: "float", nullable: false),
                    TargetBMI = table.Column<double>(type: "float", nullable: false),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NutritionalQuotas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NutritionalQuotas_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Subscriptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cost = table.Column<double>(type: "float", nullable: false),
                    DateStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    SubInfoID = table.Column<int>(type: "int", nullable: false),
                    SubscriptionInfoId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subscriptions_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Subscriptions_SubscriptionInfos_SubscriptionInfoId",
                        column: x => x.SubscriptionInfoId,
                        principalTable: "SubscriptionInfos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "NutritionInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NutritionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NutritionDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NutritionImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StaffId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NutritionInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NutritionInfos_Staffs_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staffs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Calories = table.Column<double>(type: "float", nullable: false),
                    Carbohydrates = table.Column<double>(type: "float", nullable: false),
                    Vitamins = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fats = table.Column<double>(type: "float", nullable: false),
                    ServingSize = table.Column<double>(type: "float", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FoodEntryID = table.Column<int>(type: "int", nullable: false),
                    StaffId = table.Column<int>(type: "int", nullable: false),
                    FoodDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Foods_FoodEntries_FoodEntryID",
                        column: x => x.FoodEntryID,
                        principalTable: "FoodEntries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Foods_Staffs_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staffs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Meals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Calories = table.Column<int>(type: "int", nullable: true),
                    PortionSize = table.Column<double>(type: "float", nullable: true),
                    TimePeriod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FoodEntryID = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Meals_FoodEntries_FoodEntryID",
                        column: x => x.FoodEntryID,
                        principalTable: "FoodEntries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                    { "1507dbd1-1c83-4ad2-9b0e-4d298c7b4521", 0, "945d8e4e-785d-4729-a5f2-518a83340506", "Manager@localhost.com", false, "Manager", "User", false, null, "Manager@LOCALHOST.COM", "MANAGER@LOCALHOST.COM", "AQAAAAIAAYagAAAAEFEsKkY7yW7RUIoQVX3BAXwPMnbYZ6sjMWwrqwFKd2Hm14cAdHJBUTUJ7kPESo3jcQ==", null, false, "93241b24-a310-4825-814a-c0c63b399a5a", false, "Manager@localhost.com" },
                    { "41624b27-7496-447c-b299-4892483d6b47", 0, "8da6058f-f16d-4c46-9612-977df1f94113", "Customer@localhost.com", false, "Customer", "User", false, null, "Customer@LOCALHOST.COM", "CUSTOMER@LOCALHOST.COM", "AQAAAAIAAYagAAAAEPdE7FIUuTUeV2+jtco+k4+HlMegi4i5cYm/9UKOoUBTYQnRb5tSb4ZLF8niwaoJNA==", null, false, "3ba1a7e7-2918-4162-9323-b8e02aee86e9", false, "Customer@localhost.com" },
                    { "4d3dfcba-a0af-4b10-989d-d63dcfec5e97", 0, "f531944e-af00-490f-a3ae-4aef54cc06bc", "Staff@localhost.com", false, "Staff", "User", false, null, "Staff@LOCALHOST.COM", "STAFF@LOCALHOST.COM", "AQAAAAIAAYagAAAAEMHDo6t88qz79r+I7/OdqiaVgA3U/+HqVLAan5tqJSVhcw68D1dBF/eJNDl3IS6T+Q==", null, false, "028c9124-ed67-4bc6-a85e-87f2e7e1cdfa", false, "Staff@localhost.com" },
                    { "8aa738a7-6c07-4e5a-8a7f-5637388c41b4", 0, "c0760924-5414-4dda-94d5-87db83363605", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEHhOgL62lkZ/h6J88ffufV1BL4lLL8tB46vhWFAAc5GmcSrX1gjEkX07rTdmU5FNKA==", null, false, "b11abcd3-bd8b-4121-b354-4484d7c02093", false, "admin@localhost.com" }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "CompanyDescription", "CompanyImagePath", "CompanyName", "CreatedBy", "DateCreated", "DateUpdated", "Mission", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "At NuriView Corporations, we believe that a heathy lifestyle would always begins with proper nutrition.We are a dedicated team of nutritionists and dietitians comitted in providing you with the knowledge and tools to aid you in your journey to a healthier diet.", "Not Yet Available", "NutriView", "System", new DateTime(2024, 1, 20, 22, 31, 33, 839, DateTimeKind.Local).AddTicks(1615), new DateTime(2024, 1, 20, 22, 31, 33, 839, DateTimeKind.Local).AddTicks(1616), "Our mission is to empower individuals to achieve optimal health through mindful eating. We understand that nutrition is not always a one-size-fits-all.Our goal is to guide you on a personalized journey towards a balanced and nourishing lifestyle that will bring you a step closer to a healthier you.", "System" },
                    { 2, "Not Yet Available", "Not Yet Available", "NutriViewCorps", "System", new DateTime(2024, 1, 20, 22, 31, 33, 839, DateTimeKind.Local).AddTicks(1618), new DateTime(2024, 1, 20, 22, 31, 33, 839, DateTimeKind.Local).AddTicks(1619), "Our Mission is to encourage people to eat healthy and live healthy", "System" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Age", "CreatedBy", "DateCreated", "DateUpdated", "Email", "Gender", "Height", "Password", "UpdatedBy", "UserName", "Weight" },
                values: new object[,]
                {
                    { 1, 31, "System", new DateTime(2024, 1, 20, 22, 31, 34, 45, DateTimeKind.Local).AddTicks(2576), new DateTime(2024, 1, 20, 22, 31, 34, 45, DateTimeKind.Local).AddTicks(2601), "Test@Blazor.com", "Male", 160.0, "Test222", "System", "TestLim", 88.5 },
                    { 2, 32, "System", new DateTime(2024, 1, 20, 22, 31, 34, 45, DateTimeKind.Local).AddTicks(2610), new DateTime(2024, 1, 20, 22, 31, 34, 45, DateTimeKind.Local).AddTicks(2610), "Test2@Blazor.com", "Female", 178.0, "Test2212", "System", "TestRRLim", 77.0 }
                });

            migrationBuilder.InsertData(
                table: "SubscriptionInfos",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "SubCost", "SubDescription", "SubTierName", "SubType", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 1, 20, 22, 31, 33, 839, DateTimeKind.Local).AddTicks(1242), new DateTime(2024, 1, 20, 22, 31, 33, 839, DateTimeKind.Local).AddTicks(1255), 5.0, "Unlocks The Personal Quota Tracker", "Health Enthusiasts", "Monthly", "System" },
                    { 2, "System", new DateTime(2024, 1, 20, 22, 31, 33, 839, DateTimeKind.Local).AddTicks(1259), new DateTime(2024, 1, 20, 22, 31, 33, 839, DateTimeKind.Local).AddTicks(1259), 30.0, "Unlocks The Personal Quota Tracker and other Features!!", "Health Enthusiasts", "Yearly", "System" }
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
                    { 1, "System", 1, new DateTime(2024, 1, 20, 22, 31, 34, 45, DateTimeKind.Local).AddTicks(3144), new DateTime(2024, 1, 20, 22, 31, 34, 45, DateTimeKind.Local).AddTicks(3145), "22 Jan 2024", 22.0, "System" },
                    { 2, "System", 2, new DateTime(2024, 1, 20, 22, 31, 34, 45, DateTimeKind.Local).AddTicks(3148), new DateTime(2024, 1, 20, 22, 31, 34, 45, DateTimeKind.Local).AddTicks(3149), "1 Jan 2024", 34.0, "System" }
                });

            migrationBuilder.InsertData(
                table: "NutritionalQuotas",
                columns: new[] { "Id", "CreatedBy", "CustomerID", "DateCreated", "DateUpdated", "TargetBMI", "TargetCalorieDaily", "TargetCarbDaily", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", 1, new DateTime(2024, 1, 20, 22, 31, 34, 45, DateTimeKind.Local).AddTicks(3982), new DateTime(2024, 1, 20, 22, 31, 34, 45, DateTimeKind.Local).AddTicks(3984), 19.0, 2000.0, 300.0, "System" },
                    { 2, "System", 2, new DateTime(2024, 1, 20, 22, 31, 34, 45, DateTimeKind.Local).AddTicks(3986), new DateTime(2024, 1, 20, 22, 31, 34, 45, DateTimeKind.Local).AddTicks(3986), 21.0, 2000.0, 290.0, "System" }
                });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "Id", "CompanyId", "CreatedBy", "DateCreated", "DateUpdated", "Email", "ImagePathStaff", "ManagerID", "Password", "PhoneNumber", "Role", "UpdatedBy", "UserName" },
                values: new object[,]
                {
                    { 1, 1, "System", new DateTime(2024, 1, 20, 22, 31, 33, 839, DateTimeKind.Local).AddTicks(2638), new DateTime(2024, 1, 20, 22, 31, 33, 839, DateTimeKind.Local).AddTicks(2640), "ngchunlim04@gmail.com", "-", 1, "Chun11", 87993192, "Manager", "System", "ChunLim" },
                    { 2, 1, "System", new DateTime(2024, 1, 20, 22, 31, 33, 839, DateTimeKind.Local).AddTicks(2643), new DateTime(2024, 1, 20, 22, 31, 33, 839, DateTimeKind.Local).AddTicks(2643), "Test04@gmail.com", "-", 2, "Lim12", 87993192, "Manager", "System", "Kenneth" }
                });

            migrationBuilder.InsertData(
                table: "Subscriptions",
                columns: new[] { "Id", "Cost", "CreatedBy", "CustomerID", "DateCreated", "DateEnd", "DateStart", "DateUpdated", "SubInfoID", "SubscriptionInfoId", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 0.0, "System", 1, new DateTime(2024, 1, 20, 22, 31, 34, 45, DateTimeKind.Local).AddTicks(2912), new DateTime(2024, 1, 20, 22, 31, 34, 45, DateTimeKind.Local).AddTicks(2907), new DateTime(2024, 1, 20, 22, 31, 34, 45, DateTimeKind.Local).AddTicks(2906), new DateTime(2024, 1, 20, 22, 31, 34, 45, DateTimeKind.Local).AddTicks(2912), 0, null, "System" },
                    { 2, 0.0, "System", 2, new DateTime(2024, 1, 20, 22, 31, 34, 45, DateTimeKind.Local).AddTicks(2916), new DateTime(2024, 1, 20, 22, 31, 34, 45, DateTimeKind.Local).AddTicks(2915), new DateTime(2024, 1, 20, 22, 31, 34, 45, DateTimeKind.Local).AddTicks(2915), new DateTime(2024, 1, 20, 22, 31, 34, 45, DateTimeKind.Local).AddTicks(2917), 0, null, "System" }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "Calories", "Carbohydrates", "CreatedBy", "DateCreated", "DateUpdated", "Fats", "FoodDesc", "FoodEntryID", "ImagePath", "Name", "ServingSize", "StaffId", "UpdatedBy", "Vitamins" },
                values: new object[,]
                {
                    { 1, 25.0, 6.0, "System", new DateTime(2024, 1, 20, 22, 31, 33, 839, DateTimeKind.Local).AddTicks(2000), new DateTime(2024, 1, 20, 22, 31, 33, 839, DateTimeKind.Local).AddTicks(2000), 0.10000000000000001, "Carrots Contains 25 Calories and 6g of Carbohydrates , etc", 1, "-", "Carrots", 61.0, 1, "System", "A,C,K" },
                    { 2, 165.0, 0.0, "System", new DateTime(2024, 1, 20, 22, 31, 33, 839, DateTimeKind.Local).AddTicks(2003), new DateTime(2024, 1, 20, 22, 31, 33, 839, DateTimeKind.Local).AddTicks(2003), 3.6000000000000001, "Chicken Contains 165 Calories per 100 grams and does not have any Carbohydrates , etc", 2, "-", "Chicken", 100.0, 2, "System", "A, B6, C, D, E" }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "Calories", "CreatedBy", "DateCreated", "DateUpdated", "FoodEntryID", "Name", "PortionSize", "TimePeriod", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, null, "System", new DateTime(2024, 1, 20, 14, 31, 34, 45, DateTimeKind.Utc).AddTicks(3606), new DateTime(2024, 1, 20, 14, 31, 34, 45, DateTimeKind.Utc).AddTicks(3607), 1, "Carrots", 1.0, "Morning", "System" },
                    { 2, null, "System", new DateTime(2024, 1, 20, 14, 31, 34, 45, DateTimeKind.Utc).AddTicks(3609), new DateTime(2024, 1, 20, 14, 31, 34, 45, DateTimeKind.Utc).AddTicks(3610), 2, "ChickenRice", 1.0, "Morning", "System" }
                });

            migrationBuilder.InsertData(
                table: "NutritionInfos",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "NutritionDescription", "NutritionImagePath", "NutritionName", "StaffId", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 1, 20, 22, 31, 33, 839, DateTimeKind.Local).AddTicks(1808), new DateTime(2024, 1, 20, 22, 31, 33, 839, DateTimeKind.Local).AddTicks(1809), "Essential for vision, immune function, and skin health.", "-", "Vitamin A", 1, "System" },
                    { 2, "System", new DateTime(2024, 1, 20, 22, 31, 33, 839, DateTimeKind.Local).AddTicks(1812), new DateTime(2024, 1, 20, 22, 31, 33, 839, DateTimeKind.Local).AddTicks(1812), "Supports bone health, immune system, and overall well-being.", "-", "Vitamin D", 2, "System" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCodes_DeviceCode",
                table: "DeviceCodes",
                column: "DeviceCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCodes_Expiration",
                table: "DeviceCodes",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_FoodEntries_CustomerID",
                table: "FoodEntries",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Foods_FoodEntryID",
                table: "Foods",
                column: "FoodEntryID");

            migrationBuilder.CreateIndex(
                name: "IX_Foods_StaffId",
                table: "Foods",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_Keys_Use",
                table: "Keys",
                column: "Use");

            migrationBuilder.CreateIndex(
                name: "IX_Meals_FoodEntryID",
                table: "Meals",
                column: "FoodEntryID");

            migrationBuilder.CreateIndex(
                name: "IX_NutritionalQuotas_CustomerID",
                table: "NutritionalQuotas",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_NutritionInfos_StaffId",
                table: "NutritionInfos",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_ConsumedTime",
                table: "PersistedGrants",
                column: "ConsumedTime");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_Expiration",
                table: "PersistedGrants",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_SubjectId_ClientId_Type",
                table: "PersistedGrants",
                columns: new[] { "SubjectId", "ClientId", "Type" });

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_SubjectId_SessionId_Type",
                table: "PersistedGrants",
                columns: new[] { "SubjectId", "SessionId", "Type" });

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_CompanyId",
                table: "Staffs",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptions_CustomerID",
                table: "Subscriptions",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptions_SubscriptionInfoId",
                table: "Subscriptions",
                column: "SubscriptionInfoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "DeviceCodes");

            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "Keys");

            migrationBuilder.DropTable(
                name: "Meals");

            migrationBuilder.DropTable(
                name: "NutritionalQuotas");

            migrationBuilder.DropTable(
                name: "NutritionInfos");

            migrationBuilder.DropTable(
                name: "PersistedGrants");

            migrationBuilder.DropTable(
                name: "Subscriptions");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "FoodEntries");

            migrationBuilder.DropTable(
                name: "Staffs");

            migrationBuilder.DropTable(
                name: "SubscriptionInfos");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
