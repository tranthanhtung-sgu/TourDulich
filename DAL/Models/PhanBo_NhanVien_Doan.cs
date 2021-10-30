using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class PhanBo_NhanVien_Doan
    {
        [Key]
        public int Id { get; set; }
        public int MaNhanVien { get; set; }
        public NhanVien NhanVien { get; set; }
        public int MaDoan { get; set; }
        public DoanDulich DoanDulich { get; set; }
        public String NhiemVu { get; set; }
    }
}
