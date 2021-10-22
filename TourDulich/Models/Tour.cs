using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourDulich.Models
{
    class Tour
    {
        [Key]
        public int MaTour { get; set; }

        public string TenGoi { get; set; }

        public string MoTa { get; set; }

        public LoaiHinhDuLich loaiHinhDuLich { get; set; }

        public int MaLoaiHinh { get; set; }
        public ICollection<DoanDulich> DSDoanDulich { get; set; }
        public ICollection<GiaTour> DSGiaTour { get; set; }
        public ICollection<ChiTietTour> DSChiTietTour { get; set; }
    }
}
