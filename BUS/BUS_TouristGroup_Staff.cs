using DAL;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_TouristGroup_Staff : GenericRepository<TouristGroup_Staff>
    {
        public Context context;
        public BUS_TouristGroup_Staff()
        {
            context = _context;
        }
    }
}
