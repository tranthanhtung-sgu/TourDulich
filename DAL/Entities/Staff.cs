using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Staff
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<TouristGroup_Staff> TouristGroup_Staffs { get; set; }

    }
}
