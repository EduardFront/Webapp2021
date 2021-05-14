using Microsoft.EntityFrameworkCore.Migrations;

namespace Webapp2021.Migrations
{
    public partial class AddPeople : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CreatorId",
                table: "Phones",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sername = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Patronymic = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Phones_CreatorId",
                table: "Phones",
                column: "CreatorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Phones_People_CreatorId",
                table: "Phones",
                column: "CreatorId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Phones_People_CreatorId",
                table: "Phones");

            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropIndex(
                name: "IX_Phones_CreatorId",
                table: "Phones");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "Phones");
        }
    }
}
