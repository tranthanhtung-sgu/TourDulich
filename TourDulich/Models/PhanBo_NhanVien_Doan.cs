﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourDulich.Models
{
    class PhanBo_NhanVien_Doan
    {
        public int MaNhanVien { get; set; }
        public NhanVien NhanVien { get; set; }
        public int MaDoan { get; set; }
        public DoanDulich DoanDulich { get; set; }
        public String NhiemVu { get; set; }
    }
}
