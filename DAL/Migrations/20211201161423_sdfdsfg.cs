using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class sdfdsfg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TouristGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2021, 12, 1, 22, 59, 32, 617, DateTimeKind.Local).AddTicks(9485), new DateTime(2021, 12, 1, 22, 59, 32, 617, DateTimeKind.Local).AddTicks(8712) });

            migrationBuilder.UpdateData(
                table: "TouristGroups",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2021, 12, 1, 22, 59, 32, 618, DateTimeKind.Local).AddTicks(2497), new DateTime(2021, 12, 1, 22, 59, 32, 618, DateTimeKind.Local).AddTicks(2494) });

            migrationBuilder.UpdateData(
                table: "TouristGroups",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2021, 12, 1, 22, 59, 32, 618, DateTimeKind.Local).AddTicks(2512), new DateTime(2021, 12, 1, 22, 59, 32, 618, DateTimeKind.Local).AddTicks(2509) });

            migrationBuilder.UpdateData(
                table: "TouristGroups",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2021, 12, 1, 22, 59, 32, 618, DateTimeKind.Local).AddTicks(2527), new DateTime(2021, 12, 1, 22, 59, 32, 618, DateTimeKind.Local).AddTicks(2523) });
        }
    }
}
