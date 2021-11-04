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
        [DisplayName("Tên tour du lịch")]
        public string TenGoi { get; set; }

        [DisplayName("Mô tả chuyến đi")]
        public string MoTa { get; set; }

        [DisplayName("Loại hình du lịch")]
        public string LoaiHinhDuLich { get; set; }

        [DisplayName("Giá tour hiện hành")]
        [DisplayFormat(DataFormatString = "{0:C0}")]
        public float GiaTour { get; set; }

        public static implicit operator DataRow(DTO_Tour v)
        {
            throw new NotImplementedException();
        }
    }
}
