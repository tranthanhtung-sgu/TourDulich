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
    public class DTO_Tour
    {
        [DisplayName("Mã Tour")]
        public int TourId { get; set; }

        [DisplayName("Tên tour du lịch")]
        public string TenGoi { get; set; }

        [DisplayName("Mô tả chuyến đi")]
        public string MoTa { get; set; }

        [DisplayName("Loại hình du lịch")]
        public string LoaiHinhDuLich { get; set; }

        [DisplayName("Giá tour hiện hành")]
        public string GiaTour { get; set; }
    }
}
