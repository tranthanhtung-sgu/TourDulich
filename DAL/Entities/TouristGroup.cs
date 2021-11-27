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

        public DateTime StartDate { get; set; } = DateTime.Now;

        public DateTime EndDate { get; set; } = DateTime.Now;

        public float Revenue { get; set; }
        public string Hotel { get; set; }
        public string Description { get; set; }
        public ICollection<TouristGroup_Customer> TouristGroup_Customers { get; set; } = new List<TouristGroup_Customer>();
        public ICollection<TouristGroup_Staff> TouristGroup_Staffs { get; set; } = new List<TouristGroup_Staff>();
        public ICollection<Cost> Costs { get; set; } = new List<Cost>();
    }
}
