using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourDulich.Models
{
    class DoanDulich
    {
        [Key]
        public int MaDoan { get; set; }

        public Tour Tour { get; set; }

        public int MaTour { get; set; }

        public DateTime NgayKhoiHanh { get; set; }

        public DateTime NgayKetThuc { get; set; }

        public float DoanhThu { get; set; }
        public ICollection<ChiTietDoan> DSChiTietDoans { get; set; }
        public ICollection<PhanBo_NhanVien_Doan> DSPhanBo { get; set; }
        public ICollection<ChiPhi> DSChiPhi { get; set; }
    }
}
