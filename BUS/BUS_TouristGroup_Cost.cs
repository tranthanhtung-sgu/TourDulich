using DAL;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_TouristGroup_Cost : GenericRepository<TouristGroup_Cost> 
    {
        public Context context;
        public BUS_TouristGroup_Cost()
        {
            context = _context;
        }
    }
}