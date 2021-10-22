using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourDulich.Models
{
    class ChiTietTour
    {
        public int MaTour { get; set; }
        public Tour Tour { get; set; }
        public int MaDiaDiem { get; set; }
        public DiaDiem DiaDiem { get; set; }
        public ICollection<string> ThuTu { get; set; }
    }
}
