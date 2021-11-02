namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateProperty : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.LoaiHinhDuLiches", "TenLoaiHinh", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.LoaiHinhDuLiches", "TenLoaiHinh", c => c.Int(nullable: false));
        }
    }
}
