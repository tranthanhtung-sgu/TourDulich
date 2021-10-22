using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourDulich.Models
{
    class ChiTietDoan
    {
        [Key]
        public int Id { get; set; }
        public int MaDoan { get; set; }
        public DoanDulich DoanDulich { get; set; }
        public int MaKhachHang { get; set; }
        public Khach Khach { get; set; }
    }
}
