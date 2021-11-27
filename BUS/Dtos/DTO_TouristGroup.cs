using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Dtos
{
    public class DTO_TouristGroup
    {
        [DisplayName("Mã đoàn")]
        public int Id { get; set; }
        [DisplayName("Tên đoàn")]
        public string Name { get; set; }
        [DisplayName("Ngày đi")]
        public DateTime StartDate { get; set; }
        [DisplayName("Ngày về")]
        public DateTime EndDate { get; set; }
        [DisplayName("Doanh thu")]
        public float Revenue { get; set; }
        [DisplayName("Người hướng dẫn")]
        public string TourGuide { get; set; }
        [DisplayName("Số lượng")]
        public int NumberOfTourist { get; set; }
        [DisplayName("Khách sạn")]
        public string Hotel { get; set; }
        [DisplayName("Ghi chú")]
        public string Description { get; set; }
    }
}
