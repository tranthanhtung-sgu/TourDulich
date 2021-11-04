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
        public int TourId { get; set; }
        public string TenGoi { get; set; }
        public string MoTa { get; set; }
        public int LoaiHinhDuLichId { get; set; }
        [ForeignKey("LoaiHinhDuLichId")]
        [Required]
        public LoaiHinhDuLich LoaiHinhDuLich { get; set; }
        public ICollection<DoanDulich> DSDoanDulich { get; set; }
        public ICollection<GiaTour> DSGiaTour { get; set; }
        public ICollection<ChiTietTour> DSChiTietTour { get; set; }
    }
}
