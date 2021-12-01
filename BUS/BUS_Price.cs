using DAL;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Price : GenericRepository<Price>
    {
        public Context context;
        public BUS_Price() 
        {
            context = _context;
        }

        public async Task<Price> FindAsync(int? id)
        {
            return await _context.Prices
                    .Include(p => p.Tour)
                    .FirstOrDefaultAsync(m => m.Id == id);
        }

        public Price UpdatePrice(Price price)
        {
            Delete(price.Id);
            Insert(price);
            return price;
        }
    }
}