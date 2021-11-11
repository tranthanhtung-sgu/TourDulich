using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Dtos
{
    public class DTO_Price
    {
        [DisplayName("Giá tour")]
        [DisplayFormat(DataFormatString = "{0:C0}")]
        public float Money { get; set; }

        [DisplayName("Bắt đầu")]
        public DateTime StartDate { get; set; }

        [DisplayName("Kết thúc")]
        public DateTime EndDate { get; set; }
    }
}
