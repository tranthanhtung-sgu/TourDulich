using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Dtos
{
    public class DTO_Customer
    {
        [DisplayName("Mã khách hàng")]
        public int Id { get; set; }

        [DisplayName("Tên khách hàng")]
        public string FullName { get; set; }

        [DisplayName("CCCD")]
        public string IdentityNumber { get; set; }

        [DisplayName("Địa chỉ")]
        public string Address { get; set; }

        [DisplayName("Giới tính")]
        public int Gender { get; set; }

        [DisplayName("Số điện thoại")]
        public string PhoneNumber { get; set; }

        [DisplayName("Quốc tịch")]
        public string Nation { get; set; }
    }
}
