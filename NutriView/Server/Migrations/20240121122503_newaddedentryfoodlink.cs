using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NutriView.Server.Migrations
{
    /// <inheritdoc />
    public partial class newaddedentryfoodlink : Migration
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
                    Time_Stamp = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                        name: "FK_Foods_Staffs_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staffs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.CreateTable(
                name: "EntryLinkFoods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodEntryID = table.Column<int>(type: "int", nullable: false),
                    FoodID = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntryLinkFoods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EntryLinkFoods_FoodEntries_FoodEntryID",
                        column: x => x.FoodEntryID,
                        principalTable: "FoodEntries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EntryLinkFoods_Foods_FoodID",
                        column: x => x.FoodID,
                        principalTable: "Foods",
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
                    { "1507dbd1-1c83-4ad2-9b0e-4d298c7b4521", 0, "73edf72c-054b-43b0-bfc2-5e05322c7824", "Manager@localhost.com", false, "Manager", "User", false, null, "Manager@LOCALHOST.COM", "MANAGER@LOCALHOST.COM", "AQAAAAIAAYagAAAAENdKB1C9J9fbfIvpkxRzVOXqnV2NJ9XjcofPeFWLycg/mhT9F9y+h8WAd4deN8vVCg==", null, false, "3bbd1f44-6af8-433d-a964-1bd8ce9a7656", false, "Manager@localhost.com" },
                    { "41624b27-7496-447c-b299-4892483d6b47", 0, "754ff025-1fd6-413d-87c1-417022fbc6a2", "Customer@localhost.com", false, "Customer", "User", false, null, "Customer@LOCALHOST.COM", "CUSTOMER@LOCALHOST.COM", "AQAAAAIAAYagAAAAEHMZfn6vxWlicrDMhYYAhhmXWu0luttl4Veuvi7pb1XYzP2ppyR/dU7nZTqf6dkZCQ==", null, false, "e3342960-ea55-4ad0-860a-e00e6c3e9661", false, "Customer@localhost.com" },
                    { "4d3dfcba-a0af-4b10-989d-d63dcfec5e97", 0, "aeec5155-826a-4178-836d-d753fe5a00c3", "Staff@localhost.com", false, "Staff", "User", false, null, "Staff@LOCALHOST.COM", "STAFF@LOCALHOST.COM", "AQAAAAIAAYagAAAAEHZksxjCM0DyHuNfFfmc9+1nDWDVyk17zmJLbBbOUO6iuiXbngHaObkZMCz9IlCJAw==", null, false, "5f8f3d27-d2c3-47f3-a383-4002b0e155fe", false, "Staff@localhost.com" },
                    { "8aa738a7-6c07-4e5a-8a7f-5637388c41b4", 0, "b96263bd-a023-42fa-81a4-21cee19aa8af", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEHiMQTh0d3Nt3563p9XbOLV6pygx1ABRxMBGr0ZeICd2Nj1ItxrUJLjF99KcZiv25w==", null, false, "acba25c8-69a6-4064-8cf9-635c76c23d60", false, "admin@localhost.com" }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "CompanyDescription", "CompanyImagePath", "CompanyName", "CreatedBy", "DateCreated", "DateUpdated", "Mission", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "At NuriView Corporations, we believe that a heathy lifestyle would always begins with proper nutrition.We are a dedicated team of nutritionists and dietitians comitted in providing you with the knowledge and tools to aid you in your journey to a healthier diet.", "Not Yet Available", "NutriView", "System", new DateTime(2024, 1, 21, 20, 25, 2, 710, DateTimeKind.Local).AddTicks(1321), new DateTime(2024, 1, 21, 20, 25, 2, 710, DateTimeKind.Local).AddTicks(1322), "Our mission is to empower individuals to achieve optimal health through mindful eating. We understand that nutrition is not always a one-size-fits-all.Our goal is to guide you on a personalized journey towards a balanced and nourishing lifestyle that will bring you a step closer to a healthier you.", "System" },
                    { 2, "Not Yet Available", "Not Yet Available", "NutriViewCorps", "System", new DateTime(2024, 1, 21, 20, 25, 2, 710, DateTimeKind.Local).AddTicks(1324), new DateTime(2024, 1, 21, 20, 25, 2, 710, DateTimeKind.Local).AddTicks(1324), "Our Mission is to encourage people to eat healthy and live healthy", "System" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Age", "CreatedBy", "DateCreated", "DateUpdated", "Email", "Gender", "Height", "Password", "UpdatedBy", "UserName", "Weight" },
                values: new object[,]
                {
                    { 1, 31, "System", new DateTime(2024, 1, 21, 20, 25, 2, 900, DateTimeKind.Local).AddTicks(8581), new DateTime(2024, 1, 21, 20, 25, 2, 900, DateTimeKind.Local).AddTicks(8594), "Test@Blazor.com", "Male", 160.0, "Test222", "System", "TestLim", 88.5 },
                    { 2, 32, "System", new DateTime(2024, 1, 21, 20, 25, 2, 900, DateTimeKind.Local).AddTicks(8598), new DateTime(2024, 1, 21, 20, 25, 2, 900, DateTimeKind.Local).AddTicks(8599), "Test2@Blazor.com", "Female", 178.0, "Test2212", "System", "TestRRLim", 77.0 }
                });

            migrationBuilder.InsertData(
                table: "SubscriptionInfos",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "SubCost", "SubDescription", "SubTierName", "SubType", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 1, 21, 20, 25, 2, 710, DateTimeKind.Local).AddTicks(1015), new DateTime(2024, 1, 21, 20, 25, 2, 710, DateTimeKind.Local).AddTicks(1024), 5.0, "Unlocks The Personal Quota Tracker", "Health Enthusiasts", "Monthly", "System" },
                    { 2, "System", new DateTime(2024, 1, 21, 20, 25, 2, 710, DateTimeKind.Local).AddTicks(1027), new DateTime(2024, 1, 21, 20, 25, 2, 710, DateTimeKind.Local).AddTicks(1027), 30.0, "Unlocks The Personal Quota Tracker and other Features!!", "Health Enthusiasts", "Yearly", "System" }
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
                    { 1, "System", 1, new DateTime(2024, 1, 21, 20, 25, 2, 900, DateTimeKind.Local).AddTicks(9037), new DateTime(2024, 1, 21, 20, 25, 2, 900, DateTimeKind.Local).AddTicks(9037), new DateTime(2024, 1, 21, 20, 25, 2, 900, DateTimeKind.Local).AddTicks(9036), 22.0, "System" },
                    { 2, "System", 2, new DateTime(2024, 1, 21, 20, 25, 2, 900, DateTimeKind.Local).AddTicks(9039), new DateTime(2024, 1, 21, 20, 25, 2, 900, DateTimeKind.Local).AddTicks(9040), new DateTime(2024, 1, 21, 20, 25, 2, 900, DateTimeKind.Local).AddTicks(9039), 34.0, "System" }
                });

            migrationBuilder.InsertData(
                table: "NutritionalQuotas",
                columns: new[] { "Id", "CreatedBy", "CustomerID", "DateCreated", "DateUpdated", "TargetBMI", "TargetCalorieDaily", "TargetCarbDaily", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", 1, new DateTime(2024, 1, 21, 20, 25, 2, 900, DateTimeKind.Local).AddTicks(9722), new DateTime(2024, 1, 21, 20, 25, 2, 900, DateTimeKind.Local).AddTicks(9722), 19.0, 2000.0, 300.0, "System" },
                    { 2, "System", 2, new DateTime(2024, 1, 21, 20, 25, 2, 900, DateTimeKind.Local).AddTicks(9724), new DateTime(2024, 1, 21, 20, 25, 2, 900, DateTimeKind.Local).AddTicks(9725), 21.0, 2000.0, 290.0, "System" }
                });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "Id", "CompanyId", "CreatedBy", "DateCreated", "DateUpdated", "Email", "ImagePathStaff", "ManagerID", "Password", "PhoneNumber", "Role", "UpdatedBy", "UserName" },
                values: new object[,]
                {
                    { 1, 1, "System", new DateTime(2024, 1, 21, 20, 25, 2, 710, DateTimeKind.Local).AddTicks(1999), new DateTime(2024, 1, 21, 20, 25, 2, 710, DateTimeKind.Local).AddTicks(1999), "ngchunlim04@gmail.com", "-", 1, "Chun11", 87993192, "Manager", "System", "ChunLim" },
                    { 2, 1, "System", new DateTime(2024, 1, 21, 20, 25, 2, 710, DateTimeKind.Local).AddTicks(2001), new DateTime(2024, 1, 21, 20, 25, 2, 710, DateTimeKind.Local).AddTicks(2002), "Test04@gmail.com", "-", 2, "Lim12", 87993192, "Manager", "System", "Kenneth" }
                });

            migrationBuilder.InsertData(
                table: "Subscriptions",
                columns: new[] { "Id", "Cost", "CreatedBy", "CustomerID", "DateCreated", "DateEnd", "DateStart", "DateUpdated", "SubInfoID", "SubscriptionInfoId", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 0.0, "System", 1, new DateTime(2024, 1, 21, 20, 25, 2, 900, DateTimeKind.Local).AddTicks(8826), new DateTime(2024, 1, 21, 20, 25, 2, 900, DateTimeKind.Local).AddTicks(8825), new DateTime(2024, 1, 21, 20, 25, 2, 900, DateTimeKind.Local).AddTicks(8824), new DateTime(2024, 1, 21, 20, 25, 2, 900, DateTimeKind.Local).AddTicks(8826), 0, null, "System" },
                    { 2, 0.0, "System", 2, new DateTime(2024, 1, 21, 20, 25, 2, 900, DateTimeKind.Local).AddTicks(8828), new DateTime(2024, 1, 21, 20, 25, 2, 900, DateTimeKind.Local).AddTicks(8828), new DateTime(2024, 1, 21, 20, 25, 2, 900, DateTimeKind.Local).AddTicks(8828), new DateTime(2024, 1, 21, 20, 25, 2, 900, DateTimeKind.Local).AddTicks(8829), 0, null, "System" }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "Calories", "Carbohydrates", "CreatedBy", "DateCreated", "DateUpdated", "Fats", "FoodDesc", "ImagePath", "Name", "ServingSize", "StaffId", "UpdatedBy", "Vitamins" },
                values: new object[,]
                {
                    { 1, 25.0, 6.0, "System", new DateTime(2024, 1, 21, 20, 25, 2, 710, DateTimeKind.Local).AddTicks(1654), new DateTime(2024, 1, 21, 20, 25, 2, 710, DateTimeKind.Local).AddTicks(1654), 0.10000000000000001, "Carrots Contains 25 Calories and 6g of Carbohydrates , etc", "-", "Carrots", 61.0, 1, "System", "A,C,K" },
                    { 2, 165.0, 0.0, "System", new DateTime(2024, 1, 21, 20, 25, 2, 710, DateTimeKind.Local).AddTicks(1656), new DateTime(2024, 1, 21, 20, 25, 2, 710, DateTimeKind.Local).AddTicks(1657), 3.6000000000000001, "Chicken Contains 165 Calories per 100 grams and does not have any Carbohydrates , etc", "-", "Chicken", 100.0, 2, "System", "A, B6, C, D, E" }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "Calories", "CreatedBy", "DateCreated", "DateUpdated", "FoodEntryID", "Name", "PortionSize", "TimePeriod", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, null, "System", new DateTime(2024, 1, 21, 12, 25, 2, 900, DateTimeKind.Utc).AddTicks(9436), new DateTime(2024, 1, 21, 12, 25, 2, 900, DateTimeKind.Utc).AddTicks(9437), 1, "Carrots", 1.0, "Morning", "System" },
                    { 2, null, "System", new DateTime(2024, 1, 21, 12, 25, 2, 900, DateTimeKind.Utc).AddTicks(9439), new DateTime(2024, 1, 21, 12, 25, 2, 900, DateTimeKind.Utc).AddTicks(9440), 2, "ChickenRice", 1.0, "Morning", "System" }
                });

            migrationBuilder.InsertData(
                table: "NutritionInfos",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "NutritionDescription", "NutritionImagePath", "NutritionName", "StaffId", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 1, 21, 20, 25, 2, 710, DateTimeKind.Local).AddTicks(1488), new DateTime(2024, 1, 21, 20, 25, 2, 710, DateTimeKind.Local).AddTicks(1489), "Essential for vision, immune function, and skin health.", "-", "Vitamin A", 1, "System" },
                    { 2, "System", new DateTime(2024, 1, 21, 20, 25, 2, 710, DateTimeKind.Local).AddTicks(1491), new DateTime(2024, 1, 21, 20, 25, 2, 710, DateTimeKind.Local).AddTicks(1491), "Supports bone health, immune system, and overall well-being.", "-", "Vitamin D", 2, "System" }
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
                name: "IX_EntryLinkFoods_FoodEntryID",
                table: "EntryLinkFoods",
                column: "FoodEntryID");

            migrationBuilder.CreateIndex(
                name: "IX_EntryLinkFoods_FoodID",
                table: "EntryLinkFoods",
                column: "FoodID");

            migrationBuilder.CreateIndex(
                name: "IX_FoodEntries_CustomerID",
                table: "FoodEntries",
                column: "CustomerID");

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
                name: "EntryLinkFoods");

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
                name: "Foods");

            migrationBuilder.DropTable(
                name: "FoodEntries");

            migrationBuilder.DropTable(
                name: "SubscriptionInfos");

            migrationBuilder.DropTable(
                name: "Staffs");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
