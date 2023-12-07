using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Puscas_Andrei_Ioan_Laborator2.Migrations
{
    public partial class Authors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AuthorsID",
                table: "Book",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Book_AuthorsID",
                table: "Book",
                column: "AuthorsID");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Authors_AuthorsID",
                table: "Book",
                column: "AuthorsID",
                principalTable: "Authors",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Authors_AuthorsID",
                table: "Book");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropIndex(
                name: "IX_Book_AuthorsID",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "AuthorsID",
                table: "Book");
        }
    }
}
