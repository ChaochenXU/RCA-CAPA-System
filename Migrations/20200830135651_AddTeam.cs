using Microsoft.EntityFrameworkCore.Migrations;

namespace RCAONE.Migrations
{
    public partial class AddTeam : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "memid5",
                table: "Team",
                maxLength: 6,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "memid5",
                table: "Team");
        }
    }
}
