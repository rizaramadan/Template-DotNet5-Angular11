using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Template.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Modules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    URL = table.Column<string>(type: "text", nullable: true),
                    Icon = table.Column<string>(type: "text", nullable: true),
                    Sequence = table.Column<int>(type: "integer", nullable: false),
                    CreatedUser = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    UpdatedUser = table.Column<int>(type: "integer", nullable: false),
                    UpdatedData = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modules", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Profiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    IsDefault = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedUser = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    UpdatedUser = table.Column<int>(type: "integer", nullable: false),
                    UpdatedData = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profiles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ModuleProfiles",
                columns: table => new
                {
                    ModuleId = table.Column<int>(type: "integer", nullable: false),
                    ProfileId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModuleProfiles", x => new { x.ModuleId, x.ProfileId });
                    table.ForeignKey(
                        name: "FK_ModuleProfiles_Modules_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Modules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ModuleProfiles_Profiles_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Password = table.Column<string>(type: "text", nullable: true),
                    Code = table.Column<string>(type: "text", nullable: true),
                    IsAuthorised = table.Column<bool>(type: "boolean", nullable: false),
                    ProfileId = table.Column<int>(type: "integer", nullable: false),
                    CreatedUser = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    UpdatedUser = table.Column<int>(type: "integer", nullable: false),
                    UpdatedData = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Profiles_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Modules",
                columns: new[] { "Id", "CreatedUser", "Icon", "IsActive", "Name", "Sequence", "URL", "UpdatedData", "UpdatedUser" },
                values: new object[,]
                {
                    { 1, 0, "dashboard.png", true, "Dashboard", 1, "dashboard", null, 0 },
                    { 2, 0, "users.png", true, "Users", 2, "users", null, 0 },
                    { 3, 0, "accounts.png", true, "Account", 3, "accounts", null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "CreatedUser", "IsActive", "IsDefault", "Name", "UpdatedData", "UpdatedUser" },
                values: new object[,]
                {
                    { 1, 0, true, false, "Admin", null, 0 },
                    { 2, 0, true, true, "User", null, 0 }
                });

            migrationBuilder.InsertData(
                table: "ModuleProfiles",
                columns: new[] { "ModuleId", "ProfileId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 1 },
                    { 1, 2 },
                    { 3, 2 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUser", "Email", "IsActive", "IsAuthorised", "Name", "Password", "ProfileId", "UpdatedData", "UpdatedUser" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2021, 2, 14, 21, 59, 8, 947, DateTimeKind.Local).AddTicks(4467), 1, "admin@template.com", true, true, "Admin", "8D66A53A381493BEC08DA23CEF5A43767F20A42C", 1, null, 0 },
                    { 2, null, new DateTime(2021, 2, 14, 21, 59, 8, 948, DateTimeKind.Local).AddTicks(2930), 1, "user@template.com", true, true, "User", "8D66A53A381493BEC08DA23CEF5A43767F20A42C", 2, null, 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ModuleProfiles_ProfileId",
                table: "ModuleProfiles",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_ProfileId",
                table: "Users",
                column: "ProfileId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ModuleProfiles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Modules");

            migrationBuilder.DropTable(
                name: "Profiles");
        }
    }
}
