using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourDulich.Models;

namespace TourDulich.Persistences
{
    class Context : DbContext
    {
        public Context() : base("name=con") { }
        public DbSet<Models.Tour> Tours { get; set; }
        public DbSet<DoanDulich> DoanDuLich { get; set; }
        public DbSet<GiaTour> GiaTour { get; set; }
        public DbSet<LoaiHinhDuLich> LoaiHinhDuLich { get; set; }
        public DbSet<DiaDiem> DiaDiem { get; set; }
    }
}
