using Microsoft.EntityFrameworkCore.Migrations;

namespace Metas2020.Migrations
{
    public partial class MetaMotivacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "motivacao",
                table: "Meta",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "motivacao",
                table: "Meta");
        }
    }
}
