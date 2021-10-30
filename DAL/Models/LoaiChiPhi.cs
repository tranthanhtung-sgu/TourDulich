using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class LoaiChiPhi
    {
        [Key]
        public int MaLoaiChiPhi { get; set; }
        public string TenLoaiChiPhi { get; set; }
        public ICollection<ChiPhi> DSChiPhi { get; set; }

    }
}
