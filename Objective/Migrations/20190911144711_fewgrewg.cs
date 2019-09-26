using Microsoft.EntityFrameworkCore.Migrations;

namespace Objective.Migrations
{
    public partial class fewgrewg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_TaskTag_Id",
                table: "TaskTag");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "TaskTag");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "TaskTag",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_TaskTag_Id",
                table: "TaskTag",
                column: "Id");
        }
    }
}
