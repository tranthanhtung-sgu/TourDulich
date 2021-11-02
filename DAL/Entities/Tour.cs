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
    public class Tour
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaTour { get; set; }

        [DisplayName("Tên tour du lịch")]
        public string TenGoi { get; set; }

        [DisplayName("Mô tả chuyến đi")]
        public string MoTa { get; set; }

        [DisplayName("Loại hình du lịch")]
        public int MaLoaiHinh { get; set; }

        public LoaiHinhDuLich loaiHinhDuLich { get; set; }

        public ICollection<DoanDulich> DSDoanDulich { get; set; }

        [DisplayName("Giá tour hiện hành")]
        public ICollection<GiaTour> DSGiaTour { get; set; }

        public ICollection<ChiTietTour> DSChiTietTour { get; set; }
    }
}
