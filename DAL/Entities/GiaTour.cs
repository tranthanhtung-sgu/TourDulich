using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class GiaTour
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaGia { get; set; }

        public Tour Tour { get; set; }

        [DisplayName("Tên tour du lịch")]
        public int MaTour { get; set; }

        [DisplayName("Giá tour")]
        public float ThanhTien { get; set; }

        [DisplayName("Ngày bắt đầu")]
        public DateTime ThoiGianBatDau { get; set; }

        [DisplayName("Ngày kết thúc")]
        public DateTime ThoiGianKetThuc { get; set; }
    }
}
