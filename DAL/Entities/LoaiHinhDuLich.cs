using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class LoaiHinhDuLich
    {
        public int LoaiHinhDuLichId { get; set; }
        public string TenLoaiHinh { get; set; }
        public ICollection<Tour> Tours { get; set; } = new List<Tour>();
    }
}
