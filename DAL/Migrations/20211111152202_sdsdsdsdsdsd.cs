using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class sdsdsdsdsdsd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tours_Cateogries_CateogryId",
                table: "Tours");

            migrationBuilder.DropIndex(
                name: "IX_Tours_CateogryId",
                table: "Tours");

            migrationBuilder.DropColumn(
                name: "CateogryId",
                table: "Tours");

            migrationBuilder.CreateIndex(
                name: "IX_Tours_CategoryId",
                table: "Tours",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tours_Cateogries_CategoryId",
                table: "Tours",
                column: "CategoryId",
                principalTable: "Cateogries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tours_Cateogries_CategoryId",
                table: "Tours");

            migrationBuilder.DropIndex(
                name: "IX_Tours_CategoryId",
                table: "Tours");

            migrationBuilder.AddColumn<int>(
                name: "CateogryId",
                table: "Tours",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tours_CateogryId",
                table: "Tours",
                column: "CateogryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tours_Cateogries_CateogryId",
                table: "Tours",
                column: "CateogryId",
                principalTable: "Cateogries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
