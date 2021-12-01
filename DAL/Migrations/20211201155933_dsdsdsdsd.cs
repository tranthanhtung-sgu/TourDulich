using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class dsdsdsdsd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TouristGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2021, 11, 21, 23, 50, 45, 928, DateTimeKind.Local).AddTicks(1883), new DateTime(2021, 11, 21, 23, 50, 45, 926, DateTimeKind.Local).AddTicks(9683) });

            migrationBuilder.UpdateData(
                table: "TouristGroups",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2021, 11, 21, 23, 50, 45, 928, DateTimeKind.Local).AddTicks(3531), new DateTime(2021, 11, 21, 23, 50, 45, 928, DateTimeKind.Local).AddTicks(3522) });

            migrationBuilder.UpdateData(
                table: "TouristGroups",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2021, 11, 21, 23, 50, 45, 928, DateTimeKind.Local).AddTicks(3536), new DateTime(2021, 11, 21, 23, 50, 45, 928, DateTimeKind.Local).AddTicks(3534) });

            migrationBuilder.UpdateData(
                table: "TouristGroups",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2021, 11, 21, 23, 50, 45, 928, DateTimeKind.Local).AddTicks(3540), new DateTime(2021, 11, 21, 23, 50, 45, 928, DateTimeKind.Local).AddTicks(3539) });
        }
    }
}
