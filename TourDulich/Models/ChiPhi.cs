using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourDulich.Models
{
    class ChiPhi
    {
        public int MaChiPhi { get; set; }
        public int MaDoan { get; set; }
        public DoanDulich DoanDulich { get; set; }
        public float SoTien { get; set; }
        public int MaLoaiChiPhi { get; set; }
        public LoaiChiPhi LoaiChiPhi { get; set; }
    }
}
