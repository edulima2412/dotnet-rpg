using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace dotnet_rpg.Migrations
{
    public partial class FinalSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { 1, new byte[] { 25, 94, 161, 78, 176, 222, 171, 70, 214, 240, 102, 129, 111, 3, 255, 96, 122, 96, 41, 77, 32, 9, 184, 213, 209, 45, 108, 169, 199, 243, 198, 182, 161, 89, 236, 50, 78, 175, 198, 72, 139, 254, 238, 208, 151, 85, 20, 188, 198, 208, 84, 99, 65, 217, 51, 197, 178, 184, 239, 51, 119, 177, 58, 208 }, new byte[] { 25, 94, 161, 78, 176, 222, 171, 70, 214, 240, 102, 129, 111, 3, 255, 96, 122, 96, 41, 77, 32, 9, 184, 213, 209, 45, 108, 169, 199, 243, 198, 182, 161, 89, 236, 50, 78, 175, 198, 72, 139, 254, 238, 208, 151, 85, 20, 188, 198, 208, 84, 99, 65, 217, 51, 197, 178, 184, 239, 51, 119, 177, 58, 208 }, "User1" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { 2, new byte[] { 25, 94, 161, 78, 176, 222, 171, 70, 214, 240, 102, 129, 111, 3, 255, 96, 122, 96, 41, 77, 32, 9, 184, 213, 209, 45, 108, 169, 199, 243, 198, 182, 161, 89, 236, 50, 78, 175, 198, 72, 139, 254, 238, 208, 151, 85, 20, 188, 198, 208, 84, 99, 65, 217, 51, 197, 178, 184, 239, 51, 119, 177, 58, 208 }, new byte[] { 25, 94, 161, 78, 176, 222, 171, 70, 214, 240, 102, 129, 111, 3, 255, 96, 122, 96, 41, 77, 32, 9, 184, 213, 209, 45, 108, 169, 199, 243, 198, 182, 161, 89, 236, 50, 78, 175, 198, 72, 139, 254, 238, 208, 151, 85, 20, 188, 198, 208, 84, 99, 65, 217, 51, 197, 178, 184, 239, 51, 119, 177, 58, 208 }, "User2" });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "Class", "Defeats", "Defense", "Fights", "HitPoints", "Intelligence", "Name", "Strength", "UserId", "Victories" },
                values: new object[] { 1, 1, 0, 10, 0, 100, 10, "Frodo", 15, 1, 0 });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "Class", "Defeats", "Defense", "Fights", "HitPoints", "Intelligence", "Name", "Strength", "UserId", "Victories" },
                values: new object[] { 2, 2, 0, 5, 0, 100, 20, "Raistlin", 5, 2, 0 });

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CharacterSkills",
                keyColumns: new[] { "CharacterId", "SkillId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "CharacterSkills",
                keyColumns: new[] { "CharacterId", "SkillId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "CharacterSkills",
                keyColumns: new[] { "CharacterId", "SkillId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
