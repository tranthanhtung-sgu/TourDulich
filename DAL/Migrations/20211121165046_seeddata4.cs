using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class seeddata4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Nguyễn Văn A" },
                    { 2, "Nguyễn Văn B" },
                    { 3, "Nguyễn Văn C" },
                    { 4, "Nguyễn Thị D" }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "TouristGroups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2021, 11, 20, 22, 10, 56, 29, DateTimeKind.Local).AddTicks(2622), new DateTime(2021, 11, 20, 22, 10, 56, 27, DateTimeKind.Local).AddTicks(7036) });

            migrationBuilder.UpdateData(
                table: "TouristGroups",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2021, 11, 20, 22, 10, 56, 29, DateTimeKind.Local).AddTicks(4731), new DateTime(2021, 11, 20, 22, 10, 56, 29, DateTimeKind.Local).AddTicks(4718) });

            migrationBuilder.UpdateData(
                table: "TouristGroups",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2021, 11, 20, 22, 10, 56, 29, DateTimeKind.Local).AddTicks(4737), new DateTime(2021, 11, 20, 22, 10, 56, 29, DateTimeKind.Local).AddTicks(4735) });

            migrationBuilder.UpdateData(
                table: "TouristGroups",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2021, 11, 20, 22, 10, 56, 29, DateTimeKind.Local).AddTicks(4742), new DateTime(2021, 11, 20, 22, 10, 56, 29, DateTimeKind.Local).AddTicks(4741) });
        }
    }
}
