using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TourDAL
    {
        Context _dbContext;
        public TourDAL(Context dbContext)
        {
            _dbContext = dbContext;
        }
        public List<Tour> GetAll()
        {
            return _dbContext.Tours.ToList();
        }
    }
}
