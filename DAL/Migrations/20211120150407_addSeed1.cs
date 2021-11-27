using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class addSeed1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Desciption",
                table: "TouristGroups",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Hotel",
                table: "TouristGroups",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "TouristGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2021, 11, 20, 22, 4, 6, 748, DateTimeKind.Local).AddTicks(4766), new DateTime(2021, 11, 20, 22, 4, 6, 746, DateTimeKind.Local).AddTicks(1508) });

            migrationBuilder.UpdateData(
                table: "TouristGroups",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2021, 11, 20, 22, 4, 6, 748, DateTimeKind.Local).AddTicks(6345), new DateTime(2021, 11, 20, 22, 4, 6, 748, DateTimeKind.Local).AddTicks(6332) });

            migrationBuilder.UpdateData(
                table: "TouristGroups",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2021, 11, 20, 22, 4, 6, 748, DateTimeKind.Local).AddTicks(6353), new DateTime(2021, 11, 20, 22, 4, 6, 748, DateTimeKind.Local).AddTicks(6351) });

            migrationBuilder.UpdateData(
                table: "TouristGroups",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2021, 11, 20, 22, 4, 6, 748, DateTimeKind.Local).AddTicks(6361), new DateTime(2021, 11, 20, 22, 4, 6, 748, DateTimeKind.Local).AddTicks(6358) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Desciption",
                table: "TouristGroups");

            migrationBuilder.DropColumn(
                name: "Hotel",
                table: "TouristGroups");

            migrationBuilder.UpdateData(
                table: "TouristGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2021, 11, 20, 14, 1, 20, 642, DateTimeKind.Local).AddTicks(2925), new DateTime(2021, 11, 20, 14, 1, 20, 640, DateTimeKind.Local).AddTicks(8634) });

            migrationBuilder.UpdateData(
                table: "TouristGroups",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2021, 11, 20, 14, 1, 20, 642, DateTimeKind.Local).AddTicks(4004), new DateTime(2021, 11, 20, 14, 1, 20, 642, DateTimeKind.Local).AddTicks(3996) });

            migrationBuilder.UpdateData(
                table: "TouristGroups",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2021, 11, 20, 14, 1, 20, 642, DateTimeKind.Local).AddTicks(4009), new DateTime(2021, 11, 20, 14, 1, 20, 642, DateTimeKind.Local).AddTicks(4008) });

            migrationBuilder.UpdateData(
                table: "TouristGroups",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2021, 11, 20, 14, 1, 20, 642, DateTimeKind.Local).AddTicks(4014), new DateTime(2021, 11, 20, 14, 1, 20, 642, DateTimeKind.Local).AddTicks(4012) });
        }
    }
}
