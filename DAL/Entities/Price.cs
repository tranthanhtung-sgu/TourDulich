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
    public class Price
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public Tour Tour { get; set; }

        [DisplayName("Tên tour du lịch")]
        public int TourId { get; set; }

        [DisplayName("Giá tour")]
        public float Money { get; set; }

        [DisplayName("Ngày bắt đầu")]
        public DateTime StartDate { get; set; }

        [DisplayName("Ngày kết thúc")]
        public DateTime EndDate { get; set; }
    }
}
