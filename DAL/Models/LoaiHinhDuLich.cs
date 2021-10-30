using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class LoaiHinhDuLich
    {
        [Key]
        public int MaLoaiHinh { get; set; }
        public int TenLoaiHinh { get; set; }
        public ICollection<Tour> Tours { get; set; }
    }
}
