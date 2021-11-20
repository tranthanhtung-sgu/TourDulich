using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class TouristGroup
    {
        public int Id { get; set; }

        public Tour Tour { get; set; }

        public int TourId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public float Revenue { get; set; }
        public ICollection<TouristGroup_Customer> TouristGroup_Customers { get; set; }
        public ICollection<TouristGroup_Staff> TouristGroup_Staffs { get; set; }
        public ICollection<Cost> Costs { get; set; }
    }
}
