using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Magazin.Migrations
{
    public partial class db21 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SezonID",
                table: "Produs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Sezon",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeSezon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SezonID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sezon", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Sezon_Sezon_SezonID",
                        column: x => x.SezonID,
                        principalTable: "Sezon",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Produs_SezonID",
                table: "Produs",
                column: "SezonID");

            migrationBuilder.CreateIndex(
                name: "IX_Sezon_SezonID",
                table: "Sezon",
                column: "SezonID");

            migrationBuilder.AddForeignKey(
                name: "FK_Produs_Sezon_SezonID",
                table: "Produs",
                column: "SezonID",
                principalTable: "Sezon",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produs_Sezon_SezonID",
                table: "Produs");

            migrationBuilder.DropTable(
                name: "Sezon");

            migrationBuilder.DropIndex(
                name: "IX_Produs_SezonID",
                table: "Produs");

            migrationBuilder.DropColumn(
                name: "SezonID",
                table: "Produs");
        }
    }
}
