using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlexibleAutomationTool.DL.Migrations
{
    public partial class addRuleHistory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RuleHistoryId",
                table: "Rules",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "History",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateExecution = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Executed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_History", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rules_RuleHistoryId",
                table: "Rules",
                column: "RuleHistoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rules_History_RuleHistoryId",
                table: "Rules",
                column: "RuleHistoryId",
                principalTable: "History",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rules_History_RuleHistoryId",
                table: "Rules");

            migrationBuilder.DropTable(
                name: "History");

            migrationBuilder.DropIndex(
                name: "IX_Rules_RuleHistoryId",
                table: "Rules");

            migrationBuilder.DropColumn(
                name: "RuleHistoryId",
                table: "Rules");
        }
    }
}
