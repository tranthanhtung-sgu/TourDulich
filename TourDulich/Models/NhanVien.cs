using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourDulich.Models
{
    class NhanVien
    {
        [Key]
        public int MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public ICollection<PhanBo_NhanVien_Doan> DSPhanBo { get; set; }

    }
}
