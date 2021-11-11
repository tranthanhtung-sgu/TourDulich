using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cateogries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cateogries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Khach",
                columns: table => new
                {
                    MaKhachHang = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoTen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoCMND = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GioiTinh = table.Column<int>(type: "int", nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuocTich = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Khach", x => x.MaKhachHang);
                });

            migrationBuilder.CreateTable(
                name: "LoaiChiPhi",
                columns: table => new
                {
                    MaLoaiChiPhi = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoaiChiPhi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiChiPhi", x => x.MaLoaiChiPhi);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    MaNhanVien = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenNhanVien = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.MaNhanVien);
                });

            migrationBuilder.CreateTable(
                name: "Tours",
                columns: table => new
                {
                    TourId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenGoi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CateogryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tours", x => x.TourId);
                    table.ForeignKey(
                        name: "FK_Tours_Cateogries_CateogryId",
                        column: x => x.CateogryId,
                        principalTable: "Cateogries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietTour",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TourId = table.Column<int>(type: "int", nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: false),
                    Serial = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietTour", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChiTietTour_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietTour_Tours_TourId",
                        column: x => x.TourId,
                        principalTable: "Tours",
                        principalColumn: "TourId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DoanDuLich",
                columns: table => new
                {
                    MaDoan = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TourId = table.Column<int>(type: "int", nullable: true),
                    MaTour = table.Column<int>(type: "int", nullable: false),
                    NgayKhoiHanh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayKetThuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DoanhThu = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoanDuLich", x => x.MaDoan);
                    table.ForeignKey(
                        name: "FK_DoanDuLich_Tours_TourId",
                        column: x => x.TourId,
                        principalTable: "Tours",
                        principalColumn: "TourId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GiaTour",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TourId = table.Column<int>(type: "int", nullable: false),
                    Money = table.Column<float>(type: "real", nullable: false),
                    StartDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiaTour", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GiaTour_Tours_TourId",
                        column: x => x.TourId,
                        principalTable: "Tours",
                        principalColumn: "TourId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Chiphi",
                columns: table => new
                {
                    MaChiPhi = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaDoan = table.Column<int>(type: "int", nullable: false),
                    DoanDulichMaDoan = table.Column<int>(type: "int", nullable: true),
                    SoTien = table.Column<float>(type: "real", nullable: false),
                    MaLoaiChiPhi = table.Column<int>(type: "int", nullable: false),
                    LoaiChiPhiMaLoaiChiPhi = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chiphi", x => x.MaChiPhi);
                    table.ForeignKey(
                        name: "FK_Chiphi_DoanDuLich_DoanDulichMaDoan",
                        column: x => x.DoanDulichMaDoan,
                        principalTable: "DoanDuLich",
                        principalColumn: "MaDoan",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Chiphi_LoaiChiPhi_LoaiChiPhiMaLoaiChiPhi",
                        column: x => x.LoaiChiPhiMaLoaiChiPhi,
                        principalTable: "LoaiChiPhi",
                        principalColumn: "MaLoaiChiPhi",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietDoan",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaDoan = table.Column<int>(type: "int", nullable: false),
                    DoanDulichMaDoan = table.Column<int>(type: "int", nullable: true),
                    MaKhachHang = table.Column<int>(type: "int", nullable: false),
                    KhachMaKhachHang = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietDoan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChiTietDoan_DoanDuLich_DoanDulichMaDoan",
                        column: x => x.DoanDulichMaDoan,
                        principalTable: "DoanDuLich",
                        principalColumn: "MaDoan",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChiTietDoan_Khach_KhachMaKhachHang",
                        column: x => x.KhachMaKhachHang,
                        principalTable: "Khach",
                        principalColumn: "MaKhachHang",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PhanBo_NhanVien_Doan",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaNhanVien = table.Column<int>(type: "int", nullable: false),
                    NhanVienMaNhanVien = table.Column<int>(type: "int", nullable: true),
                    MaDoan = table.Column<int>(type: "int", nullable: false),
                    DoanDulichMaDoan = table.Column<int>(type: "int", nullable: true),
                    NhiemVu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhanBo_NhanVien_Doan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhanBo_NhanVien_Doan_DoanDuLich_DoanDulichMaDoan",
                        column: x => x.DoanDulichMaDoan,
                        principalTable: "DoanDuLich",
                        principalColumn: "MaDoan",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PhanBo_NhanVien_Doan_NhanVien_NhanVienMaNhanVien",
                        column: x => x.NhanVienMaNhanVien,
                        principalTable: "NhanVien",
                        principalColumn: "MaNhanVien",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Cateogries",
                columns: new[] { "Id", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Du lịch biển" },
                    { 2, "Du lịch quê" },
                    { 3, "Du lịch dã ngoại" },
                    { 4, "Du lịch ẩm thực" }
                });

            migrationBuilder.InsertData(
                table: "Tours",
                columns: new[] { "TourId", "CategoryId", "CateogryId", "MoTa", "TenGoi" },
                values: new object[] { 1, 1, null, "Du lịch Đà Lạt- Thiền Viện Trúc Lâm Quê Garden - Kim Ngân Hills Resort từ Sài Gòn 2021. Khi tham gia tour cùng Du Lịch Việtngoài việc thưởng lãm vẻ đẹp đặc sắc của các loài hoa, khung cảnh thơ mộng với khí trời se lạnh của vùng đất phố núi, Quý khách sẽ được cảm nhận Đà Lạt chính là địa điểm du lịch đi hoài không chán bởi những “tọa độ sống ảo đẹp không góc chết” mang những phong cách hoàn toàn riêng biệt. Nếu như Đà Lạt View Coffee nổi danh với hình ảnh “Cổng trời thứ 2” phá cách và độc đáo, thì Quê Garden cũng đang làm mưa làm gió trên các trang mạng xã hội, là một khu vườn với lối kiến trúc Nhật Bản nằm giữa cao nguyên Lâm Viên. Cuối cùng là ngôi làng cổ kính Châu Âu - Kim Ngân Hills với cả bầu trời thú cưng hiền lành cùng khu ẩm thực đặc biệt mang dấu.", "Du lịch Đà Lạt - QUÊ Garden - Đà Lạt View Coffee - Kim Ngân Hills Resort từ Sài Gòn 2021" });

            migrationBuilder.CreateIndex(
                name: "IX_Chiphi_DoanDulichMaDoan",
                table: "Chiphi",
                column: "DoanDulichMaDoan");

            migrationBuilder.CreateIndex(
                name: "IX_Chiphi_LoaiChiPhiMaLoaiChiPhi",
                table: "Chiphi",
                column: "LoaiChiPhiMaLoaiChiPhi");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietDoan_DoanDulichMaDoan",
                table: "ChiTietDoan",
                column: "DoanDulichMaDoan");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietDoan_KhachMaKhachHang",
                table: "ChiTietDoan",
                column: "KhachMaKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietTour_LocationId",
                table: "ChiTietTour",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietTour_TourId",
                table: "ChiTietTour",
                column: "TourId");

            migrationBuilder.CreateIndex(
                name: "IX_DoanDuLich_TourId",
                table: "DoanDuLich",
                column: "TourId");

            migrationBuilder.CreateIndex(
                name: "IX_GiaTour_TourId",
                table: "GiaTour",
                column: "TourId");

            migrationBuilder.CreateIndex(
                name: "IX_PhanBo_NhanVien_Doan_DoanDulichMaDoan",
                table: "PhanBo_NhanVien_Doan",
                column: "DoanDulichMaDoan");

            migrationBuilder.CreateIndex(
                name: "IX_PhanBo_NhanVien_Doan_NhanVienMaNhanVien",
                table: "PhanBo_NhanVien_Doan",
                column: "NhanVienMaNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_Tours_CateogryId",
                table: "Tours",
                column: "CateogryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Chiphi");

            migrationBuilder.DropTable(
                name: "ChiTietDoan");

            migrationBuilder.DropTable(
                name: "ChiTietTour");

            migrationBuilder.DropTable(
                name: "GiaTour");

            migrationBuilder.DropTable(
                name: "PhanBo_NhanVien_Doan");

            migrationBuilder.DropTable(
                name: "LoaiChiPhi");

            migrationBuilder.DropTable(
                name: "Khach");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "DoanDuLich");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "Tours");

            migrationBuilder.DropTable(
                name: "Cateogries");
        }
    }
}
