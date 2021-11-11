using DAL;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Price : GenericRepository<Price>
    {
        public BUS_Price() 
        {
        }
    }
}