using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class Context : DbContext
    {
        public static string DataSource = "DESKTOP-910QFGL\\MAYCHU";
        public static string con = "Data Source="+ DataSource + ";Initial Catalog=tourdulich;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;";

        public Context()
        {

        }
        
        public Context(DbContextOptions<Context> options) 
            : base() 
        {
        }

        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(con);
            }   
            optionsBuilder.EnableSensitiveDataLogging();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }

        public DbSet<Tour> Tours { get; set; }
        public DbSet<TouristGroup> TouristGroups { get; set; }
        public DbSet<Price> Prices { get; set; }
        public DbSet<Category> Cateogries { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<TouristGroup_Cost> TouristGroup_Costs { get; set; }
        public DbSet<TouristGroup_Customer> TouristGroup_Customers { get; set; }
        public DbSet<TourDetail> TourDetails { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CostCategory> CostCategories { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<TouristGroup_Staff> TouristGroup_Staffs { get; set; }


    }
}
