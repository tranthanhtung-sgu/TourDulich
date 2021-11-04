using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class ChiTietTour
    {
        [Key]
        public int Id { get; set; }
        public int MaTour { get; set; }
        public Tour Tour { get; set; }
        public int MaDiaDiem { get; set; }
        public DiaDiem DiaDiem { get; set; }
        [NotMapped]
        public List<string> ThuTu { get; set; }
    }
}
