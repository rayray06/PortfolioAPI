using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class ChangedRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Skill_SkillCategoryTable_CategoryID",
                table: "Skill");

            migrationBuilder.DropIndex(
                name: "IX_Skill_CategoryID",
                table: "Skill");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SkillCategoryTable",
                table: "SkillCategoryTable");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "Skill");

            migrationBuilder.RenameTable(
                name: "SkillCategoryTable",
                newName: "SkillCategory");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SkillCategory",
                table: "SkillCategory",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Education",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    Title = table.Column<string>(type: "text", nullable: true),
                    School = table.Column<string>(type: "text", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Education", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SkillCategoryTableSkillTable",
                columns: table => new
                {
                    CategoriesId = table.Column<string>(type: "varchar(255)", nullable: false),
                    SkillsId = table.Column<string>(type: "varchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillCategoryTableSkillTable", x => new { x.CategoriesId, x.SkillsId });
                    table.ForeignKey(
                        name: "FK_SkillCategoryTableSkillTable_Skill_SkillsId",
                        column: x => x.SkillsId,
                        principalTable: "Skill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SkillCategoryTableSkillTable_SkillCategory_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "SkillCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SkillCategoryTableSkillTable_SkillsId",
                table: "SkillCategoryTableSkillTable",
                column: "SkillsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Education");

            migrationBuilder.DropTable(
                name: "SkillCategoryTableSkillTable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SkillCategory",
                table: "SkillCategory");

            migrationBuilder.RenameTable(
                name: "SkillCategory",
                newName: "SkillCategoryTable");

            migrationBuilder.AddColumn<string>(
                name: "CategoryID",
                table: "Skill",
                type: "varchar(255)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SkillCategoryTable",
                table: "SkillCategoryTable",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Skill_CategoryID",
                table: "Skill",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Skill_SkillCategoryTable_CategoryID",
                table: "Skill",
                column: "CategoryID",
                principalTable: "SkillCategoryTable",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
