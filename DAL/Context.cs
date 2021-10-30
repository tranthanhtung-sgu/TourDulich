using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL
{
    public class Context : DbContext
    {
        public static string DataSource = "Tungpc\\DATABASETUNG";
        public static string con = "Data Source="+ DataSource + ";Initial Catalog=tourdulich;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;";
        public Context() : base(con) { }
        public DbSet<Tour> Tours { get; set; }
        public DbSet<DoanDulich> DoanDuLich { get; set; }
        public DbSet<GiaTour> GiaTour { get; set; }
        public DbSet<LoaiHinhDuLich> LoaiHinhDuLich { get; set; }
        public DbSet<DiaDiem> DiaDiem { get; set; }
        public DbSet<ChiPhi> Chiphi { get; set; }
        public DbSet<ChiTietDoan> ChiTietDoan { get; set; }
        public DbSet<ChiTietTour> ChiTietTour { get; set; }
        public DbSet<Khach> Khach { get; set; }
        public DbSet<LoaiChiPhi> LoaiChiPhi { get; set; }
        public DbSet<NhanVien> NhanVien { get; set; }
        public DbSet<PhanBo_NhanVien_Doan> PhanBo_NhanVien_Doan { get; set; }

    }
}
