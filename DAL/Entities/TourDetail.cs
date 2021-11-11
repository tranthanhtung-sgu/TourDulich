using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class TourDetail
    {
        [Key]
        public int Id { get; set; }
        public int TourId { get; set; }
        public Tour Tour { get; set; }
        public int LocationId { get; set; }
        public Location Location { get; set; }
        public int Serial { get; set; }
    }
}
