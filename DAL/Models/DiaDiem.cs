using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class DiaDiem
    {
        [Key]
        public int MaDiaDiem { get; set; }
        public string TenDiaDiem { get; set; }
        public ICollection<ChiTietTour> DSChiTietTour { get; set; }
    }
}
