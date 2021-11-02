using AutoMapper;
using BUS.Dtos;
using BUS.Maps;
using DAL;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Tour : GenericRepository<Tour>, IGenericRepository<Tour>
    {
        public BUS_Tour()
        {
            
        }

        public new List<DTO_Tour> GetAll()
        {
            List<Tour> tours = table.ToList();
            List<DTO_Tour> result = mapper.Map<List<Tour>, List<DTO_Tour>>(tours);
            return result;
        }
    }
}
