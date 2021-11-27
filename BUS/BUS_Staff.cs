using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Staff : GenericRepository<Staff>
    {
        public BUS_Staff()
        {

        }

        //get all staff
        public List<Staff> GetAllStaff()
        {
            var staff = _context.Staffs
                .Include(s => s.TouristGroup_Staffs)
                .ToList();
            return staff;
        }
        
    }
}
