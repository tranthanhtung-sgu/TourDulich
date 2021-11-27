using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tour>().HasData(
                new Tour
                {
                    TourId = 1,
                    TenGoi = "Du lịch Đà Lạt - QUÊ Garden - Đà Lạt View Coffee - Kim Ngân Hills Resort từ Sài Gòn 2021",
                    MoTa = "Du lịch Đà Lạt- Thiền Viện Trúc Lâm Quê Garden - Kim Ngân Hills Resort từ Sài Gòn 2021. Khi tham gia tour cùng Du Lịch Việtngoài việc thưởng lãm vẻ đẹp đặc sắc của các loài hoa, khung cảnh thơ mộng với khí trời se lạnh của vùng đất phố núi, Quý khách sẽ được cảm nhận Đà Lạt chính là địa điểm du lịch đi hoài không chán bởi những “tọa độ sống ảo đẹp không góc chết” mang những phong cách hoàn toàn riêng biệt. Nếu như Đà Lạt View Coffee nổi danh với hình ảnh “Cổng trời thứ 2” phá cách và độc đáo, thì Quê Garden cũng đang làm mưa làm gió trên các trang mạng xã hội, là một khu vườn với lối kiến trúc Nhật Bản nằm giữa cao nguyên Lâm Viên. Cuối cùng là ngôi làng cổ kính Châu Âu - Kim Ngân Hills với cả bầu trời thú cưng hiền lành cùng khu ẩm thực đặc biệt mang dấu.",
                    CategoryId = 1
                }     
            );
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    CategoryName = "Du lịch biển"
                },
                new Category
                {
                    Id = 2,
                    CategoryName = "Du lịch quê"
                },
                new Category
                {
                    Id = 3,
                    CategoryName = "Du lịch dã ngoại"
                },
                new Category
                {
                    Id = 4,
                    CategoryName = "Du lịch ẩm thực"
                }
            );
            modelBuilder.Entity<Location>().HasData(
                new Location
                {
                    Id = 1,
                    LocationName = "Đà Lạt",
                },
                new Location
                {
                    Id = 2,
                    LocationName = "Hà Nội"
                },
                new Location
                {
                    Id = 3,
                    LocationName = "Hồ Chí Minh"
                },
                new Location
                {
                    Id = 4,
                    LocationName = "Phú Quốc"
                }
            );
            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    Id = 1,
                    FullName = "Trần Thanh Tùng",
                    Gender = 1,
                    Address = "HCM",
                    IdentityNumber = "0123456789",
                    Nation = "Việt Nam",
                    PhoneNumber = "0123456789",
                },
                new Customer
                {
                    Id = 2,
                    FullName = "Lê Hải Đăng",
                    Gender = 1,
                    Address = "HCM",
                    IdentityNumber = "0123456789",
                    Nation = "Việt Nam",
                    PhoneNumber = "0123456789",
                },
                new Customer
                {
                    Id = 3,
                    FullName = "Tô Trần Khánh Hoà",
                    Gender = 0,
                    Address = "HCM",
                    IdentityNumber = "0123456789",
                    Nation = "Việt Nam",
                    PhoneNumber = "0123456789",
                },
                new Customer
                {
                    Id = 4,
                    FullName = "Âu Đình Uy",
                    Gender = 1,
                    Address = "HCM",
                    IdentityNumber = "0123456789",
                    Nation = "Việt Nam",
                    PhoneNumber = "0123456789",
                }
            );
            modelBuilder.Entity<TouristGroup>().HasData(
                new TouristGroup
                {
                    Id = 1,
                    TourId = 1,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,
                    Revenue = 10000000,
                    Hotel = "Khách sạn",
                    Description = "Description"
                },
                new TouristGroup
                {
                    Id = 2,
                    TourId = 1,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,
                    Revenue = 10000000,
                    Hotel = "Khách sạn",
                    Description = "Description"

                },
                new TouristGroup
                {
                    Id = 3,
                    TourId = 1,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,
                    Revenue = 10000000,
                    Hotel = "Khách sạn",
                    Description = "Description"
                },
                new TouristGroup
                {
                    Id = 4,
                    TourId = 1,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,
                    Revenue = 10000000,
                    Hotel = "Khách sạn",
                    Description = "Description"
                }
            );
            modelBuilder.Entity<Staff>().HasData( 
                new Staff { 
                    Id = 1,
                    Name = "Nguyễn Văn A"
                },
                new Staff
                {
                    Id = 2,
                    Name = "Nguyễn Văn B"
                },
                new Staff
                {
                    Id = 3,
                    Name = "Nguyễn Văn C"
                },
                new Staff
                {
                    Id = 4,
                    Name = "Nguyễn Thị D"
                }
            );
        }
    }
}
