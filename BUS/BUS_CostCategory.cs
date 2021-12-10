using DAL;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_CostCategory : GenericRepository<CostCategory>
    {
        public Context Context { get; set; }
        public BUS_CostCategory()
        {
            Context = _context;
        }
    }
}
