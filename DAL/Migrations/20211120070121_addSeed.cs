using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class addSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "FullName", "Gender", "IdentityNumber", "Nation", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "HCM", "Trần Thanh Tùng", 1, "0123456789", "Việt Nam", "0123456789" },
                    { 2, "HCM", "Lê Hải Đăng", 1, "0123456789", "Việt Nam", "0123456789" },
                    { 3, "HCM", "Tô Trần Khánh Hoà", 0, "0123456789", "Việt Nam", "0123456789" },
                    { 4, "HCM", "Âu Đình Uy", 1, "0123456789", "Việt Nam", "0123456789" }
                });

            migrationBuilder.InsertData(
                table: "TouristGroups",
                columns: new[] { "Id", "EndDate", "Revenue", "StartDate", "TourId" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 11, 20, 14, 1, 20, 642, DateTimeKind.Local).AddTicks(2925), 10000000f, new DateTime(2021, 11, 20, 14, 1, 20, 640, DateTimeKind.Local).AddTicks(8634), 1 },
                    { 2, new DateTime(2021, 11, 20, 14, 1, 20, 642, DateTimeKind.Local).AddTicks(4004), 10000000f, new DateTime(2021, 11, 20, 14, 1, 20, 642, DateTimeKind.Local).AddTicks(3996), 1 },
                    { 3, new DateTime(2021, 11, 20, 14, 1, 20, 642, DateTimeKind.Local).AddTicks(4009), 10000000f, new DateTime(2021, 11, 20, 14, 1, 20, 642, DateTimeKind.Local).AddTicks(4008), 1 },
                    { 4, new DateTime(2021, 11, 20, 14, 1, 20, 642, DateTimeKind.Local).AddTicks(4014), 10000000f, new DateTime(2021, 11, 20, 14, 1, 20, 642, DateTimeKind.Local).AddTicks(4012), 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TouristGroups",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TouristGroups",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TouristGroups",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TouristGroups",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
