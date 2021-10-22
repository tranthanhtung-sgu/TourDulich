using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourDulich.Models
{
    class Khach
    {
        public int MaKhachHang { get; set; }
        public string HoTen { get; set; }
        public string SoCMND { get; set; }
        public string DiaChi { get; set; }
        public int GioiTinh { get; set; }
        public string SDT { get; set; }
        public string QuocTich { get; set; }
        public ICollection<ChiTietDoan> DSChiTietDoan { get; set; }

    }
}
