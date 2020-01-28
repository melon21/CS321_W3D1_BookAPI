using Microsoft.EntityFrameworkCore.Migrations;

namespace CS321_W3D1_BookAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(nullable: false),
                    Author = table.Column<string>(nullable: false),
                    Catigory = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "id", "Author", "Catigory", "Title" },
                values: new object[] { 1, "j.R.R. Tolkin", "Fantacy", "Lord of The Rings" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "id", "Author", "Catigory", "Title" },
                values: new object[] { 2, "j.K. Rowling", "Fantacy", "Harry Potter" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
