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
        [Display(Name = "Tên tour")]
        public string TenGoi { get; set; }
        [Display(Name = "Mô tả")]
        public string MoTa { get; set; }
        public int CategoryId { get; set; }
        [Display(Name = "Loại hình du lịch")]
        public Category Category { get; set; }
        public ICollection<TouristGroup> DSDoanDulich { get; set; } = new List<TouristGroup>();
        public ICollection<Price> Prices { get; set; } = new List<Price>();
        public IList<TourDetail> TourDetails { get; set; } = new List<TourDetail>();
    }
}
