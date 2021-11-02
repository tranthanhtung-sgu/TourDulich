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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int MaTour { get; set; }
        public Tour Tour { get; set; }
        public int MaDiaDiem { get; set; }
        public DiaDiem DiaDiem { get; set; }
        public ICollection<string> ThuTu { get; set; }
    }
}
