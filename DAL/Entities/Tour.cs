using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Tour
    {
        public int TourId { get; set; }
        public string TenGoi { get; set; }
        public string MoTa { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<DoanDulich> DSDoanDulich { get; set; }
        public ICollection<Price> Prices { get; set; }
        public ICollection<TourDetail> TourDetails { get; set; }
    }
}
