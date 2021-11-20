using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string IdentityNumber { get; set; }
        public string Address { get; set; }
        public int Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Nation { get; set; }
        public ICollection<TouristGroup_Customer> TouristGroup_Customers { get; set; }

    }
}
