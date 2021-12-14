using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEBSITE.Models
{
    public class ReportViewModel
    {
        public List<Tour> Tours { get; set; }
        public List<TouristGroup> TouristGroups { get; set; }
    }
}
