using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourDulich.Models
{
    class GiaTour
    {
        [Key]
        public int MaGia { get; set; }

        public Tour Tour { get; set; }

        public int MaTour { get; set; }

        public float ThanhTien { get; set; }

        public DateTime ThoiGianBatDau { get; set; }

        public DateTime ThoiGianKetThuc { get; set; }
    }
}
