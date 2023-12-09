using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Puscas_Andrei_Ioan_Laborator2.Migrations
{
    public partial class PublisherAdress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PublisherAdress",
                table: "Publisher",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PublisherAdress",
                table: "Publisher");
        }
    }
}
