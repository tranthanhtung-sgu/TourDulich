using AutoMapper;
using BUS.Dtos;
using BUS.Maps;
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
    public class BUS_Tour : GenericRepository<Tour>, IGenericRepository<Tour>
    {
        public BUS_Tour()
        {
            
        }

        public new List<DTO_Tour> GetAll()
        {
            List<Tour> tours = _context.Tours.Include(x=>x.LoaiHinhDuLich).ToList();
            List<DTO_Tour> result = mapper.Map<List<Tour>, List<DTO_Tour>>(tours);
            return result;
        }
        
        public bool Update (DTO_Tour tourDto)
        {
            var newTourUpdate = mapper.Map<DTO_Tour, Tour>(tourDto);
            var result = Update(newTourUpdate);
            return result;
        }
    }
}
