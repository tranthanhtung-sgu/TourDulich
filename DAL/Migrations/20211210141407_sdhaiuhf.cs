using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class sdhaiuhf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Costs");

            migrationBuilder.CreateTable(
                name: "TouristGroup_Costs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TouristGroupId = table.Column<int>(type: "int", nullable: false),
                    Money = table.Column<float>(type: "real", nullable: false),
                    CostCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TouristGroup_Costs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TouristGroup_Costs_CostCategories_CostCategoryId",
                        column: x => x.CostCategoryId,
                        principalTable: "CostCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TouristGroup_Costs_TouristGroups_TouristGroupId",
                        column: x => x.TouristGroupId,
                        principalTable: "TouristGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CostCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Ăn uống" },
                    { 2, "Khách sạn" },
                    { 3, "Đi lại" },
                    { 4, "Phát sinh" }
                });

            migrationBuilder.UpdateData(
                table: "TouristGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2021, 12, 10, 21, 14, 5, 480, DateTimeKind.Local).AddTicks(5706), new DateTime(2021, 12, 10, 21, 14, 5, 480, DateTimeKind.Local).AddTicks(4984) });

            migrationBuilder.UpdateData(
                table: "TouristGroups",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2021, 12, 10, 21, 14, 5, 480, DateTimeKind.Local).AddTicks(8356), new DateTime(2021, 12, 10, 21, 14, 5, 480, DateTimeKind.Local).AddTicks(8353) });

            migrationBuilder.UpdateData(
                table: "TouristGroups",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2021, 12, 10, 21, 14, 5, 480, DateTimeKind.Local).AddTicks(8370), new DateTime(2021, 12, 10, 21, 14, 5, 480, DateTimeKind.Local).AddTicks(8368) });

            migrationBuilder.UpdateData(
                table: "TouristGroups",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2021, 12, 10, 21, 14, 5, 480, DateTimeKind.Local).AddTicks(8381), new DateTime(2021, 12, 10, 21, 14, 5, 480, DateTimeKind.Local).AddTicks(8379) });

            migrationBuilder.CreateIndex(
                name: "IX_TouristGroup_Costs_CostCategoryId",
                table: "TouristGroup_Costs",
                column: "CostCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_TouristGroup_Costs_TouristGroupId",
                table: "TouristGroup_Costs",
                column: "TouristGroupId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TouristGroup_Costs");

            migrationBuilder.DeleteData(
                table: "CostCategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CostCategories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CostCategories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CostCategories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.CreateTable(
                name: "Costs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CostCategoryId = table.Column<int>(type: "int", nullable: false),
                    Money = table.Column<float>(type: "real", nullable: false),
                    TouristGroupId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Costs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Costs_CostCategories_CostCategoryId",
                        column: x => x.CostCategoryId,
                        principalTable: "CostCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Costs_TouristGroups_TouristGroupId",
                        column: x => x.TouristGroupId,
                        principalTable: "TouristGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "TouristGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2021, 12, 1, 23, 14, 21, 821, DateTimeKind.Local).AddTicks(7787), new DateTime(2021, 12, 1, 23, 14, 21, 821, DateTimeKind.Local).AddTicks(7023) });

            migrationBuilder.UpdateData(
                table: "TouristGroups",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2021, 12, 1, 23, 14, 21, 822, DateTimeKind.Local).AddTicks(3830), new DateTime(2021, 12, 1, 23, 14, 21, 822, DateTimeKind.Local).AddTicks(3828) });

            migrationBuilder.UpdateData(
                table: "TouristGroups",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2021, 12, 1, 23, 14, 21, 822, DateTimeKind.Local).AddTicks(3843), new DateTime(2021, 12, 1, 23, 14, 21, 822, DateTimeKind.Local).AddTicks(3841) });

            migrationBuilder.UpdateData(
                table: "TouristGroups",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2021, 12, 1, 23, 14, 21, 822, DateTimeKind.Local).AddTicks(3853), new DateTime(2021, 12, 1, 23, 14, 21, 822, DateTimeKind.Local).AddTicks(3851) });

            migrationBuilder.CreateIndex(
                name: "IX_Costs_CostCategoryId",
                table: "Costs",
                column: "CostCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Costs_TouristGroupId",
                table: "Costs",
                column: "TouristGroupId");
        }
    }
}
