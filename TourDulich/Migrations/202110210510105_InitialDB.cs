namespace TourDulich.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DiaDiems",
                c => new
                    {
                        MaDiaDiem = c.Int(nullable: false, identity: true),
                        TenDiaDiem = c.String(),
                    })
                .PrimaryKey(t => t.MaDiaDiem);
            
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
                "dbo.LoaiHinhDuLiches",
                c => new
                    {
                        MaLoaiHinh = c.Int(nullable: false, identity: true),
                        TenLoaiHinh = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaLoaiHinh);
            
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.GiaTours", "MaTour", "dbo.Tours");
            DropForeignKey("dbo.DoanDuliches", "MaTour", "dbo.Tours");
            DropForeignKey("dbo.Tours", "MaLoaiHinh", "dbo.LoaiHinhDuLiches");
            DropIndex("dbo.GiaTours", new[] { "MaTour" });
            DropIndex("dbo.Tours", new[] { "MaLoaiHinh" });
            DropIndex("dbo.DoanDuliches", new[] { "MaTour" });
            DropTable("dbo.GiaTours");
            DropTable("dbo.LoaiHinhDuLiches");
            DropTable("dbo.Tours");
            DropTable("dbo.DoanDuliches");
            DropTable("dbo.DiaDiems");
        }
    }
}
