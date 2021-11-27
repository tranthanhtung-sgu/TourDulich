using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class addSeed2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Desciption",
                table: "TouristGroups",
                newName: "Description");

            migrationBuilder.UpdateData(
                table: "TouristGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "EndDate", "Hotel", "StartDate" },
                values: new object[] { "Description", new DateTime(2021, 11, 20, 22, 10, 56, 29, DateTimeKind.Local).AddTicks(2622), "Khách sạn", new DateTime(2021, 11, 20, 22, 10, 56, 27, DateTimeKind.Local).AddTicks(7036) });

            migrationBuilder.UpdateData(
                table: "TouristGroups",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "EndDate", "Hotel", "StartDate" },
                values: new object[] { "Description", new DateTime(2021, 11, 20, 22, 10, 56, 29, DateTimeKind.Local).AddTicks(4731), "Khách sạn", new DateTime(2021, 11, 20, 22, 10, 56, 29, DateTimeKind.Local).AddTicks(4718) });

            migrationBuilder.UpdateData(
                table: "TouristGroups",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "EndDate", "Hotel", "StartDate" },
                values: new object[] { "Description", new DateTime(2021, 11, 20, 22, 10, 56, 29, DateTimeKind.Local).AddTicks(4737), "Khách sạn", new DateTime(2021, 11, 20, 22, 10, 56, 29, DateTimeKind.Local).AddTicks(4735) });

            migrationBuilder.UpdateData(
                table: "TouristGroups",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "EndDate", "Hotel", "StartDate" },
                values: new object[] { "Description", new DateTime(2021, 11, 20, 22, 10, 56, 29, DateTimeKind.Local).AddTicks(4742), "Khách sạn", new DateTime(2021, 11, 20, 22, 10, 56, 29, DateTimeKind.Local).AddTicks(4741) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "TouristGroups",
                newName: "Desciption");

            migrationBuilder.UpdateData(
                table: "TouristGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Desciption", "EndDate", "Hotel", "StartDate" },
                values: new object[] { null, new DateTime(2021, 11, 20, 22, 4, 6, 748, DateTimeKind.Local).AddTicks(4766), null, new DateTime(2021, 11, 20, 22, 4, 6, 746, DateTimeKind.Local).AddTicks(1508) });

            migrationBuilder.UpdateData(
                table: "TouristGroups",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Desciption", "EndDate", "Hotel", "StartDate" },
                values: new object[] { null, new DateTime(2021, 11, 20, 22, 4, 6, 748, DateTimeKind.Local).AddTicks(6345), null, new DateTime(2021, 11, 20, 22, 4, 6, 748, DateTimeKind.Local).AddTicks(6332) });

            migrationBuilder.UpdateData(
                table: "TouristGroups",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Desciption", "EndDate", "Hotel", "StartDate" },
                values: new object[] { null, new DateTime(2021, 11, 20, 22, 4, 6, 748, DateTimeKind.Local).AddTicks(6353), null, new DateTime(2021, 11, 20, 22, 4, 6, 748, DateTimeKind.Local).AddTicks(6351) });

            migrationBuilder.UpdateData(
                table: "TouristGroups",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Desciption", "EndDate", "Hotel", "StartDate" },
                values: new object[] { null, new DateTime(2021, 11, 20, 22, 4, 6, 748, DateTimeKind.Local).AddTicks(6361), null, new DateTime(2021, 11, 20, 22, 4, 6, 748, DateTimeKind.Local).AddTicks(6358) });
        }
    }
}
