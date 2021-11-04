﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class ChiPhi
    {
        [Key]
        public int MaChiPhi { get; set; }
        public int MaDoan { get; set; }
        public DoanDulich DoanDulich { get; set; }
        public float SoTien { get; set; }
        public int MaLoaiChiPhi { get; set; }
        public LoaiChiPhi LoaiChiPhi { get; set; }
    }
}
