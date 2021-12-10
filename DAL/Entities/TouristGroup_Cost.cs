using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class TouristGroup_Cost
    {
        public int Id { get; set; }
        public int TouristGroupId { get; set; }
        public TouristGroup TouristGroup { get; set; }
        public float Money { get; set; }
        public int CostCategoryId { get; set; }
        public CostCategory CostCategory { get; set; }
    }
}
