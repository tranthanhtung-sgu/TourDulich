using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourDulich.Models
{
    class NhanVien
    {
        public int MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public ICollection<PhanBo_NhanVien_Doan> DSPhanBo { get; set; }

    }
}
