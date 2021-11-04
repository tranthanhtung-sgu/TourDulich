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
                    LoaiHinhDuLichId = 1
                }     
            );
            modelBuilder.Entity<LoaiHinhDuLich>().HasData(
                new LoaiHinhDuLich
                {
                    LoaiHinhDuLichId = 1,
                    TenLoaiHinh = "Du lịch biển"
                },
                new LoaiHinhDuLich
                {
                    LoaiHinhDuLichId = 2,
                    TenLoaiHinh = "Du lịch quê"
                },
                new LoaiHinhDuLich
                {
                    LoaiHinhDuLichId = 3,
                    TenLoaiHinh = "Du lịch dã ngoại"
                },
                new LoaiHinhDuLich
                {
                    LoaiHinhDuLichId = 4,
                    TenLoaiHinh = "Du lịch ẩm thực"
                }
            );
        }
    }
}
