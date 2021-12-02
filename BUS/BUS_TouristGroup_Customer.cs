using DAL;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_TouristGroup_Customer : GenericRepository<TouristGroup_Customer> 
    {
        public Context context;
        public BUS_TouristGroup_Customer()
        {
            context = _context;
        }
    }
}
