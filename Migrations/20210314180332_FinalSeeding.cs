using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace dotnet_rpg.Migrations
{
    public partial class FinalSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Damage = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Username = table.Column<string>(type: "TEXT", nullable: true),
                    PasswordHash = table.Column<byte[]>(type: "BLOB", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "BLOB", nullable: true),
                    Role = table.Column<string>(type: "TEXT", nullable: false, defaultValue: "Player")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    HitPoints = table.Column<int>(type: "INTEGER", nullable: false),
                    Strength = table.Column<int>(type: "INTEGER", nullable: false),
                    Defense = table.Column<int>(type: "INTEGER", nullable: false),
                    Intelligence = table.Column<int>(type: "INTEGER", nullable: false),
                    Class = table.Column<int>(type: "INTEGER", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    Fights = table.Column<int>(type: "INTEGER", nullable: false),
                    Victories = table.Column<int>(type: "INTEGER", nullable: false),
                    Defeats = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Characters_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterSkills",
                columns: table => new
                {
                    CharacterId = table.Column<int>(type: "INTEGER", nullable: false),
                    SkillId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterSkills", x => new { x.CharacterId, x.SkillId });
                    table.ForeignKey(
                        name: "FK_CharacterSkills_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterSkills_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Weapons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Damage = table.Column<int>(type: "INTEGER", nullable: false),
                    CharacterId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Weapons_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Damage", "Name" },
                values: new object[] { 1, 30, "Fireball" });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Damage", "Name" },
                values: new object[] { 2, 20, "Frenzy" });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Damage", "Name" },
                values: new object[] { 3, 50, "Blizzard" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "PasswordHash", "PasswordSalt", "Role", "Username" },
                values: new object[] { 1, new byte[] { 214, 63, 211, 14, 193, 25, 251, 115, 246, 192, 2, 0, 95, 232, 103, 109, 89, 249, 251, 204, 149, 16, 152, 205, 80, 85, 36, 107, 190, 203, 252, 68, 208, 123, 93, 106, 202, 9, 67, 250, 198, 195, 77, 241, 58, 44, 13, 238, 159, 104, 43, 213, 176, 14, 161, 192, 223, 45, 251, 239, 105, 138, 2, 176 }, new byte[] { 248, 74, 230, 102, 47, 56, 91, 42, 123, 174, 8, 88, 112, 151, 109, 172, 104, 1, 244, 204, 72, 146, 100, 183, 238, 251, 131, 45, 207, 10, 11, 164, 168, 95, 6, 249, 198, 179, 60, 68, 164, 175, 163, 197, 212, 18, 156, 54, 119, 16, 119, 184, 158, 103, 17, 195, 113, 225, 108, 86, 233, 220, 68, 95, 184, 198, 216, 241, 131, 226, 77, 216, 231, 53, 23, 143, 214, 117, 130, 56, 216, 69, 45, 46, 51, 222, 22, 17, 67, 58, 8, 72, 199, 93, 138, 114, 1, 60, 17, 117, 156, 216, 172, 183, 67, 12, 201, 27, 171, 119, 75, 190, 83, 88, 152, 113, 61, 2, 49, 171, 103, 146, 116, 251, 223, 242, 107, 37 }, "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { 2, new byte[] { 214, 63, 211, 14, 193, 25, 251, 115, 246, 192, 2, 0, 95, 232, 103, 109, 89, 249, 251, 204, 149, 16, 152, 205, 80, 85, 36, 107, 190, 203, 252, 68, 208, 123, 93, 106, 202, 9, 67, 250, 198, 195, 77, 241, 58, 44, 13, 238, 159, 104, 43, 213, 176, 14, 161, 192, 223, 45, 251, 239, 105, 138, 2, 176 }, new byte[] { 248, 74, 230, 102, 47, 56, 91, 42, 123, 174, 8, 88, 112, 151, 109, 172, 104, 1, 244, 204, 72, 146, 100, 183, 238, 251, 131, 45, 207, 10, 11, 164, 168, 95, 6, 249, 198, 179, 60, 68, 164, 175, 163, 197, 212, 18, 156, 54, 119, 16, 119, 184, 158, 103, 17, 195, 113, 225, 108, 86, 233, 220, 68, 95, 184, 198, 216, 241, 131, 226, 77, 216, 231, 53, 23, 143, 214, 117, 130, 56, 216, 69, 45, 46, 51, 222, 22, 17, 67, 58, 8, 72, 199, 93, 138, 114, 1, 60, 17, 117, 156, 216, 172, 183, 67, 12, 201, 27, 171, 119, 75, 190, 83, 88, 152, 113, 61, 2, 49, 171, 103, 146, 116, 251, 223, 242, 107, 37 }, "User1" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { 3, new byte[] { 214, 63, 211, 14, 193, 25, 251, 115, 246, 192, 2, 0, 95, 232, 103, 109, 89, 249, 251, 204, 149, 16, 152, 205, 80, 85, 36, 107, 190, 203, 252, 68, 208, 123, 93, 106, 202, 9, 67, 250, 198, 195, 77, 241, 58, 44, 13, 238, 159, 104, 43, 213, 176, 14, 161, 192, 223, 45, 251, 239, 105, 138, 2, 176 }, new byte[] { 248, 74, 230, 102, 47, 56, 91, 42, 123, 174, 8, 88, 112, 151, 109, 172, 104, 1, 244, 204, 72, 146, 100, 183, 238, 251, 131, 45, 207, 10, 11, 164, 168, 95, 6, 249, 198, 179, 60, 68, 164, 175, 163, 197, 212, 18, 156, 54, 119, 16, 119, 184, 158, 103, 17, 195, 113, 225, 108, 86, 233, 220, 68, 95, 184, 198, 216, 241, 131, 226, 77, 216, 231, 53, 23, 143, 214, 117, 130, 56, 216, 69, 45, 46, 51, 222, 22, 17, 67, 58, 8, 72, 199, 93, 138, 114, 1, 60, 17, 117, 156, 216, 172, 183, 67, 12, 201, 27, 171, 119, 75, 190, 83, 88, 152, 113, 61, 2, 49, 171, 103, 146, 116, 251, 223, 242, 107, 37 }, "User2" });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "Class", "Defeats", "Defense", "Fights", "HitPoints", "Intelligence", "Name", "Strength", "UserId", "Victories" },
                values: new object[] { 1, 1, 0, 10, 0, 100, 10, "Frodo", 15, 2, 0 });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "Class", "Defeats", "Defense", "Fights", "HitPoints", "Intelligence", "Name", "Strength", "UserId", "Victories" },
                values: new object[] { 2, 2, 0, 5, 0, 100, 20, "Raistlin", 5, 3, 0 });

            migrationBuilder.InsertData(
                table: "CharacterSkills",
                columns: new[] { "CharacterId", "SkillId" },
                values: new object[] { 1, 2 });

            migrationBuilder.InsertData(
                table: "CharacterSkills",
                columns: new[] { "CharacterId", "SkillId" },
                values: new object[] { 2, 1 });

            migrationBuilder.InsertData(
                table: "CharacterSkills",
                columns: new[] { "CharacterId", "SkillId" },
                values: new object[] { 2, 3 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "CharacterId", "Damage", "Name" },
                values: new object[] { 1, 1, 20, "Master Sword" });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "CharacterId", "Damage", "Name" },
                values: new object[] { 2, 2, 5, "Crystal Wand" });

            migrationBuilder.CreateIndex(
                name: "IX_Characters_UserId",
                table: "Characters",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterSkills_SkillId",
                table: "CharacterSkills",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_Weapons_CharacterId",
                table: "Weapons",
                column: "CharacterId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CharacterSkills");

            migrationBuilder.DropTable(
                name: "Weapons");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
