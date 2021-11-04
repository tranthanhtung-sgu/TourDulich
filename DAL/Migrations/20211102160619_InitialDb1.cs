using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class InitialDb1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tours_LoaiHinhDuLich_LoaiHinhDuLichId",
                table: "Tours");

            migrationBuilder.DeleteData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "LoaiHinhDuLichId",
                table: "Tours",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Tours_LoaiHinhDuLich_LoaiHinhDuLichId",
                table: "Tours",
                column: "LoaiHinhDuLichId",
                principalTable: "LoaiHinhDuLich",
                principalColumn: "LoaiHinhDuLichId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tours_LoaiHinhDuLich_LoaiHinhDuLichId",
                table: "Tours");

            migrationBuilder.AlterColumn<int>(
                name: "LoaiHinhDuLichId",
                table: "Tours",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Tours",
                columns: new[] { "TourId", "LoaiHinhDuLichId", "MoTa", "TenGoi" },
                values: new object[] { 1, null, "Du lịch Đà Lạt- Thiền Viện Trúc Lâm Quê Garden - Kim Ngân Hills Resort từ Sài Gòn 2021. Khi tham gia tour cùng Du Lịch Việtngoài việc thưởng lãm vẻ đẹp đặc sắc của các loài hoa, khung cảnh thơ mộng với khí trời se lạnh của vùng đất phố núi, Quý khách sẽ được cảm nhận Đà Lạt chính là địa điểm du lịch đi hoài không chán bởi những “tọa độ sống ảo đẹp không góc chết” mang những phong cách hoàn toàn riêng biệt. Nếu như Đà Lạt View Coffee nổi danh với hình ảnh “Cổng trời thứ 2” phá cách và độc đáo, thì Quê Garden cũng đang làm mưa làm gió trên các trang mạng xã hội, là một khu vườn với lối kiến trúc Nhật Bản nằm giữa cao nguyên Lâm Viên. Cuối cùng là ngôi làng cổ kính Châu Âu - Kim Ngân Hills với cả bầu trời thú cưng hiền lành cùng khu ẩm thực đặc biệt mang dấu.", "Du lịch Đà Lạt - QUÊ Garden - Đà Lạt View Coffee - Kim Ngân Hills Resort từ Sài Gòn 2021" });

            migrationBuilder.AddForeignKey(
                name: "FK_Tours_LoaiHinhDuLich_LoaiHinhDuLichId",
                table: "Tours",
                column: "LoaiHinhDuLichId",
                principalTable: "LoaiHinhDuLich",
                principalColumn: "LoaiHinhDuLichId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
