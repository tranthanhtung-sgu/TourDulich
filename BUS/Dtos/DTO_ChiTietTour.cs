using DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Dtos
{
    public class DTO_ChiTietTour
    {
        [DisplayName("Thứ tự")]
        public int Serial { get; set; }
        [DisplayName("Tên địa điểm")]
        public string LocationName { get; set; }
    }
}
