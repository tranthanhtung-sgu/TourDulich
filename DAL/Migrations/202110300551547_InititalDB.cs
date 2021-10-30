namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InititalDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChiPhis",
                c => new
                    {
                        MaChiPhi = c.Int(nullable: false, identity: true),
                        MaDoan = c.Int(nullable: false),
                        SoTien = c.Single(nullable: false),
                        MaLoaiChiPhi = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaChiPhi)
                .ForeignKey("dbo.DoanDuliches", t => t.MaDoan, cascadeDelete: true)
                .ForeignKey("dbo.LoaiChiPhis", t => t.MaLoaiChiPhi, cascadeDelete: true)
                .Index(t => t.MaDoan)
                .Index(t => t.MaLoaiChiPhi);
            
            CreateTable(
                "dbo.DoanDuliches",
                c => new
                    {
                        MaDoan = c.Int(nullable: false, identity: true),
                        MaTour = c.Int(nullable: false),
                        NgayKhoiHanh = c.DateTime(nullable: false),
                        NgayKetThuc = c.DateTime(nullable: false),
                        DoanhThu = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.MaDoan)
                .ForeignKey("dbo.Tours", t => t.MaTour, cascadeDelete: true)
                .Index(t => t.MaTour);
            
            CreateTable(
                "dbo.ChiTietDoans",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MaDoan = c.Int(nullable: false),
                        MaKhachHang = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DoanDuliches", t => t.MaDoan, cascadeDelete: true)
                .ForeignKey("dbo.Khaches", t => t.MaKhachHang, cascadeDelete: true)
                .Index(t => t.MaDoan)
                .Index(t => t.MaKhachHang);
            
            CreateTable(
                "dbo.Khaches",
                c => new
                    {
                        MaKhachHang = c.Int(nullable: false, identity: true),
                        HoTen = c.String(),
                        SoCMND = c.String(),
                        DiaChi = c.String(),
                        GioiTinh = c.Int(nullable: false),
                        SDT = c.String(),
                        QuocTich = c.String(),
                    })
                .PrimaryKey(t => t.MaKhachHang);
            
            CreateTable(
                "dbo.PhanBo_NhanVien_Doan",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MaNhanVien = c.Int(nullable: false),
                        MaDoan = c.Int(nullable: false),
                        NhiemVu = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DoanDuliches", t => t.MaDoan, cascadeDelete: true)
                .ForeignKey("dbo.NhanViens", t => t.MaNhanVien, cascadeDelete: true)
                .Index(t => t.MaNhanVien)
                .Index(t => t.MaDoan);
            
            CreateTable(
                "dbo.NhanViens",
                c => new
                    {
                        MaNhanVien = c.Int(nullable: false, identity: true),
                        TenNhanVien = c.String(),
                    })
                .PrimaryKey(t => t.MaNhanVien);
            
            CreateTable(
                "dbo.Tours",
                c => new
                    {
                        MaTour = c.Int(nullable: false, identity: true),
                        TenGoi = c.String(),
                        MoTa = c.String(),
                        MaLoaiHinh = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaTour)
                .ForeignKey("dbo.LoaiHinhDuLiches", t => t.MaLoaiHinh, cascadeDelete: true)
                .Index(t => t.MaLoaiHinh);
            
            CreateTable(
                "dbo.ChiTietTours",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MaTour = c.Int(nullable: false),
                        MaDiaDiem = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DiaDiems", t => t.MaDiaDiem, cascadeDelete: true)
                .ForeignKey("dbo.Tours", t => t.MaTour, cascadeDelete: true)
                .Index(t => t.MaTour)
                .Index(t => t.MaDiaDiem);
            
            CreateTable(
                "dbo.DiaDiems",
                c => new
                    {
                        MaDiaDiem = c.Int(nullable: false, identity: true),
                        TenDiaDiem = c.String(),
                    })
                .PrimaryKey(t => t.MaDiaDiem);
            
            CreateTable(
                "dbo.GiaTours",
                c => new
                    {
                        MaGia = c.Int(nullable: false, identity: true),
                        MaTour = c.Int(nullable: false),
                        ThanhTien = c.Single(nullable: false),
                        ThoiGianBatDau = c.DateTime(nullable: false),
                        ThoiGianKetThuc = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.MaGia)
                .ForeignKey("dbo.Tours", t => t.MaTour, cascadeDelete: true)
                .Index(t => t.MaTour);
            
            CreateTable(
                "dbo.LoaiHinhDuLiches",
                c => new
                    {
                        MaLoaiHinh = c.Int(nullable: false, identity: true),
                        TenLoaiHinh = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaLoaiHinh);
            
            CreateTable(
                "dbo.LoaiChiPhis",
                c => new
                    {
                        MaLoaiChiPhi = c.Int(nullable: false, identity: true),
                        TenLoaiChiPhi = c.String(),
                    })
                .PrimaryKey(t => t.MaLoaiChiPhi);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ChiPhis", "MaLoaiChiPhi", "dbo.LoaiChiPhis");
            DropForeignKey("dbo.Tours", "MaLoaiHinh", "dbo.LoaiHinhDuLiches");
            DropForeignKey("dbo.GiaTours", "MaTour", "dbo.Tours");
            DropForeignKey("dbo.DoanDuliches", "MaTour", "dbo.Tours");
            DropForeignKey("dbo.ChiTietTours", "MaTour", "dbo.Tours");
            DropForeignKey("dbo.ChiTietTours", "MaDiaDiem", "dbo.DiaDiems");
            DropForeignKey("dbo.PhanBo_NhanVien_Doan", "MaNhanVien", "dbo.NhanViens");
            DropForeignKey("dbo.PhanBo_NhanVien_Doan", "MaDoan", "dbo.DoanDuliches");
            DropForeignKey("dbo.ChiTietDoans", "MaKhachHang", "dbo.Khaches");
            DropForeignKey("dbo.ChiTietDoans", "MaDoan", "dbo.DoanDuliches");
            DropForeignKey("dbo.ChiPhis", "MaDoan", "dbo.DoanDuliches");
            DropIndex("dbo.GiaTours", new[] { "MaTour" });
            DropIndex("dbo.ChiTietTours", new[] { "MaDiaDiem" });
            DropIndex("dbo.ChiTietTours", new[] { "MaTour" });
            DropIndex("dbo.Tours", new[] { "MaLoaiHinh" });
            DropIndex("dbo.PhanBo_NhanVien_Doan", new[] { "MaDoan" });
            DropIndex("dbo.PhanBo_NhanVien_Doan", new[] { "MaNhanVien" });
            DropIndex("dbo.ChiTietDoans", new[] { "MaKhachHang" });
            DropIndex("dbo.ChiTietDoans", new[] { "MaDoan" });
            DropIndex("dbo.DoanDuliches", new[] { "MaTour" });
            DropIndex("dbo.ChiPhis", new[] { "MaLoaiChiPhi" });
            DropIndex("dbo.ChiPhis", new[] { "MaDoan" });
            DropTable("dbo.LoaiChiPhis");
            DropTable("dbo.LoaiHinhDuLiches");
            DropTable("dbo.GiaTours");
            DropTable("dbo.DiaDiems");
            DropTable("dbo.ChiTietTours");
            DropTable("dbo.Tours");
            DropTable("dbo.NhanViens");
            DropTable("dbo.PhanBo_NhanVien_Doan");
            DropTable("dbo.Khaches");
            DropTable("dbo.ChiTietDoans");
            DropTable("dbo.DoanDuliches");
            DropTable("dbo.ChiPhis");
        }
    }
}
